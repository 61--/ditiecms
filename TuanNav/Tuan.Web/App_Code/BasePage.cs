using System;
using System.Collections.Generic;
using System.Web;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Web
{
    public class BasePage : System.Web.UI.Page
    {
        protected LoginUser loginUser = null;

        protected override void OnInit(EventArgs e)
        {
            //从Session中获取用户信息
            if (HttpContext.Current.Session["LoginUser"] != null)
            {
                loginUser = (LoginUser)HttpContext.Current.Session["LoginUser"];
            }
            else
            {
                //loginUser = Tuan.Data.DAO.UserDAO.Instance.UserLogin("lwh923", "123456", Request.UserHostAddress);
            }

            base.OnInit(e);
        }

        /// <summary>
        /// 重写系统异常类
        /// </summary>
        protected override void OnError(EventArgs e)
        {
            Exception ex = Server.GetLastError().GetBaseException();
            if (ex != null)
            {
                string msg = string.Format("错误信息：{0}", ex.Message);

                if (Utils.GetQueryString("op") != "")  //Ajax请求
                {
                    Ajax.Message(-1001, msg.Replace("\\", "\\\\").Replace("'", "\\'"));
                }
                else
                {
                    Message.Dialog("系统运行时遇到未处理错误！", msg, "-1", MessageIcon.Error, 0);
                }

                Server.ClearError();
            }
            base.OnError(e);
        }

        /// <summary>
        /// 获取用户登陆信息
        /// </summary>
        protected string GetLoginInfo()
        {
            string loginInfo = string.Empty;
            if (loginUser == null)
            {
                loginInfo = "<span class=\"n_a\">您好,欢迎来到TuanLet! 请<a href=\"/login.aspx\">[登录</a>·<a href=\"/register.aspx\">免费注册]</a></span>";
            }
            else
            {
                loginInfo = string.Format("<span class=\"n_a\">您好<a href=\"/user/center.aspx\" onmouseover=\"showPopup(this);\" onmouseout=\"hidePopup();\" class=\"username\">{0}</a>,欢迎您回来! ",
                    loginUser.UserName, loginUser.LoginCount);
                loginInfo += string.Format("<a href=\"/user/message.aspx\" class=\"message\">消息({0})</a>|<a href=\"/user/favorite.aspx\">收藏</a>|<a href=\"/user/friend.aspx\">好友</a>", loginUser.PMCount);

                if (loginUser.UsergroupID == 0 || loginUser.UsergroupID == 1)
                {
                    loginInfo += "|<a href=\"/admin/index.aspx\">系统管理</a>";
                }
                loginInfo += "|<a href=\"/user/logout.aspx\">退出</a></span>";
            }
            return loginInfo;
        }
    }
}
