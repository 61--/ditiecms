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
            long execTime = 0;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            AjaxPro.Utility.RegisterTypeForAjax(typeof(AjaxTest));

            sw.Stop();
            execTime = sw.ElapsedMilliseconds;

            DTCMS.Common.JScript.ShowMessage(this, string.Format("用时{0}毫秒", execTime.ToString()));
        }

        [AjaxPro.AjaxMethod]
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
