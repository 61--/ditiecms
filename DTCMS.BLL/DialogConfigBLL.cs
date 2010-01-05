using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Config;
using DTCMS.Common;
using System.Web.Caching;

namespace DTCMS.BLL
{
    public class DialogConfigBLL
    {
        DialogConfig configDialog = new DialogConfig();
        /// <summary>
        /// 获取缓存依赖
        /// </summary>
        private CacheDependency GetDialogConfigCacheDependency()
        {
            return new CacheDependency(Utils.GetRootPath() + "config\\sys\\DialogConfig.config");
        }

        #region 公有方法
        /// <summary>
        ///关键字(Tag)
        /// </summary>
        public string GetTag()
        {
            return Get("tag");
        }
        /// <summary>
        ///关键字(Tag)
        /// </summary>
        public void SetTag(string value)
        {
            Set("tag", value);
        }

        /// <summary>
        ///文章来源
        /// </summary>
        public string GetArticleSource()
        {
            return Get("articleSource");
        }
        /// <summary>
        ///文章来源
        /// </summary>
        public void SetArticleSource(string value)
        {
            Set("articleSource", value);
        }

        /// <summary>
        ///文章作者
        /// </summary>
        public string GetArticleAuthor()
        {
            return Get("articleAuthor");
        }
        /// <summary>
        ///文章作者
        /// </summary>
        public void SetArticleAuthor(string value)
        {
            Set("articleAuthor", value);
        }
        #endregion 公有方法

        #region  私有方法
        private string Get(string key)
        {
            string iKey = CacheAccess.GetFromCache(key) as string;
            if (iKey == "" || iKey == null)
            {
                iKey = configDialog.GetDialogSingle(key);
                CacheAccess.SaveToCache(key, iKey, GetDialogConfigCacheDependency());          
            }
            return iKey;
        }

        private void Set(string key,string value)
        {
            configDialog.SetDialogSingle(key, value);
        }

        #endregion  私有方法

    }
}
