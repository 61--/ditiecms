//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-10-29 19:54:28
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
    public class CMSConfig
    {
        private readonly string path = Utils.GetRootPath() + ConfigPath.CFG_CMS;
        private static CMSConfig cmsConfig = null;

        public static CMSConfig GetInstance()
        {
            if (cmsConfig == null)
            {
                cmsConfig = new CMSConfig();
            }
            return cmsConfig;
        }

        /// <summary>
        ///序列化CMS配置文件
        /// </summary>
        public void SaveConfig(CMSConfigInfo cmsConfigInfo)
        {
            SerializerXML.Save(cmsConfigInfo, path);
        }

        /// <summary>
        /// 反序列化CMS配置文件
        /// </summary>
        /// <returns></returns>
        public CMSConfigInfo LoadConfig()
        {
            CMSConfigInfo cmsConfigInfo = (CMSConfigInfo)CacheAccess.GetFromCache("CMSCONFIG");
            if (cmsConfigInfo == null)
            {
                cmsConfigInfo = (CMSConfigInfo)SerializerXML.Load(typeof(CMSConfigInfo), path);
                CacheDependency cmsConfigDependency = new CacheDependency(path);
                CacheAccess.SaveToCache("CMSCONFIG", cmsConfigInfo, cmsConfigDependency);
            }
            return cmsConfigInfo;
        }
    }
}
