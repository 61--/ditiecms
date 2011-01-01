//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-03-01 17:47:34
// 功能描述: DataGrid Control
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Web.UI;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Drawing.Design;

namespace Tuan.Controls
{
    /// <summary>
    /// ColumnCollection 成员集合
    /// </summary>
    [ToolboxItem(false)]
    [ParseChildren(true)]
    [Editor(typeof(ColumnCollectionEditor), typeof(UITypeEditor))]
    public class ColumnCollection : Collection<ItemBase>
    {
        public ColumnCollection() : base() { }

        public new int Count
        {
            get { return base.Count; }
        }

        public new void Add(ItemBase item)
        {
            base.Add(item);
        }

        public new void Remove(ItemBase item)
        {
            base.Remove(item);
        }

        public new void Clear()
        {
            base.Clear();
        }

        public new ItemBase this[int index]
        {
            get { return base[index]; }
            set { base[index] = value; }
        }
    }
}
