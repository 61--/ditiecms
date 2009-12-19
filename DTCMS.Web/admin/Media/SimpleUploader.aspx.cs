using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;
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
            string attachmentType = Common.Utils.GetQueryString("type");
            switch (attachmentType.Trim().ToLower())
            {
                case "image":
                    PhotoUpload();
                    break;
                default:
                    break;

            }
        }
        /// <summary>
        /// 图片上传
        /// </summary>
        private void PhotoUpload()
        {
            //图片配置列表
            Hashtable htPhoto = AttachmentConfig.GetPhotoList();
            string filepath = DTCMS.Common.Utils.GetRootPath() + htPhoto["path"].ToString()+"//"; //文件存放路径
            string errorMsg = string.Empty; //错误信息
            int returnVal = 1;    //返回值。1：成功，202：无效上传文件，203：你没有权限，204：未知错误
            string returnImgPath = string.Empty;    //返回图片路径

            HttpFileCollection uploadedFiles = Request.Files;
            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                #region 图片上传
                HttpPostedFile userPostedFile = uploadedFiles[i];
                string fileName = System.IO.Path.GetFileName(userPostedFile.FileName);
                if (fileName != "")
                {
                    #region 验证图片格式是否正确
                    if (!PhotoFormat(fileName))
                    {
                        if (errorMsg != string.Empty)
                        {
                            errorMsg += ",";
                        }
                        errorMsg += fileName;
                        continue;
                    }
                    #endregion 验证图片格式是否正确

                    try
                    {
                        int fileContentLen = userPostedFile.ContentLength;
                        if (fileContentLen > 0)
                        {
                            returnImgPath = DateTime.Now.ToString("yyyyMMddHHmmss") + fileName.Substring(fileName.LastIndexOf('.')).ToLower();
                            userPostedFile.SaveAs(filepath + returnImgPath);  //图片上传
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
                #endregion 图片上传

                #region 存储数据

                #endregion 存储数据
            }            

            Response.Redirect("~/admin/Media/EmptyPage.html?returnVal=" + returnVal + "&errorMsg=" + errorMsg+"&returnImgPath="+"/"+htPhoto["path"].ToString().Replace("\\","/")+"/"+returnImgPath);
        }

        /// <summary>
        /// 判断图片格式是否正确
        /// </summary>
        private bool PhotoFormat(string fileName)
        {
            string[] extNameList = AttachmentConfig.GetPhotoStr("format").Split('|');
            string extName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower();
            for (int i = 0; i < extNameList.Length; i++)
            {
                if (extName == extNameList[i].ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
