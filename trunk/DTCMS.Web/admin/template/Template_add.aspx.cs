using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using DTCMS.Entity;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class Template_add : AdminPage
    {
        Sys_TemplateBLL bllTemplate = new Sys_TemplateBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}
