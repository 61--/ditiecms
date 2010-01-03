using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common.Xml;
using DTCMS.Common;
using System.Xml;
using System.Data;

namespace DTCMS.Config
{
    public class DialogConfig
    {
        private static XmlDocumentExtender xmlDoc = new XmlDocumentExtender();
        private static string path = Utils.GetRootPath() + ConfigPath.DIALOG;

        /// <summary>
        /// 初始化XML文档
        /// </summary>
        private static void InitXmlDoc()
        {
            xmlDoc.Load(path);
        }

        public static string GetDialogSingle(string dialogkey)
        {
            InitXmlDoc();
            XmlNodeList dialogNodeList = xmlDoc.DocumentElement.SelectNodes(("/configuration/dialog[@key='" + dialogkey + "']"));
            if (dialogNodeList != null && dialogNodeList.Count > 0)
            {
                return dialogNodeList[0].Attributes["value"].Value.Trim();
            }
            else
            {
                return "";
            }
        }

        public static void SetDialogSingle(string dialogkey, string dialogvalue)
        {
            InitXmlDoc();
            XmlNodeList dialogNodeList = xmlDoc.DocumentElement.SelectNodes(("/configuration/dialog[@key='" + dialogkey + "']"));
            if (dialogNodeList != null && dialogNodeList.Count > 0)
            {
                dialogNodeList[0].Attributes["value"].Value = dialogvalue.Trim();
            }
        }

    }
}
