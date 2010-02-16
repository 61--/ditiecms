using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;
using DTCMS.Entity;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class index : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminUser"] != null)
            {
                Users adminUser = (Users)Session["AdminUser"];
                lbl_username.Text = adminUser.UserName;
            }

            ModulesBLL modulesBll = new ModulesBLL();

            int count;
            List<Modules> mlist = modulesBll.GetTopnav(out count);

            if (count > 0)
            {
                rpt_Topnav.DataSource = mlist;
                rpt_Topnav.DataBind();
            }
        }

        protected void lbn_Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("login.aspx?do=logout");
        }
    }
}
