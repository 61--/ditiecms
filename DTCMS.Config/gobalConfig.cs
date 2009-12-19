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
        /// 从相应的节点下检索轮显数据
        /// </summary>
        /// <param name="nodename">节点名称</param>
        public static string GetWaterImageStr(string nodeName)
        {
            string path = Utils.GetRootPath() + ConfigPath.GOBAL;
            xmlDoc.Load(path);
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/SystemConfig/WaterImage");
            return xmlDoc.GetSingleNodeValue(xmlnode, nodeName);
        }
        /// <summary>
        /// 获取水印图片配置列表
        /// </summary>
        public static Hashtable GetWaterImageList()
        {
            string path = Utils.GetRootPath() + ConfigPath.GOBAL;
            xmlDoc.Load(path);
            XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/SystemConfig/WaterImage");
            Hashtable ht = new Hashtable();            
            ht.Add("WaterPic", xmlDoc.GetSingleNodeValue(xmlnode,"WaterPic"));
            ht.Add("WaterCharater", xmlDoc.GetSingleNodeValue(xmlnode, "WaterCharater"));
            ht.Add("WaterPicPath", xmlDoc.GetSingleNodeValue(xmlnode, "WaterPicPath"));
            ht.Add("XPercent", xmlDoc.GetSingleNodeValue(xmlnode, "XPercent"));
            ht.Add("YPercent", xmlDoc.GetSingleNodeValue(xmlnode, "YPercent"));
            ht.Add("CharColor", xmlDoc.GetSingleNodeValue(xmlnode, "CharColor"));
            ht.Add("Transparence", xmlDoc.GetSingleNodeValue(xmlnode, "Transparence"));
            return ht;
        }
    }
}
