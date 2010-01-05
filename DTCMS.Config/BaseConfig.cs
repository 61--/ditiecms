using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common.Xml;
using DTCMS.Common;
using System.Xml;

namespace DTCMS.Config
{
    public class BaseConfig
    {
        private XmlDocumentExtender xmlDoc = null;

        protected XmlDocumentExtender GetXmlInstance(string path)
        {
            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocumentExtender();
            }
            xmlDoc.Load(path);
            return xmlDoc;
        }

        protected XmlNodeList SelectNodes(string xmlPath, string nodePath)
        {
            if (xmlDoc == null)
            {
                GetXmlInstance(xmlPath);
            }

            return xmlDoc.DocumentElement.SelectNodes(nodePath);
        }

        protected XmlNode SelectSingleNodes(string xmlPath, string nodePath)
        {
            if (xmlDoc == null)
            {
                GetXmlInstance(xmlPath);
            }
            return xmlDoc.DocumentElement.SelectSingleNode(nodePath);
        }

    }
}
