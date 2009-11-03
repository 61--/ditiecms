using System;
using System.Configuration;
using System.Reflection;
using System.Web;
using System.Web.Caching;
using DTCMS.Common;

namespace DTCMS.DALFactory
{
    /// <summary>
    /// ����ע���ṩ�ߣ�ʹ�÷������
    /// </summary>
    public sealed class DependencyProvider
    {
        /// <summary>
        /// ȡ�����ݷ��ʲ����
        /// ���ȼ�黺�����Ƿ���ڣ��粻�������÷������
        /// </summary>
        /// <param name="className">���ݷ���������</param>
        /// <returns>���ݷ��ʶ���</returns>
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
