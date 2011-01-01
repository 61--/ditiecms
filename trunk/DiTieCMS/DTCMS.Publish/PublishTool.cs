using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common;
namespace DTCMS.Publish
{
    public class PublishTool
    {


        private int _total;
        private int _num;

        /// <summary>
        /// 共多少条数据
        /// </summary>
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
        /// <summary>
        /// 当前第几条
        /// </summary>
        public int Num
        {
            get { return _num; }
            set { _num = value; }
        }

        /// <summary>
        /// 得到模板
        /// </summary>
        /// <param name="filePath">模板先对路径</param>
        /// <returns></returns>
        public  string GetTemplate(string filePath)
        {
            object obj = CacheAccess.GetFromCache(filePath);
            if (obj!=null)
            {
                return obj as string;
            }
            else
            {
                try
                {
                    string template = FileAccessHelper.ReadTextFile(Utils.GetPhysicalPath(string.Format("~/{0}", filePath)));
                    CacheAccess.SaveToCache(filePath, template);
                    return template;
                }
                catch
                {
                    return "此模板文件不存在";
                }
            }
        }

        /// <summary>
        /// 获取栏目保存路径
        /// </summary>
        /// <param name="savePath">保存路径规则</param>
        /// <returns>栏目保存路径</returns>
        public string GetClassUrl(string savePath)
        {
            return savePath = savePath.Replace("{#sitepath}","");
        }
        /// <summary>
        /// 生成html文件
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="htmlpath">生成html路径</param>
        /// <returns></returns>
        public  bool CreateHtml(string content, string htmlpath)
        {
            try
            {
                    
                    FileAccessHelper.WriteTextFile(htmlpath, content);
                    return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 标题长度处理
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="tlen">要截的长度</param>
        /// <param name="isMark">内容后面是否加标记 如...</param>
        /// <returns></returns>
        public string GetTitle(string title,int tlen,bool isMark)
        {
            if (tlen > 0)
            {
                string mark = string.Empty;
                if (isMark)
                    mark = "...";
                return Utils.GetSubString(title, tlen, mark);
            }
            else
            {
                return title;
            }
            
        }
        /// <summary>
        /// 内容长度处理
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="clen">要截的长度</param>
        /// <param name="isMark">内容后面是否加标记 如...</param>
        /// <returns></returns>
        public string GetContent(string content, int clen, bool isMark)
        {
            content = Utils.NoHTML(content);
            if (clen > 0)
            {
                string mark = string.Empty;
                if (isMark)
                    mark = "...";
                return Utils.GetSubString(content, clen, mark);
            }
            else
            {
                return content;
            }
        }
    }
}
