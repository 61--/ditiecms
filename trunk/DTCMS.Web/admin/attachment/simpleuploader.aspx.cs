using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;
using DTCMS.Config;
using DTCMS.Entity;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class SimpleUploader : AdminPage
    {
        AttachMentBLL bllAttachment = new AttachMentBLL();
        SystemConfig sysConfig = GobalConfig.GetCobalInstance().LoadGoableConfig();

        protected void Page_Load(object sender, EventArgs e)
        {
            Upload();
        }

        /// <summary>
        /// 附件上传
        /// </summary>
        private void Upload()
        {
            int attachmentAttribute = Utils.GetFormInt("hidden_attr"); //附件属性
            string hasWaterMark = Utils.GetFormString("chHasWaterMark");   //原图是否水印
            string hasAbbrImage1 = Utils.GetFormString("chHasAbbrImage1"); //是否生成缩略图
            string hasWaterMark1 = Utils.GetFormString("chHasWaterMark1");   //缩略图是否水印
            int abbrImageWidth1 = Utils.GetFormInt("abbrImageWidth1"); //缩略图宽
            int abbrImageHeight1 = Utils.GetFormInt("abbrImageHeight1");   //缩略图高
            string filepathshort = sysConfig.Attachments.Path.Replace("\\\\", "\\") + "\\"
                + DateTime.Now.ToString(sysConfig.Attachments.Directory == "" ? "yyyyMM" : sysConfig.Attachments.Directory) + "\\";
            string filepath = Utils.GetRootPath() + filepathshort; //附件存放路径

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            string errorMsg = string.Empty; //错误信息
            int returnVal = 1;    //返回值。1：成功，202：无效上传文件，203：你没有权限，204：未知错误
            string returnImgName = string.Empty;    //返回图片名称
            string abbName = string.Empty;  //缩略图名称

            HttpFileCollection uploadedFiles = Request.Files;
            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                string fileDisplayName = DTCMS.Common.Utils.GetFormString("File" + (i + 1) + "Name");    //附件名称
                string fileInfo = DTCMS.Common.Utils.GetFormString("File" + (i + 1) + "Info");  //附件描述

                HttpPostedFile userPostedFile = uploadedFiles[i];
                string fileName = System.IO.Path.GetFileName(userPostedFile.FileName);
                if (fileName != "")
                {
                    #region 验证附件格式是否正确
                    if (!AttachmentFormat(fileName, attachmentAttribute))
                    {
                        if (errorMsg != string.Empty)
                        {
                            errorMsg += ",";
                        }
                        errorMsg += fileName;
                        continue;
                    }
                    #endregion 验证附件格式是否正确

                    try
                    {

                        int fileContentLen = userPostedFile.ContentLength;
                        if (fileContentLen > 0)
                        {
                            #region 附件上传

                            returnImgName = DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond.ToString() + fileName.Substring(fileName.LastIndexOf('.')).ToLower();
                            abbName = returnImgName.Substring(0, returnImgName.LastIndexOf('.')) + "_abbr" + fileName.Substring(fileName.LastIndexOf('.')).ToLower();
                            userPostedFile.SaveAs(filepath + returnImgName);  //附件上传
                            #endregion 附件上传

                            #region 是否图片
                            if (attachmentAttribute == (int)EAttachmentAttribute.Photo)
                            {
                                if (hasAbbrImage1.Trim().ToLower() == "true")
                                {
                                    #region 生成缩略图
                                    EWaterImageType mode = EWaterImageType.W;
                                    if (abbrImageHeight1 > 0 && abbrImageWidth1 <= 0)
                                    {
                                        mode = EWaterImageType.H;
                                    }
                                    else if (abbrImageWidth1 > 0 && abbrImageHeight1 <= 0)
                                    {
                                        mode = EWaterImageType.W;
                                    }
                                    else if ((abbrImageHeight1 > 0) && (abbrImageWidth1 > 0))
                                    {
                                        mode = EWaterImageType.CUT;
                                    }
                                    else
                                    {
                                        mode = EWaterImageType.NO;
                                    }
                                    if (mode == EWaterImageType.NO)
                                    {
                                        abbrImageWidth1 = 500;
                                        abbrImageHeight1 = 0;
                                        mode = EWaterImageType.W;
                                    }
                                    string abbPath = filepath + abbName;
                                    Common.WaterImage.MakeThumbnail(filepath + returnImgName, abbPath
                                       , abbrImageWidth1, abbrImageHeight1, mode);
                                    #endregion 生成缩略图

                                    #region 缩略图水印
                                    if (hasWaterMark1.Trim().ToLower() == "true")
                                    {
                                        WaterImage(abbPath, abbPath);
                                    }
                                    #endregion 缩略图水印
                                }

                                #region 原图水印

                                if (attachmentAttribute == (int)EAttachmentAttribute.Photo)
                                {
                                    if (hasWaterMark.Trim().ToLower() == "true")
                                    {
                                        WaterImage(filepath + returnImgName, filepath + returnImgName);
                                    }
                                }
                                #endregion 原图水印
                            }
                            #endregion 是否图片

                            #region 保存数据
                            AttachMent modAttachMent = new AttachMent();
                            modAttachMent.Attribute = (byte)attachmentAttribute;
                            modAttachMent.DisplayName = fileDisplayName;
                            modAttachMent.AttachMentPath = "/" + filepathshort.Replace("\\", "/") + returnImgName;
                            modAttachMent.AttachMentSize = fileContentLen;
                            if (hasAbbrImage1.Trim().ToLower() == "true")
                            {
                                modAttachMent.AbbrPhotoPath = "/" + filepathshort.Replace("\\", "/") + abbName;
                            }
                            else
                            {
                                modAttachMent.AbbrPhotoPath = "";
                            }
                            modAttachMent.PubLisher = "";
                            modAttachMent.AddDate = DateTime.Now;
                            modAttachMent.PhotoDescription = fileInfo;
                            bllAttachment.Add(modAttachMent);
                            #endregion 保存数据
                        }
                        else
                        {
                            if (errorMsg != string.Empty)
                            {
                                errorMsg += ",";
                            }
                            errorMsg += fileName;
                        }

                    }
                    catch
                    {
                        returnVal = 204;    //未知错误
                        errorMsg = "";
                    }
                }
                
                if (errorMsg != "")
                {
                    returnVal = 202;    //无效上传文件
                }
            }
            string returnImgPath = "";
            if (hasAbbrImage1.Trim().ToLower() == "true")
            {
                returnImgPath = "/" + filepathshort.Replace("\\", "/") + abbName;
            }
            else
            {
                returnImgPath = "/" + filepathshort.Replace("\\", "/")+ returnImgName;
            }

            Response.Redirect("~/admin/attachment/emptyPage.html?returnVal=" + returnVal + "&errorMsg=" + Server.UrlEncode(errorMsg) + "&returnImgPath=" + Server.UrlEncode(returnImgPath));
        }

        /// <summary>
        /// 附件格式是否正确
        /// </summary>
        /// <param name="fileName">附件后缀名</param>
        /// <param name="attachmentAtr">附件属性</param>
        /// <returns></returns>
        private bool AttachmentFormat(string fileName, int attachmentAtr)
        {
            switch (attachmentAtr)
            {
                case (int)EAttachmentAttribute.Photo:
                    return AttachmentFormat(fileName, sysConfig.Attachments.ImageFormat);
                case (int)EAttachmentAttribute.Video:
                    return AttachmentFormat(fileName, sysConfig.Attachments.VideoFormat);
                case (int)EAttachmentAttribute.Audio:
                    return AttachmentFormat(fileName, sysConfig.Attachments.AudioFormat);
                case (int)EAttachmentAttribute.Flash:
                    return AttachmentFormat(fileName, sysConfig.Attachments.FlashFormat);
                case (int)EAttachmentAttribute.Attachment:
                    return AttachmentFormat(fileName, sysConfig.Attachments.AttachmentFormat);
                default:
                    return false;
            }
        }

        /// <summary>
        /// 判断附件格式是否正确
        /// </summary>
        /// <param name="fileName">附件后缀名</param>
        /// <param name="configAttachmentFormatName">配置参数</param>
        /// <returns></returns>
        private bool AttachmentFormat(string fileName, string configParamName)
        {
            string[] extNameList = configParamName.Split('|');
            string extName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower();
            if (extNameList != null && extNameList.Length > 0)
            {
                for (int i = 0; i < extNameList.Length; i++)
                {
                    if (extName == extNameList[i].ToLower())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 水印
        /// </summary>
        /// <param name="path">原图地址</param>
        /// <param name="path_syp">水印地址</param>
        private void WaterImage(string path, string path_syp)
        {
            if (Convert.ToInt32(sysConfig.Attachments.WaterImages.WaterPic) == 1)
            {//图片水印
                Common.WaterImage.AddWaterPic(path, path_syp, sysConfig.Attachments.WaterImages.WaterPicPath
                     , Convert.ToDouble(sysConfig.Attachments.WaterImages.XPercent)
                    , Convert.ToDouble(sysConfig.Attachments.WaterImages.YPercent)
                    , float.Parse(sysConfig.Attachments.WaterImages.Transparence));
            }
            else
            {//文字水印
                Common.WaterImage.AddWater(path, path_syp, sysConfig.Attachments.WaterImages.WaterCharater
                    , Convert.ToDouble(sysConfig.Attachments.WaterImages.XPercent)
                    , Convert.ToDouble(sysConfig.Attachments.WaterImages.YPercent)
                    , System.Drawing.ColorTranslator.FromHtml(sysConfig.Attachments.WaterImages.CharColor)
                    , sysConfig.Attachments.WaterImages.FontFamilyName, Convert.ToInt32(sysConfig.Attachments.WaterImages.FontSize));
            }

        }

    }
    /// <summary>
    /// 附件属性
    /// </summary>
    public enum EAttachmentAttribute
    {
        /// <summary>
        /// 图片
        /// </summary>
        Photo = 1,

        /// <summary>
        /// 视频
        /// </summary>
        Video = 2,

        /// <summary>
        /// 音频
        /// </summary>
        Audio = 3,

        /// <summary>
        /// Flash
        /// </summary>
        Flash = 4,

        /// <summary>
        /// 附件
        /// </summary>
        Attachment = 5
    }
}
