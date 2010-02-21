using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DTCMS.BLL;
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public partial class TemplateFile_list : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(Template_list));
        }

        /// <summary>
        /// 获取模版目录文件Json数据
        /// </summary>
        /// <param name="filePath">模版文件路径</param>
        [AjaxPro.AjaxMethod]
        public string GetTemplateJsonData(string filePath)
        {
            Sys_FileInfoBLL fileBll = new Sys_FileInfoBLL();
            return AjaxPro.JavaScriptSerializer.Serialize(fileBll.GetFileList(filePath));
        }
    }
}
