using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DTCMS.BLL;
using DTCMS.Common;
using DTCMS.Entity;

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
        /// 获取模块权限列表
        /// </summary>
        /// <returns></returns>
        protected string GetModulesControl()
        {
            ModulesBLL moduleBll = new ModulesBLL();
            ModuleControlBLL controlBll = new ModuleControlBLL();
            DataTable modules = moduleBll.GetModules(Utils.GetQueryInt("ID"));
            DataTable control = controlBll.GetModuleControl();
            StringBuilder sb = new StringBuilder();

            //获取顶级模块
            DataRow[] dr1 = GetChildModule(modules, "M0");
            if (dr1 != null & dr1.Length > 0)
            {
                for (int i = 0; i < dr1.Length; i++)
                {
                    sb.AppendFormat("<table id=\"T-{0}\" class=\"mlist\">", dr1[i]["moduleid"]);
                    sb.AppendFormat("<tr><th colspan=\"2\"><input type=\"checkbox\" id=\"{0}\" name=\"M0\" value=\"{0}\" onclick=\"checkNode(this);\" /><label for=\"{0}\">{1}</label></th></tr>\r\n",
                        dr1[i]["moduleid"], dr1[i]["modulename"]);

                    //获取第二级模块
                    DataRow[] dr2 = GetChildModule(modules, dr1[i]["moduleid"].ToString());
                    if (dr2 != null && dr2.Length > 0)
                    {
                        for (int j = 0; j < dr2.Length; j++)
                        {
                            sb.AppendFormat("<tr class=\"mt\"><td colspan=\"2\"><input type=\"checkbox\" id=\"{0}\" name=\"{1}\" value=\"{0}\" onclick=\"checkNode(this);\" /><label for=\"{0}\">{2}</label></td></tr>\r\n",
                                dr2[j]["moduleid"], dr1[i]["moduleid"], dr2[j]["modulename"]);
                            //获取第三级模块
                            DataRow[] dr3 = GetChildModule(modules, dr2[j]["moduleid"].ToString());
                            if (dr3 != null && dr3.Length > 0)
                            {
                                for (int k = 0; k < dr3.Length; k++)
                                {
                                    if (k % 2 == 0)
                                        sb.AppendFormat("<tr class=\"mi\"><td style=\"width:35%\"><input type=\"checkbox\" id=\"{0}\" name=\"{1}\" value=\"{0}\" class=\"modules\" onclick=\"checkNode(this);\" /><label for=\"{0}\">{2}</label></td>",
                                            dr3[k]["moduleid"], dr2[j]["moduleid"], dr3[k]["modulename"]);
                                    else
                                        sb.AppendFormat("<tr class=\"mi\" style=\"background:#F3F9FB;\"><td><input type=\"checkbox\" id=\"{0}\" name=\"{1}\" value=\"{0}\" class=\"modules\" onclick=\"checkNode(this);\" /><label for=\"{0}\">{2}</label></td>",
                                            dr3[k]["moduleid"], dr2[j]["moduleid"], dr3[k]["modulename"]);

                                    DataRow[] drcontrol = GetControlByModule(control, dr3[k]["moduleid"].ToString());
                                    sb.Append("<td>");
                                    for (int c = 0; c < drcontrol.Length; c++)
                                    {
                                        sb.AppendFormat("<input type=\"checkbox\" id=\"{0}-{1}\" name=\"{0}\" value=\"{1}\" /><label for=\"{0}-{1}\">{2}</label>&nbsp;&nbsp;",
                                            drcontrol[c]["ModuleID"], drcontrol[c]["ControlValue"], drcontrol[c]["ControlName"]);
                                    }
                                    sb.Append("</td></tr>");
                                }
                            }
                        }
                    }
                    sb.Append("</table>\r\n");
                }
            }

            return sb.ToString();
        }

        private static DataRow[] GetChildModule(DataTable dt, string parentId)
        {
            return dt.Select(string.Format("ParentId='{0}'", parentId));
        }

        private static DataRow[] GetControlByModule(DataTable dt, string ID)
        {
            return dt.Select(string.Format("ModuleId='{0}'", ID));
        }

        /// <summary>
        /// 获取角色Json数据
        /// </summary>
        [AjaxPro.AjaxMethod]
        public string GetRolesJsonData(string sortValue)
        {
            return roleBll.GetRolesJsonData(sortValue);
        }

        /// <summary>
        /// 删除用户角色
        /// </summary>
        /// <returns>返回影响记录数</returns>
        [AjaxPro.AjaxMethod]
        public int DeleteRoles(string id)
        {
            if (id == "1")
            {
                return -1;
            }
            try
            {
                return roleBll.Delete(id);
            }
            catch
            {
                return -2;
            }
        }

        /// <summary>
        /// 保存角色模块权限
        /// </summary>
        [AjaxPro.AjaxMethod]
        public int SaveModulesControl(int ID, string ctl)
        {
            RolesInModulesBLL rimBll = new RolesInModulesBLL();
            RolesInModules rimInfo = new RolesInModules();
            rimInfo.RoleID = ID;

            try
            {
                //删除角色所有权限控制码
                //rimBll.DeleteRoleControl(ID);

                if (ctl.Length == 0)
                    return 1;

                //添加角色权限控制码
                string[] mctl = ctl.Split(',');
                foreach (string m in mctl)
                {
                    rimInfo.ModuleID = m.Substring(0, 8);
                    rimInfo.ControlValue = Convert.ToInt32(m.Substring(9, m.Length - 9));

                    rimBll.Update(rimInfo);
                }
                return 1;
            }
            catch
            {
                return -1;
            }
        }
    }
}
