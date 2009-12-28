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
            string name = Common.Utils.GetQueryString("name").Trim();
            string email = Common.Utils.GetQueryString("email").Trim();
            string url = Common.Utils.GetQueryString("url").Trim();

            switch (action)
            {
                case "tag":
                    Response.Write(TagManage(method,name));
                    break;
                case "tagpage":
                    Response.Write(GetTagListPage());
                    break;
                case "author":
                    Response.Write(AuthorManage(method, name, email));
                    break;
                case "authorpage":
                    Response.Write(GetAuthorListPage());
                    break;
                case "newssource":
                    Response.Write(NewsSourceManage(method,name,url));
                    break;
                default:
                    break;
            }
        }

        #region 关键字TAG
        private string TagManage(string method,string tagName)
        {            
            switch (method)
            {
                case "add":
                    return AddTag(tagName);
                case "delete":
                    return DeleteTag(tagName).ToString();
                case "list":
                    return GetTagList();
                default :
                    return "";
            }
        }
        /// <summary>
        /// 添加Tag标签
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        private string AddTag(string tagName)
        {
            if (tagName == string.Empty)
            {
                return "TAG名称 不能为空!";
            }
            try
            {
                Config.BaseSettingConfig.AddTag(tagName);
                return "添加【" + tagName + "】成功!";
            }
            catch
            {
                return "添加【" + tagName + "】失败!";
            }
        }

        /// <summary>
        /// 删除Tag标签
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        private string DeleteTag(string tagName)
        {
            if (tagName == string.Empty)
            {
                return "请选择要删除数据!";
            }
            try
            {
                Config.BaseSettingConfig.DeleteTag(tagName);
                return "删除【" + tagName + "】成功!";
            }
            catch
            {
                return "删除【" + tagName + "】失败!";
            }
        }

        /// <summary>
        /// 获取Tag列表
        /// </summary>
        /// <returns></returns>
        private string GetTagList()
        {
            List<string> tagList = Config.BaseSettingConfig.GetTagList();
            StringBuilder sb = new StringBuilder();
            int idnum = 1;
            sb.Append("<table class=\"table_data\">");
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th>ID</th>");
            sb.Append("<th>Tag名称</th>");
            sb.Append("<th>操作</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<tbody id=\"tab\">");
            foreach (string tag in tagList)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + idnum + "</td>");
                sb.Append("<td>"+tag+"</td>");
                sb.Append("<td><a href=\"javascript:void(0);\" onclick=\"del_tag('" + tag + "')\">删除</a><td>");
                sb.Append("</tr>");
                idnum++;
            }
            sb.Append("</tbody>");
            sb.Append("</table>");

            return sb.ToString();
        }

        /// <summary>
        /// 获取Tag列表页，前台显示
        /// </summary>
        /// <returns></returns>
        private string GetTagListPage()
        {
            List<string> tagList = Config.BaseSettingConfig.GetTagList();
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
        private string AuthorManage(string method, string authorName,string email)
        {
            switch (method)
            {
                case "add":
                    return AddAuthor(authorName, email);
                case "edit":
                    return UpdateAuthor(authorName, email);
                case "delete":
                    return DeleteAuthor(authorName);
                case "list":
                    return GetAutorList();
                default:
                    return "";
            }
        }

        /// <summary>
        /// 添加作者
        /// </summary>
        private string AddAuthor(string authorName,string email)
        {
            if (authorName == string.Empty)
            {
                return "作者名称 不能为空!";
            }
            try
            {
                Config.BaseSettingConfig.AddAuthor(authorName,email);
                return "添加【" + authorName + "】成功!";
            }
            catch
            {
                return "添加【" + authorName + "】失败!";
            }
        }

        /// <summary>
        /// 修改作者
        /// </summary>
        /// <param name="tagName"></param>
        private string UpdateAuthor(string authorName, string email)
        {
            if (authorName == string.Empty)
            {
                return "请选择要修改数据!";
            }
            try
            {
                Config.BaseSettingConfig.UpdateAuthor(authorName,email);
                return "修改【" + authorName + "】成功!";
            }
            catch
            {
                return "修改【" + authorName + "】失败!";
            }
        }

        /// <summary>
        /// 删除作者
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        private string DeleteAuthor(string authorName)
        {
            if (authorName == string.Empty)
            {
                return "请选择要删除数据!";
            }
            try
            {
                Config.BaseSettingConfig.DeleteAuthor(authorName);
                return "删除【" + authorName + "】成功!";
            }
            catch
            {
                return "删除【" + authorName + "】失败!";
            }
        }

        /// <summary>
        /// 获取作者列表
        /// </summary>
        /// <returns></returns>
        private string GetAutorList()
        {
            Dictionary<string,string> authorList = Config.BaseSettingConfig.GetAuthorList();
            StringBuilder sb = new StringBuilder();
            int idnum = 1;
            sb.Append("<table class=\"table_data\">");
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th>ID</th>");
            sb.Append("<th>作者</th>");
            sb.Append("<th>Email</th>");
            sb.Append("<th>操作</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<tbody id=\"tab\">");
            foreach (KeyValuePair<string, string> author in authorList)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + idnum + "</td>");
                sb.Append("<td>" + author.Key.ToString().Trim() + "</td>");
                sb.Append("<td>" + author.Value.ToString().Trim() + "</td>");
                sb.Append("<td><a href=\"javascript:void(0);\" onclick=\"del_author('" + author.Key.ToString().Trim() + "')\">删除</a><td>");
                sb.Append("</tr>");
                idnum++;
            }
            sb.Append("</tbody>");
            sb.Append("</table>");

            return sb.ToString();
        }

        /// <summary>
        /// 获取作者列表，前台显示
        /// </summary>
        /// <returns></returns>
        private string GetAuthorListPage()
        {
            Dictionary<string, string> authorList = Config.BaseSettingConfig.GetAuthorList();
            StringBuilder sb = new StringBuilder();
            int count = 1;
            sb.Append("<ul>");
            foreach (KeyValuePair<string,string> author in authorList)
            {
                string chk_id = "chk_" + count.ToString();
                sb.Append("<li>");
                sb.Append("<input type=\"checkbox\" name=\"item\" id=\"" + chk_id + "\" value=\"" + author.Key.ToString() + "\" />");
                sb.Append("<label for=\"" + chk_id + "\">" + author.Key.ToString() + "</label>");
                sb.Append("</li>");
                count++;
            }
            sb.Append("</ul>");

            return sb.ToString();
        }

        #endregion 作者

        #region 文章来源
        private string NewsSourceManage(string method, string newssourceName, string url)
        {
            switch (method)
            {
                case "add":
                    return AddNewsSource(newssourceName, url);
                case "edit":
                    return UpdateNewsSource(newssourceName, url);
                case "delete":
                    return DeleteNewsSource(newssourceName);
                case "list":
                    return GetNewsSourceList();
                default:
                    return "";
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        private string AddNewsSource(string newssourceName, string url)
        {
            if (newssourceName == string.Empty)
            {
                return "文章来源标题 不能为空!";
            }
            try
            {
                Config.BaseSettingConfig.AddNewsSource(newssourceName,url);
                return "添加【" + newssourceName + "】成功!";
            }
            catch
            {
                return "添加【" + newssourceName + "】失败!";
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="tagName"></param>
        private string UpdateNewsSource(string newssourceName, string url)
        {
            if (newssourceName == string.Empty)
            {
                return "请选择要修改数据!";
            }
            try
            {
                Config.BaseSettingConfig.UpdateNewsSource(newssourceName, url);
                return "修改【" + newssourceName + "】成功!";
            }
            catch
            {
                return "修改【" + newssourceName + "】失败!";
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        private string DeleteNewsSource(string newssourceName)
        {
            if (newssourceName == string.Empty)
            {
                return "请选择要删除数据!";
            }
            try
            {
                Config.BaseSettingConfig.DeleteNewsSource(newssourceName);
                return "删除【" + newssourceName + "】成功!";
            }
            catch
            {
                return "删除【" + newssourceName + "】失败!";
            }
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        private string GetNewsSourceList()
        {
            Dictionary<string, string> newssourceList = Config.BaseSettingConfig.GetNewsSourceList();
            StringBuilder sb = new StringBuilder();
            int idnum = 1;
            sb.Append("<table class=\"table_data\">");
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th>ID</th>");
            sb.Append("<th>标题</th>");
            sb.Append("<th>Url</th>");
            sb.Append("<th>操作</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<tbody id=\"tab\">");
            foreach (KeyValuePair<string, string> newssource in newssourceList)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + idnum + "</td>");
                sb.Append("<td>" + newssource.Key.ToString().Trim() + "</td>");
                sb.Append("<td>" + newssource.Value.ToString().Trim() + "</td>");
                sb.Append("<td><a href=\"javascript:void(0);\" onclick=\"del_newssource('" + newssource.Key.ToString().Trim() + "')\">删除</a><td>");
                sb.Append("</tr>");
                idnum++;
            }
            sb.Append("</tbody>");
            sb.Append("</table>");

            return sb.ToString();
        }

        /// <summary>
        /// 获取列表，前台显示
        /// </summary>
        /// <returns></returns>
        private string GetNewsSourceListPage()
        {
            Dictionary<string, string> newssourceList = Config.BaseSettingConfig.GetNewsSourceList();
            StringBuilder sb = new StringBuilder();
            int count = 1;
            sb.Append("<ul>");
            foreach (KeyValuePair<string, string> newssource in newssourceList)
            {
                string chk_id = "chk_" + count.ToString();
                sb.Append("<li>");
                sb.Append("<input type=\"checkbox\" name=\"item\" id=\"" + chk_id + "\" value=\"" + newssource.Key.ToString() + "\" />");
                sb.Append("<label for=\"" + chk_id + "\">" + newssource.Key.ToString() + "</label>");
                sb.Append("</li>");
                count++;
            }
            sb.Append("</ul>");

            return sb.ToString();
        }
        #endregion 文章来源
    }
}
