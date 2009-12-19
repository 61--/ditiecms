using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Common;
using DTCMS.Common.Xml;
using System.Xml;
using System.IO;

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
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/attachment");
            return xmlDoc.GetSingleNodeValue(xmlnode, nodeName);
        }
        /// <summary>
        /// 获取图片配置列表
        /// </summary>
        public static Hashtable GetPhotoList()
        {
            string path = Utils.GetRootPath() + ConfigPath.ATTACHMENT;
            xmlDoc.Load(path);
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/attachment");
            Hashtable ht = new Hashtable();
            string fileName = xmlDoc.GetSingleNodeValue(xmlnode, "path")+"\\"+DateTime.Now.ToString("yyyyMM");
            if (!FileAccessHelper.DirectoryExists(fileName))
            {
                Directory.CreateDirectory(fileName);
            }
            ht.Add("path", fileName);
            ht.Add("contentLength", xmlDoc.GetSingleNodeValue(xmlnode, "contentLength"));
            ht.Add("imageFormat", xmlDoc.GetSingleNodeValue(xmlnode, "imageFormat"));
            ht.Add("videoFormat", xmlDoc.GetSingleNodeValue(xmlnode, "videoFormat"));
            ht.Add("audioFormat", xmlDoc.GetSingleNodeValue(xmlnode, "audioFormat"));
            ht.Add("flashFormat", xmlDoc.GetSingleNodeValue(xmlnode, "flashFormat"));
            ht.Add("attachmentFormat", xmlDoc.GetSingleNodeValue(xmlnode, "attachmentFormat"));
            return ht;
        }
        #endregion 图片操作
    }
}
