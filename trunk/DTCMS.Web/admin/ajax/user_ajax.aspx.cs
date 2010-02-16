using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using DTCMS.BLL;
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public partial class user_ajax : AdminPage
    {
        private UsersBLL userBll = new UsersBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Utils.GetQueryString("action").Trim();

            switch (action)
            {
                case "load":
                    Response.Write(GetUserJsonData());
                    break;
                case "delete":
                    Response.Write(DeleteUsers());
                    break;
                case "verify":
                    Response.Write(VerifyUsers());
                    break;
                default:
                    Response.Write("");
                    break;
            }
        }

        /// <summary>
        /// 获取用户Json数据
        /// </summary>
        public string GetUserJsonData()
        {
            int currentPage = Utils.GetQueryInt("page");
            return userBll.GetUserJsonData(currentPage);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <returns>返回影响记录数</returns>
        public int DeleteUsers()
        {
            try
            {
                string id = Utils.GetQueryString("Id");
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
        public int VerifyUsers()
        {
            try
            {
                string id = Utils.GetQueryString("Id");
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
    }
}
