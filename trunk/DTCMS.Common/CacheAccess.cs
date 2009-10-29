using System;
using System.Web;
using System.Web.Caching;

namespace DTCMS.Common
{
    /// <summary>
    /// �����࣬���ڻ���������
    /// </summary>
    public sealed class CacheAccess
    {

        /// <summary>
        /// ��������뵽������
        /// </summary>
        /// <param name="cacheKey">�����</param>
        /// <param name="cacheObject">�������</param>
        public static void SaveToCache(string cacheKey, object cacheObject)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, cacheObject);
        }

        /// <summary>
        /// ��������뵽������
        /// </summary>
        /// <param name="cacheKey">�����</param>
        /// <param name="cacheObject">�������</param>
        /// <param name="cacheDependency">����������</param>
        public static void SaveToCache(string cacheKey, object cacheObject, CacheDependency cacheDependency)
        {
            Cache cache = HttpRuntime.Cache;
            cache.Insert(cacheKey, cacheObject, cacheDependency);
        }

        /// <summary>
        /// �ӻ�����ȡ�������粻���ڷ���NULL
        /// </summary>
        /// <param name="cacheKey">�����</param>
        /// <returns>ȡ���������</returns>
        public static object GetFromCache(string cacheKey)
        {
            Cache cache = HttpRuntime.Cache;
            return cache[cacheKey];
        }
    }
}
