//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-04-04 02:33:15
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data;
using DTCMS.BLL;
using DTCMS.Entity;

namespace DTCMS.TemplateEngine
{
    /// <summary>
    /// 数据列表标签,.如: &lt;vt:arclist item="archive" type="all" /&gt;
    /// </summary>
    public class ArcListTag : Tag
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ownerTemplate"></param>
        internal ArcListTag(Template ownerTemplate)
            : base(ownerTemplate)
        {
        }

        #region 重写Tag的方法
        /// <summary>
        /// 返回标签的名称
        /// </summary>
        public override string TagName
        {
            get { return "arclist"; }
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
        /// 文档类型.
        /// </summary>
        /// <remarks></remarks>
        public Attribute Type
        {
            get { return this.Attributes["Type"]; }
        }

        /// <summary>
        /// 数据项
        /// </summary>
        public VariableIdentity Item
        {
            get;
            protected set;
        }

        /// <summary>
        /// 栏目ID
        /// </summary>
        public Attribute ClassID
        {
            get { return this.Attributes["ClassID"]; }
        }

        /// <summary>
        /// 返回文档列表条数
        /// </summary>
        public Attribute Row
        {
            get { return this.Attributes["Row"]; }
        }

        /// <summary>
        /// 排序类型
        /// </summary>
        public Attribute OrderBy
        {
            get { return this.Attributes["OrderBy"]; }
        }

        /// <summary>
        /// 排序类型，默认为降序，Desc降序、Asc升序
        /// </summary>
        public Attribute OrderType
        {
            get { return this.Attributes["OrderType"]; }
        }

        /// <summary>
        /// 文档包含关键字，多个关键字用半角逗号隔开
        /// </summary>
        public Attribute KeyWord
        {
            get { return this.Attributes["KeyWord"]; }
        }

        /// <summary>
        /// 文档模型
        /// </summary>
        public Attribute ModelID
        {
            get { return this.Attributes["ModelID"]; }
        }

        /// <summary>
        /// 限定条数，如limit="10-20"，设置了本属性以后，Row属性将失效
        /// </summary>
        public Attribute Limit
        {
            get { return this.Attributes["Limit"]; }
        }

        /// <summary>
        /// 标识多少天内发布的文档
        /// </summary>
        public Attribute InDay
        {
            get { return this.Attributes["InDay"]; }
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
                case "item":
                    this.Item = ParserHelper.CreateVariableIdentity(this.OwnerTemplate, item.Text);
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
            if (this.Item == null && !this.Output) throw new ParserException(string.Format("{0}标签中如果未定义Output属性为true则必须定义item属性", this.TagName));
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
            ArcListTag tag = new ArcListTag(ownerTemplate);
            this.CopyTo(tag);
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
            List<Arc_Article> arc = this.GetServerData();
            if (this.Item != null) this.Item.Value = arc[0];

            if (this.Output && arc != null) writer.Write(arc[0]);
            base.RenderTagData(writer);
        }
        #endregion

        #region 获取对应类型的数据
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        private List<Arc_Article> GetServerData()
        {
            //ServerDataType type = (ServerDataType)Utility.ConvertTo(this.Type.GetTextValue(), typeof(ServerDataType));
            Arc_ArticleBLL articleBll = new Arc_ArticleBLL();
            int pagecount;

            List<Arc_Article> arc = articleBll.GetPageList(10, 1, out pagecount);
            return arc;
        }

        #endregion
    }
}
