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
    public class Article_List : Archive
    {
        private string _editor;
        private string _source;

        private int _totalRecord;
        private int _currentPage;
        private int _totalPage;
        private string _pageBar;

        /// <summary>
        /// 责任编辑
        /// </summary>
        public string Editor
        {
            get { return _editor; }
            set { _editor = value; }
        }

        /// <summary>
        /// 文章来源
        /// </summary>
        public string Source
        {
            get { return _source; }
            set { _source = value; }
        }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalRecord
        {
            get { return _totalRecord; }
            set { _totalRecord = value; }
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        public int CurrentPage
        {
            get { return _currentPage; }
            set { _currentPage = value; }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public int TotalPage
        {
            get { return _totalPage; }
            set { _totalPage = value; }
        }

        /// <summary>
        /// 分页标签
        /// </summary>
        public string PageItem
        {
            get { return _pageBar; }
            set { _pageBar = value; }
        }
    }
}
