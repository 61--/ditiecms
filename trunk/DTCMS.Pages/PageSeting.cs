using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Pages
{
    public  class PageSeting
    {
        /// <summary>
        /// ajax分页
        /// </summary>
        /// <param name="recordTotalCount">共有多少条记录</param>
        /// <param name="pageSize">每页显示多少条记录</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="ajaxLoad">初始化数据ajax方法名称</param>
        /// <returns></returns>
        public static string  CreateAjaxPageHtml(int recordTotalCount,int pageSize,int pageIndex,string ajaxLoad)
        {
            int pageCount = GetPageCount(recordTotalCount,pageSize);
            if (pageIndex < 1)
            {
                pageIndex = 1;
            }
            if (pageIndex > pageCount)
            {
                pageIndex = pageCount;
            }
            StringBuilder strHtml = new StringBuilder();
            strHtml.Append("<div class=\"ajaxpage\">");
            strHtml.Append(string.Format("<span>共{0}条记录 - 每页{1}条 -当前第 {2}/{3}页</span>",recordTotalCount,pageSize,pageIndex,pageCount));
            strHtml.Append("<label>");
            if (pageIndex <= 1)
            {
                strHtml.Append("首页");
                strHtml.Append("上一页");
            }
            else
            {
                strHtml.Append(string.Format("<a href=\"#\" onclick=\"{0}({1})\">首页</a>",ajaxLoad,1));
                strHtml.Append(string.Format("<a href=\"#\" onclick=\"{0}({1})\">上一页</a>",ajaxLoad,pageIndex-1));
            }
            if (pageIndex < pageCount)
            {
                
                strHtml.Append(string.Format("<a href=\"#\" onclick=\"{0}({1})\">下一页</a>", ajaxLoad, pageIndex+1));
                strHtml.Append(string.Format("<a href=\"#\" onclick=\"{0}({1})\">尾页</a>", ajaxLoad,pageCount));
            }
            else
            {
                strHtml.Append("下一页");
                strHtml.Append("尾页");
            }
            strHtml.Append("<input type=\"text\" size=\"10\" id=\"txtPageIndex\"/>");
            strHtml.Append("<input type=\"button\" value=\"GO\" onclick=\"GoPage()\"/>");
            strHtml.Append("<lable>");
            strHtml.Append("</div>");
            return strHtml.ToString();
        }
        /// <summary>
        /// 算共有几页
        /// </summary>
        /// <param name="recordTotalCount">共有多少条记录</param>
        /// <param name="pageSize">每页显示多少条记录</param>
        /// <returns>共有几页</returns>
        public static int GetPageCount(int recordTotalCount, int pageSize)
        {
            int totalCount = 0;
            if (recordTotalCount % pageSize == 0)
            {
                totalCount= recordTotalCount / pageSize;
            }
            else
            {
                totalCount = recordTotalCount / pageSize + 1;
            }
            return totalCount;
        }
    }
}
