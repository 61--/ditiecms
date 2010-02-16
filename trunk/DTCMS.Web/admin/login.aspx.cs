using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;
using DTCMS.BLL;
using DTCMS.Entity;

namespace DTCMS.Web.admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_username.Value.Length == 0)
            {
                Message.Dialog("提示信息", "用户名不能为空！", "-1", MessageIcon.Stop, 0);
            }
            else if (txt_password.Value.Length == 0)
            {
                Message.Dialog("提示信息", "用户密码不能为空！", "-1", MessageIcon.Stop, 0);
            }
            else if (txt_checkcode.Value.Length == 0)
            {
                Message.Dialog("提示信息", "验证码不能为空！", "-1", MessageIcon.Stop, 0);
            }
            else
            {
                if (txt_checkcode.Value.Trim() != Session["ValidateCodekey"].ToString())
                {
                    Message.Dialog("提示信息", "验证码填写错误！", "-1", MessageIcon.Stop, 0);
                }
                else
                {
                    UsersBLL userBll = new UsersBLL();
                    Users userInfo = userBll.CheckLogin(txt_username.Value.Trim(), txt_password.Value.Trim(), true);

                    if (userInfo == null)
                    {
                        Message.Dialog("提示信息", "用户名或密码不正确！", "-1", MessageIcon.Stop, 0);
                    }
                    else
                    {
                        if (userInfo.IsLock == 1)
                        {
                            Message.Dialog("提示信息", "对不起，您的帐号被锁定，暂时不能登陆系统后台，请联系网站管理员！", "-1", MessageIcon.Stop, 0);
                        }
                        else if (userInfo.IsVerify == 0)
                        {
                            Message.Dialog("提示信息", "对不起，您的帐号还未通过审核，暂时不能登陆系统后台，请联系网站管理员！", "-1", MessageIcon.Stop, 0);
                        }
                        else
                        {
                            Session["AdminUser"] = userInfo;
                            //更新用户登陆信息
                            userBll.UpdateLoginInfo(userInfo.UID, Request.UserHostAddress);
                            Message.Dialog("提示信息", "登陆成功，正在转向管理后台！", "index.aspx", MessageIcon.Success, 2);
                        }
                    }
                }
            }
        }
    }
}
