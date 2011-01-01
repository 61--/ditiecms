//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-03-01 17:47:25
// 功能描述: DataGrid Control
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.ComponentModel.Design;

namespace Tuan.Controls
{
    /// <summary>
    /// 集合属性编辑器
    /// </summary>
    public class ColumnCollectionEditor : CollectionEditor
    {
        public ColumnCollectionEditor(Type type)
            : base(type) { }

        protected override bool CanSelectMultipleInstances()
        {
            return true;
        }

        protected override Type[] CreateNewItemTypes()
        {
            return new Type[] { typeof(CheckBox), typeof(RowNumber), typeof(ColumnItem) };
        }

        protected override object CreateInstance(Type itemType)
        {
            if (itemType == typeof(CheckBox))
            {
                return new CheckBox();
            }
            if (itemType == typeof(RowNumber))
            {
                return new RowNumber();
            }
            if (itemType == typeof(ColumnItem))
            {
                return new ColumnItem();
            }
            return null;
        }

    }
}
