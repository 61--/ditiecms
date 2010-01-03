using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Config;
using DTCMS.Common;
using System.Web.Caching;

namespace DTCMS.BLL
{
    public class SectionConfigBLL
    {
        /// <summary>
        /// 获取缓存依赖
        /// </summary>
        private CacheDependency GetSectionConfigCacheDependency()
        {
            return new CacheDependency(Utils.GetRootPath() + "config\\sys\\SectionConfig.config");
        }

        /// <summary>
        /// 获取栏目类型
        /// </summary>
        public DataTable GetSectionListClassType()
        {
            return Get("class_type");
        }

        /// <summary>
        /// 获取阅读权限
        /// </summary>
        public DataTable GetSectionListReadaccess()
        {
            return Get("class_readaccess");
        }

        /// <summary>
        /// 审核机制
        /// </summary>
        public DataTable GetSectionListCheckLevel()
        {
            return Get("class_checklevel");
        }

        /// <summary>
        /// 文章类型
       /// </summary>
       /// <returns></returns>
        public DataTable GetSectionListTitleFlag()
        {
            return Get("news_titleflag");
        }

        /// <summary>
        /// 文字类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetSectionListTitleFontType()
        {
            return Get("font_type");
        }

        /// <summary>
        /// 附件类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetSectionListAttachmentType()
        {
            return Get("attachment_type");
        }

        private DataTable Get(string key)
        {
            DataTable dtKey = CacheAccess.GetFromCache(key) as DataTable;
            if (dtKey == null)
            {
                dtKey = SectionConfig.GetSectionList(key);
                CacheAccess.SaveToCache(key, dtKey, GetSectionConfigCacheDependency());
            }
            return dtKey;
        }
    }
}
