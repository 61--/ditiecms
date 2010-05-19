using System;
using System.Web;
using System.Text;
using System.IO;
using System.Web.SessionState;
using DTCMS.TemplateEngine;

namespace DTCMS.Web.admin.createstatic
{
    public partial class createlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TestType = Request.QueryString["testtype"];

            //输出数据
            this.LoadCurrentTemplate();
            this.InitPageTemplate();
            this.Document.Render(this.Response.Output);
        }

        private void InitContext()
        {
            //this.Context = context;
            //this.Application = context.Application;
            //this.Request = context.Request;
            //this.Response = context.Response;
            //this.Server = context.Server;
            //this.Session = context.Session;
            Tag tag = this.Document.CurrentRenderingTag;
            var attr = tag.Attributes["ChannelID"];
        }

        #region 当前页面的测试类型
        /// <summary>
        /// 测试类型
        /// </summary>
        private string TestType { get; set; }
        #endregion

        /// <summary>
        /// 当前页面的模板文档对象
        /// </summary>
        protected TemplateDocument Document
        {
            get;
            private set;
        }
        /// <summary>
        /// 当前页面的模板文档的配置参数
        /// </summary>
        protected virtual TemplateDocumentConfig DocumentConfig
        {
            get
            {
                return TemplateDocumentConfig.Default;
            }
        }
        /// <summary>
        /// 是否读取缓存模板
        /// </summary>
        protected virtual bool IsLoadCacheTemplate
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// 装载当前页面的模板文档
        /// </summary>
        public virtual void LoadCurrentTemplate()
        {
            this.LoadTemplateFile(this.Server.MapPath("~/template/default/article_list.html"));
        }
        /// <summary>
        /// 装载模板文件
        /// </summary>
        /// <param name="fileName"></param>
        protected virtual void LoadTemplateFile(string fileName)
        {
            this.Document = null;
            if ("cache".Equals(this.TestType, StringComparison.InvariantCultureIgnoreCase) || this.IsLoadCacheTemplate)
            {
                //测试缓存模板文档
                this.Document = TemplateDocument.FromFileCache(fileName, Encoding.UTF8, this.DocumentConfig);
            }
            else
            {
                //测试实例模板文档
                this.Document = new TemplateDocument(fileName, Encoding.UTF8, this.DocumentConfig);
            }
        }

        /// <summary>
        /// 初始化当前页面模板数据
        /// </summary>
        protected void InitPageTemplate() { }
    }
}
