using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    public class Columns : List<HeaderItem>
    {
        //private HeaderItemCollection _headerItem;

        //[PersistenceMode(PersistenceMode.InnerProperty)]
        //public HeaderItemCollection HeaderItem
        //{
        //    get
        //    {
        //        if (_headerItem == null)
        //        {
        //            _headerItem = new HeaderItemCollection();
        //        }
        //        return _headerItem;
        //    }
        //}

        public Columns() : base(){ }

        public new int Count
        {
            get { return base.Count; }
        }

        public new void Add(HeaderItem item)
        {
            base.Add(item);
        }

        public new void Clear()
        {
            base.Clear();
        }

        public new HeaderItem this[int index]
        {
            get { return base[index]; }
            set { base[index] = value; }
        }
    }
}
