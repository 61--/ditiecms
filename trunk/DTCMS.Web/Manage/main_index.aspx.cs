using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class manager_main_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null || Session["PassWord"] == null)
        {
            string url = "../login.html?ReturnUrl=" + Server.UrlEncode("manager/main_index.aspx");
            Response.Write("<script type=\"text/javascript\">document.frames.top.location.href='" + url + "';</script>");
        }
        ServerInfo si = new ServerInfo();
        si.GetServerInof();
        lblDrives.Text = si.Drives;
        lblSystemDir.Text = si.SystemDir;
        lblRunningTime.Text = si.RunningTime;
        lblDomainName.Text = si.DomainName;
        lblMachineName.Text = si.MachineName;
    }

}
