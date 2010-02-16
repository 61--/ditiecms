using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DTCMS.Entity;
using DTCMS.Entity.Enum;
using DTCMS.BLL;
using DTCMS.Common;
using DTCMS.Config;

namespace DTCMS.Web.admin
{
    public partial class permission_add : AdminPage
    {
        protected string action;
        private int Id;
        private RolesBLL roleBll = new RolesBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            action = Utils.GetQueryString("action");
            Id = Utils.GetQueryInt("Id");

            if (!IsPostBack)
            {
                if (Id > 0)
                {
                    SetPageData();
                }
            }
        }

        /// <summary>
        /// 更新数据赋值
        /// </summary>
        private void SetPageData()
        {
            Roles roleInfo = new Roles();
            roleInfo = roleBll.GetModel(Id);
            if (roleInfo!=null)
            {
                txt_RoleID.Value = roleInfo.ID.ToString();
                txt_RoleName.Value = roleInfo.RoleName;
                txt_Description.Value = roleInfo.Description;
                txt_OrderID.Value = roleInfo.OrderID.ToString();
            }
        }
    }
}
