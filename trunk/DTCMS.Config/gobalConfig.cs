using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common;
using DTCMS.Common.Xml;
using System.Xml;
using System.IO;
using System.Web.Caching;

namespace DTCMS.Config
{
    public class GobalConfig
    {       
        /// <summary>
        /// 获取缓存依赖
        /// </summary>
        private static CacheDependency GetGobalConfigCacheDependency()
        {
            return new CacheDependency(Utils.GetRootPath()+"config\\sys\\gobal.config");
        }

        /// <summary>
        /// 获取xmlDoc
        /// </summary>
        private static XmlDocumentExtender GetXMLDocument()
        {             
           XmlDocumentExtender xmlDoc = CacheAccess.GetFromCache("XmlDocumentExtender") as XmlDocumentExtender;
            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocumentExtender();
                string path = Utils.GetRootPath() + ConfigPath.GOBAL;
                xmlDoc.Load(path);
                CacheAccess.SaveToCache("XmlDocumentExtender", xmlDoc, GetGobalConfigCacheDependency());
            }
            return xmlDoc;
        }

        #region 附件
        /// <summary>
        /// 获取单个值
        /// </summary>
        /// <param name="nodename">节点名称</param>
        public static string GetWaterImageStr(string nodeName)
        {
            XmlNode xmlnode = GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment/WaterImage");
            return GetXMLDocument().GetSingleNodeValue(xmlnode, nodeName);
        }

        /// <summary>
        /// 获取水印图片配置列表
        /// </summary>
        public static Hashtable GetWaterImageList()
        {
            Hashtable htWaterImageList = CacheAccess.GetFromCache("htWaterImageList") as Hashtable;
            if (htWaterImageList == null)
            {
                XmlNode xmlnode = GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment/WaterImage");
                XmlNodeList xmlnodelist = xmlnode.ChildNodes;
                htWaterImageList = new Hashtable();                
                foreach (XmlNode node in xmlnodelist)
                {
                    htWaterImageList.Add(node.Name.ToString(), GetXMLDocument().GetSingleNodeValue(xmlnode, node.Name.ToString()));
                }
                CacheAccess.SaveToCache("htWaterImageList", htWaterImageList, GetGobalConfigCacheDependency());
            }
            return htWaterImageList;
        }

        /// <summary>
        /// 获取单个值
        /// </summary>
        /// <param name="nodename">节点名称</param>
        public static string GetAttachmentStr(string nodeName)
        {
            XmlNode xmlnode = GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment");
            return GetXMLDocument().GetSingleNodeValue(xmlnode, nodeName);
        }

        /// <summary>
        /// 获取附件配置列表
        /// </summary>
        public static Hashtable GetAttachmentList()
        {            
            Hashtable htAttachmentList = CacheAccess.GetFromCache("htAttachmentList") as Hashtable;
            if (htAttachmentList == null)
            {
                XmlNode xmlnode = GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment");

                string fileName = GetXMLDocument().GetSingleNodeValue(xmlnode, "Path") + "\\"
                + DateTime.Now.ToString(GetXMLDocument().GetSingleNodeValue(xmlnode, "Directory") == "" ? "yyyyMM" : GetXMLDocument().GetSingleNodeValue(xmlnode, "Directory"));

                if (!FileAccessHelper.DirectoryExists(fileName))
                {
                    Directory.CreateDirectory(fileName);
                }

                htAttachmentList = new Hashtable();
                htAttachmentList.Add("Path", fileName);
                htAttachmentList.Add("Directory", GetXMLDocument().GetSingleNodeValue(xmlnode, "Directory"));
                htAttachmentList.Add("ImageFormat", GetXMLDocument().GetSingleNodeValue(xmlnode, "ImageFormat"));
                htAttachmentList.Add("VideoFormat", GetXMLDocument().GetSingleNodeValue(xmlnode, "VideoFormat"));
                htAttachmentList.Add("AudioFormat", GetXMLDocument().GetSingleNodeValue(xmlnode, "AudioFormat"));
                htAttachmentList.Add("FlashFormat", GetXMLDocument().GetSingleNodeValue(xmlnode, "FlashFormat"));
                htAttachmentList.Add("AttachmentFormat", GetXMLDocument().GetSingleNodeValue(xmlnode, "AttachmentFormat"));
                htAttachmentList.Add("HasWaterMark", GetXMLDocument().GetSingleNodeValue(xmlnode, "HasWaterMark"));
                htAttachmentList.Add("HasAbbrImage", GetXMLDocument().GetSingleNodeValue(xmlnode, "HasAbbrImage"));
                htAttachmentList.Add("HasAbbrImageWaterMark", GetXMLDocument().GetSingleNodeValue(xmlnode, "HasAbbrImageWaterMark"));
                htAttachmentList.Add("AbbrImageWidth", GetXMLDocument().GetSingleNodeValue(xmlnode, "AbbrImageWidth"));
                htAttachmentList.Add("AbbrImageHeight", GetXMLDocument().GetSingleNodeValue(xmlnode, "AbbrImageHeight"));
                
                CacheAccess.SaveToCache("htAttachmentList", htAttachmentList, GetGobalConfigCacheDependency());
            }           
            return htAttachmentList;
        }

        #endregion 附件
    }
}
