using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using DTCMS.BLL;
using DTCMS.Common;
namespace DTCMS.Web.admin.ajax
{
    public partial class Template_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action");
            switch (action)
            { 
                case "load":
                    Response.Write(GetTemplateJson());
                    break;

            }
        }
        protected void GetTemplateJson()
        { 
            
        }
    }
}
