using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.BLL;
using System.Data;

namespace DTCMS.Web.admin.ajax
{
    public partial class news_list : System.Web.UI.Page
    {
        private Arc_ArticleBLL bllArticle = new Arc_ArticleBLL();   //文章

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action");
            switch (action)
            {
                case "load":
                    Response.Write(CreateArticleTable());
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// 创建文章表格
        /// </summary>
        public string CreateArticleTable()
        {
            int pagesum = 1;
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("Title","标题");
            DataTable dt = bllArticle.GetData("Title", 10, 10, 0, null, "ID", "id desc", 1,ref pagesum);
            sb.Append(DTTable.CreateTable(dt, table));
            return sb.ToString();
        }
    }
}
