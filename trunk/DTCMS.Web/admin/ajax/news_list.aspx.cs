using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.BLL;
using System.Data;

namespace DTCMS.Web.admin
{
    public partial class news_list : AdminPage
    {
        private Arc_ArticleBLL bllArticle = new Arc_ArticleBLL();   //文章

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action").Trim();

            switch (action)
            {
                case "load": Response.Write(CreateArticleTableToJoan()); break;
                case "delete":Response.Write(DeleteNews());break;
                default: Response.Write(""); break;

            }
        }

        /// <summary>
        /// 创建文章表格
        /// </summary>
        public string CreateArticleTableToJoan()
        {
            return bllArticle.CreateArticleTableToJoan();
        }

        /// <summary>
        /// 删除文章
        /// </summary>
        /// <returns></returns>
        public string DeleteNews()
        {
            try
            {
                string id = Common.Utils.GetQueryString("Id");
                if (id == "")
                {
                    return "请选择你要删除的文章！";
                }
                
                if (bllArticle.Delete(id) > 0)
                {
                    return "True";
                }
                else
                {
                    return "文章删除失败！";
                }
            }
            catch
            {
                return "删除文章出现未知错误！";
            }
        }
    }
}
