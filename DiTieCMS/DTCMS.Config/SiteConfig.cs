//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-08-04 23:15:59
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Web.Caching;
using DTCMS.Common;
using DTCMS.Common.Xml;
using DTCMS.Entity.Config;

namespace DTCMS.Config
{
    public class SiteConfig
    {
        private readonly string path = Utils.GetRootPath() + ConfigPath.CFG_CMS;
        private static SiteConfig siteConfig = null;

        public static SiteConfig GetInstance()
        {
            if (siteConfig == null)
            {
                siteConfig = new SiteConfig();
            }
            return siteConfig;
        }

        /// <summary>
        ///序列化Site配置文件
        /// </summary>
        public void SaveConfig(SiteConfigInfo siteConfigInfo)
        {
            SerializerXML.Save(siteConfigInfo, path);
        }

        /// <summary>
        /// 反序列化Site配置文件
        /// </summary>
        /// <returns></returns>
        public SiteConfigInfo LoadConfig()
        {
            SiteConfigInfo siteConfigInfo = (SiteConfigInfo)CacheAccess.GetFromCache("SITECONFIG");
            if (siteConfigInfo == null)
            {
                siteConfigInfo = (SiteConfigInfo)SerializerXML.Load(typeof(SiteConfigInfo), path);
                CacheDependency cmsConfigDependency = new CacheDependency(path);
                CacheAccess.SaveToCache("SITECONFIG", siteConfigInfo, cmsConfigDependency);
            }
            return siteConfigInfo;
        }
    }
}
