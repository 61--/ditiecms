using System;

namespace Tuan.Entity
{
	/// <summary>
	/// 实体类 TuanSite
	/// </summary>
	public class TuanSite
	{
		public TuanSite()
		{ }

		#region Model
		private int _siteID;
		private int _userID;
		private int _cityID;
		private string _siteUrl;
		private string _logoUrl;
		private string _apiUrl;
		private string _siteName;
		private string _description;
		private DateTime _openDate;
		private int _categoryID;
		private int _tuanCount;
		private int _commentCount;
		private int _clickCount;
		private string _master;
		private string _contactPerson;
		private string _phone;
		private string _email;
		private string _qQ;
		private byte _apiTypeID;
		private byte _siteType;
		private byte _rank;
		private byte _trust;
		private byte _isVerify;
		private DateTime _addDate;
		private int _orderID;

		/// <summary>
		/// 团购网站ID
		/// </summary>
		public int SiteID
		{
			set { _siteID = value; }
			get { return _siteID; }
		}
		/// <summary>
		/// 用户ID
		/// </summary>
		public int UserID
		{
			set { _userID = value; }
			get { return _userID; }
		}
		/// <summary>
		/// 所在城市
		/// </summary>
		public int CityID
		{
			set { _cityID = value; }
			get { return _cityID; }
		}
		/// <summary>
		/// SiteUrl
		/// </summary>
		public string SiteUrl
		{
			set { _siteUrl = value; }
			get { return _siteUrl; }
		}
		/// <summary>
		/// LogoUrl
		/// </summary>
		public string LogoUrl
		{
			set { _logoUrl = value; }
			get { return _logoUrl; }
		}
		/// <summary>
		/// ApiUrl
		/// </summary>
		public string ApiUrl
		{
			set { _apiUrl = value; }
			get { return _apiUrl; }
		}
		/// <summary>
		/// 团购网站名
		/// </summary>
		public string SiteName
		{
			set { _siteName = value; }
			get { return _siteName; }
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			set { _description = value; }
			get { return _description; }
		}
		/// <summary>
		/// 开团日期
		/// </summary>
		public DateTime OpenDate
		{
			set { _openDate = value; }
			get { return _openDate; }
		}
		/// <summary>
		/// 分类ID
		/// </summary>
		public int CategoryID
		{
			set { _categoryID = value; }
			get { return _categoryID; }
		}
		/// <summary>
		/// 开团次数
		/// </summary>
		public int TuanCount
		{
			set { _tuanCount = value; }
			get { return _tuanCount; }
		}
		/// <summary>
		/// CommentCount
		/// </summary>
		public int CommentCount
		{
			set { _commentCount = value; }
			get { return _commentCount; }
		}
		/// <summary>
		/// ClickCount
		/// </summary>
		public int ClickCount
		{
			set { _clickCount = value; }
			get { return _clickCount; }
		}
		/// <summary>
		/// 网站创始人
		/// </summary>
		public string Master
		{
			set { _master = value; }
			get { return _master; }
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string ContactPerson
		{
			set { _contactPerson = value; }
			get { return _contactPerson; }
		}
		/// <summary>
		/// Phone
		/// </summary>
		public string Phone
		{
			set { _phone = value; }
			get { return _phone; }
		}
		/// <summary>
		/// Email
		/// </summary>
		public string Email
		{
			set { _email = value; }
			get { return _email; }
		}
		/// <summary>
		/// QQ
		/// </summary>
		public string QQ
		{
			set { _qQ = value; }
			get { return _qQ; }
		}
		/// <summary>
		/// ApiTypeID
		/// </summary>
		public byte ApiTypeID
		{
			set { _apiTypeID = value; }
			get { return _apiTypeID; }
		}
		/// <summary>
		/// 站点类型，1公司，0个人
		/// </summary>
		public byte SiteType
		{
			set { _siteType = value; }
			get { return _siteType; }
		}
		/// <summary>
		/// 等级
		/// </summary>
		public byte Rank
		{
			set { _rank = value; }
			get { return _rank; }
		}
		/// <summary>
		/// 信任度
		/// </summary>
		public byte Trust
		{
			set { _trust = value; }
			get { return _trust; }
		}
		/// <summary>
		/// 是否审核
		/// </summary>
		public byte IsVerify
		{
			set { _isVerify = value; }
			get { return _isVerify; }
		}
		/// <summary>
		/// AddDate
		/// </summary>
		public DateTime AddDate
		{
			set { _addDate = value; }
			get { return _addDate; }
		}
		/// <summary>
		/// OrderID
		/// </summary>
		public int OrderID
		{
			set { _orderID = value; }
			get { return _orderID; }
		}
		#endregion
	}
}
