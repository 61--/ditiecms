using System;
using System.Configuration;
using System.Reflection;
using System.Web;
using System.Web.Caching;
using DTCMS.Common;

namespace DTCMS.DALFactory
{
    /// <summary>
    /// 依赖注入提供者，使用反射机制
    /// </summary>
    public sealed class DependencyProvider
    {
        /// <summary>
        /// 取得数据访问层对象
        /// 首先检查缓存中是否存在，如不存在则用反射加载
        /// </summary>
        /// <param name="className">数据访问类名称</param>
        /// <returns>数据访问对象</returns>
        public static object GetDALObject(string className)
        {
            object dalObject = CacheAccess.GetFromCache(className);
            if (null == dalObject)
            {
                string dalName = ConfigurationManager.AppSettings["DAL"];
                string fullClassName = dalName + "." + className;
                CacheDependency fileDependency = new CacheDependency(HttpContext.Current.Server.MapPath("Web.Config"));
                dalObject = Assembly.Load(dalName).CreateInstance(fullClassName);
                CacheAccess.SaveToCache(className, dalObject, fileDependency);
            }
            return dalObject;
        }
    }
}
