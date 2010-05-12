//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-04-24 15:51:36
// 功能描述: 
// 修改标识:
// 修改描述: LinPanxing 修改于 2010-05-06 23:12:59
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data;
using DTCMS.Common;
using DTCMS.BLL.TemplateEngine;
using DTCMS.Entity.TemplateEngine;

namespace DTCMS.TemplateEngine
{
    /// <summary>
    /// 栏目标签,.如: &lt;dt:class var="class" type="all" /&gt;
    /// </summary>
    public class ArcClassTag : Tag
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ownerTemplate"></param>
        internal ArcClassTag(Template ownerTemplate)
            : base(ownerTemplate)
        { }

        #region 重写Tag的方法
        /// <summary>
        /// 返回标签的名称
        /// </summary>
        public override string TagName
        {
            get { return "class"; }
        }

        /// <summary>
        /// 返回此标签是否是单一标签.即是不需要配对的结束标签
        /// </summary>
        internal override bool IsSingleTag
        {
            get { return false; }
        }
        #endregion

        #region 属性定义
        /// <summary>
        /// 存储表达式结果的变量
        /// </summary>
        public VariableIdentity Variable { get; protected set; }

        /// <summary>
        /// 获取栏目层级，level=top顶级栏目，self同级栏目，sub下级栏目
        /// </summary>
        public Attribute Level
        {
            get { return this.Attributes["Level"]; }
        }

        /// <summary>
        /// 文档模型，如1文章类型、2软件类型
        /// </summary>
        /// <remarks></remarks>
        public Attribute Type
        {
            get { return this.Attributes["Type"]; }
        }

        /// <summary>
        /// 栏目ID
        /// </summary>
        public Attribute ClassID
        {
            get { return this.Attributes["ClassID"]; }
        }

        /// <summary>
        /// 返回栏目条数
        /// </summary>
        public Attribute Row
        {
            get { return this.Attributes["Row"]; }
        }

        /// <summary>
        /// 是否输出此标签的结果值
        /// </summary>
        public bool Output { get; protected set; }
        #endregion

        #region 添加标签属性时的触发函数.用于设置自身的某些属性值
        /// <summary>
        /// 添加标签属性时的触发函数.用于设置自身的某些属性值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="item"></param>
        protected override void OnAddingAttribute(string name, Attribute item)
        {
            switch (name)
            {
                case "var":
                    this.Variable = ParserHelper.CreateVariableIdentity(this.OwnerTemplate, item.Text);
                    break;
                case "output":
                    this.Output = Utility.ConverToBoolean(item.Text);
                    break;
            }
        }
        #endregion

        #region 开始解析标签数据
        /// <summary>
        /// 开始解析标签数据
        /// </summary>
        /// <param name="ownerTemplate">宿主模板</param>
        /// <param name="container">标签的容器</param>
        /// <param name="tagStack">标签堆栈</param>
        /// <param name="text"></param>
        /// <param name="match"></param>
        /// <param name="isClosedTag">是否闭合标签</param>
        /// <returns>如果需要继续处理EndTag则返回true.否则请返回false</returns>
        internal override bool ProcessBeginTag(Template ownerTemplate, Tag container, Stack<Tag> tagStack, string text, ref Match match, bool isClosedTag)
        {
            if (this.Variable == null && !this.Output)
                this.Variable = ParserHelper.CreateVariableIdentity(this.OwnerTemplate, "class");
            //throw new ParserException(string.Format("{0}标签中如果未定义Output属性为true则必须定义var属性", this.TagName));
            //if (this.Type != ServerDataType.Random 
            //    && this.Type != ServerDataType.Time
            //    && this.Type != ServerDataType.Request
            //    && this.Type != ServerDataType.Environment
            //    && this.Item == null) throw new ParserException(string.Format("当{0}标签type=\"{1}\"时必须设置item属性值", this.TagName, this.Type));

            return base.ProcessBeginTag(ownerTemplate, container, tagStack, text, ref match, isClosedTag);
        }
        #endregion

        #region 克隆当前元素到新的宿主模板
        /// <summary>
        /// 克隆当前元素到新的宿主模板
        /// </summary>
        /// <param name="ownerTemplate"></param>
        /// <returns></returns>
        internal override Element Clone(Template ownerTemplate)
        {
            ArcClassTag tag = new ArcClassTag(ownerTemplate);
            this.CopyTo(tag);
            tag.Variable = this.Variable == null ? null : this.Variable.Clone(ownerTemplate);
            tag.Output = this.Output;
            return tag;
        }
        #endregion

        #region 呈现本元素的数据
        /// <summary>
        /// 呈现本元素的数据
        /// </summary>
        /// <param name="writer"></param>
        protected override void RenderTagData(System.IO.TextWriter writer)
        {
            List<ArcClass> classList = this.GetClassList();
            if (classList.Count > 0)
            {
                foreach (ArcClass classItem in classList)
                {
                    if (this.Variable != null)
                        this.Variable.Value = classItem;
                    if (this.Output)
                        writer.Write("<li><a href=\"" + classItem.ID + "\">" + classItem.ClassPath + "</a></li>\r\n");
                    base.RenderTagData(writer);
                }
            }
        }
        #endregion

        #region 获取对应类型的数据
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        private List<ArcClass> GetClassList()
        {
            //获取记录条数
            int row = TypeConvert.ToInt32(this.Row.Text);

            //构造Type，如1文章类型、2软件类型
            string type = this.Type == null ? string.Empty : this.Type.Text;

            //构造WHERE语句
            string strWhere = string.Empty;

            if (this.ClassID != null)
            {
                string[] scList = this.ClassID.Text.Split(',');
                if (scList.Length > 1)
                {
                    string scSql = string.Format(" AND CID IN(", scList[0]);
                    for (int i = 1; i < scList.Length; i++)
                    {
                        scSql += string.Format(",{0}", scList[i]);
                    }
                    scSql += ")";
                    strWhere += scSql;
                }
                else
                {
                    strWhere = string.Format(" AND CID={0}", scList[0]);
                }
            }

            if (this.Level != null)
            {
                switch (this.Level.Text)
                {
                    case "top":
                        strWhere += " AND Level=1";
                        break;
                    case "self":
                        break;
                    case "sub":
                        break;
                    default:
                        break;
                }
            }

            ArcListBLL classBll = new ArcListBLL();

            List<ArcClass> classList = classBll.GetArcClass(row, type, strWhere);
            return classList;
        }
        #endregion
    }
}
