//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-07-13 21:42:17
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;

namespace DTCMS.Entity.TemplateEngine
{
    /// <summary>
    /// 栏目分页数据实体类
    /// </summary>
    public class PageListField
    {
        private int _totalRecord;
        private int _currentPage;
        private int _totalPage;
        private string _pageIndex;
        private string _position;

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
        public string PageIndex
        {
            get { return _pageIndex; }
            set { _pageIndex = value; }
        }

        /// <summary>
        /// 当前位置
        /// </summary>
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
