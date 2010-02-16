using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DTCMS.Web.admin
{
    public partial class AjaxTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(AjaxTest));
        }

        [AjaxPro.AjaxMethod]
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
