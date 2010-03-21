using System;
using System.ComponentModel.Design;

namespace DTCMS.Controls
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
