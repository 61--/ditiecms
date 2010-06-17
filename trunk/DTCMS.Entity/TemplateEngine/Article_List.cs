//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-06-17 21:24:44
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity.TemplateEngine
{
    /// <summary>
    /// 文章列表实体类
    /// </summary>
    public class Article_List : IArchive
    {
        private int totalRecord;
        private int currentPage;
        private int totalPage;
        private String pageItem;

        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        public int CurrentPage
        {
            get { return currentPage; }
            set { currentPage = value; }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage
        {
            get { return totalPage; }
            set { totalPage = value; }
        }

        /// <summary>
        /// 分页标签
        /// </summary>
        public String PageItem
        {
            get { return pageItem; }
            set { pageItem = value; }
        }
    }
}
