using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections;
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
            Hashtable htFormat = GobalConfig.GetAttachmentList();
            if (htFormat != null)
            {
                sb.Append("function hasImage(ext) { return (");
                foreach (string img in htFormat["ImageFormat"].ToString().Split('|'))
                {
                    sb.Append("ext == '" + img + "'");
                    sb.Append(" || ");
                }
                sb.Remove(sb.ToString().Length - 4, 4);
                sb.Append("); }");

                sb.Append("function hasVideo(ext) { return(");
                foreach (string video in htFormat["VideoFormat"].ToString().Split('|'))
                {
                    sb.Append("ext == '" + video + "'");
                    sb.Append(" || ");
                }
                sb.Remove(sb.ToString().Length - 4, 4);
                sb.Append("); }");

                sb.Append("function hasAudio(ext) { return(");
                foreach (string audio in htFormat["AudioFormat"].ToString().Split('|'))
                {
                    sb.Append("ext == '" + audio + "'");
                    sb.Append(" || ");
                }
                sb.Remove(sb.ToString().Length - 4, 4);
                sb.Append("); }");

                sb.Append("function hasFlash(ext) { return(");
                foreach (string flash in htFormat["FlashFormat"].ToString().Split('|'))
                {
                    sb.Append("ext == '" + flash + "'");
                    sb.Append(" || ");
                }
                sb.Remove(sb.ToString().Length - 4, 4);
                sb.Append("); }");

                sb.Append("function hasAttachment(ext) { return(");
                foreach (string attachment in htFormat["AttachmentFormat"].ToString().Split('|'))
                {
                    sb.Append("ext == '" + attachment + "'");
                    sb.Append(" || ");
                }
                sb.Remove(sb.ToString().Length - 4, 4);
                sb.Append("); }");                
            }
            return sb.ToString();
        }
    }
}
