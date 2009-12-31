using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DTCMS.Common;
using DTCMS.Common.Xml;
using System.Xml;
using System.IO;
using System.Web.Caching;
using DTCMS.Entity;

namespace DTCMS.Config
{
    public class GobalConfig
    {
        private static string path = Utils.GetRootPath() + ConfigPath.GOBAL;
        private static CacheDependency GobalConfigCacheDependency = new CacheDependency(Utils.GetRootPath() + "config\\sys\\gobal.config");


        /// <summary>
        ///序列化Gobal配置文件
        /// </summary>
        public static void SaveGobalConfig(SystemConfig sysConfig)
        {
            SerializerXML.Save(sysConfig, path);
        }

        /// <summary>
        /// 反序列化Gobal配置文件
        /// </summary>
        /// <returns></returns>
        public static SystemConfig LoadGoableConfig()
        {
            SystemConfig sysConfig = (SystemConfig)CacheAccess.GetFromCache("GoableConfig");
            if (sysConfig == null)
            {
                sysConfig= (SystemConfig)SerializerXML.Load(typeof(SystemConfig), path);
                CacheAccess.SaveToCache("GoableConfig", sysConfig, GobalConfigCacheDependency);
            }
            return sysConfig;
        }


        /// <summary>
        /// 获取xmlDoc
        /// </summary>
        public static XmlDocumentExtender GetXMLDocument()
        {
            XmlDocumentExtender xmlDoc = CacheAccess.GetFromCache("XmlDocumentExtender") as XmlDocumentExtender;
            if (xmlDoc == null)
            {
                xmlDoc = new XmlDocumentExtender();
                xmlDoc.Load(path);
                CacheAccess.SaveToCache("XmlDocumentExtender", xmlDoc, GobalConfigCacheDependency);
            }
            return xmlDoc;
        }

        public static void SaveXMLDocument()
        {
            GetXMLDocument().Save(path);
        }

        //#region 附件

       // /// <summary>
       // /// 附件路径
       // /// </summary>
       // public static string Path
       // {
       //     get { return GetAttachmentStr("Path"); }
       //     set { SetAttachmentStr("Path", value); }
       // }
       // /// <summary>
       // /// 附件保存方式
       // /// </summary>
       // public static string Directory
       // {
       //     get { return GetAttachmentStr("Directory"); }
       //     set { SetAttachmentStr("Directory", value); }
       // }
       // /// <summary>
       // /// 图片格式
       // /// </summary>
       // public static string ImageFormat
       // {
       //     get { return GetAttachmentStr("ImageFormat"); }
       //     set { SetAttachmentStr("ImageFormat", value); }
       // }
       // /// <summary>
       // /// 视频格式
       // /// </summary>
       // public static string VideoFormat
       // {
       //     get { return GetAttachmentStr("VideoFormat"); }
       //     set { SetAttachmentStr("VideoFormat", value); }
       // }
       // /// <summary>
       // /// 音频格式
       // /// </summary>
       // public static string AudioFormat
       // {
       //     get { return GetAttachmentStr("AudioFormat"); }
       //     set { SetAttachmentStr("AudioFormat", value); }
       // }
       // /// <summary>
       // /// Flash格式
       // /// </summary>
       // public static string FlashFormat
       // {
       //     get { return GetAttachmentStr("FlashFormat"); }
       //     set { SetAttachmentStr("FlashFormat", value); }
       // }
       // /// <summary>
       // /// 其它附件格式
       // /// </summary>
       // public static string AttachmentFormat
       // {
       //     get { return GetAttachmentStr("AttachmentFormat"); }
       //     set { SetAttachmentStr("AttachmentFormat", value); }
       // }
       ///// <summary>
       ///// 原图水印
       ///// </summary>
       // public static string HasWaterMark
       // {
       //     get { return GetAttachmentStr("HasWaterMark"); }
       //     set { SetAttachmentStr("HasWaterMark", value); }
       // }
       // /// <summary>
       // /// 缩略图
       // /// </summary>
       // public static string HasAbbrImage
       // {
       //     get { return GetAttachmentStr("HasAbbrImage"); }
       //     set { SetAttachmentStr("HasAbbrImage", value); }
       // }
       // /// <summary>
       // /// 缩略图水印
       // /// </summary>
       // public static string HasAbbrImageWaterMark
       // {
       //     get { return GetAttachmentStr("HasAbbrImageWaterMark"); }
       //     set { SetAttachmentStr("HasAbbrImageWaterMark", value); }
       // }
       // /// <summary>
       // /// 缩略图宽
       // /// </summary>
       // public static string AbbrImageWidth
       // {
       //     get { return GetAttachmentStr("AbbrImageWidth"); }
       //     set { SetAttachmentStr("AbbrImageWidth", value); }
       // }
       // /// <summary>
       // /// 缩略图高
       // /// </summary>
       // public static string AbbrImageHeight
       // {
       //     get { return GetAttachmentStr("AbbrImageHeight"); }
       //     set { SetAttachmentStr("AbbrImageHeight", value); }
       // }

