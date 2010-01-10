using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using DTCMS.BLL;
using DTCMS.Common;

namespace DTCMS.Web.admin.ajax
{
    public partial class Template_list : AdminPage
    {
        Sys_TemplateBLL bllTemp = new Sys_TemplateBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action");
            switch (action)
            {
                case "load":
                    Response.Write(GetTemplateList());
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 获取风格列表数据
        /// </summary>
        /// <returns></returns>
        protected string GetTemplateList()
        {
           StringBuilder sb = new StringBuilder();
           DataTable dt = new DataTable();  //bllTemp.GetList();
           if (dt != null && dt.Rows.Count > 0)
           {
               int checkID = 1;
               sb.Append("<div id=\"content\">\r\n");
               sb.Append("<ul>\r\n");
               foreach (DataRow row in dt.Rows)
               {
                   string chk_Id = "chk_" + checkID;
                   sb.Append("<li>\r\n");
                   sb.Append("<dl>\r\n");
                   sb.Append("<dt>\r\n");
                   sb.Append("<table>\r\n");
                   sb.Append("<tr>\r\n");
                   sb.Append("<td>\r\n");
                   sb.Append("<a onclick=\"selectImage('" + chk_Id + "')\" href=\"javascript:void(0);\">\r\n");
                   sb.Append(string.Format("<img src=\"{0}\" width=\"110\" height=\"120\" border=\"0\" />",row["TemplateImg"].ToString()));//需修改
                   sb.Append("</td>\r\n");
                   sb.Append("<td>\r\n");
                   sb.Append(string.Format("默认<input type=\"radio\" onclick=\"UpdateEnable({0})\" name=\"rad_default\"><br/>\r\n",row["TemplateId"].ToString()));
                   sb.Append(string.Format("卸载<a href=\"DeleteTemp({0})\">卸载</a><br/>\r\n",row["TemplateId"].ToString()));
                   sb.Append(string.Format("<a href=\"EditTemp({0},'{1}')\">编辑</a><br/>\r\n",row["TemplateId"].ToString(),row["TemplateDirectory"].ToString()));
                   sb.Append(string.Format("<a href=\"ManageTemp({0})\">管理</a><br/>\r\n",row["TemplateId"].ToString()));
                   sb.Append("</td>\r\n");
                   sb.Append("</tr>\r\n");
                   sb.Append("</table>");
                   sb.Append("</a>\r\n");
                   sb.Append("</dt>\r\n");
                   sb.Append("<dd>\r\n");
                   sb.Append(row["TemplateName"].ToString());
                   sb.Append("</dd>\r\n");
                   sb.Append("</dl>\r\n");
                   sb.Append("</li>\r\n");

                   checkID++;
               }
               sb.Append("</ul>\r\n");
               sb.Append("</div>\r\n");
              
           }
           return sb.ToString();
        }
        
    }
}
