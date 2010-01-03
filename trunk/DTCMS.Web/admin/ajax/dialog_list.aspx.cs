using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.BLL;

namespace DTCMS.Web.admin.ajax
{
    public partial class dialog_list : System.Web.UI.Page
    {
        DialogConfigBLL bllDialogConfig = new DialogConfigBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action").Trim();
            switch (action)
            {                
                case "tagpage":
                    Response.Write(GetTag());
                    break;
                case "authorpage":
                    Response.Write(GetArticleAuthor());
                    break;
                case "sourcepage":
                    Response.Write(GetArticleSource());
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 获取Tag列表页，前台显示
        /// </summary>
        private string GetTag()
        {
            return Get(bllDialogConfig.GetTag());
        }

        /// <summary>
        /// 获取作者列表页，前台显示
        /// </summary>
        private string GetArticleAuthor()
        {
            return Get(bllDialogConfig.GetArticleAuthor());
        }

        /// <summary>
        /// 获取文章来源列表页，前台显示
        /// </summary>
        private string GetArticleSource()
        {
            return Get(bllDialogConfig.GetArticleSource());
        }

        private string Get(string key)
        {
            if (key != "" && key != null)
            {
                string[] keyList = key.Split(',');
                StringBuilder sb = new StringBuilder();
                int count = 1;
                sb.Append("<ul>");
                foreach (string ikey in keyList)
                {
                    string chk_id = "chk_" + count.ToString();
                    sb.Append("<li>");
                    sb.Append("<input type=\"checkbox\" name=\"item\" id=\"" + chk_id + "\" value=\"" + ikey + "\" />");
                    sb.Append("<label for=\"" + chk_id + "\">" + ikey + "</label>");
                    sb.Append("</li>");
                    count++;
                }
                sb.Append("</ul>");
                return sb.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
