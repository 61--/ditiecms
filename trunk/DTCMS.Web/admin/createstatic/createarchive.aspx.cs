using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using DTCMS.Entity;
using DTCMS.BLL;
using Ader.TemplateEngine;

namespace DTCMS.Web.admin.createstatic
{
    public partial class createarchive : System.Web.UI.Page
    {
        private Arc_ArticleBLL articleBll = new Arc_ArticleBLL();
        private Arc_ClassBLL classBll = new Arc_ClassBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string output = "";

            Template _Public_Header = Template.FromFile("_Public_Header", this.Server.MapPath("~/template/default/_Public_Header.html"));
            Template _Public_Footer = Template.FromFile("_Public_Footer", this.Server.MapPath("~/template/default/_Public_Footer.html"));


            TemplateManager tm = TemplateManager.FromFile(this.Server.MapPath("~/template/default/arc_article.html"));

            tm.AddTemplate(_Public_Header);
            tm.AddTemplate(_Public_Footer);

            Arc_Article articleInfo = new Arc_Article();
            articleInfo = articleBll.GetModel(69);

            tm.SetValue("article", articleInfo);
            //tm.SetValue("DTCMS", new string[] { "www.vmoom.com", "www.vmoom.net" });

            output = tm.Process();

            // 删除空行
            //output = Regex.Replace(output, @"\n\s+\n", "\n", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            //db.Book.Rows[].RowState.ToString()

            Response.Write(output);
            Response.End();
        }
    }
}
