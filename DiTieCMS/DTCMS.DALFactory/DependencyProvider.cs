//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-10-29 11:52:34
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
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
