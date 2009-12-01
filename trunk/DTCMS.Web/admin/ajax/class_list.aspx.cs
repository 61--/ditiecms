using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
using DTCMS.Common;
using DTCMS.BLL;
namespace DTCMS.Web.admin.ajax
{
    public partial class class_list : System.Web.UI.Page
    {
        protected Arc_ClassBLL bllClass = new Arc_ClassBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //string action =Common.Utils.GetQueryString("action");
            //switch (action)
            //{ 
            //    case "load":
            Response.Write(GetClassListJson());
            //        break;

            //}
            

        }
        public string GetClassListJson()
        {
            return bllClass.GetDataTableJoson();
        }
    }

}