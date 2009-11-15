using System;
namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类DT_Arc_Article 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class Arc_Article
	{
        public Arc_Article()
		{ }
        #region Entity
        private int _id;
		private int _classid;
		private string _title;
		private string _shorttitle;
		private string _titlestyle;
		private string _tags;
		private string _imgurl;
		private string _author;
		private string _editor;
		private string _publisher;
		private string _source;
		private string _templet;
		private string _keywords;
		private string _description;
		private string _content;
		private int _click;
		private int _good;
		private int _bad;
		private int? _readaccess;
		private int? _money;
		private string _attribute;
		private int? _iscomment;
		private int _ischecked;
		private int _isrecycle;
		private int _isredirect;
		private int? _ishtml;
		private int? _ispaging;
		private string _filepath;
		private DateTime _adddate;
		private DateTime _pubdate;
		private int? _orderid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 栏目ID
		/// </summary>
		public int ClassID
		{
			set{ _classid=value;}
			get{return _classid;}
		}
		/// <summary>
		/// 文章标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 文章缩略标题
		/// </summary>
		public string ShortTitle
		{
			set{ _shorttitle=value;}
			get{return _shorttitle;}
		}
		/// <summary>
		/// 标题样式
		/// </summary>
		public string TitleStyle
		{
			set{ _titlestyle=value;}
			get{return _titlestyle;}
		}
		/// <summary>
		/// 文章TAG
		/// </summary>
		public string Tags
		{
			set{ _tags=value;}
			get{return _tags;}
		}
		/// <summary>
		/// 文章缩略图
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 文章作者
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 责任编辑
		/// </summary>
		public string Editor
		{
			set{ _editor=value;}
			get{return _editor;}
		}
		/// <summary>
		/// 发布者
		/// </summary>
		public string PubLisher
		{
			set{ _publisher=value;}
			get{return _publisher;}
		}
		/// <summary>
		/// 文章来源
		/// </summary>
		public string Source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 文章模版
		/// </summary>
		public string Templet
		{
			set{ _templet=value;}
			get{return _templet;}
		}
		/// <summary>
		/// 关键字
		/// </summary>
		public string Keywords
		{
			set{ _keywords=value;}
			get{return _keywords;}
		}
		/// <summary>
		/// 文章描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 文章正文
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 文章点击
		/// </summary>
		public int Click
		{
			set{ _click=value;}
			get{return _click;}
		}
		/// <summary>
		/// 顶
		/// </summary>
		public int Good
		{
			set{ _good=value;}
			get{return _good;}
		}
		/// <summary>
		/// 踩
		/// </summary>
		public int Bad
		{
			set{ _bad=value;}
			get{return _bad;}
		}
		/// <summary>
		/// 阅读权限，会员组
		/// </summary>
		public int? Readaccess
		{
			set{ _readaccess=value;}
			get{return _readaccess;}
		}
		/// <summary>
		/// 消费点数
		/// </summary>
		public int? Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 文章属性，h头条，c推荐，p图片，f灯幻，s滚动
		/// </summary>
		public string Attribute
		{
			set{ _attribute=value;}
			get{return _attribute;}
		}
		/// <summary>
		/// 是否允许评论，1允许，0不允许
		/// </summary>
		public int? IsComment
		{
			set{ _iscomment=value;}
			get{return _iscomment;}
		}
		/// <summary>
		/// 是否审核，0未审核，1审核
		/// </summary>
		public int IsChecked
		{
			set{ _ischecked=value;}
			get{return _ischecked;}
		}
		/// <summary>
		/// 是否放入回收站，0正常，1回收站
		/// </summary>
		public int IsRecycle
		{
			set{ _isrecycle=value;}
			get{return _isrecycle;}
		}
		/// <summary>
		/// 是否跳转地址，1是，0否
		/// </summary>
		public int IsRedirect
		{
			set{ _isredirect=value;}
			get{return _isredirect;}
		}
		/// <summary>
		/// 是否生成静态页，1生成静态，0动态访问
		/// </summary>
		public int? IsHtml
		{
			set{ _ishtml=value;}
			get{return _ishtml;}
		}
		/// <summary>
		/// 是否分页
		/// </summary>
		public int? IsPaging
		{
			set{ _ispaging=value;}
			get{return _ispaging;}
		}
		/// <summary>
		/// 存储路径
		/// </summary>
		public string FilePath
		{
			set{ _filepath=value;}
			get{return _filepath;}
		}
		/// <summary>
		/// 添加时间
		/// </summary>
		public DateTime AddDate
		{
			set{ _adddate=value;}
			get{return _adddate;}
		}
		/// <summary>
		/// 发布时间
		/// </summary>
		public DateTime PubDate
		{
			set{ _pubdate=value;}
			get{return _pubdate;}
		}
		/// <summary>
		/// 文章排序
		/// </summary>
		public int? OrderID
		{
			set{ _orderid=value;}
			get{return _orderid;}
        }
        #endregion Entity

    }
}

