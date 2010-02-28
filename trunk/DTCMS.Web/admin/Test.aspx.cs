using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTCMS.Common;
using DTCMS.Config;
using DTCMS.Controls.DropDownTree;
using System.Data;

namespace DTCMS.Web.admin
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text = "从缓存中获取xml方法：";
            this.Label2.Text = "从缓存中直接获取：";

            BLL.Arc_ClassBLL b=new DTCMS.BLL.Arc_ClassBLL ();
            DataTable dt=b.GetDropList("");
            DropDownTree.BindToDropDownList(DropDownList1,dt,"0");
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            long execTime = 0;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            CacheAccess.SaveToCache("Path", "uploads\\users");

            for (int i = 0; i < 100000; i++)
            {
                string path = CacheAccess.GetFromCache("Path").ToString();
            }

            sw.Stop();
            execTime = sw.ElapsedMilliseconds;

            JScript.ShowMessage(this, string.Format("用时{0}毫秒", execTime.ToString()));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            long execTime = 0;

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < 100000; i++)
            {
                string path = GobalConfig.GetCobalInstance().LoadGoableConfig().Attachments.Path;
            }

            sw.Stop();
            execTime = sw.ElapsedMilliseconds;

            JScript.ShowMessage(this, string.Format("用时{0}毫秒", execTime.ToString()));
        }
    }
}
