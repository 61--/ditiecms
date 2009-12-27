using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;
using DTCMS.BLL;
using DTCMS.Pages;
namespace DTCMS.Publish
{
    public class ArticleLable:Lable
    {
        protected Arc_ArticleBLL arcBll = new Arc_ArticleBLL();

        /// <summary>
        /// 生成内容页
        /// </summary>
        /// <param name="articleID">文章编号</param>
        public override void CreatePageHtml(int articleID)
        {
            DataTable dt = new DataTable();
            string template = string.Empty;
            //替换其它

             ReplayPageLable(template,dt.Rows[0]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="classID"></param>
        public override void CreateListHtml(int classID)
        {
            //其它替换

            string template = string.Empty;
            Regex regnew = new Regex(@"{loop:list(.*)}([\s\S]*?){/loop}", RegexOptions.Compiled);
            Match match = regnew.Match(template);
            if (match.Success)
            {
                int tlen = 0;
                int clen = 0;
                //解析标签

                //构造sql语句
                string sql =string.Format("SELECT * FROM DT_Arc_Article WHERE CID={0}",classID);
                DataTable dt = new DataTable();
                int pageSize=10;
                int totalRecord = dt.Rows.Count;
                string path=string.Empty;
                ConvertPagingList(path, template, match.Groups[2].Value, match.Groups[0].Value, pageSize, dt);
                
                dt.Dispose();
            }
        }

        /// <summary>
        /// 列表页分页
        /// </summary>
        /// <param name="path">第一页生成路径</param>
        /// <param name="template">列表模板</param>
        /// <param name="loopitem">循环项内容</param>
        /// <param name="loopitemrule">循环规则</param>
        /// <param name="pageSize">每页显示条数</param>
        /// <param name="dt">数据集合</param>
        protected override void ConvertPagingList(string path, string template, string loopitem, string loopitemrule, int pageSize, System.Data.DataTable dt)
        {

            int totalPage = PageSeting.GetPageCount(dt.Rows.Count, pageSize);
            StringBuilder strListItem = new StringBuilder();
            string strList = string.Empty;
            int tlen = 0;
            int clen = 0;
            for (int i = 1; i <= totalPage; i++)
            {

                for (int n = (i - 1) * pageSize; n < i * pageSize; n++)
                {
                    strListItem.Append(ReplayListLable(tlen, clen, true, loopitem, dt.Rows[n]));
                }
                strList = template.Replace(loopitemrule, strListItem.ToString());
                strList = strList.Replace("{#page}",PageSeting.GetPageNumbers(i,totalPage,string.Format("{0}_{1}",path,1),pageSize,"",""));//分页
                strListItem.Length = 0;//清空stringbuilder 数据
                //创建静态页
            }
        }
        public override void CreateCoverHtml(int classID)
        {
            
        }

        /// <summary>
        /// 替换循环列表通用方法
        /// </summary>
        /// <param name="tlen">标题长度 0原长度</param>
        /// <param name="clen">描述/内容长度 0原长度</param>
        /// <param name="isMark">内容后面是否加标记 如...</param>
        /// <param name="loopitem">循环内容</param>
        /// <param name="dt">数据原</param>
        /// <returns>替换完的内容</returns>
        public override string ReplayListLable(int tlen, int clen, bool isMark, string loopitem, DataRow row)
        {
            StringBuilder strHtml = new StringBuilder();
            string strReplace = string.Empty;
 
            strReplace = loopitem.Replace("[#article.title]", row["title"].ToString());
            strReplace = strReplace.Replace("[#article.articleurl]", row["filepath"].ToString());
            strReplace = strReplace.Replace("[#article.content]", row["content"].ToString());
            strReplace = strReplace.Replace("{#article.description}", row["description"].ToString());
            strReplace = strReplace.Replace("[#article.classname]", row["classname"].ToString());
            strReplace = strReplace.Replace("[#article.imgurl]", row["imgurl"].ToString());
            strReplace = strReplace.Replace("[#article.author]", row["author"].ToString());
            strReplace = strReplace.Replace("[#article.pubdate]", row["pubdate"].ToString());//时间得改
            strReplace = strReplace.Replace("[#article.click]", "");
            strReplace = strReplace.Replace("[#article.goodnum]", "");
            strReplace = strReplace.Replace("[#article.badnum]", "");
            strReplace = strReplace.Replace("[#article.goodper]", "");
            strReplace = strReplace.Replace("[#article.badper]", "");
            strHtml.Append(strReplace + "\r\n");
       
            return strHtml.ToString();
        }
        /// <summary>
        /// 替换内容详细页
        /// </summary>
        /// <param name="template">模板</param>
        /// <param name="row">内容页数据</param>
        /// <returns></returns>
        public override void ReplayPageLable(string template,DataRow row)
        {
            string strReplace=string.Empty;
            strReplace = template.Replace("{#article.title}", row["title"].ToString());
            strReplace = strReplace.Replace("{#article.articleurl}", row["filepath"].ToString());          
            strReplace = strReplace.Replace("{#article.description}", row["description"].ToString());
            strReplace = strReplace.Replace("{#article.classname}", row["classname"].ToString());
            strReplace = strReplace.Replace("{#article.imgurl}", row["imgurl"].ToString());
            strReplace = strReplace.Replace("{#article.author}", row["author"].ToString());
            strReplace = strReplace.Replace("{#article.pubdate}", row["pubdate"].ToString());//时间得改
            strReplace = strReplace.Replace("{#article.click}", "");
            strReplace = strReplace.Replace("{#article.goodnum}", "");
            strReplace = strReplace.Replace("{#article.badnum}", "");
            strReplace = strReplace.Replace("{#article.goodper}", "");
            strReplace = strReplace.Replace("{#article.badper}", "");
            string path=string.Empty;
            ConvertPagingContent(path,strReplace,row["content"].ToString(),"{#article.content}");
           
        }
    }
}
