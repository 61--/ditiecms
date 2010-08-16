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

namespace DTCMS.Web.admin
{
    public partial class permission_setting : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(permission_setting));

            //if (!IsPostBack)
            //{
            //    BindRolesList();
            //}
        }

        protected string GetModulesByControl()
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
                    sb.AppendFormat("<tr><th colspan=\"2\"><input type=\"checkbox\" id=\"{0}\" name=\"modules\" value=\"{0}\" onclick=\"checkNode('{0}',1);\" /><label for=\"{0}\">{1}</label></th></tr>\r\n", dr1[i]["moduleid"], dr1[i]["modulename"]);

                    //获取第二级模块
                    DataRow[] dr2 = GetChildModule(modules, dr1[i]["moduleid"].ToString());
                    if (dr2 != null && dr2.Length > 0)
                    {
                        for (int j = 0; j < dr2.Length; j++)
                        {
                            sb.AppendFormat("<tr class=\"mt\"><td colspan=\"2\"><input type=\"checkbox\" id=\"{0}\" name=\"modules\" value=\"{0}\" onclick=\"checkNode('{0}',2);\" /><label for=\"{0}\">{1}</label></td></tr>\r\n", dr2[j]["moduleid"], dr2[j]["modulename"]);
                            //获取第三级模块
                            DataRow[] dr3 = GetChildModule(modules, dr2[j]["moduleid"].ToString());
                            if (dr3 != null && dr3.Length > 0)
                            {
                                for (int k = 0; k < dr3.Length; k++)
                                {
                                    if (k % 2 == 0)
                                        sb.AppendFormat("<tr class=\"mi\"><td style=\"width:35%\"><input type=\"checkbox\" id=\"{0}\" name=\"s-modules\" value=\"{0}\" onclick=\"checkNode('{0}',3);\" /><label for=\"{0}\">{1}</label></td>", dr3[k]["moduleid"], dr3[k]["modulename"]);
                                    else
                                        sb.AppendFormat("<tr class=\"mi\" style=\"background:#F3F9FB;\"><td><input type=\"checkbox\" id=\"{0}\" name=\"s-modules\" value=\"{0}\" onclick=\"checkNode('{0}',3);\" /><label for=\"{0}\">{1}</label></td>", dr3[k]["moduleid"], dr3[k]["modulename"]);

                                    DataRow[] drcontrol = GetControlByModule(control, dr3[k]["moduleid"].ToString());
                                    sb.Append("<td>");
                                    for (int c = 0; c < drcontrol.Length; c++)
                                    {
                                        sb.AppendFormat("<input type=\"checkbox\" id=\"{0}-{1}\" name=\"{0}\" value=\"{1}\" onclick=\"checkNode('{0}',4);\" /><label for=\"{0}-{1}\">{2}</label>&nbsp;&nbsp;", drcontrol[c]["ModuleID"], drcontrol[c]["ControlValue"], drcontrol[c]["ControlName"]);
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
        /// 绑定角色列表
        /// </summary>
        //private void BindRolesList()
        //{
        //    RolesBLL roleBll = new RolesBLL();
        //    DataTable dt = roleBll.GetList();

        //    rpt_RolesList.DataSource = dt;
        //    rpt_RolesList.DataBind();
        //}

        /// <summary>
        /// 获取模块Json数据
        /// </summary>
        [AjaxPro.AjaxMethod]
        public string GetModulesJsonData()
        {
            ModulesBLL moduleBll = new ModulesBLL();
            return moduleBll.GetModulesJsonData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JScript.ShowMessage(this, Request.Form["test"]);
        }
    }
}
