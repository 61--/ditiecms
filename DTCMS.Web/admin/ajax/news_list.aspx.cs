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
    public partial class news_list : AdminPage
    {
        private Arc_ArticleBLL articleBll = new Arc_ArticleBLL();   //文章

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Utils.GetQueryString("action").Trim();

            switch (action)
            {
                case "load":
                    Response.Write(GetArticleJsonData());
                    break;
                case "delete":
                    Response.Write(DeleteNews());
                    break;
                default:
                    Response.Write("");
                    break;
            }
        }

        /// <summary>
        /// 获取文章Json数据
        /// </summary>
        public string GetArticleJsonData()
        {
            int currentPage = Utils.GetQueryInt("page");
            return articleBll.GetArticleJsonData(currentPage);
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <returns></returns>
        public int DeleteNews()
        {
            try
            {
                string id = Common.Utils.GetQueryString("Id");
                if (id == "")
                {
                    return -1;
                }
                return articleBll.Delete(id);
            }
            catch
            {
                return -2;
            }
        }
    }
}
