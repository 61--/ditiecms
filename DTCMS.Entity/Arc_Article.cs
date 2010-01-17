//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-9 0:23:01
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类 Arc_Article
	/// </summary>
	public class Arc_Article
	{
		public Arc_Article()
		{ }

		#region Model
		private int _id;
		private int _classID;
		private int _viceClassID;
		private string _title;
		private string _shortTitle;
		private string _titleStyle;
		private byte _titleFlag;
		private string _tags;
		private string _imgUrl;
		private string _author;
		private string _editor;
		private string _pubLisher;
		private string _source;
		private string _templet;
		private string _keywords;
		private string _description;
		private string _aContent;
		private int _click;
		private int _good;
		private int _bad;
		private Int16 _readaccess;
		private Int16 _money;
		private Int16 _attribute;
		private byte _isComment;
		private byte _isChecked;
		private byte _isRecycle;
		private byte _isRedirect;
		private byte _isHtml;
		private byte _isPaging;
		private string _filePath;
		private string _similarArticle;
		private DateTime _addDate;
		private DateTime _pubDate;
		private int _orderID;
		/// <summary>
		/// 文章ID
		/// </summary>
		public int ID
		{
			set { _id = value; }
			get { return _id; }
		}
		/// <summary>
		/// 栏目ID
		/// </summary>
		public int ClassID
		{
			set { _classID = value; }
			get { return _classID; }
		}
		/// <summary>
		/// 副栏目ID,-1没有副栏目
		/// </summary>
		public int ViceClassID
		{
			set { _viceClassID = value; }
			get { return _viceClassID; }
		}
		/// <summary>
		/// 文章标题
		/// </summary>
		public string Title
		{
			set { _title = value; }
			get { return _title; }
		}
		/// <summary>
		/// 文章缩略标题
		/// </summary>
		public string ShortTitle
		{
			set { _shortTitle = value; }
			get { return _shortTitle; }
		}
		/// <summary>
		/// 标题样式
		/// </summary>
		public string TitleStyle
		{
			set { _titleStyle = value; }
			get { return _titleStyle; }
		}
		/// <summary>
		/// 标题标签，如原创、转载
		/// </summary>
		public byte TitleFlag
		{
			set { _titleFlag = value; }
			get { return _titleFlag; }
		}
		/// <summary>
		/// 文章TAG
		/// </summary>
		public string Tags
		{
			set { _tags = value; }
			get { return _tags; }
		}
		/// <summary>
		/// 文章缩略图
		/// </summary>
		public string ImgUrl
		{
			set { _imgUrl = value; }
			get { return _imgUrl; }
		}
		/// <summary>
		/// 文章作者
		/// </summary>
		public string Author
		{
			set { _author = value; }
			get { return _author; }
		}
		/// <summary>
		/// 责任编辑
		/// </summary>
		public string Editor
		{
			set { _editor = value; }
			get { return _editor; }
		}
		/// <summary>
		/// 发布者
		/// </summary>
		public string PubLisher
		{
			set { _pubLisher = value; }
			get { return _pubLisher; }
		}
		/// <summary>
		/// 文章来源
		/// </summary>
		public string Source
		{
			set { _source = value; }
			get { return _source; }
		}
		/// <summary>
		/// 文章模版
		/// </summary>
		public string Templet
		{
			set { _templet = value; }
			get { return _templet; }
		}
		/// <summary>
		/// 关键字
		/// </summary>
		public string Keywords
		{
			set { _keywords = value; }
			get { return _keywords; }
		}
		/// <summary>
		/// 文章描述
		/// </summary>
		public string Description
		{
			set { _description = value; }
			get { return _description; }
		}
		/// <summary>
		/// 文章正文
		/// </summary>
		public string AContent
		{
			set { _aContent = value; }
			get { return _aContent; }
		}
		/// <summary>
		/// 文章点击
		/// </summary>
		public int Click
		{
			set { _click = value; }
			get { return _click; }
		}
		/// <summary>
		/// 顶
		/// </summary>
		public int Good
		{
			set { _good = value; }
			get { return _good; }
		}
		/// <summary>
		/// 踩
		/// </summary>
		public int Bad
		{
			set { _bad = value; }
			get { return _bad; }
		}
		/// <summary>
		/// 阅读权限，会员组
		/// </summary>
		public Int16 Readaccess
		{
			set { _readaccess = value; }
			get { return _readaccess; }
		}
		/// <summary>
		/// 消费点数
		/// </summary>
		public Int16 Money
		{
			set { _money = value; }
			get { return _money; }
		}
		/// <summary>
		/// 文章属性，1头条，2推荐，4图片，8灯幻，16滚动
		/// </summary>
		public Int16 Attribute
		{
			set { _attribute = value; }
			get { return _attribute; }
		}
		/// <summary>
		/// 是否允许评论，1允许，0不允许
		/// </summary>
		public byte IsComment
		{
			set { _isComment = value; }
			get { return _isComment; }
		}
		/// <summary>
		/// 是否审核，0未审核，1审核
		/// </summary>
		public byte IsChecked
		{
			set { _isChecked = value; }
			get { return _isChecked; }
		}
		/// <summary>
		/// 是否放入回收站，0正常，1回收站
		/// </summary>
		public byte IsRecycle
		{
			set { _isRecycle = value; }
			get { return _isRecycle; }
		}
		/// <summary>
		/// 是否跳转地址，1是，0否
		/// </summary>
		public byte IsRedirect
		{
			set { _isRedirect = value; }
			get { return _isRedirect; }
		}
		/// <summary>
		/// 是否生成静态页，1生成静态，0动态访问
		/// </summary>
		public byte IsHtml
		{
			set { _isHtml = value; }
			get { return _isHtml; }
		}
		/// <summary>
		/// 是否分页，1分页，0不分页
		/// </summary>
		public byte IsPaging
		{
			set { _isPaging = value; }
			get { return _isPaging; }
		}
		/// <summary>
		/// 存储路径
		/// </summary>
		public string FilePath
		{
			set { _filePath = value; }
			get { return _filePath; }
		}
		/// <summary>
		/// 相关文章
		/// </summary>
		public string SimilarArticle
		{
			set { _similarArticle = value; }
			get { return _similarArticle; }
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
		/// 发布时间
		/// </summary>
		public DateTime PubDate
		{
			set { _pubDate = value; }
			get { return _pubDate; }
		}
		/// <summary>
		/// 文章排序
		/// </summary>
		public int OrderID
		{
			set { _orderID = value; }
			get { return _orderID; }
		}
		#endregion

        //#region 栏目成员

        //private string _classname;
        ///// <summary>
        ///// 栏目名称
        ///// </summary>
        //public string ClassName
        //{
        //    set { _classname = value; }
        //    get { return  _classname; }
        //}

        //#endregion
    }
}
