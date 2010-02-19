using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DTCMS.BLL;
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public partial class user_list : AdminPage
    {
        private UsersBLL userBll = new UsersBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            AjaxPro.Utility.RegisterTypeForAjax(typeof(user_list));
        }

        #region Ajax方法
        /// <summary>
        /// 获取用户Json数据
        /// </summary>
        [AjaxPro.AjaxMethod]
        public string GetUserJsonData(int currentPage)
        {
            return userBll.GetUserJsonData(currentPage);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <returns>返回影响记录数</returns>
        [AjaxPro.AjaxMethod]
        public int DeleteUsers(string id)
        {
            try
            {
                if (id == "")
                {
                    return -1;
                }
                return userBll.Delete(id);
            }
            catch
            {
                return -2;
            }
        }

        /// <summary>
        /// 审核用户
        /// </summary>
        /// <returns>返回影响记录数</returns>
        [AjaxPro.AjaxMethod]
        public int VerifyUsers(string id)
        {
            try
            {
                if (id == "")
                {
                    return -1;
                }
                return userBll.VerifyUsers(id);
            }
            catch
            {
                return -2;
            }
        }
        #endregion
    }
}
