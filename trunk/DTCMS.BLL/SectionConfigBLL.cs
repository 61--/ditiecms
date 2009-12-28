using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Config;
using System.Data;

namespace DTCMS.BLL
{
    public class SectionConfigBLL
    {
        /// <summary>
        /// 获取栏目类型
        /// </summary>
        public static DataTable GetSectionListClassType()
        {
            return SectionConfig.GetSectionList("class_type");
        }

        /// <summary>
        /// 获取阅读权限
        /// </summary>
        public static DataTable GetSectionListReadaccess()
        {
            return SectionConfig.GetSectionList("class_readaccess");
        }

        /// <summary>
        /// 审核机制
        /// </summary>
        public static DataTable GetSectionListCheckLevel()
        {
            return SectionConfig.GetSectionList("class_checklevel");
        }

        /// <summary>
        /// 文章类型
       /// </summary>
       /// <returns></returns>
        public static DataTable GetSectionListTitleFlag()
        {
            return SectionConfig.GetSectionList("news_titleflag");
        }
    }
}
