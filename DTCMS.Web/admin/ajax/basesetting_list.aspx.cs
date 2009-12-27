using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.Config;

namespace DTCMS.Web.admin.ajax
{
    public partial class basesetting_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action").Trim().ToLower();
            string method = Common.Utils.GetQueryString("method").Trim().ToLower();
            string name = Common.Utils.GetQueryString("name").Trim().ToLower();
            switch (action)
            {
                case "tag":
                    Response.Write(TagManage(method,name));
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
                return "添加成功!";
            }
            catch
            {
                return "添加失败!";
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
                return "删除成功!";
            }
            catch
            {
                return "删除失败!";
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
        #endregion
    }
}
