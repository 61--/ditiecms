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

public partial class manager_top_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            this.lblWelcome.Text = "您未登陆或登陆超时！";
        }
        else
        {
            string UserName = Session["UserName"].ToString();
            this.lblUser.Text = UserName;
            this.lblWelcome.Text = "，欢迎使用昌融物业管理系统，这是您第<span class=\"username\">" + Session["LoginCount"].ToString() + "</span>次登陆！";
        }
    }
    protected void hlkExi_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Write("<script type=\"text/javascript\">top.document.frames.top.location.href='../login.html?action=logout'</script>");
    }
}
