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
        /// 获取数据表
        /// </summary>
        /// <param name="dt">数据原</param>
        /// <param name="title">数据库中字段名-对应名称</param>
        /// <param name="widthList">列宽百分比用豆号分隔</param>
        /// <param name="lastTD">最后一列显示头名称-内容对应值</param>
        /// <param name="lastTDValue">值参数</param>
        /// <returns></returns>
        public static string CreateTable(DataTable dt, Dictionary<string, string> title, string widthList, string lastTDTitle, string lastTDValue, string[] lastTDValueArray)
        {
            string tb_title = CreateTableTitle(title, widthList, lastTDTitle);
            string tb_content = CreateTableContent(dt, title, lastTDValue, lastTDValueArray);
            return tb_title + tb_content;
        }

        /// <summary>
        /// 获取数据表头
        /// </summary>
        /// <param name="title">表头</param>
        /// <param name="widthList">列宽百分比用豆号分隔</param>
        /// <param name="lastTH">最后一列显示头名称</param>
        /// <returns></returns>
        private static string CreateTableTitle(Dictionary<string, string> title, string widthList,string lastTH)
        {
            string[] widthLists = widthList.Split(',');
            if (lastTH == "")
            {
                if (title.Count != widthLists.Length - 1) throw new ArgumentException("参数长度错误");
            }
            else
            {
                if (title.Count != widthLists.Length - 2) throw new ArgumentException("参数长度错误");
            }

            StringBuilder sb = new StringBuilder();
            if (title.Count > 0)
            {
                int thCount = 0;
                sb.Append("<table class=\"table_data\">");
                sb.Append("<thead>");
                sb.Append("<tr>");
                sb.Append("<th width=\"" + widthLists [thCount]+ "\">ID </th>");
                foreach (KeyValuePair<string, string> value in title)
                {
                    thCount++;

                    if (value.Key.ToString().ToUpper() == "ID")
                    {
                        sb.Append("<th width=\"" + widthLists[thCount] + "\"><input onclick=\"selectAll(this,'tab')\" type=\"checkbox\" value=\"\" name=\"test\" title=\"全选/取消\" /></th>");
                    }
                    else
                    {
                        sb.Append("<th width=\"" + widthLists[thCount] + "\">");
                        sb.Append(value.Value);
                        sb.Append("</th>");
                    }                    
                }
                if (lastTH != "")
                {
                    thCount++;

                    sb.Append("<th width=\"" + widthLists[thCount] + "\">");
                    sb.Append(lastTH);
                    sb.Append("</th>");
                }
                sb.Append("</tr>");
                sb.Append("</thead>");
                sb.Append("<tbody id=\"tab\">");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 获取数据表内容
        /// </summary>
        /// <param name="dt">数据源</param>
        /// <param name="title">数据库中字段名-对应名称</param>
        /// <param name="lastTD">最后一列显示头名称-内容对应值</param>
        /// <param name="lastTDValue">值参数</param>
        /// <returns></returns>
        private static string CreateTableContent(DataTable dt, Dictionary<string, string> title,string lastTD,string[] lastTDValue)
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

                    if (lastTD != "")
                    {
                        sb.Append("<td>");
                        if (lastTDValue != null)
                        {
                            object[] formatParams = new object[lastTDValue.Length];
                            for (int i = 0; i < lastTDValue.Length; i++)
                            {
                                formatParams[i] = dr[lastTDValue[i]];
                            }
                            sb.Append(string.Format(lastTD, formatParams));
                        }
                        else
                        {
                            sb.Append(lastTD);
                        }
                        sb.Append("</td>");
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
