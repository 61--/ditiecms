using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using DTCMS.BLL;
using DTCMS.Common;
using Newtonsoft.Json;

namespace DTCMS.Web.admin
{
    public partial class File_list : AdminPage
    {
        Sys_FileInfoBLL bllFile = new Sys_FileInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action").Trim();
            string filePath = Common.Utils.GetQueryString("path").Trim();
            switch (action)
            { 
                case "template":Response.Write(GetTemplateToJson(filePath));break;
                default: Response.Write(""); break;

            }
        }
        protected string GetTemplateToJson(string filePath)
        {
             return JavaScriptConvert.SerializeObject( bllFile.GetFileList(filePath));
        }
    }
}
