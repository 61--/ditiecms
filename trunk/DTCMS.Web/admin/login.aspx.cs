using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;

namespace DTCMS.Web.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Message message = new Message();
            Message.Show("提示信息", "消息内容", "-1", MessageIcon.Error, 0);
        }
    }
}
