//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-08-05 20:48:23
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Caching;
using DTCMS.Common;
using DTCMS.Common.Xml;
using DTCMS.Entity.Config;

namespace DTCMS.Config
{
    /// <summary>
    /// 配置文件访问简单工厂
    /// </summary>
    public class ConfigAccess
    {
        /// <summary>
        /// 获取配置文件信息工厂
        /// </summary>
        /// <param name="configName">配置文件类名</param>
        /// <returns>数据访问类对象</returns>
        public static T LoadConfig<T>(string configName) where T : IConfigInfo
        {
            string path = GetPath(configName);
            object configObj = CacheAccess.GetFromCache(configName);
            if (configObj == null)
            {
                configObj = SerializerXML.Load(typeof(T), path);
                CacheDependency configDependency = new CacheDependency(path);
                CacheAccess.SaveToCache(configName, configObj, configDependency);
            }
            return (T)configObj;
        }

        /// <summary>
        ///序列化配置文件
        /// </summary>
        public static void SaveConfig<T>(IConfigInfo configInfo, string configName) where T : IConfigInfo
        {
            SerializerXML.Save((T)configInfo, GetPath(configName));
        }

        /// <summary>
        /// 获取配置文件位置
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetPath(string configName)
        {
            string path = Utils.GetRootPath();
            switch (configName)
            {
                case "CFG_CMS":
                    return path + ConfigPath.CFG_CMS;
                case "CFG_SITE":
                    return path + ConfigPath.CFG_SITE;
                default:
                    return "";
            }
        }
    }
}
