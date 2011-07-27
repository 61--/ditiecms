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
                    try
                    {
                        _instance = new T();
                        _instance = (T)XmlSerializerUtils.Load(typeof(T), _instance.GetPATH());
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
            XmlSerializerUtils.Save((T)configInfo, configInfo.GetPATH());
        }
    }
}
