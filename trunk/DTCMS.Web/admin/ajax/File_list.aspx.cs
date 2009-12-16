using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using DTCMS.BLL;
using DTCMS.Common;
using Newtonsoft.Json;
namespace DTCMS.Web.admin.ajax
{
    public partial class File_list : System.Web.UI.Page
    {
        Sys_FileInfoBLL bllFile = new Sys_FileInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action");
            string filePath = Common.Utils.GetQueryString("path");
            switch (action)
            { 
                case "template":
                    Response.Write(GetTemplateJson(filePath));
                    break;

            }
        }
        protected string GetTemplateJson(string filePath)
        {
            string s = "[{'FileName':'index.html','UpdateTime':'new Date(-59011459200000)','FileSize':'250 B','isDirectory':'false','FileTitle':'null','FilePath':'/template/default/index.html'}]";
            s = "[ {'id':2,'title':'1','classname':'','adddate':'2009-3-18 0:00:00','ischecked':'1'} ];";
            return s;
             //return JavaScriptConvert.SerializeObject( bllFile.GetFileList(filePath));
        }
    }
}
