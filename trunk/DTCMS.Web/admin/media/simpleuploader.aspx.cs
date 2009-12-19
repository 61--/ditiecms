using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;
using DTCMS.Config;

namespace DTCMS.Web.admin
{
    public partial class SimpleUploader : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Upload();
        }

        /// <summary>
        /// 附件上传
        /// </summary>
        private void Upload()
        {
            int attachmentAttribute = DTCMS.Common.Utils.GetFormInt("hid_attachmentAttribute"); //附件属性
            string hasWaterMark = DTCMS.Common.Utils.GetFormString("chHasWaterMark");   //原图是否水印
            string hasAbbrImage1 = DTCMS.Common.Utils.GetFormString("chHasAbbrImage1"); //是否生成缩略图
            string hasWaterMark1 = DTCMS.Common.Utils.GetFormString("chHasWaterMark1");   //缩略图是否水印
            int abbrImageWidth1 = DTCMS.Common.Utils.GetFormInt("abbrImageWidth1"); //缩略图宽
            int abbrImageHeight1 = DTCMS.Common.Utils.GetFormInt("abbrImageHeight1");   //缩略图高

            Hashtable htPhoto = AttachmentConfig.GetPhotoList();    //附件配置列表
            string filepath = DTCMS.Common.Utils.GetRootPath() + htPhoto["path"].ToString()+"\\"; //附件存放路径

            string errorMsg = string.Empty; //错误信息
            int returnVal = 1;    //返回值。1：成功，202：无效上传文件，203：你没有权限，204：未知错误
            string returnImgPath = string.Empty;    //返回图片路径

            HttpFileCollection uploadedFiles = Request.Files;
            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                string fileDisplayName = "File"+i.ToString()+"Name";    //附件名称
                string fileInfo = "File" + i.ToString() + "Info";  //附件描述

                #region 附件上传
                HttpPostedFile userPostedFile = uploadedFiles[i];
                string fileName = System.IO.Path.GetFileName(userPostedFile.FileName);
                if (fileName != "")
                {
                    #region 验证附件格式是否正确
                    if (!AttachmentFormat(fileName,attachmentAttribute))
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
                            returnImgPath = DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond.ToString() + fileName.Substring(fileName.LastIndexOf('.')).ToLower();
                            userPostedFile.SaveAs(filepath + returnImgPath);  //附件上传
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
                #endregion 附件上传
            }            

            Response.Redirect("~/admin/Media/EmptyPage.html?returnVal=" + returnVal + "&errorMsg=" + errorMsg+"&returnImgPath="+"/"+htPhoto["path"].ToString().Replace("\\","/")+"/"+returnImgPath);
        }

        /// <summary>
        /// 附件格式是否正确
        /// </summary>
        /// <param name="fileName">附件后缀名</param>
        /// <param name="attachmentAtr">附件属性</param>
        /// <returns></returns>
        private bool AttachmentFormat(string fileName,int attachmentAtr)
        {
            switch (attachmentAtr)
            {
                case (int)EAttachmentAttribute.Photo:
                    return AttachmentFormat(fileName, "imageFormat");
                case (int)EAttachmentAttribute.Video:
                    return AttachmentFormat(fileName, "videoFormat");
                case (int)EAttachmentAttribute.Audio:
                    return AttachmentFormat(fileName, "audioFormat");
                case (int)EAttachmentAttribute.Flash:
                    return AttachmentFormat(fileName, "flashFormat");
                case (int)EAttachmentAttribute.Attachment:
                    return AttachmentFormat(fileName, "attachmentFormat");
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
        private bool AttachmentFormat(string fileName,string configParamName)
        {
            string[] extNameList = AttachmentConfig.GetPhotoStr(configParamName).Split('|');
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

    }
    /// <summary>
    /// 附件属性
    /// </summary>
    public enum EAttachmentAttribute
    {
        /// <summary>
        /// 图片
        /// </summary>
        Photo=1,

        /// <summary>
        /// 视频
        /// </summary>
        Video=2,

        /// <summary>
        /// 音频
        /// </summary>
        Audio=3,

        /// <summary>
        /// Flash
        /// </summary>
        Flash=4,

        /// <summary>
        /// 附件
        /// </summary>
        Attachment=5
    }
}
