using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DTCMS.BLL;

namespace DTCMS.Web.admin
{
    public partial class attachmentsearch : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitAttachmentType();
        }       

        private void InitAttachmentType()
        {
            DataTable dtAttachmentType = SectionConfigBLL.GetSectionListAttachmentType();
            slt_attachmentType.DataSource = dtAttachmentType;
            slt_attachmentType.DataTextField = "value";
            slt_attachmentType.DataValueField = "key";
            slt_attachmentType.DataBind();
        }
    }
}
