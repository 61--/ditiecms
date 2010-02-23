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
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public partial class permission_list : AdminPage
    {
        protected bool AddPermission = false;
        protected bool EditPermission = true;
        protected bool DeletePermission = true;
        protected bool SettingPermission = true;
        private RolesBLL roleBll = new RolesBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(permission_list));
        }

        /// <summary>
        /// 获取角色Json数据
        /// </summary>
        [AjaxPro.AjaxMethod]
        public string GetRolesJsonData()
        {
            return roleBll.GetRolesJsonData();
        }

        /// <summary>
        /// 删除用户角色
        /// </summary>
        /// <returns>返回影响记录数</returns>
        [AjaxPro.AjaxMethod]
        public int DeleteRoles(string id)
        {
            try
            {
                if (id == "")
                {
                    return -1;
                }
                return roleBll.Delete(id);
            }
            catch
            {
                return -2;
            }
        }
    }
}
