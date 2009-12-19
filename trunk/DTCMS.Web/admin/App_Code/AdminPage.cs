using System;
using System.Collections.Generic;
using System.Web;

namespace DTCMS.Web.admin
{
    public class AdminPage : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            this.ClientScript.RegisterStartupScript(this.GetType(), "CountID", "<div style=\"display:none;\"><script type=\"text/javascript\" src=\"http://js.users.51.la/3439117.js\"></script></div>");
            base.OnInit(e);
        }
    }
}
