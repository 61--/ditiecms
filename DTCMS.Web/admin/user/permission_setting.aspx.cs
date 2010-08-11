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
            DataTable dt = moduleBll.GetModulesByControl();
            StringBuilder sb = new StringBuilder();

            //获取顶级模块
            DataRow[] dr1 = GetChildModule(dt, "M0");
            if (dr1 != null & dr1.Length > 0)
            {
                sb.Append("<table class=\"mlist\">");
                for (int i = 0; i < dr1.Length; i++)
                {
                    sb.AppendFormat("<tr><th>{0}</th></tr>", dr1[i]["modulename"]);

                    //获取第二级模块
                    DataRow[] dr2 = GetChildModule(dt, dr1[i]["moduleid"].ToString());
                    if (dr2 != null && dr2.Length > 0)
                    {
                        for (int j = 0; j < dr2.Length; j++)
                        {
                            sb.AppendFormat("<tr class=\"mitem\"><td>{0}</td></tr>", dr2[j]["modulename"]);
                            //获取第三级模块
                            DataRow[] dr3 = GetChildModule(dt, dr2[j]["moduleid"].ToString());
                            if (dr3 != null && dr3.Length > 0)
                            {
                                for (int k = 0; k < dr3.Length; k++)
                                {
                                    if (k % 2 == 0)
                                        sb.AppendFormat("<tr><td>{0}</td></tr>", dr3[k]["modulename"]);
                                    else
                                        sb.AppendFormat("<tr style=\"background:#F3F9FB;\"><td>{0}</td></tr>", dr3[k]["modulename"]);
                                }
                            }
                        }
                    }
                }
                sb.Append("</table>");
            }

            return sb.ToString();
        }

        private static DataRow[] GetChildModule(DataTable dt, string parentId)
        {
            return dt.Select(string.Format("parentId='{0}'", parentId));
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
    }
}
