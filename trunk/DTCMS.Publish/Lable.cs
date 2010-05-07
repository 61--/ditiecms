using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using DTCMS.Pages;

namespace DTCMS.Publish
{
    public abstract class Lable
    {
        PublishTool tool = new PublishTool();
        /// <summary>
        /// 内容页分页
        /// </summary>
        /// <param name="path">第一页生成路径</param>
        /// <param name="template">内容页模板</param>
        ///<param name="content">文章内容</param>
        ///<param name="tag">文章正文标签{#.content}</param>
        public  virtual void ConvertPagingContent(string path, string template, string content, string tag)
        {
            string strPage = string.Empty;
            if (content.IndexOf("{#pagenext}") != -1)
            {
                string[] strContent = content.Split(new string[] { "{#pagenext}" }, StringSplitOptions.RemoveEmptyEntries);
                int i = 0;
                foreach (string str in strContent)
                {
                    i++;
                    strPage = template.Replace(tag, str);
                    strPage = strPage.Replace("{#page}", PageSeting.GetPageNumbers(i, strContent.Length, string.Format("{0}_{1}", path, i), 10, "", ""));//分页标签
                    tool.CreateHtml(content, path);
                }
            }
            else
            {
                strPage = template.Replace(tag, content);
                tool.CreateHtml(content, path);
            }
            
        }
        /// <summary>
        /// 列表页分页
        /// </summary>
        /// <param name="path">第一页生成路径</param>
        /// <param name="template">列表模板</param>
        /// <param name="pageSize">每页显示条数</param>
        /// <param name="dt"></param>
        protected virtual string ConvertPagingList(string path, string template, string loopitem, string loopitemrule, int pageSize, System.Data.DataTable dt) 
        {
            return "";
        }
        

        /// <summary>
        /// 生成内容页
        /// </summary>
        public virtual string ConvertPageHtml(DataRow row) 
        {
            return "";
        }

        /// <summary>
        /// 生成列表页
        /// </summary>
        /// <param name="classID">类别编号</param>
        public virtual string ConvertListHtml(int classID)
        {
            return "";
        }

        /// <summary>
        /// 生成封面页
        /// </summary>
        /// <param name="classID">类别编号</param>
        public virtual string ConvertCoverHtml(int classID)
        {
            return "";
        }

        /// <summary>
        /// 替换循环列表通用方法
        /// </summary>
        /// <param name="tlen">标题长度 0原长度</param>
        /// <param name="clen">内容长度 0</param>
        /// <param name="isMark">内容后面是否加标记 如...</param>
        /// <param name="loopitem">循环内容</param>
        /// <param name="dt">数据原</param>
        /// <returns>替换结束列表</returns>
        public virtual string ReplayListLable(int tlen, int clen, bool isMark, string loopitem, DataRow row) 
        {
            return "";
        }

        /// <summary>
        /// 替换内容页通用方法
        /// </summary>
        /// <param name="template">内容页模板</param>
        /// <param name="row">内容数据</param>
        /// <returns></returns>
        public virtual string ReplayPageLable(string template, DataRow row)
        {
            return "";
        }
    }
}
