using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Web.admin
{
    public partial class top_index : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void hlkExi_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Write("<script type=\"text/javascript\">top.document.frames.top.location.href='../login.aspx?action=logout'</script>");
        }
    }
}
