//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-04-04 02:33:15
// 功能描述: 
// 修改标识: 
// 修改描述: LinPanxing 修改于 2010-04-21 21:33:13
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
    /// 数据列表标签,.如: &lt;dt:arclist var="archive" type="article" /&gt;
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
        /// 存储表达式结果的变量
        /// </summary>
        public VariableIdentity Variable { get; protected set; }

        /// <summary>
        /// 文档模型，如1文章类型、2软件类型
        /// </summary>
        /// <remarks></remarks>
        public Attribute Type
        {
            get { return this.Attributes["Type"]; }
        }

        /// <summary>
        /// 自定义标题标签，如1[原创]、2[转载]、3[投稿]
        /// </summary>
        public Attribute TitleFlag
        {
            get { return this.Attributes["TitleFlag"]; }
        }

        /// <summary>
        /// 栏目ID
        /// </summary>
        public Attribute ChannelID
        {
            get { return this.Attributes["ChannelID"]; }
        }

        /// <summary>
        /// 是否包含子栏目
        /// </summary>
        public Attribute SubChannel
        {
            get { return this.Attributes["SubChannel"]; }
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
                this.Variable = ParserHelper.CreateVariableIdentity(this.OwnerTemplate, "a");
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
            ArcListTag tag = new ArcListTag(ownerTemplate);
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
            List<ArcList> arcList = this.GetArcList();
            if (arcList.Count > 0)
            {
                foreach (ArcList arcInfo in arcList)
                {
                    if (this.Variable != null)
                        this.Variable.Value = arcInfo;
                    if (this.Output)
                        writer.Write("<li><a href=\"" + arcInfo.ID + "\">" + arcInfo.Title + "</a></li>\r\n");
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
        private List<ArcList> GetArcList()
        {
            //构造Limit语句
            int firstRecort = 1;
            int lastRecort = 1;
            if (this.Limit != null)
            {
                string[] temp = this.Limit.Text.Split(',');
                try
                {
                    int f = TypeConvert.ToInt32(temp[0]);
                    int l = TypeConvert.ToInt32(temp[1]);
                    if (f > l)
                    {
                        f = l;
                    }
                    if (f > 0)
                    {
                        firstRecort = f;
                        lastRecort = l;
                    }
                }
                catch
                {
                    throw new ParserException("Limit属性必须由\"10,20\"这样的格式组成；并且结束条数必须大于开始条数，中间用半角逗号隔开。");
                }

            }
            else
            {
                if (this.Row != null)
                {
                    lastRecort = TypeConvert.ToInt32(this.Row.Text);
                }
            }

            //构造Type，如1文章类型、2软件类型
            string type = this.Type == null ? "1" : this.Type.Text;

            //构造WHERE语句
            string strWhere = string.Empty;
            if (this.TitleFlag != null)
            {
                strWhere += string.Format(" AND TitleFlag={0}", this.TitleFlag.Text);
            }
            if (this.ChannelID != null && this.ChannelID.Value.GetValue() != null)
            {
                if (this.SubChannel == null ? true : TypeConvert.ToBool(this.SubChannel.Text, true))
                {
                    //如果包含子栏目
                    //string[] scList = this.ChannelID.Value.GetValue().ToString().Split(',');
                    string[] scList = this.ChannelID.GetTextValue().Split(',');
                    if (scList.Length > 1)
                    {
                        string scSql = string.Format(" AND ClassID IN(SELECT CID FROM {{0}}Arc_Class WHERE Relation LIKE '%.{0}.%'", scList[0]);
                        for (int i = 1; i < scList.Length; i++)
                        {
                            scSql += string.Format(" OR Relation LIKE '%.{0}.%'", scList[i]);
                        }
                        scSql += ")";
                        strWhere += scSql;
                    }
                    else
                    {
                        strWhere = string.Format(" AND ClassID IN(SELECT CID FROM {{0}}Arc_Class WHERE Relation LIKE '%.{0}.%')", scList[0]);
                    }
                }
                else
                {
                    strWhere += string.Format(" AND ClassID IN({0})", this.ChannelID.Text);
                }
            }
            if (this.KeyWord != null)
            {
                string[] kwList = this.KeyWord.Text.Split(',');
                if (kwList.Length > 1)
                {
                    string kwSql = string.Format(" AND(A.KeyWords LIKE '%{0}%'", kwList[0]);
                    for (int i = 1; i < kwList.Length; i++)
                    {
                        kwSql += string.Format(" OR A.KeyWords LIKE '%{0}%'", kwList[i]);
                    }
                    kwSql += ")";
                    strWhere += kwSql;
                }
                else
                {
                    strWhere += string.Format(" AND A.KeyWords LIKE '%{0}%'", kwList[0]);
                }
            }
            if (this.InDay != null)
            {
                double inDay;
                bool rv = double.TryParse(this.InDay.Text, out inDay);
                if (rv && inDay > 0)
                {
                    strWhere += string.Format(" AND PubDate>'{0}'", DateTime.Now.AddDays(-inDay).ToShortDateString());
                }
            }

            //构造ORDER BY语句
            string strOrder = string.Empty;
            if (this.OrderBy != null)
            {
                strOrder = string.Format(" ORDER BY {0}", this.OrderBy.Text);
                if (this.OrderType != null)
                {
                    if (String.Compare(this.OrderType.Text, "ASC", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        strOrder += " ASC";
                    }
                    else
                    {
                        strOrder += " DESC";
                    }
                }
            }

            ArcListBLL arcListBll = new ArcListBLL();

            List<ArcList> arcList = arcListBll.GetArcList(firstRecort, lastRecort, type, strWhere, strOrder);
            return arcList;
        }
        #endregion
    }
}
