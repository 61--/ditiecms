//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-07-20 23:20:19
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;

namespace DTCMS.Entity.TemplateEngine
{
    /// <summary>
    /// 文档详细页数据实体类
    /// </summary>
    public class ArchiveField
    {
        private string _position;
        private string _prior = "这已经是第一篇了";
        private string _next = "这已经是最后一篇了";

        /// <summary>
        /// 当前位置
        /// </summary>
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        /// 上一篇
        /// </summary>
        public string Prior
        {
            get { return _prior; }
            set { _prior = value; }
        }

        /// <summary>
        /// 下一篇
        /// </summary>
        public string Next
        {
            get { return _next; }
            set { _next = value; }
        }
    }
}
