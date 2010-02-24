using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Controls
{
    public class Columns
    {
        private HeaderItemCollection _headerItem;

        [PersistenceMode(PersistenceMode.InnerProperty)]
        public HeaderItemCollection HeaderItem
        {
            get
            {
                if (_headerItem == null)
                {
                    _headerItem = new HeaderItemCollection();
                }
                return _headerItem;
            }
        }
    }
}
