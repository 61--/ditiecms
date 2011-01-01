using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tuan.Common;
using Tuan.Entity;
using Tuan.Data.DAO;

namespace Tuan.Web
{
    public partial class login : Tuan.Web.UI.BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            LoginUser loginUser = UserDAO.Instance.UserLogin(txt_UserName.Text, txt_Pwd.Text, Request.UserHostAddress);

            if (loginUser == null)
            {
                JScript.ShowMessage(this, "用户名或密码错误！");
            }
            else
            {
                if (loginUser.IsLock == 1)
                {
                    JScript.ShowMessage(this, "对不起，您的帐号被锁定，暂时不能登陆系统后台，请联系网站管理员！");
                }
                else if (loginUser.IsVerify == 0)
                {
                    JScript.ShowMessage(this, "对不起，您的帐号还未通过审核，暂时不能登陆系统后台，请联系网站管理员！");
                }
                else
                {
                    Session["LoginUser"] = loginUser;

                    string returnUrl = Utils.GetQueryString("url");
                    if (returnUrl == "")
                        returnUrl = "/admin/index.aspx";

                    JScript.ShowAndRedirect(this, "登陆成功，正在转向管理后台！", returnUrl);
                }
            }
        }
    }
}
