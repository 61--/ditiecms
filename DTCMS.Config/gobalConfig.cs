using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common;
using DTCMS.Common.Xml;
using System.Xml;
using System.IO;

namespace DTCMS.Config
{
    public class GobalConfig
    {
        /// <summary>
        /// xmldoc对象,用于数据文件的信息操作
        /// </summary>
        private static XmlDocumentExtender xmlDoc = new XmlDocumentExtender();

        /// <summary>
        /// 初始化xml
        /// </summary>
        private static void InitXmlDoc()
        {
            string path = Utils.GetRootPath() + ConfigPath.GOBAL;
            xmlDoc.Load(path);
        }

        /// <summary>
        /// 从相应的节点下检索轮显数据
        /// </summary>
        /// <param name="nodename">节点名称</param>
        public static string GetWaterImageStr(string nodeName)
        {
            InitXmlDoc();
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/SystemConfig/Attachment/WaterImage");
            return xmlDoc.GetSingleNodeValue(xmlnode, nodeName);
        }

        /// <summary>
        /// 获取水印图片配置列表
        /// </summary>
        public static Hashtable GetWaterImageList()
        {
            InitXmlDoc();
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/SystemConfig/Attachment/WaterImage");
            Hashtable ht = new Hashtable();            
            ht.Add("WaterPic", xmlDoc.GetSingleNodeValue(xmlnode,"WaterPic"));
            ht.Add("WaterCharater", xmlDoc.GetSingleNodeValue(xmlnode, "WaterCharater"));
            ht.Add("WaterPicPath", xmlDoc.GetSingleNodeValue(xmlnode, "WaterPicPath"));
            ht.Add("XPercent", xmlDoc.GetSingleNodeValue(xmlnode, "XPercent"));
            ht.Add("YPercent", xmlDoc.GetSingleNodeValue(xmlnode, "YPercent"));
            ht.Add("CharColor", xmlDoc.GetSingleNodeValue(xmlnode, "CharColor"));
            ht.Add("Transparence", xmlDoc.GetSingleNodeValue(xmlnode, "Transparence"));
            ht.Add("FontFamilyName", xmlDoc.GetSingleNodeValue(xmlnode, "FontFamilyName"));
            ht.Add("FontSize", xmlDoc.GetSingleNodeValue(xmlnode, "FontSize"));
            return ht;
        }

        /// <summary>
        /// 从相应的节点下检索轮显数据
        /// </summary>
        /// <param name="nodename">节点名称</param>
        public static string GetAttachmentStr(string nodeName)
        {
            InitXmlDoc();
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/SystemConfig/Attachment");
            return xmlDoc.GetSingleNodeValue(xmlnode, nodeName);
        }

        /// <summary>
        /// 获取附件配置列表
        /// </summary>
        public static Hashtable GetAttachmentList()
        {
            InitXmlDoc();
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/SystemConfig/Attachment");
            
            Hashtable ht = new Hashtable();
            string fileName = xmlDoc.GetSingleNodeValue(xmlnode, "Path") + "\\"
                + DateTime.Now.ToString(xmlDoc.GetSingleNodeValue(xmlnode, "Directory") == "" ? "yyyyMM" : xmlDoc.GetSingleNodeValue(xmlnode, "Directory"));
            if (!FileAccessHelper.DirectoryExists(fileName))
            {
                Directory.CreateDirectory(fileName);
            }

            ht.Add("Path", fileName);
            ht.Add("ImageFormat", xmlDoc.GetSingleNodeValue(xmlnode, "ImageFormat"));
            ht.Add("VideoFormat", xmlDoc.GetSingleNodeValue(xmlnode, "VideoFormat"));
            ht.Add("AudioFormat", xmlDoc.GetSingleNodeValue(xmlnode, "AudioFormat"));
            ht.Add("FlashFormat", xmlDoc.GetSingleNodeValue(xmlnode, "FlashFormat"));
            ht.Add("AttachmentFormat", xmlDoc.GetSingleNodeValue(xmlnode, "AttachmentFormat"));
            ht.Add("HasWaterMark", xmlDoc.GetSingleNodeValue(xmlnode, "HasWaterMark"));
            ht.Add("HasAbbrImage", xmlDoc.GetSingleNodeValue(xmlnode, "HasAbbrImage"));
            ht.Add("HasAbbrImageWaterMark", xmlDoc.GetSingleNodeValue(xmlnode, "HasAbbrImageWaterMark"));
            ht.Add("AbbrImageWidth", xmlDoc.GetSingleNodeValue(xmlnode, "AbbrImageWidth"));
            ht.Add("AbbrImageHeight", xmlDoc.GetSingleNodeValue(xmlnode, "AbbrImageHeight"));
            return ht;
        }

    }
}
