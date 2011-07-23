using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Utils;

namespace Config
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
                    try
                    {
                        _instance = (T)XmlSerializerUtils.Load(type, GetPath(type.Name));
                    }
                    catch
                    {
                        SaveConfig(new T());
                    }
                    return _instance;
                }
            }
            return _instance;
        }

        public static void SaveConfig(IConfigInfo configInfo)
        {
            XmlSerializerUtils.Save((T)configInfo, GetPath(typeof(T).Name));
        }

        /// <summary>
        /// 获取配置文件位置
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        private static string GetPath(string configName)
        {
            switch (configName)
            {
                case "AppConfigInfo":
                    return "app.config";
                
                default:
                    return "";
            }
        }
    }
}
