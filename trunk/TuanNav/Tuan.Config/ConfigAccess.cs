using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Caching;
using System.Text;
using Tuan.Entity.Config;
using Tuan.Common;
using Tuan.Common.XML;

namespace Tuan.Config
{
    public sealed class ConfigAccess<T> where T : IConfigInfo, new()
    {
        private static T _instance;
        private static object lockHelper = new object();

        public static T GetConfig()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    Type type = typeof(T);
                    _instance = (T)SerializerXML.Load(type, GetPath(type.Name));
                    return _instance;
                }
            }
            return _instance;
        }

        public static void SaveConfig(IConfigInfo configInfo)
        {
            SerializerXML.Save((T)configInfo, GetPath(typeof(T).Name));
        }

        /// <summary>
        /// 获取配置文件位置
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        private static string GetPath(string configName)
        {
            string path = Utils.GetRootPath();
            switch (configName)
            {
                case "AppConfigInfo":
                    return path + ConfigPath.CFG_APP;
                case "UrlRewriteInfo":
                    return path + ConfigPath.CFG_URLREWRITE;
                default:
                    return "";
            }
        }
    }
}
