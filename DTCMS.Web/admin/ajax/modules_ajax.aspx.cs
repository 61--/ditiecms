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

namespace DTCMS.Web.admin
{
    public partial class modules_ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ModulesBLL moduleBll = new ModulesBLL();
            Response.Write(moduleBll.GetModulesJsonData());
        }
    }
}
