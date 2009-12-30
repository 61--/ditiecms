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
        private static CacheDependency GetSectionConfigCacheDependency()
        {
            return new CacheDependency(Utils.GetRootPath() + "config\\sys\\SectionConfig.config");
        }

        /// <summary>
        /// 获取栏目类型
        /// </summary>
        public static DataTable GetSectionListClassType()
        {
            DataTable dtClassType = CacheAccess.GetFromCache("class_type") as DataTable;
            if (dtClassType == null)
            {
                dtClassType= SectionConfig.GetSectionList("class_type");
                CacheAccess.SaveToCache("class_type", dtClassType, GetSectionConfigCacheDependency());
            }
            return dtClassType;
        }

        /// <summary>
        /// 获取阅读权限
        /// </summary>
        public static DataTable GetSectionListReadaccess()
        {
            DataTable dtReadaccess = CacheAccess.GetFromCache("class_readaccess") as DataTable;
            if (dtReadaccess == null)
            {
                dtReadaccess = SectionConfig.GetSectionList("class_readaccess");
                CacheAccess.SaveToCache("class_readaccess", dtReadaccess, GetSectionConfigCacheDependency());
            }
            return dtReadaccess;
        }

        /// <summary>
        /// 审核机制
        /// </summary>
        public static DataTable GetSectionListCheckLevel()
        {
            DataTable dtCheckLevel = CacheAccess.GetFromCache("class_checklevel") as DataTable;
            if (dtCheckLevel == null)
            {
                dtCheckLevel= SectionConfig.GetSectionList("class_checklevel");
                CacheAccess.SaveToCache("class_checklevel", dtCheckLevel, GetSectionConfigCacheDependency());
            }
            return dtCheckLevel;
        }

        /// <summary>
        /// 文章类型
       /// </summary>
       /// <returns></returns>
        public static DataTable GetSectionListTitleFlag()
        {
            DataTable dtflag = CacheAccess.GetFromCache("news_titleflag") as DataTable;
            if (dtflag == null)
            {
                dtflag= SectionConfig.GetSectionList("news_titleflag");
                CacheAccess.SaveToCache("news_titleflag", dtflag, GetSectionConfigCacheDependency());
            }
            return dtflag;
        }

        /// <summary>
        /// 文字类型
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSectionListTitleFontType()
        {
            DataTable dtFontType = CacheAccess.GetFromCache("font_type") as DataTable;
            if (dtFontType == null)
            {
                dtFontType = SectionConfig.GetSectionList("font_type");
                CacheAccess.SaveToCache("font_type", dtFontType, GetSectionConfigCacheDependency());
            }
            return dtFontType;
        }

        /// <summary>
        /// 附件类型
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSectionListAttachmentType()
        {
            DataTable dtAttachment=CacheAccess.GetFromCache("attachment_type") as DataTable;
            if (dtAttachment == null)
            {
                dtAttachment = SectionConfig.GetSectionList("attachment_type");
                CacheAccess.SaveToCache("attachment_type",dtAttachment,GetSectionConfigCacheDependency());
            }
            return dtAttachment;
        }
    }
}
