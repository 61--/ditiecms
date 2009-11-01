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
            Message.Show("用户密码错误！", "-1", MessageIcon.Warning);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //dtTxtValidate.ValidateData();
        }
    }
}
