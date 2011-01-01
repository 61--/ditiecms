using System;
using System.Collections.Generic;
using System.Web;
using Tuan.Common;

namespace Tuan.Web.user
{
    public class UserPage : BasePage
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            //检查是否登录
            ValidateUser();
        }

        #region 后台登陆验证
        /// <summary>
        /// 用户登陆验证
        /// </summary>
        public void ValidateUser()
        {
            if (loginUser == null)
            {
                Message.Dialog("您未登录或登录超时,请重新登录！", "/login.aspx", MessageIcon.Information);
            }
        }
        #endregion
    }
}