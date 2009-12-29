using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common;
namespace DTCMS.Publish
{
    public delegate void DelegateRoll(int total, int num);
    public class PublishTool
    {
        public event DelegateRoll ResponeRoll;

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
                    if (ResponeRoll != null)
                    {
                        ResponeRoll(this._total,this._num);
                    }
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
