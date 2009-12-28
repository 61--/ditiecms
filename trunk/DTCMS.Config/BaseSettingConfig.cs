using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common;
using DTCMS.Common.Xml;
using System.Xml;
using System.IO;

namespace DTCMS.Config
{
    public class BaseSettingConfig
    {
        private static XmlDocumentExtender xmlDoc = new XmlDocumentExtender();
        private static string path = Utils.GetRootPath() + ConfigPath.BASESETTING;
        /// <summary>
        /// 初始化XML文档
        /// </summary>
        private static void InitXmlDoc()
        {
            xmlDoc.Load(path);
        }

        #region 关键字TAG        
        /// <summary>
        /// 判断Tag是否存在
        /// </summary>
        private static bool ExistsTag(string tagName){
            InitXmlDoc();
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Tag/Tr");
            foreach (XmlNode tag in xmlnodeList)
            {
                if (tag.SelectSingleNode("Name").LastChild.Value.ToLower() == tagName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 获取关键字TAG列表
        /// </summary>
        public static List<string> GetTagList()
        {
            InitXmlDoc();
            List<string> tagList = new List<string>();
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Tag/Tr");
            foreach (XmlNode tag in xmlnodeList)
            {
                tagList.Add(xmlDoc.GetSingleNodeValue(tag, "Name"));
            }
            return tagList;
        }
        /// <summary>
        /// 添加Tag
        /// </summary>
        /// <param name="tagName">Tag名称</param>       
        public static void AddTag(string tagName)
        {
            if (!ExistsTag(tagName))
            {
                XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/Tag");
                XmlElement tr = xmlDoc.CreateElement("Tr");
                XmlElement td = xmlDoc.CreateElement("Name");
                td.InnerText = tagName;
                tr.AppendChild(td);
                xmlnode.AppendChild(tr);
                xmlDoc.Save(path);
            }
        }
        /// <summary>
        /// 删除Tag
        /// </summary>
        /// <param name="tagName"></param>
        public static void DeleteTag(string tagName)
        {
            InitXmlDoc();
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/Tag");
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Tag/Tr");
            foreach (XmlNode tag in xmlnodeList)
            {
                if (tag.SelectSingleNode("Name").LastChild.Value == tagName)
                {
                    xmlnode.RemoveChild(tag);
                }
            }
            xmlDoc.Save(path);
        }
        #endregion 关键字TAG

        #region 作者
        /// <summary>
        /// 判断Tag是否存在
        /// </summary>
        private static bool ExistsAuthor(string authorName)
        {
            InitXmlDoc();
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Author/Tr");
            foreach (XmlNode author in xmlnodeList)
            {
                if (author.SelectSingleNode("Name").LastChild.Value.ToLower() == authorName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 添加作者
        /// </summary>
        /// <param name="tagName">作者名称</param>       
        public static void AddAuthor(string authorName,string email)
        {
            if (!ExistsAuthor(authorName))
            {
                XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/Author");
                XmlElement tr = xmlDoc.CreateElement("Tr");

                XmlElement tdname = xmlDoc.CreateElement("Name");
                tdname.InnerText = authorName;
                tr.AppendChild(tdname);

                XmlElement tdemail = xmlDoc.CreateElement("Email");
                tdemail.InnerText = email;
                tr.AppendChild(tdemail);

                xmlnode.AppendChild(tr);
                xmlDoc.Save(path);
            }
        }

        /// <summary>
        /// 修改作者
        /// </summary>
        /// <param name="tagName"></param>
        public static void UpdateAuthor(string authorName,string email)
        {
            if (ExistsAuthor(authorName))
            {
                XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/Author");
                XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Author/Tr");
                foreach (XmlNode author in xmlnodeList)
                {
                    if (author.SelectSingleNode("Name").LastChild.Value.ToLower() == authorName.ToLower())
                    {
                        XmlElement Tr = xmlDoc.CreateElement("Tr");

                        XmlElement tdname = xmlDoc.CreateElement("Name");
                        tdname.InnerText = authorName;
                        Tr.AppendChild(tdname);

                        XmlElement tdemail = xmlDoc.CreateElement("Email");
                        tdemail.InnerText = email;
                        Tr.AppendChild(tdemail);

                        xmlnode.ReplaceChild(Tr, author);
                    }
                }
                xmlDoc.Save(path);
            }
        }

        /// <summary>
        /// 删除作者
        /// </summary>
        /// <param name="tagName"></param>
        public static void DeleteAuthor(string authorName)
        {
            InitXmlDoc();
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/Author");
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Author/Tr");
            foreach (XmlNode author in xmlnodeList)
            {
                if (author.SelectSingleNode("Name").LastChild.Value.ToLower() == authorName.ToLower())
                {
                    xmlnode.RemoveChild(author);
                }
            }
            xmlDoc.Save(path);
        }

        /// <summary>
        /// 获取作者列表
        /// </summary>
        public static Dictionary<string, string> GetAuthorList()
        {
            InitXmlDoc();
            Dictionary<string, string> authorlist = new Dictionary<string, string>();
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Author/Tr");
            foreach (XmlNode author in xmlnodeList)
            {
                authorlist.Add(xmlDoc.GetSingleNodeValue(author, "Name"), xmlDoc.GetSingleNodeValue(author, "Email"));
            }
            return authorlist;
        }

        #endregion 作者

        #region 文章来源
        /// <summary>
        /// 判断文章来源是否存在
        /// </summary>
        private static bool ExistsNewsSource(string newssourceName)
        {
            InitXmlDoc();
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/NewsSource/Tr");
            foreach (XmlNode newssource in xmlnodeList)
            {
                if (newssource.SelectSingleNode("Name").LastChild.Value.ToLower() == newssourceName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 添加文章来源
        /// </summary>
        /// <param name="tagName">作者名称</param>       
        public static void AddNewsSource(string newssourceName, string url)
        {
            if (!ExistsNewsSource(newssourceName))
            {
                XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/NewsSource");
                XmlElement tr = xmlDoc.CreateElement("Tr");

                XmlElement tdname = xmlDoc.CreateElement("Name");
                tdname.InnerText = newssourceName;
                tr.AppendChild(tdname);

                XmlElement tdurl = xmlDoc.CreateElement("Url");
                tdurl.InnerText = url;
                tr.AppendChild(tdurl);

                xmlnode.AppendChild(tr);
                xmlDoc.Save(path);
            }
        }

        /// <summary>
        /// 修改文章来源
        /// </summary>
        /// <param name="tagName"></param>
        public static void UpdateNewsSource(string newssourceName, string url)
        {
            if (ExistsNewsSource(newssourceName))
            {
                XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/NewsSource");
                XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/NewsSource/Tr");
                foreach (XmlNode newssource in xmlnodeList)
                {
                    if (newssource.SelectSingleNode("Name").LastChild.Value.ToLower() == newssourceName.ToLower())
                    {
                        XmlElement Tr = xmlDoc.CreateElement("Tr");

                        XmlElement tdname = xmlDoc.CreateElement("Name");
                        tdname.InnerText = newssourceName;
                        Tr.AppendChild(tdname);

                        XmlElement tdurl = xmlDoc.CreateElement("Url");
                        tdurl.InnerText = url;
                        Tr.AppendChild(tdurl);

                        xmlnode.ReplaceChild(Tr,newssource);
                    }
                }
                xmlDoc.Save(path);
            }
        }

        /// <summary>
        /// 删除文章来源
        /// </summary>
        /// <param name="tagName"></param>
        public static void DeleteNewsSource(string newssourceName)
        {
            InitXmlDoc();
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/BaseSeting/NewsSource");
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/NewsSource/Tr");
            foreach (XmlNode newssource in xmlnodeList)
            {
                if (newssource.SelectSingleNode("Name").LastChild.Value.ToLower() == newssourceName.ToLower())
                {
                    xmlnode.RemoveChild(newssource);
                }
            }
            xmlDoc.Save(path);
        }

        /// <summary>
        /// 获取文章来源列表
        /// </summary>
        public static Dictionary<string, string> GetNewsSourceList()
        {
            InitXmlDoc();
            Dictionary<string, string> newssourcelist = new Dictionary<string, string>();
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/NewsSource/Tr");
            foreach (XmlNode newssource in xmlnodeList)
            {
                newssourcelist.Add(xmlDoc.GetSingleNodeValue(newssource, "Name"), xmlDoc.GetSingleNodeValue(newssource, "Url"));
            }
            return newssourcelist;
        }
        #endregion 文章来源
    }
}
