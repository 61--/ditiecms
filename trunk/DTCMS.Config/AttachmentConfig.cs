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
        private static XmlDocumentExtender xmlDoc = new XmlDocumentExtender();

        #region 附件操作
        /// <summary>
        /// 从相应的节点下检索轮显数据
        /// </summary>
        /// <param name="nodename">节点名称</param>
        public static string GetAttachmentStr(string nodeName)
        {
            string path = Utils.GetRootPath() + ConfigPath.ATTACHMENT;
            xmlDoc.Load(path);
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/Attachment");
            return xmlDoc.GetSingleNodeValue(xmlnode, nodeName);
        }
        /// <summary>
        /// 获取附件配置列表
        /// </summary>
        public static Hashtable GetAttachmentList()
        {
            string path = Utils.GetRootPath() + ConfigPath.ATTACHMENT;
            xmlDoc.Load(path);
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/Attachment");
            Hashtable ht = new Hashtable();
            string fileName = xmlDoc.GetSingleNodeValue(xmlnode, "Path")+"\\"+DateTime.Now.ToString("yyyyMM");
            if (!FileAccessHelper.DirectoryExists(fileName))
            {
                Directory.CreateDirectory(fileName);
            }
            ht.Add("Path", fileName);
            ht.Add("ContentLength", xmlDoc.GetSingleNodeValue(xmlnode, "ContentLength"));
            ht.Add("ImageFormat", xmlDoc.GetSingleNodeValue(xmlnode, "ImageFormat"));
            ht.Add("VideoFormat", xmlDoc.GetSingleNodeValue(xmlnode, "VideoFormat"));
            ht.Add("AudioFormat", xmlDoc.GetSingleNodeValue(xmlnode, "AudioFormat"));
            ht.Add("FlashFormat", xmlDoc.GetSingleNodeValue(xmlnode, "FlashFormat"));
            ht.Add("AttachmentFormat", xmlDoc.GetSingleNodeValue(xmlnode, "AttachmentFormat"));
            return ht;
        }
        #endregion 附件操作
    }
}
