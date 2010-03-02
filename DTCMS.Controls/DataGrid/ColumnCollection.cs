using System;
using System.Web.UI;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Drawing.Design;

namespace DTCMS.Controls
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
