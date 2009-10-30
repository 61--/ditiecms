using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;

namespace DTCMS.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.ShowMessage("测试", "测试方法");
            }
            catch
            {
                MessageBox.ShowMessage("测试", "测试方法2");
            }
        }
    }
}
