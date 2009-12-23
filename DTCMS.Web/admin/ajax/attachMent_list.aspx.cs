using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class attachment_list : System.Web.UI.Page
    {
        Atr_AttachMentBLL bllAttachment = new Atr_AttachMentBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action");
            int page = Common.Utils.GetQueryInt("page");
            if (page == 0)
            {
                page = 1;
            }
            switch (action)
            {
                case "image":
                    Response.Write(HtmlImageList(page,""));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="page">第几页</param>
        /// <param name="attachMentDisplayName">附件名称</param>
        /// <returns></returns>
        private string HtmlImageList(int pageCurrent, string attachMentDisplayName)
        {
            int totalcount=0;    //总页数
            string where = string.Empty;    //查询条件
            StringBuilder sb = new StringBuilder();
            if (attachMentDisplayName != string.Empty)
            {
                where = string.Format("AttachMentAttribute=1 and AttachMentDisplayName like '%{0}%'", attachMentDisplayName);
            }
            else
            {
                where = string.Format("AttachMentAttribute=1");
            }
            DataTable dtImageList = bllAttachment.GetAttachmentList(pageCurrent, 10, where, out totalcount);
            if (dtImageList != null && dtImageList.Rows.Count > 0)
            {
                int checkID = 1;
                sb.Append("<div id=\"content\">");
                sb.Append("<ul>");
                foreach (DataRow dr in dtImageList.Rows)
                {
                    string chk_Id = "chk_" + checkID;
                    string displayName = dr["AttachMentDisplayName"].ToString().Split('.')[0];
                    sb.Append("<li>");
                    sb.Append("<dl>");
                    sb.Append("<dt>");
                    sb.Append("<a onclick=\"selectImage('" + chk_Id + "')\" href=\"javascript:void(0);\">");
                    if (dr["AbbrPhotoPath"].ToString() != string.Empty)
                    {
                        sb.Append("<img src=\"" + dr["AbbrPhotoPath"].ToString() + "\" alt=\"" + displayName + "\" />");
                    }
                    else
                    {
                        sb.Append("<img src=\"" + dr["AttachMentPath"].ToString() + "\" alt=\"" + displayName + "\" />");
                    }
                    sb.Append("</a>");
                    sb.Append("</dt>");
                    sb.Append("<dd>");
                    if (dr["AbbrPhotoPath"].ToString() != string.Empty)
                    {
                        sb.Append("<input type=\"checkbox\" id=\"" + chk_Id + "\" name=\"items\" value=\"" + dr["AbbrPhotoPath"].ToString() + "\" />");
                    }
                    else
                    {
                        sb.Append("<input type=\"checkbox\" id=\"" + chk_Id + "\" name=\"items\" value=\"" + dr["AttachMentPath"].ToString() + "\" />");
                    }
                    sb.Append("<label title=\"" + displayName + "\" for=\"" + chk_Id + "\">" + (displayName.Length > 10 ? displayName.Substring(0, 10) : displayName) + "</label>");
                    sb.Append("</dd>");
                    sb.Append("</dl>");
                    sb.Append("</li>");

                    checkID++;
                }
                sb.Append("</ul>");
                sb.Append("</div>");
                int pagecount = DTCMS.Pages.PageSeting.GetPageCount(totalcount, 10);
                sb.Append("<div style=\"position:absolute;right:0;bottom:-6px;z-index:-1 \">");
                sb.Append("<div class=\"grayr\" style=\"height:30px;line-height:30px;\">");
                sb.Append(DTCMS.Pages.PageSeting.GetAjaxPage(pageCurrent, pagecount, "LoadData", 10));
                sb.Append("</div>");
                sb.Append("</div>");
            }
            return sb.ToString();
        }
    }
}
