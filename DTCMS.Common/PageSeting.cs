using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Common
{
    public class PageSeting
    {
        #region
        /// <summary>
        /// 计算总共多少页
        /// </summary>
        /// <param name="totalCount">记录总数</param>
        /// <param name="m_pageNum">一页显示的数据量</param>
        /// <returns></returns>
        public static int GetPageCount(int totalCount, int pageSize)
        {
            int totalPage = 0;
            if (totalCount % pageSize == 0)
            {
                totalPage = totalCount / pageSize;
            }
            else
            {
                totalPage = totalCount / pageSize + 1;
            }
            return totalPage;
        }
        #endregion

        #region 构造后台ajax分页的html
        /// <summary>
        /// 构造分页的html
        /// </summary>
        /// <param name="p_pageNow">当前页</param>
        /// <param name="p_pageCount">分页总量</param>
        /// <param name="p_recCount">总记录条数</param>
        /// <param name="p_pageSize">一页显示的数据量</param>
        /// <param name="p_listFunName">分页的js方法名</param>
        /// <param name="delFun">数据删除的方法名</param>
        /// <returns></returns>
        public static string PaginationHtml(int p_pageNow, int p_pageCount, int p_recCount, int p_pageSize, string p_listFunName, string delFun)
        {
            StringBuilder returnStr = new StringBuilder();
            returnStr.Append("<div class=\"page\"><span style=\"float:left; padding-left:5px\">");
            returnStr.Append("<a href=\"#\" onclick=\"SelChecked()\">全选</a> | ");
            returnStr.Append("<a href=\"#\" onclick=\"RevChecked()\">反选</a> | ");
            returnStr.Append("<a href=\"#\" onclick=\"" + delFun + "('del',false);" + p_listFunName + "('" + p_pageNow + "');\">删除</a></span>");
            returnStr.Append("<span style=\"float:right; padding-right:5px\">");
            returnStr.Append(TP.Webs.ClassLib.DataLib.getPageTable(p_pageNow, p_pageCount, p_recCount, p_pageSize, p_listFunName));
            returnStr.Append("</span><div class=\"clear\"></div></div>");
            returnStr = returnStr.Replace("<span style=\"float: left; padding-left: 5px\">", "<span style=\"float: left; padding-left: 5px; line-height:22px;\">");
            returnStr = returnStr.Replace("<table class=page align=center>", "<table style=\"background-color:#EAEAEA;\">");
            returnStr = returnStr.Replace("<td width=40%>", "<td style=\"line-height:22px;\">");
            returnStr = returnStr.Replace("<td width=60% style='text-align:right;'>", "<td style=\"text-align: right;line-height:22px;\">");
            returnStr = returnStr.Replace("<input style=width:20px;height:18px;", "<input style=\"width: 15px; height: 12px;\"");
            return returnStr.ToString();
        }
        #endregion

    }
}
