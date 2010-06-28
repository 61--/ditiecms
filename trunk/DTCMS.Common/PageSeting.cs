//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-06-02 11:10:08
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Text;

namespace DTCMS.Common
{
    public class PageSeting
    {
        /// <summary>
        /// 算共有几页
        /// </summary>
        /// <param name="recordTotalCount">共有多少条记录</param>
        /// <param name="pageSize">每页显示多少条记录</param>
        /// <returns>共有几页</returns>
        public static int GetPageCount(int totalRecord, int pageSize)
        {
            return (int)Math.Ceiling(totalRecord / TypeConvert.ToFloat(pageSize));
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
            //string pagetag = "page";
            int startPage = 1;
            int endPage = 1;

            string t1 = "<a href=\"javascript:;\" onclick=\"" + string.Format("{0}({1})", callback, (curPage - 1) < 1 ? 1 : (curPage - 1));
            string t2 = "<a href=\"javascript:;\" onclick=\"" + string.Format("{0}({1})", callback, (curPage + 1) > countPage ? curPage : (curPage + 1));

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

                s.Append("<a href=\"javascript:;\" onclick=\"");
                s.Append(string.Format("{0}({1})", callback, 1));
                s.Append("\">");
                s.Append(1);
                s.Append("</a>");
                s.Append("<a href=\"javascript:;\" onclick=\"");
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
                    s.Append("<a href=\"javascript:;\" onclick=\"");
                    s.Append(string.Format("{0}({1})", callback, i));
                    s.Append("\">");
                    s.Append(i);
                    s.Append("</a>");
                }
            }
            if ((countPage - curPage) > (extendPage / 2))
            {
                s.Append("...");
                s.Append("<a href=\"javascript:;\" onclick=\"");
                s.Append(string.Format("{0}({1})", callback, countPage - 1));
                s.Append("\">");
                s.Append(countPage - 1);
                s.Append("</a>");
                s.Append("<a href=\"javascript:;\" onclick=\"");
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
        public static string GetPageNum(int curPage, int totalPage, int extendPage, int channelID, string pageItem)
        {
            string[] items = pageItem.ToLower().Split(',');
            StringBuilder sb = new StringBuilder();

            if (totalPage < 1)
                totalPage = 1;
            if (extendPage < 3)
                extendPage = 3;

            foreach (string item in items)
            {
                switch (item)
                {
                    case "first":
                        if (curPage == 1)
                        {
                            sb.Append("<a href='#' class='pFirst disabled'>首页</a>");
                        }
                        else
                        {
                            sb.Append("<a href='index.html' class='pFirst'>首页</a>");
                        }
                        break;
                    case "pre":
                        if (curPage == 1)
                        {
                            sb.Append("<a href='#' class='pPrev disabled'>上一页</a>");
                        }
                        else
                        {
                            if (curPage == 2)
                            {
                                sb.Append("<a href='index.html' class='pPrev'>上一页</a>");
                            }
                            else
                            {
                                sb.Append("<a href='");
                                sb.Append("list_1_").Append(curPage - 1).Append(".html");
                                sb.Append("' class='pPrev'>上一页</a>");
                            }
                        }
                        break;
                    case "pagenum":
                        int startPage = 1;
                        int endPage = 1;
                        if (totalPage > extendPage)
                        {
                            if (curPage - (extendPage / 2) > 0)
                            {
                                if (curPage + (extendPage / 2) < totalPage)
                                {
                                    startPage = curPage - (extendPage / 2);
                                    endPage = startPage + extendPage - 1;
                                }
                                else
                                {
                                    endPage = totalPage;
                                    startPage = endPage - extendPage + 1;
                                }
                            }
                            else
                            {
                                endPage = extendPage;
                            }
                        }
                        else
                        {
                            startPage = 1;
                            endPage = totalPage;
                        }

                        //生成数字分页链接
                        for (int i = startPage; i <= endPage; i++)
                        {
                            if (i == curPage)
                            {
                                sb.Append("<strong>");
                                sb.Append(i);
                                sb.Append("</strong>");
                            }
                            else
                            {
                                sb.Append("<a href=\"");
                                sb.Append("list_1_").Append(i).Append(".html");
                                sb.Append("\">").Append(i).Append("</a>");
                            }
                        }
                        break;
                    case "next":
                        if (curPage == totalPage)
                        {
                            sb.Append("<a href='#' class='pNext disabled'>下一页</a>");
                        }
                        else
                        {
                            sb.Append("<a href='");
                            sb.Append("list_1_").Append(curPage + 1).Append(".html");
                            sb.Append("' class='pNext'>下一页</a>");
                        }
                        break;
                    case "last":
                        if (curPage == totalPage)
                        {
                            sb.Append("<a href='#' class='pLast disabled'>末页</a>");
                        }
                        else
                        {
                            sb.Append("<a href='");
                            sb.Append("list_1_").Append(totalPage).Append(".html");
                            sb.Append("' class='pLast'>末页</a>");
                        }
                        break;
                    case "potion":
                        sb.Append("potion");
                        break;
                    default:
                        break;
                }
            }            
            return sb.ToString();
        }
        #endregion

    }
}
