using System;
using System.Web;
using System.Text;
using System.IO;
using System.Data;
using System.Web.SessionState;
using DTCMS.Common;
using DTCMS.Entity;
using DTCMS.Entity.TemplateEngine;
using DTCMS.BLL;
using DTCMS.BLL.TemplateEngine;
using DTCMS.TemplateEngine;

namespace DTCMS.Web.admin.createstatic
{
    public partial class createlist : System.Web.UI.Page
    {
        protected int channelID;    //栏目ID
        protected string channelType;   //栏目类型
        protected byte channelAttr; //栏目属性
        protected int totalRecord;  //总记录数
        protected int pageSize;     //分页大小
        protected int pageIndex;    //当前页码

        //以下复杂字段存在隐藏域中
        protected string pageItem;  //分页项目
        protected string classUrl;  //栏目地址
        protected string listTemplet;   //栏目列表模版
        protected string indexRule; //页码索引规则
        protected string thisPlace; //当前位置
        protected string relation;  //栏目关系

        protected void Page_Load(object sender, EventArgs e)
        {
            this.TestType = Request.QueryString["testtype"];

            //输出数据
            this.LoadCurrentTemplate();
            this.InitPageTemplate();
            this.Document.Render(this.Response.Output);
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
        protected void InitPageTemplate()
        {
            //获取要生成的栏目ID
            channelID = Utils.GetQueryInt("ID");
            if (channelID < 0)
            {
                Message.Dialog("生成错误，生成静态页的栏目ID为空！", "-1", MessageIcon.Warning);
            }

            //获取栏目类型
            channelType = Utils.GetQueryString("type");
            if (channelType.Length == 0)
            {
                ArcListBLL arclistBll = new ArcListBLL();
                channelType = arclistBll.GetChannelType(channelID);
            }

            //获取记录总数
            totalRecord = Utils.GetQueryInt("total");
            if (totalRecord < 0)
            {
                ArcListBLL arclistBll = new ArcListBLL();
                totalRecord = arclistBll.GetArcCount(channelID, channelType);
            }

            //获取生成栏目当前页数
            pageIndex = Utils.GetQueryInt("page");
            if (pageIndex < 0)
            {
                Message.Dialog("生成错误，生成静态页的当前页数为空！", "-1", MessageIcon.Warning);
            }

            //获取分页大小
            pageSize = Utils.GetQueryInt("size");
            //获取分页选项
            pageItem = this.__PAGEITEM.Value;
            if (pageSize < 0 || pageItem.Length == 0)
            {
                //分页大小和分页选项从PageList标签中获取
                ElementCollection<Tag> tags = this.Document.GetChildTagsByTagName("PageList");
                foreach (Tag tag in tags)
                {
                    pageSize = TypeConvert.ToInt32(tag.Attributes["PageSize"].Value);
                    pageItem = tag.Attributes["Item"].Value.ToString();
                }
                this.__PAGEITEM.Value = pageItem;
            }

            //获取栏目当前位置
            classUrl = this.__CLASSURL.Value;
            listTemplet = this.__LISTTEMPLET.Value;
            indexRule = this.__INDEXRULE.Value;
            thisPlace = this.__THISPLACE.Value;
            relation = this.__RELATION.Value;
            if (classUrl.Length == 0 || listTemplet.Length == 0 || indexRule.Length == 0 || relation.Length == 0)
            {
                Arc_ClassBLL classBll = new Arc_ClassBLL();
                Arc_Class classInfo = classBll.GetModel(channelID);
                classUrl = this.__CLASSURL.Value = classInfo.ClassPath;
                listTemplet = this.__LISTTEMPLET.Value = classInfo.ListTemplet;
                indexRule = this.__INDEXRULE.Value = classInfo.IndexRule;
                relation = this.__RELATION.Value = classInfo.Relation.TrimEnd('.').Replace('.', ',');
            }
            if (thisPlace.Length == 0)
            {
                Arc_ClassBLL classBll = new Arc_ClassBLL();
                DataTable dt = classBll.GetThisPlace(relation);

                thisPlace += "<a href=\"/\">首页</a> &raquo; ";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    thisPlace += "<a href=\"" + dt.Rows[i]["ClassEName"] + "\">" + dt.Rows[i]["ClassName"] + "</a>";
                    if (i + 1 < dt.Rows.Count)
                    {
                        thisPlace += " &raquo; ";
                    }
                }
                this.__THISPLACE.Value = thisPlace;
            }

            //设置自定义属性
            PageListField field = new PageListField();
            field.CurrentPage = pageIndex;
            field.TotalPage = PageSeting.GetPageCount(totalRecord, pageSize);
            field.TotalRecord = totalRecord;
            field.PageIndex = PageSeting.GetPageNum(pageIndex, field.TotalPage, 10, "createlist.aspx?id=10&page={0}", pageItem);
            field.ThisPlace = thisPlace;
            //gobal.PageIndex = gobal.PageIndex.Replace(string.Format("list/{0}/1/", channelID), "index.html");
            this.Document.Variables.SetValue("field", field);
        }

        /// <summary>
        /// 获取栏目信息
        /// </summary>
        //private void GetClassInfo()
        //{
        //    Arc_ClassBLL classBll = new Arc_ClassBLL();
        //    Arc_Class classInfo = classBll.GetModel(channelID);
        //}
    }
}
