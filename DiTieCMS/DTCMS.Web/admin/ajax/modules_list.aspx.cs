using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;
using DTCMS.Entity;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class modules_list : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string modulesID = Utils.GetQueryString("modulesID");

            if (modulesID.Length == 0)
            {
                return;
            }

            StringBuilder strHtml = new StringBuilder();

            ModulesBLL modulesBll = new ModulesBLL();
            int count = 0;
            List<Modules> mlist = modulesBll.GetSubNav(out count);
        }
    }
}
