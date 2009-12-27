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
        #region 关键字TAG
        /// <summary>
        /// 初始化XML文档
        /// </summary>
        private static void InitXmlDoc()
        {            
            xmlDoc.Load(path);
        }
        /// <summary>
        /// 判断Tag是否存在
        /// </summary>
        private static bool ExistsTag(string tagName){
            InitXmlDoc();
            XmlNodeList xmlnodeList = xmlDoc.DocumentElement.SelectNodes("/BaseSeting/Tag/Tr");
            foreach (XmlNode tag in xmlnodeList)
            {
                if (tag.SelectSingleNode("Name").LastChild.Value == tagName)
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
                InitXmlDoc();
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
    }
}
