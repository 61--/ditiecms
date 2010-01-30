using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.Common;
using DTCMS.Entity;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class menu : AdminPage
    {
        ModulesBLL modulesBll = new ModulesBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string modulesID = Utils.GetQueryString("modulesID");

            if (modulesID.Length == 0)
            {
                Response.Write("请求地址错误！");
            }
            else
            {
                int count;

                List<Modules> mlist = modulesBll.GetSubnavByParentID(modulesID, 2, out count);
                if (count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Modules m in mlist)
                    {
                        sb.Append("<div class=\"menu\">\r\n<dl>\r\n");
                        sb.AppendFormat("<dt><a href=\"javascript:;\" onclick=\"showHide('{0}');\" target=\"_self\">{1}</a></dt>\r\n", m.ModuleID, m.Name);
                        sb.AppendFormat("<dd id=\"{0}\" style=\"display:block;\">\r\n<ul>\r\n", m.ModuleID);
                        sb.Append(this.GetSubnav(m.ModuleID));
                        sb.Append("</ul>\r\n</dd>\r\n</dl>\r\n</div>\r\n");
                    }
                    Response.Write(sb.ToString());
                }
                else
                {
                    Response.Write("没有指定的模块！");
                }
            }
        }

        private string GetSubnav(string modulesID)
        {
            int count;
            List<Modules> submlist = modulesBll.GetSubnavByParentID(modulesID, 3, out count);
            if (count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Modules m in submlist)
                {
                    sb.AppendFormat("<li><a href=\"javascript:frameRedirect('{0}')\" alt=\"{1}\">{2}</a></li>\r\n", m.ModuleURL, m.Description, m.Name);
                }
                return sb.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
