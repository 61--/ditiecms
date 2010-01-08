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
	/// 实体类 Usergroup
	/// </summary>
	public class Usergroup
	{
		public Usergroup()
		{ }

		#region Model
		private int _iD;
		private byte _type;
		private byte _isSystem;
		private string _groupName;
		private string _description;
		private int _creditBegin;
		private int _creditEnd;
		private byte _stars;
		private string _groupAvatar;
		private int _readaccess;
		private byte _allowPost;
		private byte _allowComment;
		private byte _allowDownload;
		private byte _allowAvatar;
		private byte _allowSpace;
		private byte _allowTransfer;
		private byte _allowViewInfo;
		private byte _allowNickname;
		private Int16 _maxPMNum;
		private Int16 _maxSignSize;
		private int _maxAttachSize;
		private int _maxAttachTotalSize;
		private string _attachExtension;
		private int _orderID;
		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			set { _iD = value; }
			get { return _iD; }
		}
		/// <summary>
		/// Type
		/// </summary>
		public byte Type
		{
			set { _type = value; }
			get { return _type; }
		}
		/// <summary>
		/// IsSystem
		/// </summary>
		public byte IsSystem
		{
			set { _isSystem = value; }
			get { return _isSystem; }
		}
		/// <summary>
		/// GroupName
		/// </summary>
		public string GroupName
		{
			set { _groupName = value; }
			get { return _groupName; }
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
		/// CreditBegin
		/// </summary>
		public int CreditBegin
		{
			set { _creditBegin = value; }
			get { return _creditBegin; }
		}
		/// <summary>
		/// CreditEnd
		/// </summary>
		public int CreditEnd
		{
			set { _creditEnd = value; }
			get { return _creditEnd; }
		}
		/// <summary>
		/// stars
		/// </summary>
		public byte stars
		{
			set { _stars = value; }
			get { return _stars; }
		}
		/// <summary>
		/// GroupAvatar
		/// </summary>
		public string GroupAvatar
		{
			set { _groupAvatar = value; }
			get { return _groupAvatar; }
		}
		/// <summary>
		/// Readaccess
		/// </summary>
		public int Readaccess
		{
			set { _readaccess = value; }
			get { return _readaccess; }
		}
		/// <summary>
		/// AllowPost
		/// </summary>
		public byte AllowPost
		{
			set { _allowPost = value; }
			get { return _allowPost; }
		}
		/// <summary>
		/// AllowComment
		/// </summary>
		public byte AllowComment
		{
			set { _allowComment = value; }
			get { return _allowComment; }
		}
		/// <summary>
		/// AllowDownload
		/// </summary>
		public byte AllowDownload
		{
			set { _allowDownload = value; }
			get { return _allowDownload; }
		}
		/// <summary>
		/// AllowAvatar
		/// </summary>
		public byte AllowAvatar
		{
			set { _allowAvatar = value; }
			get { return _allowAvatar; }
		}
		/// <summary>
		/// AllowSpace
		/// </summary>
		public byte AllowSpace
		{
			set { _allowSpace = value; }
			get { return _allowSpace; }
		}
		/// <summary>
		/// AllowTransfer
		/// </summary>
		public byte AllowTransfer
		{
			set { _allowTransfer = value; }
			get { return _allowTransfer; }
		}
		/// <summary>
		/// AllowViewInfo
		/// </summary>
		public byte AllowViewInfo
		{
			set { _allowViewInfo = value; }
			get { return _allowViewInfo; }
		}
		/// <summary>
		/// AllowNickname
		/// </summary>
		public byte AllowNickname
		{
			set { _allowNickname = value; }
			get { return _allowNickname; }
		}
		/// <summary>
		/// MaxPMNum
		/// </summary>
		public Int16 MaxPMNum
		{
			set { _maxPMNum = value; }
			get { return _maxPMNum; }
		}
		/// <summary>
		/// MaxSignSize
		/// </summary>
		public Int16 MaxSignSize
		{
			set { _maxSignSize = value; }
			get { return _maxSignSize; }
		}
		/// <summary>
		/// MaxAttachSize
		/// </summary>
		public int MaxAttachSize
		{
			set { _maxAttachSize = value; }
			get { return _maxAttachSize; }
		}
		/// <summary>
		/// MaxAttachTotalSize
		/// </summary>
		public int MaxAttachTotalSize
		{
			set { _maxAttachTotalSize = value; }
			get { return _maxAttachTotalSize; }
		}
		/// <summary>
		/// AttachExtension
		/// </summary>
		public string AttachExtension
		{
			set { _attachExtension = value; }
			get { return _attachExtension; }
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
