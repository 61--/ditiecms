using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using DTCMS.Entity;
using DTCMS.BLL;
using DTCMS.TemplateEngine;

namespace DTCMS.Web.admin.createstatic
{
    public partial class createarchive : System.Web.UI.Page
    {
        private Arc_ArticleBLL articleBll = new Arc_ArticleBLL();
        private Arc_ClassBLL classBll = new Arc_ClassBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string output = "";

            
        }
    }
}
