using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using DTCMS.Config;
namespace DTCMS.Web.admin
{
    public partial class attachmentload : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(Page.GetType(), " ", "<script>" + ExistsFormat() + "</script>");
        }
        private string ExistsFormat()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("function hasImage(ext) { return (");
            foreach (string img in GobalConfig.ImageFormat.Split('|'))
            {
                sb.Append("ext == '" + img + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasVideo(ext) { return(");
            foreach (string video in GobalConfig.VideoFormat.Split('|'))
            {
                sb.Append("ext == '" + video + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasAudio(ext) { return(");
            foreach (string audio in GobalConfig.AudioFormat.Split('|'))
            {
                sb.Append("ext == '" + audio + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasFlash(ext) { return(");
            foreach (string flash in GobalConfig.FlashFormat.Split('|'))
            {
                sb.Append("ext == '" + flash + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n");

            sb.Append("function hasAttachment(ext) { return(");
            foreach (string attachment in GobalConfig.AttachmentFormat.Split('|'))
            {
                sb.Append("ext == '" + attachment + "'");
                sb.Append(" || ");
            }
            sb.Remove(sb.ToString().Length - 4, 4);
            sb.Append("); }\r\n"); 
            return sb.ToString();
        }
    }
}
