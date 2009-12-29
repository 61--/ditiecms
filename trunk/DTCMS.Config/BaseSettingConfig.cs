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
        public static XmlNode GetBaseSetting(string basesettingkey)
        {
            InitXmlDoc();
            XmlNode basesetnnode = xmlDoc.DocumentElement.SelectSingleNode("/configuration/baseseting[@key='" + basesettingkey + "']/item");
            return basesetnnode;
        }

        /// <summary>
        /// 关键字
        /// </summary>
        public static string GetTagTitle()
        {
            XmlNode tagNode = GetBaseSetting("tag");
            return tagNode.Attributes["value"].Value.Trim();
        }
        /// <summary>
        /// 关键字
        /// </summary>
        public static void SetTagTitle(string tagtitle)
        {
            XmlNode tagNode = GetBaseSetting("tag");
            tagNode.Attributes["value"].Value = tagtitle;
        }

        /// <summary>
        /// 作者
        /// </summary>
        public static string GetAuthorTitle()
        {
            XmlNode authorNode = GetBaseSetting("author");
            return authorNode.Attributes["value"].Value.Trim();
        }
        /// <summary>
        /// 作者
        /// </summary>
        public static void SetAuthorTitle(string authortitle)
        {
            XmlNode authorNode = GetBaseSetting("author");
            authorNode.Attributes["value"].Value = authortitle;
        }

        /// <summary>
        /// 责任编辑
        /// </summary>
        public static string GetEditorTitle()
        {
            XmlNode editorNode = GetBaseSetting("editor");
            return editorNode.Attributes["value"].Value.Trim();
        }
        /// <summary>
        /// 责任编辑
        /// </summary>
        public static void SetEditorTitle(string editortitle)
        {
            XmlNode editorNode = GetBaseSetting("editor");
            editorNode.Attributes["value"].Value = editortitle;
        }

        /// <summary>
        /// 文章来源
        /// </summary>
        public static string GetNewsSourceTitle()
        {
            XmlNode newssourceNode = GetBaseSetting("newssource");
            return newssourceNode.Attributes["value"].Value.Trim();
        }
        /// <summary>
        /// 文章来源
        /// </summary>
        public static void SetNewsSourceTitle(string newssourcetitle)
        {
            XmlNode newssourceNode = GetBaseSetting("newssource");
            newssourceNode.Attributes["value"].Value = newssourcetitle;
        }

    }
}
