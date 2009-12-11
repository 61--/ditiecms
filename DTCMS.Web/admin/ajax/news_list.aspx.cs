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
            int pagesum = 1;    //总页数
            StringBuilder sb = new StringBuilder();
            //列宽 
            string widthList = "8%,8%,30%,25%,22%,17%"; 

            //画Table
            Dictionary<string, string> table = new Dictionary<string, string>();
            table.Add("ID","ID");
            table.Add("Title","标题");
            table.Add("ClassID","栏目");
            table.Add("IsChecked","审核");

            //绑定数据
            DataTable dt = bllArticle.GetData("ID,Title,ClassID,IsChecked", 10, 10, 0, null, "ID", "id desc", 1, out pagesum);
            
            string lastTDTitle = "操作";
            string lastTDValue = "<a onclick=\"alert('{0}')\">修改</a>";
            sb.Append(DTTable.CreateTable(dt, table, widthList, lastTDTitle, lastTDValue, new string[] { "ID" }));
            return sb.ToString();
        }
    }
}
