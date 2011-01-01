//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-03-01 17:46:35
// 功能描述: DataGrid Control
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan.Controls
{
    /// <summary>
    /// Item 抽象类
    /// </summary>
    public abstract class ItemBase
    {
        private string _width;

        public string Width
        {
            get { return _width; }
            set { _width = value; }
        }
    }
}
