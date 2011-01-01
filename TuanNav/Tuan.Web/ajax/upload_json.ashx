<%@ WebHandler Language="C#" Class="Upload" %>
using System;
using System.Collections;
using System.Web;
using System.Web.SessionState;
using System.IO;
using System.Globalization;
using Tuan.Common;

public class Upload : IHttpHandler, IRequiresSessionState
{
    //文件保存目录路径
    private String savePath = "/upload/images/";
    //文件保存目录URL
    private String saveUrl = "/upload/images/";
    //定义允许上传的文件扩展名
    private String fileTypes = "gif,jpg,jpeg,png,bmp";
    //最大文件大小
    private int maxSize = 1000000;

    private HttpContext context;

    public void ProcessRequest(HttpContext context)
    {
        //从Session中获取用户信息
        if (context.Session["UserInf"] == null)
        {
            Ajax.ShowMessage(1, "您未登陆或登陆超时，请返回登陆后再执行此操作！");
        }
        
        this.context = context;
        DateTime date = DateTime.Now;

        HttpPostedFile imgFile = context.Request.Files["imgFile"];
        if (imgFile == null)
        {
            Ajax.ShowMessage(1, "请选择文件。");
        }

        String dirPath = context.Server.MapPath(savePath);
        dirPath += String.Concat(date.ToString("yyyy"), "\\", date.ToString("MM"), "\\");
        saveUrl += String.Concat(date.ToString("yyyy"), "/", date.ToString("MM"), "/");
        if (!Directory.Exists(dirPath))
        {
            Directory.CreateDirectory(dirPath);
        }

        String fileName = imgFile.FileName;
        String fileExt = Path.GetExtension(fileName).ToLower();
        ArrayList fileTypeList = ArrayList.Adapter(fileTypes.Split(','));

        if (imgFile.InputStream == null || imgFile.InputStream.Length > maxSize)
        {
            Ajax.ShowMessage(1, "上传文件大小超过限制。");
        }

        if (String.IsNullOrEmpty(fileExt) || Array.IndexOf(fileTypes.Split(','), fileExt.Substring(1).ToLower()) == -1)
        {
            Ajax.ShowMessage(1, "上传文件扩展名是不允许的扩展名。");
        }

        String newFileName = date.ToString("ddHHmmssffff", DateTimeFormatInfo.InvariantInfo) + fileExt;
        String filePath = dirPath + newFileName;

        imgFile.SaveAs(filePath);

        String fileUrl = saveUrl + newFileName;

        Ajax.ShowMessage(0, fileUrl);
    }

    //private void showError(string message)
    //{
    //    Hashtable hash = new Hashtable();
    //    hash["error"] = 1;
    //    hash["message"] = message;
    //    context.Response.AddHeader("Content-Type", "text/html; charset=UTF-8");
    //    context.Response.Write(JsonMapper.ToJson(hash));
    //    context.Response.End();
    //}

    public bool IsReusable
    {
        get
        {
            return true;
        }
    }
}
