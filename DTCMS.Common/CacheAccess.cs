using System;
using System.Web;
using System.Web.Caching;

namespace DTCMS.Common
{
    /// <summary>
    /// 公共类，用于缓存对象操作
    /// </summary>
    public sealed class CacheAccess
    {

        /// <summary>
        /// 将对象加入到缓存中
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        /// <param name="cacheObject">缓存对象</param>
        public static void SaveToCache(string cacheKey, object cacheObject)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, cacheObject);
        }

        /// <summary>
        /// 将对象加入到缓存中
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        /// <param name="cacheObject">缓存对象</param>
        /// <param name="cacheDependency">缓存依赖项</param>
        public static void SaveToCache(string cacheKey, object cacheObject, CacheDependency cacheDependency)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, cacheObject, cacheDependency);
        }

        /// <summary>
        /// 从缓存中取出对象，如不存在返回NULL
        /// </summary>
        /// <param name="cacheKey">缓存键</param>
        /// <returns>取出缓存对象</returns>
        public static object GetFromCache(string cacheKey)
        {
            Cache cache = HttpRuntime.Cache;
            return cache[cacheKey];
        }
    }
}
