//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-10-29 19:54:28
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
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
        private readonly string path = Utils.GetRootPath() + ConfigPath.GOBAL;
        private readonly CacheDependency GobalConfigCacheDependency = new CacheDependency(Utils.GetRootPath() + "config\\sys\\gobal.config");
        private static GobalConfig configGobal = null;

        public static GobalConfig GetCobalInstance()
        {
            if (configGobal == null)
            {
                configGobal = new GobalConfig();
            }
            return configGobal;
        }

        /// <summary>
        ///序列化Gobal配置文件
        /// </summary>
        public void SaveGobalConfig(SystemConfig sysConfig)
        {
            SerializerXML.Save(sysConfig, path);
        }

        /// <summary>
        /// 反序列化Gobal配置文件
        /// </summary>
        /// <returns></returns>
        public SystemConfig LoadGoableConfig()
        {
            SystemConfig sysConfig = (SystemConfig)CacheAccess.GetFromCache("GoableConfig");
            if (sysConfig == null)
            {
                sysConfig= (SystemConfig)SerializerXML.Load(typeof(SystemConfig), path);
                CacheAccess.SaveToCache("GoableConfig", sysConfig, GobalConfigCacheDependency);
            }
            return sysConfig;
        }
    }
}
