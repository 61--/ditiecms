using System;
using System.Collections.Generic;
using System.Reflection;
using Tuan.Entity.Config;
using Tuan.Config;

namespace Tuan.Data.Provider
{
    public class DbProviderFactory
    {
        private static IDataProvider _instance;
        private static object lockHelper = new object();

        public static IDataProvider Create()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    try
                    {
                        string dbType = ConfigAccess<AppConfigInfo>.GetConfig().DbType;
                        _instance = (IDataProvider)Activator.CreateInstance(Type.GetType(string.Format("Tuan.Data.{0}.DataProvider, Tuan.Data.{0}", dbType), true, true));
                    }
                    catch
                    {
                        throw new Exception("请检查App.config中Dbtype节点数据库类型是否正确，例如：SqlServer、Access、MySql");
                    }
                }
            }
            return _instance;
        }
    }
}
