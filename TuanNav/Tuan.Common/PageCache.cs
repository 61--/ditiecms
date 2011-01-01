using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;


namespace Tuan.Common
{
    public class PageCache
    {
        public static bool CanUsePageCache
        {
            get
            {
                return HttpContext.Current != null;
            }
        }

        public static object Get(string key)
        {
            if (HttpContext.Current == null || !HttpContext.Current.Items.Contains(key))
                return null;
            else
                return HttpContext.Current.Items[key];
        }

        public static T Get<T>(string key)
        {
            if (HttpContext.Current == null || !HttpContext.Current.Items.Contains(key))
                return default(T);
            else
                return (T)HttpContext.Current.Items[key];
        }

        public static bool Contains(string key)
        {
            if (HttpContext.Current == null)
                return false;

            return (HttpContext.Current.Items.Contains(key));
        }

        public static void Set(string key, object value)
        {
            if (HttpContext.Current == null)
                return;

            HttpContext.Current.Items[key] = value;
        }

        public static void Remove(string key)
        {
            if (HttpContext.Current == null)
                return;

            HttpContext.Current.Items.Remove(key);
        }
    }
}
