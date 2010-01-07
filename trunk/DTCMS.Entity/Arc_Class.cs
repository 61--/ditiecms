//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-7 23:34:18
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类 Arc_Class
	/// </summary>
	public class Arc_Class
	{
		public Arc_Class()
		{ }

		#region Model
		private int _cID;
		private int _parentID;
		private byte _attribute;
		private string _className;
		private string _classEName;
		private byte _classType;
		private string _classDomain;
		private string _classPath;
		private string _indexTemplet;
		private string _listTemplet;
		private string _archiveTemplet;
		private string _indexRule;
		private string _listRule;
		private string _archiveRule;
		private byte _classPage;
		private string _description;
		private byte _isHidden;
		private byte _isHtml;
		private byte _checkLevel;
		private byte _isContribute;
		private byte _isComment;
		private Int16 _readaccess;
		private byte _siteID;
		private DateTime _addDate;
		private string _relation;
		private Int16 _orderID;
		private string _imgUrl;
		private string _keywords;
		private string _crossID;
		private string _content;
		/// <summary>
		/// 栏目ID
		/// </summary>
		public int CID
		{
			set { _cID = value; }
			get { return _cID; }
		}
		/// <summary>
		/// 栏目父ID，默认0为顶级栏目
		/// </summary>
		public int ParentID
		{
			set { _parentID = value; }
			get { return _parentID; }
		}
		/// <summary>
		/// 栏目属性，1封面，2列表，3单页面，4链接地址
		/// </summary>
		public byte Attribute
		{
			set { _attribute = value; }
			get { return _attribute; }
		}
		/// <summary>
		/// 栏目名称
		/// </summary>
		public string ClassName
		{
			set { _className = value; }
			get { return _className; }
		}
		/// <summary>
		/// 栏目英文名称
		/// </summary>
		public string ClassEName
		{
			set { _classEName = value; }
			get { return _classEName; }
		}
		/// <summary>
		/// 栏目类型
		/// </summary>
		public byte ClassType
		{
			set { _classType = value; }
			get { return _classType; }
		}
		/// <summary>
		/// 栏目二级域名
		/// </summary>
		public string ClassDomain
		{
			set { _classDomain = value; }
			get { return _classDomain; }
		}
		/// <summary>
		/// 栏目目录，{#CmsPath}/Archive/
		/// </summary>
		public string ClassPath
		{
			set { _classPath = value; }
			get { return _classPath; }
		}
		/// <summary>
		/// 封面模版
		/// </summary>
		public string IndexTemplet
		{
			set { _indexTemplet = value; }
			get { return _indexTemplet; }
		}
		/// <summary>
		/// 列表模版
		/// </summary>
		public string ListTemplet
		{
			set { _listTemplet = value; }
			get { return _listTemplet; }
		}
		/// <summary>
		/// 文档模版
		/// </summary>
		public string ArchiveTemplet
		{
			set { _archiveTemplet = value; }
			get { return _archiveTemplet; }
		}
		/// <summary>
		/// 封面页规则
		/// </summary>
		public string IndexRule
		{
			set { _indexRule = value; }
			get { return _indexRule; }
		}
		/// <summary>
		/// 列表页规则，访问路径
		/// </summary>
		public string ListRule
		{
			set { _listRule = value; }
			get { return _listRule; }
		}
		/// <summary>
		/// 文档页规则，访问路径
		/// </summary>
		public string ArchiveRule
		{
			set { _archiveRule = value; }
			get { return _archiveRule; }
		}
		/// <summary>
		/// 栏目分页大小,列表条数
		/// </summary>
		public byte ClassPage
		{
			set { _classPage = value; }
			get { return _classPage; }
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
		public byte IsHidden
		{
			set { _isHidden = value; }
			get { return _isHidden; }
		}
		/// <summary>
		/// 是否允许生成静态页，1生成静态，0动态访问
		/// </summary>
		public byte IsHtml
		{
			set { _isHtml = value; }
			get { return _isHtml; }
		}
		/// <summary>
		/// 审核机制
		/// </summary>
		public byte CheckLevel
		{
			set { _checkLevel = value; }
			get { return _checkLevel; }
		}
		/// <summary>
		/// 是否允许投稿，1允许，0不允许
		/// </summary>
		public byte IsContribute
		{
			set { _isContribute = value; }
			get { return _isContribute; }
		}
		/// <summary>
		/// 本栏目文章是否允许评论，1允许，0不允许
		/// </summary>
		public byte IsComment
		{
			set { _isComment = value; }
			get { return _isComment; }
		}
		/// <summary>
		/// 阅读权限
		/// </summary>
		public Int16 Readaccess
		{
			set { _readaccess = value; }
			get { return _readaccess; }
		}
		/// <summary>
		/// 站点ID
		/// </summary>
		public byte SiteID
		{
			set { _siteID = value; }
			get { return _siteID; }
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set { _addDate = value; }
			get { return _addDate; }
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
		public Int16 OrderID
		{
			set { _orderID = value; }
			get { return _orderID; }
		}
		/// <summary>
		/// 栏目图片地址
		/// </summary>
		public string ImgUrl
		{
			set { _imgUrl = value; }
			get { return _imgUrl; }
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
			set { _crossID = value; }
			get { return _crossID; }
		}
		/// <summary>
		/// 栏目内容
		/// </summary>
		public string Content
		{
			set { _content = value; }
			get { return _content; }
		}
		#endregion
	}
}
