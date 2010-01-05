using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.Config;
using DTCMS.Entity;
namespace DTCMS.Web.admin
{
    public partial class attachmentload : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //Page.ClientScript.RegisterStartupScript(Page.GetType(), " ", "<script>" + ExistsFormat() + "</script>");
                Response.Write(ExistsFormat());
            }
        }
        private string ExistsFormat()
        {
            SystemConfig sysConfig = GobalConfig.GetCobalInstance().LoadGoableConfig();

            StringBuilder sb = new StringBuilder();
            sb.Append("<script>\r\n");
            sb.Append("function hasImage(ext) { return (");
            foreach (string img in sysConfig.Attachments.ImageFormat.Split('|'))
            {
                sb.Append("ext == '" + img + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasVideo(ext) { return(");
            foreach (string video in sysConfig.Attachments.VideoFormat.Split('|'))
            {
                sb.Append("ext == '" + video + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasAudio(ext) { return(");
            foreach (string audio in sysConfig.Attachments.AudioFormat.Split('|'))
            {
                sb.Append("ext == '" + audio + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasFlash(ext) { return(");
            foreach (string flash in sysConfig.Attachments.FlashFormat.Split('|'))
            {
                sb.Append("ext == '" + flash + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasAttachment(ext) { return(");
            foreach (string attachment in sysConfig.Attachments.AttachmentFormat.Split('|'))
            {
                sb.Append("ext == '" + attachment + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");
            sb.Append("</script>");
            return sb.ToString();
        }
    }
}