       // #region 水印
       // /// <summary>
       // /// 水印类型（1:t图片水印，0:文字水印）
       // /// </summary>
       // public static string WaterPic
       // {
       //     get { return GetWaterImageStr("WaterPic"); }
       //     set { SetWaterImageStr("WaterPic", value); }
       // }
       // /// <summary>
       // /// 水印文字
       // /// </summary>
       // public static string WaterCharater
       // {
       //     get { return GetWaterImageStr("WaterCharater"); }
       //     set { SetWaterImageStr("WaterCharater", value); }
       // }
       // /// <summary>
       // /// 水印图片地址
       // /// </summary>
       // public static string WaterPicPath
       // {
       //     get { return GetWaterImageStr("WaterPicPath"); }
       //     set { SetWaterImageStr("WaterPicPath", value); }
       // }
       // /// <summary>
       // /// 水印X坐标
       // /// </summary>
       // public static string XPercent
       // {
       //     get { return GetWaterImageStr("XPercent"); }
       //     set { SetWaterImageStr("XPercent", value); }
       // }
       // /// <summary>
       // /// 水印Y坐标
       // /// </summary>
       // public static string YPercent
       // {
       //     get { return GetWaterImageStr("YPercent"); }
       //     set { SetWaterImageStr("YPercent", value); }
       // }
       // /// <summary>
       // /// 文字水印颜色
       // /// </summary>
       // public static string CharColor
       // {
       //     get { return GetWaterImageStr("CharColor"); }
       //     set { SetWaterImageStr("CharColor", value); }
       // }
       // /// <summary>
       // /// 水印透明度
       // /// </summary>
       // public static string Transparence
       // {
       //     get { return GetWaterImageStr("Transparence"); }
       //     set { SetWaterImageStr("Transparence", value); }
       // }
       // /// <summary>
       // /// 水印文字类型
       // /// </summary>
       // public static string FontFamilyName
       // {
       //     get { return GetWaterImageStr("FontFamilyName"); }
       //     set { SetWaterImageStr("FontFamilyName", value); }
       // }
       // /// <summary>
       // /// 水印文字大小
       // /// </summary>
       // public static string FontSize
       // {
       //     get { return GetWaterImageStr("FontSize"); }
       //     set { SetWaterImageStr("FontSize", value); }
       // }
       // #endregion 水印

       // public static string GetAttachmentStr(string nodeName)
       // {
       //     XmlNode xmlnode=GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment");
       //     return GetXMLDocument().GetSingleNodeValue(xmlnode, nodeName);
       // }

       // public static void SetAttachmentStr(string nodeName, string nodeValue)
       // {
       //     GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment/" + nodeName).InnerText = nodeValue;
       // }

       // public static string GetWaterImageStr(string nodeName)
       // {
       //     XmlNode xmlnode= GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment/WaterImage");
       //     return GetXMLDocument().GetSingleNodeValue(xmlnode,nodeName);
       // }

       // public static void SetWaterImageStr(string nodeName, string nodeValue)
       // {
       //     GetXMLDocument().DocumentElement.SelectSingleNode("/SystemConfig/Attachment/WaterImage/" + nodeName).InnerText = nodeValue;
       // }

       // public static string Get()
       // {
       //     XmlDocumentExtender xmlDoc = new XmlDocumentExtender();            
       //     xmlDoc.Load(path);
       //     XmlNode xmlnode = xmlDoc.DocumentElement.SelectSingleNode("/SystemConfig/Attachment");
       //     return GetXMLDocument().GetSingleNodeValue(xmlnode, "ImageFormat");
       // }

       // #endregion 附件
    }
}
