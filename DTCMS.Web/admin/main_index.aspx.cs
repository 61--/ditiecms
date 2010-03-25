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
    public partial class main_index : AdminPage
    {
        private ModulesBLL modulesBll = new ModulesBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(main_index));

            if (Session["AdminUser"] != null)
            {
                Users adminUser = (Users)Session["AdminUser"];
                lbl_username.Text = adminUser.UserName;
            }

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

        #region Ajax方法

        /// <summary>
        /// 获取子模块
        /// </summary>
        private string GetSubnav(string modulesID)
        {
            int count;
            List<Modules> submlist = modulesBll.GetSubnavByParentID(modulesID, 3, out count);
            if (count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Modules m in submlist)
                {
                    //sb.AppendFormat("<li><a href=\"{0}\" alt=\"{1}\" target=\"{2}\">{3}</a></li>\r\n", m.ModuleURL, m.Description, m.Target, m.ModuleName);
                    sb.AppendFormat("<li><a href=\"{0}\" alt=\"{1}\" target=\"{2}\" ondblclick='javascript:editMenu({4})'>{3}</a></li>\r\n", m.ModuleURL, m.Description, m.Target, m.ModuleName, m.ID);
                }
                return sb.ToString();
            }
            else
            {
                return "";
            }
        }

        [AjaxPro.AjaxMethod]
        public string GetLeftnav(string modulesID)
        {
            int count;

            List<Modules> mlist = modulesBll.GetSubnavByParentID(modulesID, 2, out count);
            if (count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (Modules m in mlist)
                {
                    sb.Append("<div class=\"menu\">\r\n<dl>\r\n");
                    sb.AppendFormat("<dt><a href=\"javascript:toggleMenu('{0}');\" ondblclick='javascript:editMenu({2})' hidefocus=\"true\">{1}</a></dt>\r\n", m.ModuleID, m.ModuleName, m.ID);
                    sb.AppendFormat("<dd id=\"{0}\" style=\"display:block;\">\r\n<ul>\r\n", m.ModuleID);
                    sb.Append(this.GetSubnav(m.ModuleID));
                    sb.Append("</ul>\r\n</dd>\r\n</dl>\r\n</div>\r\n");
                }
                return sb.ToString();
            }
            else
            {
                return "没有指定的模块或数据！";
            }
        }
        #endregion
    }
}
