using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.Config;

namespace DTCMS.Web.admin.ajax
{
    public partial class basesetting_list : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action").Trim();
            string method = Common.Utils.GetQueryString("method").Trim();
            string title = Common.Utils.GetQueryString("title").Trim();

            switch (action)
            {
                case "tag":
                    Response.Write(TagManage(method, title));
                    break;
                case "tagpage":
                    Response.Write(GetTagListPage());
                    break;
                case "author":
                    Response.Write(AuthorManage(method, title));
                    break;
                case "authorpage":
                    Response.Write(GetAuthorListPage());
                    break;
                case "newssource":
                    Response.Write(NewsSourceManage(method, title));
                    break;
                case "newssourcepage":
                    Response.Write(GetNewsSourceListPage());
                    break;
                default:
                    break;
            }
        }

        #region 关键字TAG
        private string TagManage(string method,string tagtitle)
        {            
            switch (method)
            {
                case "save":
                    return SetTagList(tagtitle);
                case "list":
                    return GetTagList();
                default :
                    return "";
            }
        }

        /// <summary>
        /// 保存关键字
        /// </summary>       
        public string SetTagList(string tagtitle)
        {
            try
            {
                Config.BaseSettingConfig.SetTagTitle(tagtitle);
                return "保存关键字 成功!";
            }
            catch
            {
                return "保存关键字 失败!";
            }
        }

        /// <summary>
        /// 获取Tag列表
        /// </summary>
        /// <returns></returns>
        private string GetTagList()
        {
            return Config.BaseSettingConfig.GetTagTitle();
        }

        /// <summary>
        /// 获取Tag列表页，前台显示
        /// </summary>
        /// <returns></returns>
        private string GetTagListPage()
        {
            string[] tagList = GetTagList().Split(',');
            StringBuilder sb = new StringBuilder();
            int count = 1;
            sb.Append("<ul>");
            foreach (string tag in tagList)
            {
                string chk_id = "chk_" + count.ToString();
                sb.Append("<li>");
                sb.Append("<input type=\"checkbox\" name=\"item\" id=\"" + chk_id + "\" value=\"" + tag + "\" />");
                sb.Append("<label for=\"" + chk_id + "\">" + tag + "</label>");
                sb.Append("</li>");
                count++;
            }
            sb.Append("</ul>");
            return sb.ToString();
        }
        #endregion

        #region  作者
        private string AuthorManage(string method, string authorTitle)
        {
            switch (method)
            {
                case "save":
                    return SetAuthorList(authorTitle);
                case "list":
                    return GetAutorList();
                default:
                    return "";
            }
        }

        /// <summary>
        /// 添加作者
        /// </summary>
        public string SetAuthorList(string authortitle)
        {
            try
            {
                Config.BaseSettingConfig.SetAuthorTitle(authortitle);

                return "保存作者信息 成功!";
            }
            catch
            {
                return "保存作者信息 失败!";
            }
        }

        /// <summary>
        /// 获取作者列表
        /// </summary>
        /// <returns></returns>
        private string GetAutorList()
        {
            return Config.BaseSettingConfig.GetAuthorTitle();            
        }

        /// <summary>
        /// 获取作者列表，前台显示
        /// </summary>
        /// <returns></returns>
        private string GetAuthorListPage()
        {
            string[] authorList = GetAutorList().Split(',');
            StringBuilder sb = new StringBuilder();
            int count = 1;
            sb.Append("<ul>");
            foreach (string author in authorList)
            {
                string chk_id = "chk_" + count.ToString();
                sb.Append("<li>");
                sb.Append("<input type=\"checkbox\" name=\"item\" id=\"" + chk_id + "\" value=\"" + author.ToString() + "\" />");
                sb.Append("<label for=\"" + chk_id + "\">" + author.ToString() + "</label>");
                sb.Append("</li>");
                count++;
            }
            sb.Append("</ul>");

            return sb.ToString();
        }

        #endregion 作者

        #region 文章来源
        private string NewsSourceManage(string method, string newSourceTitle)
        {
            switch (method)
            {
                case "save":
                    return SetNewsSourceList(newSourceTitle);
                case "list":
                    return GetNewsSourceList();
                default:
                    return "";
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        private string SetNewsSourceList(string newSsourceTitle)
        {
            try
            {
                Config.BaseSettingConfig.SetNewsSourceTitle(newSsourceTitle);
                return "保存文章来源 成功!";
            }
            catch
            {
                return "保存文章来源 失败!";
            }
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        private string GetNewsSourceList()
        {
            return Config.BaseSettingConfig.GetNewsSourceTitle();
        }

        /// <summary>
        /// 获取列表，前台显示
        /// </summary>
        /// <returns></returns>
        private string GetNewsSourceListPage()
        {
            string[] newssourceList = GetNewsSourceList().Split(',');
            StringBuilder sb = new StringBuilder();
            int count = 1;
            sb.Append("<ul>");
            foreach (string newssource in newssourceList)
            {
                string chk_id = "chk_" + count.ToString();
                sb.Append("<li>");
                sb.Append("<input type=\"checkbox\" name=\"item\" id=\"" + chk_id + "\" value=\"" + newssource.ToString() + "\" />");
                sb.Append("<label for=\"" + chk_id + "\">" + newssource.ToString() + "</label>");
                sb.Append("</li>");
                count++;
            }
            sb.Append("</ul>");

            return sb.ToString();
        }
        #endregion 文章来源
    }
}
