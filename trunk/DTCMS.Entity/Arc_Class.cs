using System;
namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类DT_Arc_Class 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class Arc_Class
	{
		public Arc_Class()
		{ }
        #region Entity
        private int _cid;
        private int _parentid;
        private int _attribute;
        private string _classname;
        private string _classename;
        private int _classtype;
        private string _classdomain;
        private string _classpath;
        private string _indextemplet;
        private string _listtemplet;
        private string _archivetemplet;
        private string _indexrule;
        private string _listrule;
        private string _archiverule;
        private int? _classpage;
        private string _description;
        private int _ishidden;
        private int _ishtml;
        private int _checklevel;
        private int _iscontribute;
        private int _iscomment;
        private int? _readaccess;
        private int? _siteid;
        private DateTime _adddate;
        private string _relation;
        private int _orderid;
        private string _imgurl;
        private string _keywords;
        private string _crossid;
        private string _content;
        /// <summary>
        /// 栏目ID
        /// </summary>
        public int CID
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// 栏目父ID，默认0为顶级栏目
        /// </summary>
        public int ParentID
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 栏目属性，1封面，2列表，3链接地址
        /// </summary>
        public int Attribute
        {
            set { _attribute = value; }
            get { return _attribute; }
        }
        /// <summary>
        /// 栏目名称
        /// </summary>
        public string ClassName
        {
            set { _classname = value; }
            get { return _classname; }
        }
        /// <summary>
        /// 栏目英文名称
        /// </summary>
        public string ClassEName
        {
            set { _classename = value; }
            get { return _classename; }
        }
        /// <summary>
        /// 栏目类型
        /// </summary>
        public int ClassType
        {
            set { _classtype = value; }
            get { return _classtype; }
        }
        /// <summary>
        /// 栏目二级域名
        /// </summary>
        public string ClassDomain
        {
            set { _classdomain = value; }
            get { return _classdomain; }
        }
        /// <summary>
        /// 栏目目录，{#CmsPath}/Archive/
        /// </summary>
        public string ClassPath
        {
            set { _classpath = value; }
            get { return _classpath; }
        }
        /// <summary>
        /// 封面模版
        /// </summary>
        public string IndexTemplet
        {
            set { _indextemplet = value; }
            get { return _indextemplet; }
        }
        /// <summary>
        /// 列表模版
        /// </summary>
        public string ListTemplet
        {
            set { _listtemplet = value; }
            get { return _listtemplet; }
        }
        /// <summary>
        /// 文档模版
        /// </summary>
        public string ArchiveTemplet
        {
            set { _archivetemplet = value; }
            get { return _archivetemplet; }
        }
        /// <summary>
        /// 封面页规则
        /// </summary>
        public string IndexRule
        {
            set { _indexrule = value; }
            get { return _indexrule; }
        }
        /// <summary>
        /// 列表页规则，访问路径
        /// </summary>
        public string ListRule
        {
            set { _listrule = value; }
            get { return _listrule; }
        }
        /// <summary>
        /// 文档页规则，访问路径
        /// </summary>
        public string ArchiveRule
        {
            set { _archiverule = value; }
            get { return _archiverule; }
        }
        /// <summary>
        /// 栏目分页大小,列表条数
        /// </summary>
        public int? ClassPage
        {
            set { _classpage = value; }
            get { return _classpage; }
        }
        /// <summary>
        /// 栏目描述
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 是否隐藏，1启用，0隐藏
        /// </summary>
        public int IsHidden
        {
            set { _ishidden = value; }
            get { return _ishidden; }
        }
        /// <summary>
        /// 是否允许生成静态页，1生成静态，0动态访问
        /// </summary>
        public int IsHtml
        {
            set { _ishtml = value; }
            get { return _ishtml; }
        }
        /// <summary>
        /// 审核机制
        /// </summary>
        public int CheckLevel
        {
            set { _checklevel = value; }
            get { return _checklevel; }
        }
        /// <summary>
        /// 是否允许投稿，1允许，0不允许
        /// </summary>
        public int IsContribute
        {
            set { _iscontribute = value; }
            get { return _iscontribute; }
        }
        /// <summary>
        /// 本栏目文章是否允许评论，1允许，0不允许
        /// </summary>
        public int IsComment
        {
            set { _iscomment = value; }
            get { return _iscomment; }
        }
        /// <summary>
        /// 阅读权限
        /// </summary>
        public int? Readaccess
        {
            set { _readaccess = value; }
            get { return _readaccess; }
        }
        /// <summary>
        /// 站点ID
        /// </summary>
        public int? SiteID
        {
            set { _siteid = value; }
            get { return _siteid; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 栏目关系
        /// </summary>
        public string Relation
        {
            set { _relation = value; }
            get { return _relation; }
        }
        /// <summary>
        /// 栏目排序，升序排列
        /// </summary>
        public int OrderID
        {
            set { _orderid = value; }
            get { return _orderid; }
        }
        /// <summary>
        /// 栏目图片地址
        /// </summary>
        public string ImgUrl
        {
            set { _imgurl = value; }
            get { return _imgurl; }
        }
        /// <summary>
        /// 栏目关键字
        /// </summary>
        public string Keywords
        {
            set { _keywords = value; }
            get { return _keywords; }
        }
        /// <summary>
        /// 交叉栏目，多个栏目用,号隔开
        /// </summary>
        public string CrossID
        {
            set { _crossid = value; }
            get { return _crossid; }
        }
        /// <summary>
        /// 栏目内容
        /// </summary>
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        #endregion Entity

    }
}

