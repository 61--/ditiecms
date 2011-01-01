using System;
using Tuan.Common;

namespace Tuan.Web
{
    public partial class error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int error = Utils.GetQueryInt("error");
            switch (error)
            {
                case -1000:
                    Message.Dialog("您未登录或登录超时，请返回登录页面登录后再访问！", "/login.aspx?url=" + Utils.UrlEncode(Utils.GetQueryString("url")), MessageIcon.Stop);
                    break;
                default:
                    Message.Dialog("对不起，系统遇到未处理的异常，请稍候访问！", "/index.aspx", MessageIcon.Error);
                    break;
            }
        }
    }
}
