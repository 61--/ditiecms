using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.BLL;
using System.Data;
using System.Text;

namespace DTCMS.Web.admin.system
{
    public partial class database_runsql : AdminPage
    {
        DataBase_RunSqlBLL bllDatabaseRunSql = new DataBase_RunSqlBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(database_runsql));

            if (!IsPostBack)
            {
                InitSysObject();
            }
        }
        #region 私有方法
        /// <summary>
        /// 初始化系统表
        /// </summary>
        private void InitSysObject()
        {
            DataTable dtSysObject=bllDatabaseRunSql.GetSysObjectDataTable();
            if(dtSysObject==null)
                return;
            
            slt_sysobject.DataSource = dtSysObject;
            slt_sysobject.DataTextField = "name";
            slt_sysobject.DataValueField = "name";
            slt_sysobject.DataBind();
        }

        [AjaxPro.AjaxMethod]
        public string GetSysObjectDataTable(string tablename)
        {
            DataTable dtSysColumn = bllDatabaseRunSql.GetSysColumnsDataTable(tablename);
            if (dtSysColumn == null)
                return "";
            if (dtSysColumn.Rows != null && dtSysColumn.Rows.Count > 0)
            {
                StringBuilder sbcolumns = new StringBuilder();
                sbcolumns.Append("<ul>");
                for (int i = 0, count = dtSysColumn.Rows.Count; i < count; i++)
                {
                    sbcolumns.Append("<li>");
                    sbcolumns.Append(string.Format("<input type=\"checkbox\" id=\"chk_columns_{0}\" name=\"{1}\" /><label for=\"chk_columns_{0}\">{1}[{2}]</label>", i, dtSysColumn.Rows[i]["name"].ToString(), dtSysColumn.Rows[i]["value"].ToString()));
                    sbcolumns.Append("</li>");
                }
                sbcolumns.Append("</ul>");
                return sbcolumns.ToString();
            }
            return "";
        }
        #endregion 
    }
}
