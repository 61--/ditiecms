using System;
using System.Collections.Generic;
using System.Web;
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public class AdminPage : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            //检查是否登陆
            //ValidateUser();

            base.OnInit(e);
        }

        #region 后台登陆验证
        /// <summary>
        /// 后台登陆验证
        /// </summary>
        public void ValidateUser()
        {
            if (HttpContext.Current.Session["AdminUser"] == null)
            {
                JScript.ShowAndRedirects(this, "非法操作,请重新登录！", "/admin/login.aspx");
            }
        }
        #endregion

        /// <summary>
        /// 重写系统异常类
        /// </summary>
        protected override void OnError(EventArgs e)
        {
            Exception ex = Server.GetLastError().GetBaseException();
            if (ex != null)
            {
                string msg = string.Format("错误信息：{0}<br />调用堆栈：{1}<br />请求地址：{2}", ex.Message, ex.StackTrace.Length > 200 ? ex.StackTrace.Substring(0, 200) : ex.StackTrace, HttpContext.Current.Request.Url);
                Message.Dialog("系统运行时遇到未处理错误！", msg, "-1", MessageIcon.Error, 0);

                Server.ClearError();
            }
            base.OnError(e);
        }
    }
}
