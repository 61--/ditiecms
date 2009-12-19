using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Common;
using DTCMS.Common.Xml;
using System.Xml;

namespace DTCMS.Config
{
    public class AttachmentConfig
    {

        /// <summary>
        /// xmldoc对象,用于数据文件的信息操作
        /// </summary>
        protected static XmlDocumentExtender xmlDoc = new XmlDocumentExtender();

        #region 图片操作
        /// <summary>
        /// 从相应的节点下检索轮显数据
        /// </summary>
        /// <param name="nodename">节点名称</param>
        public static string GetPhotoStr(string nodeName)
        {
            string path = Utils.GetRootPath() + ConfigPath.ATTACHMENT;
            xmlDoc.Load(path);
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/attachment/photo");
            return xmlDoc.GetSingleNodeValue(xmlnode, nodeName);
        }
        /// <summary>
        /// 获取图片配置列表
        /// </summary>
        public static Hashtable GetPhotoList()
        {
            string path = Utils.GetRootPath() + ConfigPath.ATTACHMENT;
            xmlDoc.Load(path);
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/attachment/photo");
            Hashtable ht = new Hashtable();
            ht.Add("path", xmlDoc.GetSingleNodeValue(xmlnode,"path"));
            ht.Add("contentLength", xmlDoc.GetSingleNodeValue(xmlnode, "contentLength"));
            ht.Add("format", xmlDoc.GetSingleNodeValue(xmlnode, "format"));
            ht.Add("hasAbbrImage", xmlDoc.GetSingleNodeValue(xmlnode, "hasAbbrImage"));
            ht.Add("hasWaterMark", xmlDoc.GetSingleNodeValue(xmlnode, "hasWaterMark"));
            ht.Add("hasAbbrWaterMark", xmlDoc.GetSingleNodeValue(xmlnode, "hasAbbrWaterMark"));
            ht.Add("waterMarkPosition", xmlDoc.GetSingleNodeValue(xmlnode, "waterMarkPosition"));
            return ht;
        }
        #endregion 图片操作
    }
}
