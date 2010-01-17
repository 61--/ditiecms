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
            ModulesBLL modulesBll = new ModulesBLL();

            int count = 0;
            List<Modules> modulesList = modulesBll.GetTopNav(out count);

            if (count > 0)
            {
                rpt_Topnav.DataSource = modulesList;
                rpt_Topnav.DataBind();
            }
        }
    }
}
