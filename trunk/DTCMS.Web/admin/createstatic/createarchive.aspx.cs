using System;
using System.Web;
using System.Text;
using System.IO;
using System.Data;
using System.Collections.Generic;
using DTCMS.Common;
using DTCMS.Entity;
using DTCMS.Entity.TemplateEngine;
using DTCMS.BLL;
using DTCMS.BLL.TemplateEngine;
using DTCMS.TemplateEngine;

namespace DTCMS.Web.admin.createstatic
{
    public partial class createarchive : System.Web.UI.Page
    {
        protected int channelID;    //栏目ID
        protected int channelType;   //栏目类型
        protected int archiveID;   //文档ID
        protected int pageIndex = 1;    //文档当前页码

        //以下复杂字段存在隐藏域中
        protected string classUrl;  //栏目地址
        protected string archiveTemplet;   //文档模版
        //protected string indexRule; //页码索引规则
        protected string position; //当前位置
        protected string relation;  //栏目关系

        protected void Page_Load(object sender, EventArgs e)
        {
            //输出数据
            this.LoadCurrentTemplate();
            this.InitPageTemplate();
            this.Document.Render(this.Response.Output);
        }

        /// <summary>
        /// 测试类型
        /// </summary>
        private string TestType { get; set; }

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
            this.LoadTemplateFile(this.Server.MapPath("~/template/default/arc_article.html"));
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
            #region 获取文档内容
            //获取要生成的栏目ID
            archiveID = Utils.GetQueryInt("ID");
            if (archiveID < 0)
            {
                Message.Dialog("生成错误，生成静态页的文档ID为空！", "-1", MessageIcon.Warning);
            }

            //获取栏目类型
            channelType = Utils.GetQueryInt("type");
            if (channelType < 0)
            {
                ArcListBLL arclistBll = new ArcListBLL();
                Message.Dialog("生成错误，请选择要生成的文档类型！", "-1", MessageIcon.Warning);
            }

            //获取生成文档当前页数，默认为第一页
            pageIndex = Utils.GetQueryInt("page");
            if (pageIndex < 0)
                pageIndex = 1;

            ArcListBLL arcBll = new ArcListBLL();
            List<Archive> archiveInfo = arcBll.GetArchiveInfo(archiveID, channelType);
            if (archiveInfo.Count > 0)
            {
                channelID = archiveInfo[0].ClassID;
            }
            else
            {
                return;
            }

            #endregion

            #region 获取当前位置
            ArchiveField gobal = new ArchiveField();

            //获取栏目当前位置
            classUrl = this.__CLASSURL.Value;
            position = this.__POSITION.Value;
            relation = this.__RELATION.Value;
            if (classUrl.Length == 0 || relation.Length == 0)
            {
                Arc_ClassBLL classBll = new Arc_ClassBLL();
                Arc_Class classInfo = classBll.GetModel(channelID);
                classUrl = this.__CLASSURL.Value = classInfo.ClassPath;
                relation = this.__RELATION.Value = classInfo.Relation.TrimEnd('.').Replace('.', ',');
            }
            if (position.Length == 0)
            {
                Arc_ClassBLL classBll = new Arc_ClassBLL();
                DataTable dt = classBll.GetThisPlace(relation);

                position += "<a href=\"/\">首页</a> &raquo; ";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    position += "<a href=\"" + dt.Rows[i]["ClassEName"] + "\">" + dt.Rows[i]["ClassName"] + "</a>";
                    if (i + 1 < dt.Rows.Count)
                    {
                        position += " &raquo; ";
                    }
                }
                this.__POSITION.Value = gobal.Position = position;
            }
            #endregion

            #region 获取上一篇、下一篇链接
            int count = archiveInfo.Count;
            for (int i = 1; i < count; i++)
            {
                if (archiveInfo[i] != null)
                {
                    string temp = "<a href=\"" + archiveInfo[i].Url + "\">" + archiveInfo[i].Title + "</a>";
                    if (archiveInfo[i].ID < archiveID)
                    {
                        gobal.Prior = temp;
                    }
                    else
                    {
                        gobal.Next = temp;
                    }
                }
            }

            #endregion

            this.Document.Variables.SetValue("field", archiveInfo[0]);
            this.Document.Variables.SetValue("gobal", gobal);
        }
    }
}
