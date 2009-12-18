using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;

namespace DTCMS.Web.admin.Media
{
    public partial class SimpleUploader : System.Web.UI.Page
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

            string filepath = DTCMS.Common.Utils.GetRootPath() + "admin\\files\\photo\\";  //文件存放路径，最好可以配置
            string errorMsg = string.Empty; //错误信息
            int returnVal = 1;    //返回值。1：成功，202：无效上传文件，203：你没有权限，204：未知错误

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
                            userPostedFile.SaveAs(filepath + fileName);  //图片上传
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
                    }
                }
                if (errorMsg != "")
                {
                    returnVal = 202;    //无效上传文件
                }
            }
            #endregion 图片上传

            Response.Redirect("~/admin/Media/EmptyPage.html?returnVal=" + returnVal + "&errorMsg=" + errorMsg);
        }

        /// <summary>
        /// 判断图片格式是否正确
        /// </summary>
        private bool PhotoFormat(string fileName)
        {
            string extName = fileName.Substring(fileName.LastIndexOf(".") + 1).ToLower();
            if (extName == "jpg" || extName == "jpeg" || extName == "bmp" || extName == "gif" || extName == "png")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
