using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.Pages
{
    public  class PageSeting
    {
       
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

        #region 获取ajax形式的分页链接
        /// <summary>
        /// 获取ajax形式的分页链接
        /// </summary>
        /// <param name="curPage">当前页数</param>
        /// <param name="countPage">总页数</param>
        /// <param name="callback">ajax回调函数</param>
        /// <param name="extendPage">周边页码显示个数上限</param>
        /// <returns></returns>
        public static string GetAjaxPage(int curPage, int countPage, string callback, int extendPage)
        {
            string pagetag = "page";
            int startPage = 1;
            int endPage = 1;

            string t1 = "<a href=\"###\" onclick=\"" + string.Format("{0}({1})",callback,(curPage-1)<1?1:(curPage-1));
            string t2 = "<a href=\"###\" onclick=\"" + string.Format("{0}({1})", callback,(curPage+1)>countPage?curPage:(curPage+1));

            t1 += "\">&laquo;</a>";
            t2 += "\">&raquo;</a>";

            if (countPage < 1)
                countPage = 1;
            if (extendPage < 3)
                extendPage = 2;

            if (countPage > extendPage)
            {
                if (curPage - (extendPage / 2) > 0)
                {
                    if (curPage + (extendPage / 2) < countPage)
                    {
                        startPage = curPage - (extendPage / 2);
                        endPage = startPage + extendPage - 1;
                    }
                    else
                    {
                        endPage = countPage;
                        startPage = endPage - extendPage + 1;
                        t2 = "";
                    }
                }
                else
                {
                    endPage = extendPage;
                    t1 = "";
                }
            }
            else
            {
                startPage = 1;
                endPage = countPage;
                t1 = "";
                t2 = "";
            }

            StringBuilder s = new StringBuilder("");

            s.Append(t1);
            if (curPage-(extendPage/2) > 2)
            {

                s.Append("<a href=\"###\" onclick=\"");
                s.Append(string.Format("{0}({1})", callback, 1));
                s.Append("\">");
                s.Append(1);
                s.Append("</a>");
                s.Append("<a href=\"###\" onclick=\"");
                s.Append(string.Format("{0}({1})", callback, 2));
                s.Append("\">");
                s.Append(2);
                s.Append("</a>");
                s.Append("...");
            }
            for (int i = startPage; i <= endPage; i++)
            {
                if (i == curPage)
                {
                    s.Append("<span class=\"current\">");
                    s.Append(i);
                    s.Append("</span>");
                }
                else
                {
                    s.Append("<a href=\"###\" onclick=\"");
                    s.Append(string.Format("{0}({1})",callback, i));
                    s.Append("\">");
                    s.Append(i);
                    s.Append("</a>");
                }
            }
            if ((countPage-curPage) >(extendPage/2))
            {
                s.Append("<a href=\"###\" onclick=\"");
                s.Append(string.Format("{0}({1})", callback, countPage-1));
                s.Append("\">");
                s.Append(countPage - 1);
                s.Append("</a>");
                s.Append("<a href=\"###\" onclick=\"");
                s.Append(string.Format("{0}({1})", callback, countPage));
                s.Append("\">");
                s.Append(countPage);
                s.Append("</a>");
            }
            s.Append(t2);

            return s.ToString();
        }
        #endregion

        #region 获取url形式分页
        /// <summary>
        /// 获得页码显示链接
        /// </summary>
        /// <param name="curPage">当前页数</param>
        /// <param name="countPage">总页数</param>
        /// <param name="url">超级链接地址</param>
        /// <param name="extendPage">周边页码显示个数上限</param>
        /// <param name="pagetag">页码标记</param>
        /// <param name="anchor">锚点</param>
        /// <returns>页码html</returns>
        public static string GetPageNumbers(int curPage, int countPage, string url, int extendPage, string pagetag, string anchor)
        {
            if (pagetag == "")
                pagetag = "page";
            int startPage = 1;
            int endPage = 1;

            if (url.IndexOf("?") > 0)
                url = url + "&";
            else
                url = url + "?";
            int upnum = (curPage - 1) < 1 ? 1 : (curPage - 1);
            int downnum = (curPage + 1) > countPage ? countPage : (curPage + 1);
            string t1 = "<a href=\"" + url  + pagetag + "=" + upnum;
            string t2 = "<a href=\"" + url  + pagetag + "=" + downnum;
            if (anchor != null)
            {
                t1 += anchor;
                t2 += anchor;
            }
            t1 += "\">&laquo;</a>";
            t2 += "\">&raquo;</a>";

            if (countPage < 1)
                countPage = 1;
            if (extendPage < 3)
                extendPage = 2;

            if (countPage > extendPage)
            {
                if (curPage - (extendPage / 2) > 0)
                {
                    if (curPage + (extendPage / 2) < countPage)
                    {
                        startPage = curPage - (extendPage / 2);
                        endPage = startPage + extendPage - 1;
                    }
                    else
                    {
                        endPage = countPage;
                        startPage = endPage - extendPage + 1;
                        t2 = "";
                    }
                }
                else
                {
                    endPage = extendPage;
                    t1 = "";
                }
            }
            else
            {
                startPage = 1;
                endPage = countPage;
                t1 = "";
                t2 = "";
            }

            StringBuilder s = new StringBuilder("");

            s.Append(t1);
            if (curPage - (extendPage / 2) > 2)
            {

                s.Append("<a href=\"");
                s.Append(url);
                s.Append(pagetag);
                s.Append("=");
                s.Append(1);
                if (anchor != null)
                {
                    s.Append(anchor);
                }
                s.Append("\">");
                s.Append(1);
                s.Append("</a>");
                s.Append("<a href=\"");
                s.Append(url);
                s.Append(pagetag);
                s.Append("=");
                s.Append(2);
                if (anchor != null)
                {
                    s.Append(anchor);
                }
                s.Append("\">");
                s.Append(2);
                s.Append("</a>");
                s.Append("...");
            }
            for (int i = startPage; i <= endPage; i++)
            {
                if (i == curPage)
                {
                    s.Append("<span>");
                    s.Append(i);
                    s.Append("</span>");
                }
                else
                {
                    s.Append("<a href=\"");
                    s.Append(url);
                    s.Append(pagetag);
                    s.Append("=");
                    s.Append(i);
                    if (anchor != null)
                    {
                        s.Append(anchor);
                    }
                    s.Append("\">");
                    s.Append(i);
                    s.Append("</a>");
                }
            }
            if ((countPage - curPage) > (extendPage / 2))
            {
                s.Append("...");
                s.Append("<a href=\"");
                s.Append(url);
                s.Append(pagetag);
                s.Append("=");
                s.Append(countPage - 1);
                if (anchor != null)
                {
                    s.Append(anchor);
                }
                s.Append("\">");
                s.Append(countPage - 1);
                s.Append("</a>");
                s.Append("<a href=\"");
                s.Append(url);
                s.Append(pagetag);
                s.Append("=");
                s.Append(countPage);
                if (anchor != null)
                {
                    s.Append(anchor);
                }
                s.Append("\">");
                s.Append(countPage);
                s.Append("</a>");
            }
            s.Append(t2);

            return s.ToString();
        }
        #endregion

    }
}
