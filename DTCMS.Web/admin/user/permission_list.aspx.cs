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

namespace DTCMS.Web.admin
{
    public partial class permission_list : AdminPage
    {
        protected bool AddPermission = true;
        protected bool EditPermission = true;
        protected bool DeletePermission = true;
        protected bool SettingPermission = true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
