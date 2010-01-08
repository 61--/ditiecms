//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-8 11:52:52
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
		private string _classContent;
		/// <summary>
		/// CID
		/// </summary>
		public int CID
		{
			set { _cID = value; }
			get { return _cID; }
		}
		/// <summary>
		/// ParentID
		/// </summary>
		public int ParentID
		{
			set { _parentID = value; }
			get { return _parentID; }
		}
		/// <summary>
		/// Attribute
		/// </summary>
		public byte Attribute
		{
			set { _attribute = value; }
			get { return _attribute; }
		}
		/// <summary>
		/// ClassName
		/// </summary>
		public string ClassName
		{
			set { _className = value; }
			get { return _className; }
		}
		/// <summary>
		/// ClassEName
		/// </summary>
		public string ClassEName
		{
			set { _classEName = value; }
			get { return _classEName; }
		}
		/// <summary>
		/// ClassType
		/// </summary>
		public byte ClassType
		{
			set { _classType = value; }
			get { return _classType; }
		}
		/// <summary>
		/// ClassDomain
		/// </summary>
		public string ClassDomain
		{
			set { _classDomain = value; }
			get { return _classDomain; }
		}
		/// <summary>
		/// ClassPath
		/// </summary>
		public string ClassPath
		{
			set { _classPath = value; }
			get { return _classPath; }
		}
		/// <summary>
		/// IndexTemplet
		/// </summary>
		public string IndexTemplet
		{
			set { _indexTemplet = value; }
			get { return _indexTemplet; }
		}
		/// <summary>
		/// ListTemplet
		/// </summary>
		public string ListTemplet
		{
			set { _listTemplet = value; }
			get { return _listTemplet; }
		}
		/// <summary>
		/// ArchiveTemplet
		/// </summary>
		public string ArchiveTemplet
		{
			set { _archiveTemplet = value; }
			get { return _archiveTemplet; }
		}
		/// <summary>
		/// IndexRule
		/// </summary>
		public string IndexRule
		{
			set { _indexRule = value; }
			get { return _indexRule; }
		}
		/// <summary>
		/// ListRule
		/// </summary>
		public string ListRule
		{
			set { _listRule = value; }
			get { return _listRule; }
		}
		/// <summary>
		/// ArchiveRule
		/// </summary>
		public string ArchiveRule
		{
			set { _archiveRule = value; }
			get { return _archiveRule; }
		}
		/// <summary>
		/// ClassPage
		/// </summary>
		public byte ClassPage
		{
			set { _classPage = value; }
			get { return _classPage; }
		}
		/// <summary>
		/// Description
		/// </summary>
		public string Description
		{
			set { _description = value; }
			get { return _description; }
		}
		/// <summary>
		/// IsHidden
		/// </summary>
		public byte IsHidden
		{
			set { _isHidden = value; }
			get { return _isHidden; }
		}
		/// <summary>
		/// IsHtml
		/// </summary>
		public byte IsHtml
		{
			set { _isHtml = value; }
			get { return _isHtml; }
		}
		/// <summary>
		/// CheckLevel
		/// </summary>
		public byte CheckLevel
		{
			set { _checkLevel = value; }
			get { return _checkLevel; }
		}
		/// <summary>
		/// IsContribute
		/// </summary>
		public byte IsContribute
		{
			set { _isContribute = value; }
			get { return _isContribute; }
		}
		/// <summary>
		/// IsComment
		/// </summary>
		public byte IsComment
		{
			set { _isComment = value; }
			get { return _isComment; }
		}
		/// <summary>
		/// Readaccess
		/// </summary>
		public Int16 Readaccess
		{
			set { _readaccess = value; }
			get { return _readaccess; }
		}
		/// <summary>
		/// SiteID
		/// </summary>
		public byte SiteID
		{
			set { _siteID = value; }
			get { return _siteID; }
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
		/// Relation
		/// </summary>
		public string Relation
		{
			set { _relation = value; }
			get { return _relation; }
		}
		/// <summary>
		/// OrderID
		/// </summary>
		public Int16 OrderID
		{
			set { _orderID = value; }
			get { return _orderID; }
		}
		/// <summary>
		/// ImgUrl
		/// </summary>
		public string ImgUrl
		{
			set { _imgUrl = value; }
			get { return _imgUrl; }
		}
		/// <summary>
		/// Keywords
		/// </summary>
		public string Keywords
		{
			set { _keywords = value; }
			get { return _keywords; }
		}
		/// <summary>
		/// CrossID
		/// </summary>
		public string CrossID
		{
			set { _crossID = value; }
			get { return _crossID; }
		}
		/// <summary>
		/// ClassContent
		/// </summary>
		public string ClassContent
		{
			set { _classContent = value; }
			get { return _classContent; }
		}
		#endregion
	}
}
