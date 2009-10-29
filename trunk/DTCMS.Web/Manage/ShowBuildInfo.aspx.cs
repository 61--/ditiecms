using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class manager_BuildEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int buildId = Convert.ToInt32(Request.QueryString["buildId"]);
        BuildInfo buildInfo = new BuildInfo();
        SqlDataReader sdr = buildInfo.GetBuildInfoById(buildId);

        if (sdr.Read())
        {
            this.lblBuildId.Text = sdr[0].ToString();
            this.lblBuildName.Text = sdr[1].ToString();
            this.lblBuildNumber.Text = sdr[3].ToString();
            this.lblBuildFace.Text = sdr[6].ToString();
            this.lblBuildUse.Text = sdr[4].ToString();
            this.lblDatetime.Text = sdr[7].ToString();
            this.lblBuildCategory.Text = sdr[5].ToString();
            this.lblBuildStatus.Text = sdr[8].ToString();
            this.lblBuildAdress.Text = sdr[2].ToString();
            this.lblComment.Text = sdr[9].ToString();
        }
    }
}
