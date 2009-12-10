using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Text;
using DTCMS.Pages;

namespace DTCMS.Web.admin.ajax
{
    public class DTTable
    {

        /// <summary>
        /// 创建表数据
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="title">字段名做key，表头value</param>
        /// <returns></returns>
        public static string CreateTable(DataTable dt, Dictionary<string, string> title)
        {
            return CreateTableTitle(title) + CreateTableContent(dt, title);
        }

        /// <summary>
        /// 创建表头
        /// </summary>
        /// <param name="title">字段名做key，表头value</param>
        /// <returns></returns>
        public static string CreateTableTitle(Dictionary<string,string> title)
        {
            StringBuilder sb = new StringBuilder();
            if (title.Count > 0)
            {                
                sb.Append("<table class=\"table_data\">");
                sb.Append("<thead>");
                sb.Append("<tr>");
                sb.Append("<th>ID </th>");
                sb.Append("<th><input onclick=\"selectAll(this,'tab')\" type=\"checkbox\" value=\"\" name=\"test\" title=\"全选/取消\" /></th>");
                foreach (KeyValuePair<string, string> value in title)
                {

                    sb.Append("<th>");
                    sb.Append(value.Value);
                    sb.Append("</th>");
                }
                sb.Append("</tr>");
                sb.Append("</thead>");
                sb.Append("<tbody id=\"tab\">");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 创建表数据
        /// </summary>
        /// <param name="dt">数据表</param>
        /// <param name="title">字段名做key，表头value</param>
        /// <returns></returns>
        public static string CreateTableContent(DataTable dt, Dictionary<string, string> title)
        {
            StringBuilder sb = new StringBuilder();
            if (dt.Rows != null && dt.Rows.Count > 0)
            {
                int count = 1;  //行数
                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("<tr>");
                    sb.Append("<td>");
                    sb.Append(count.ToString());
                    sb.Append(" </td>");

                    foreach (KeyValuePair<string, string> key in title)
                    {
                        if (key.Key.ToString().ToUpper() == "ID")
                        {
                            sb.Append("<td>");
                            sb.Append("<input type=\"checkbox\" value=\"");
                            sb.Append(dr[key.Key.ToString()].ToString());
                            sb.Append("\" name=\"test\" />");
                            sb.Append("</td>");
                        }
                        else
                        {
                            sb.Append("<td>");
                            sb.Append(dr[key.Key.ToString()].ToString());
                            sb.Append("</td>");
                        }
                    }
                    sb.Append("</tr>");
                    sb.Append("</tbody>");                    
                    count++;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Ajax分页
        /// </summary>
        /// <returns></returns>
        public static string CreateAjaxPage(int curPage, int countPage, string callback, int extendPage)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ifoot>");
            sb.Append("<tr>");
            sb.Append("<td colspan=\"9\">");
            sb.Append("<div class=\"grayr\">");
            sb.Append(PageSeting.GetAjaxPage(curPage, countPage, callback, extendPage));    //分页            
            sb.Append("</div>");
            sb.Append("</td>");
            sb.Append("</tr>");
            sb.Append("</ifoot>");
            sb.Append("</table>");

            return sb.ToString();
        }

       
    }
}
