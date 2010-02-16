using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using DTCMS.Entity;
using DTCMS.BLL;
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public partial class permission_ajax : AdminPage
    {
        private RolesBLL roleBll = new RolesBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Utils.GetQueryString("action").Trim();

            switch (action)
            {
                case "load":
                    Response.Write(GetRolesJsonData());
                    break;
                case "add":
                    Response.Write(AddRoles());
                    break;
                case "edit":
                    Response.Write(EditRoles());
                    break;
                case "delete":
                    Response.Write(DeleteRoles());
                    break;
                case "setting":
                    Response.Write(SettingRoles());
                    break;
                default:
                    Response.Write("");
                    break;
            }
        }

        /// <summary>
        /// 获取角色Json数据
        /// </summary>
        private string GetRolesJsonData()
        {
            return roleBll.GetRolesJsonData();
        }

        /// <summary>
        /// 添加用户角色
        /// </summary>
        /// <returns>成功返回1，失败返回-1</returns>
        private int AddRoles()
        {
            Roles roleInfo = new Roles();
            roleInfo.ID = Utils.GetFormInt("Id");
            roleInfo.RoleName = Utils.GetFormString("RoleName");
            roleInfo.Description = Utils.GetFormString("Description");
            roleInfo.AddDate = DateTime.Now;
            roleInfo.OrderID = Utils.GetFormInt("OrderID");
            try
            {
                return roleBll.Add(roleInfo);
            }
            catch
            {

                return -1;
            }
        }

        /// <summary>
        /// 编辑用户角色
        /// </summary>
        /// <returns>成功返回1，失败返回-1</returns>
        private int EditRoles()
        {
            Roles roleInfo = new Roles();
            roleInfo.ID = Utils.GetFormInt("Id");
            roleInfo.RoleName = Utils.GetFormString("RoleName");
            roleInfo.Description = Utils.GetFormString("Description");
            roleInfo.OrderID = Utils.GetFormInt("OrderID");
            try
            {
                return roleBll.Update(roleInfo);
            }
            catch
            {

                return -1;
            }
        }

        /// <summary>
        /// 删除用户角色
        /// </summary>
        /// <returns>返回影响记录数</returns>
        private int DeleteRoles()
        {
            try
            {
                string id = Utils.GetQueryString("Id");
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

        /// <summary>
        /// 设置角色权限
        /// </summary>
        /// <returns></returns>
        private bool SettingRoles()
        {
            return true;
        }
    }
}
