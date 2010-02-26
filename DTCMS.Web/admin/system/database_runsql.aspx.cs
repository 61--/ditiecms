using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.BLL;
using System.Data;
using System.Text;
using DTCMS.Common;

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
        public string GetSysColumnDataTable(string tablename)
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
                    if (dtSysColumn.Rows[i]["name"].ToString() == "*")
                    {
                        sbcolumns.Append(string.Format("<input type=\"checkbox\" id=\"chk_columns_{0}\" name=\"columns\" value=\"{1}\" onclick=\"selectColumnsAll(this);\" /><label for=\"chk_columns_{0}\">{1}[{2}]</label>", i, dtSysColumn.Rows[i]["name"].ToString(), dtSysColumn.Rows[i]["value"].ToString()));
                    }
                    else
                    {
                        sbcolumns.Append(string.Format("<input type=\"checkbox\" id=\"chk_columns_{0}\" name=\"columns\" value=\"{1}\" onclick=\"selectColumns();\" /><label for=\"chk_columns_{0}\">{1}[{2}]</label>", i, dtSysColumn.Rows[i]["name"].ToString(), dtSysColumn.Rows[i]["value"].ToString()));
                    }
                    sbcolumns.Append("</li>");
                }
                sbcolumns.Append("</ul>");
                return sbcolumns.ToString();
            }
            return "";
        }

        [AjaxPro.AjaxMethod]
        public string Update(string strSql)
        {
            if (strSql == string.Empty|| strSql==null)
                return "";

            if (Regular.ValidateSQL(strSql))
            {
                return "<div style=\"color:red;\">【" + strSql + "】存在危险字符！请确认后在执行。<div>";
            }

            try
            {
                int sum = bllDatabaseRunSql.ExecuteSql(strSql);
                return "成功执行1个SQL语句!";
            }
            catch(Exception e)
            {
                return string.Format("<p>{0}  <span style=\"color:red;\">{1}</span></p><br/>运行SQL：{1}，无返回记录！", e.Message, strSql);
            }
        }

        [AjaxPro.AjaxMethod]
        public string Select(string strSql)
        {
            if (strSql == string.Empty || strSql == null)
                return "";

            if (Regular.ValidateSQL(strSql))
            {
                return "<div style=\"color:red;\">【" + strSql + "】存在危险字符！请确认后在执行。</div>";
            }

            try
            {
                DataTable dtSelect = bllDatabaseRunSql.ExecuteSqlToDataTable(strSql);

                if (dtSelect != null && dtSelect.Rows != null && dtSelect.Rows.Count > 0)
                {
                    StringBuilder sbmsg = new StringBuilder();
                    sbmsg.Append(string.Format("<div>运行{0}，共有{1}条记录，最大返回100条！<div>", strSql, dtSelect.Rows.Count));
                    for (int i = 0, count = dtSelect.Rows.Count > 100 ? 100 : dtSelect.Rows.Count; i < count; i++)
                    {
                        sbmsg.Append("<div style=\"margin-top:15px; font-size:16px;\">");
                        sbmsg.Append("记录");
                        sbmsg.Append(i + 1);
                        sbmsg.Append("</div>");
                        sbmsg.Append("<hr/>");
                        for (int j = 0, sum = dtSelect.Columns.Count; j < sum; j++)
                        {
                            sbmsg.Append("<span style=\"color:red;\">");
                            sbmsg.Append(dtSelect.Columns[j].ColumnName);
                            sbmsg.Append("</span>：");
                            sbmsg.Append(dtSelect.Rows[i][j].ToString());
                            sbmsg.Append("<br/>");
                        }
                    }
                    return sbmsg.ToString();
                }
                else
                {
                    return string.Format("<div style=\"color:red;\">运行{0}，没有返回记录！<div>", strSql);
                }
            }
            catch (Exception e)
            {
                return string.Format("<p>{0}  <span style=\"color:red;\">{1}</span></p><br/>运行SQL：{1}，无返回记录！", e.Message, strSql);
            }
        }
        #endregion 
    }
}
