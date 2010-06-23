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
    }
}
