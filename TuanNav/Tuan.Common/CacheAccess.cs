using System;
using System.Web;
using System.Web.Caching;
using System.Collections.Generic;
using System.Collections;

namespace Tuan.Common
{
    public sealed class CacheAccess
    {
        /// <summary>
        /// 将对象加入到缓存中
        /// </summary>
        public static void Set(string key, object value)
        {
            Set(key, value, 0, CacheExpiresType.Sliding, null, CacheItemPriority.NotRemovable);
        }

        public static void Set(string key, object value, int cacheTime)
        {
            Set(key, value, cacheTime, CacheExpiresType.Sliding, null, CacheItemPriority.NotRemovable);
        }

        public static void Set(string key, object value, CacheItemPriority cacheItemPriority)
        {
            Set(key, value, 0, CacheExpiresType.Sliding, null, cacheItemPriority);
        }

        public static void Set(string key, object value, int cacheTime, CacheExpiresType cacheExpiresType)
        {
            Set(key, value, cacheTime, cacheExpiresType, null, CacheItemPriority.NotRemovable);
        }

        public static void Set(string key, object value, int cacheTime, CacheExpiresType cacheExpiresType, CacheDependency dependencies)
        {
            Set(key, value, cacheTime, cacheExpiresType, dependencies, CacheItemPriority.NotRemovable);
        }

        public static void Set(string key, object value, int cacheTime, CacheExpiresType cacheExpiresType, CacheDependency dependencies, CacheItemPriority cacheItemPriority)
        {
            DateTime absoluteExpiration;
            if (cacheTime == 0 || cacheExpiresType == CacheExpiresType.Sliding)
                absoluteExpiration = Cache.NoAbsoluteExpiration;
            else
                absoluteExpiration = DateTime.Now.AddMinutes(cacheTime);

            TimeSpan slidingExpiration;
            if (cacheTime == 0 || cacheExpiresType == CacheExpiresType.Absolute)
                slidingExpiration = Cache.NoSlidingExpiration;
            else
                slidingExpiration = TimeSpan.FromMinutes(cacheTime);

            HttpRuntime.Cache.Insert(key, value, dependencies, absoluteExpiration, slidingExpiration, cacheItemPriority, null);
        }

        /// <summary>
        /// 从缓存中取出对象，如不存在返回NULL
        /// </summary>
        /// <param name="key">缓存键</param>
        /// <returns>取出缓存对象</returns>
        public static object Get(string key)
        {
            return HttpRuntime.Cache[key];
        }

        /// <summary>
        /// 从缓存中取出对象，如不存在返回NULL
        /// </summary>
        /// <param name="key">缓存键</param>
        /// <returns>取出缓存对象</returns>
        public static T Get<T>(string key)
        {
            object obj = Get(key);
            if (obj == null)
                return default(T);
            else
                return (T)obj;
        }

        /// <summary>
        /// 清除系统中所有缓存
        /// </summary>
        public static void Clear()
        {
            List<string> keys = new List<string>();

            foreach (DictionaryEntry elem in HttpRuntime.Cache)
            {
                keys.Add(elem.Key.ToString());
            }

            foreach (string key in keys)
            {
                try
                {
                    HttpRuntime.Cache.Remove(key);
                }
                catch { }
            }
        }

        /// <summary>
        /// 移除指定的缓存
        /// </summary>
        /// <param name="key">缓存的key</param>
        public static void Remove(string key)
        {
            try
            {
                HttpRuntime.Cache.Remove(key);
            }
            catch { }
        }
    }

    /// <summary>
    /// 缓存的过期时间
    /// </summary>
    public enum CacheExpiresType
    {
        /// <summary>
        /// 绝对时间
        /// </summary>
        Absolute,

        /// <summary>
        /// 相对时间
        /// </summary>
        Sliding
    }
}
