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
    public partial class permission_setting : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRolesList();
            }
        }

        /// <summary>
        /// 绑定角色列表
        /// </summary>
        private void BindRolesList()
        {
            RolesBLL roleBll = new RolesBLL();
            DataTable dt = roleBll.GetList();

            rpt_RolesList.DataSource = dt;
            rpt_RolesList.DataBind();
        }
    }
}
