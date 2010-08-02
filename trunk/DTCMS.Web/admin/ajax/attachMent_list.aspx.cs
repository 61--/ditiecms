using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using System.Text;
using DTCMS.BLL;
using DTCMS.Config;
using DTCMS.Entity;
using DTCMS.Common;

namespace DTCMS.Web.admin
{
    public partial class attachment_list : AdminPage
    {
        AttachMentBLL bllAttachment = new AttachMentBLL();
        SectionConfigBLL bllSelectionConfig = new SectionConfigBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = Common.Utils.GetQueryString("action").Trim();
            int type = Common.Utils.GetQueryInt("type");
            string name = Common.Utils.GetQueryString("name").Trim();
            int page = Common.Utils.GetQueryInt("page");

            if (page == 0)
            {
                page = 1;
            }

            switch (action)
            {
                case "upload": Response.Write(AttachmentListToJson());break;
                case "search":
                    switch (type)
                    {
                        case 1:
                            Response.Write(ImageListToHtml(page, name));
                            break;
                        default: 
                            Response.Write(AttachmentListToHtml(page, type, name));
                            break;
                    } break;
                default: Response.Write(""); break;
            }
        }

        /// <summary>
        /// 获取图片列表
        /// </summary>
        /// <param name="page">第几页</param>
        /// <param name="attachMentDisplayName">附件名称</param>
        /// <returns></returns>
        private string ImageListToHtml(int pageCurrent, string attachMentDisplayName)
        {
            int totalcount=0;
            int page = 10;
            string where = string.Empty;
            StringBuilder sb = new StringBuilder();

            if (attachMentDisplayName != string.Empty)
            {
                where = string.Format("Attribute=1 and DisplayName like '%{0}%'", attachMentDisplayName);
            }
            else
            {
                where = "Attribute=1";
            }

            DataTable dtImageList = bllAttachment.GetAttachmentList(pageCurrent, page, where, out totalcount);
            if (dtImageList != null && dtImageList.Rows.Count > 0)
            {
                int checkID = 1;
                sb.Append("<div id=\"content\">");
                sb.Append("<ul>");
                foreach (DataRow dr in dtImageList.Rows)
                {
                    string chk_Id = "chk_" + checkID;
                    string displayName = dr["DisplayName"].ToString().Split('.')[0];
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
                        sb.Append("&nbsp;<input type=\"checkbox\" id=\"" + chk_Id + "\" name=\"items\" value=\"" + dr["AbbrPhotoPath"].ToString() + "\" />");
                    }
                    else
                    {
                        sb.Append("&nbsp;<input type=\"checkbox\" id=\"" + chk_Id + "\" name=\"items\" value=\"" + dr["AttachMentPath"].ToString() + "\" />");
                    }
                    sb.Append("<label title=\"" + displayName + "\" for=\"" + chk_Id + "\">" + (displayName.Length > 9 ? displayName.Substring(0, 9) : displayName) + "</label>");
                    sb.Append("</dd>");
                    sb.Append("</dl>");
                    sb.Append("</li>");

                    checkID++;
                }
                sb.Append("</ul>");
                sb.Append("</div>");

                int pagecount = PageSeting.GetPageCount(totalcount, page);
                sb.Append("<div style=\"position:absolute;right:0;bottom:-3px;z-index:-1 \">");
                sb.Append("<div class=\"grayr\" style=\"height:30px;line-height:30px;\">");
                sb.Append(PageSeting.GetAjaxPage(pageCurrent, pagecount, "LoadData", page));
                sb.Append("</div>");
                sb.Append("</div>");
            }
            return sb.ToString();
        }

        private string AttachmentListToHtml(int pageCurrent,int attachMentType,string attachMentDisplayName)
        {
            int idnum = 1;
            int totalcount = 0;
            int page = 10;
            string where = string.Empty;
            StringBuilder sb = new StringBuilder();

            if (attachMentDisplayName != string.Empty)
            {
                where = string.Format("Attribute={0} and DisplayName like '%{1}%'",attachMentType,attachMentDisplayName);
            }
            else
            {
                where = string.Format("Attribute={0}",attachMentType);
            }

            DataTable dtAttachMentList = bllAttachment.GetAttachmentList(pageCurrent, page, where, out totalcount);
            if (dtAttachMentList != null && dtAttachMentList.Rows.Count > 0)
            {
                sb.Append("<div id=\"content\">");
                sb.Append("<table class=\"table_data\">");
                sb.Append("<thead>");
                sb.Append("<tr>");
                sb.Append("<th>ID</th>");
                sb.Append("<th>选择</th>");
                sb.Append("<th>标题</th>");
                sb.Append("<th>大小</th>");
                sb.Append("<th>发布者</th>");
                sb.Append("<th>发布时间</th>");
                sb.Append("</tr>");
                sb.Append("</thead>");
                sb.Append("<tbody id=\"tab\">");
                foreach (DataRow dr in dtAttachMentList.Rows)
                {
                    string chk_id = "chk_" + idnum.ToString();
                    sb.Append("<tr onclick='selectImage(\"" + chk_id + "\")'>");
                    sb.Append("<td>" + idnum + "</td>");
                    sb.Append("<td><input type=\"checkbox\" id=\"" + chk_id + "\" value=\"" + dr["AttachMentPath"] + "\" name=\"items\" onclick='selectImage(\"" + chk_id + "\")' /> </td>");
                    sb.Append("<td>" + dr["DisplayName"].ToString() + "</td>");
                    sb.Append("<td>" + dr["AttachMentSize"].ToString() + "</td>");
                    sb.Append("<td>" + dr["PubLisher"] + "</td>");
                    sb.Append("<td>" + dr["AddDate"].ToString() + "</td>");
                    sb.Append("</tr>");
                    idnum++;
                }
                sb.Append("</tbody>");
                sb.Append("</table>");
                sb.Append("</div>");

                int pagecount = PageSeting.GetPageCount(totalcount, page);
                sb.Append("<div style=\"position:absolute;right:0px;bottom:-3px;z-index:-1; \">");
                sb.Append("<div class=\"grayr\" style=\"height:30px;line-height:30px;\">");
                sb.Append(PageSeting.GetAjaxPage(pageCurrent, pagecount, "LoadData", page));
                sb.Append("</div>");
                sb.Append("</div>");
            }            
            return sb.ToString();
        }

        private string AttachmentListToJson()
        {
            StringBuilder sbJson = new StringBuilder();
            SystemConfig sysConfig = CMSConfig.GetCobalInstance().LoadGoableConfig();

            sbJson.Append("{");
            sbJson.Append("'HasWaterMark':'" + sysConfig.Attachments.HasWaterMark + "'");
            sbJson.Append(",");
            sbJson.Append("'HasAbbrImage':'" + sysConfig.Attachments.HasAbbrImage + "'");
            sbJson.Append(",");
            sbJson.Append("'HasHasAbbrImageWaterMarkWaterMark':'" + sysConfig.Attachments.HasAbbrImageWaterMark + "'");
            sbJson.Append(",");
            sbJson.Append("'AbbrImageWidth':'" + sysConfig.Attachments.AbbrImageWidth + "'");
            sbJson.Append(",");
            sbJson.Append("'AbbrImageHeight':'" + sysConfig.Attachments.AbbrImageHeight + "'");
            sbJson.Append(",");

            DataTable dtAttachmentType = bllSelectionConfig.GetSectionListAttachmentType();
            if (dtAttachmentType != null && dtAttachmentType.Rows.Count > 0)
            {
                sbJson.Append("'attachmentType':'");
                int rdo_count = 1;
                foreach(DataRow dr in dtAttachmentType.Rows)
                {                    
                    sbJson.Append("<span>");
                    if (rdo_count == 1)
                    {
                        sbJson.Append("<input type=\"radio\" id=\"rdo_" + rdo_count.ToString() + "\" name=\"rdo\" checked=\"checked\" value=\"" + dr["key"].ToString() + "\" onclick=\"setAttr(this)\" />");
                    }
                    else
                    {
                        sbJson.Append("<input type=\"radio\" id=\"rdo_" + rdo_count.ToString() + "\" name=\"rdo\" value=\"" + dr["key"].ToString() + "\" onclick=\"setAttr(this)\" />");
                    }
                    sbJson.Append("<label for=\"rdo_" + rdo_count.ToString() + "\">" + dr["value"].ToString() + "</label>");
                    sbJson.Append("</span>");
                    rdo_count++;
                }
            }
            sbJson.Append("'}");
            return sbJson.ToString();
        }
    }
}
