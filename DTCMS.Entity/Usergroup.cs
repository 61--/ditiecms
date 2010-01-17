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
	/// 用户组实体类
	/// </summary>
	public class Usergroup
	{
		public Usergroup()
		{ }

		#region Model
		private int _id;
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
		/// 用户组ID
		/// </summary>
		public int ID
		{
			set { _id = value; }
			get { return _id; }
		}
		/// <summary>
		/// 用户组类型，0系统组，1管理组，2用户组
		/// </summary>
		public byte Type
		{
			set { _type = value; }
			get { return _type; }
		}
		/// <summary>
		/// 是否系统内置组，系统内置组不能被删除
		/// </summary>
		public byte IsSystem
		{
			set { _isSystem = value; }
			get { return _isSystem; }
		}
		/// <summary>
		/// 用户组名
		/// </summary>
		public string GroupName
		{
			set { _groupName = value; }
			get { return _groupName; }
		}
		/// <summary>
		/// 用户组描述
		/// </summary>
		public string Description
		{
			set { _description = value; }
			get { return _description; }
		}
		/// <summary>
		/// 开始积分
		/// </summary>
		public int CreditBegin
		{
			set { _creditBegin = value; }
			get { return _creditBegin; }
		}
		/// <summary>
		/// 结束积分
		/// </summary>
		public int CreditEnd
		{
			set { _creditEnd = value; }
			get { return _creditEnd; }
		}
		/// <summary>
		/// 星星等级
		/// </summary>
		public byte stars
		{
			set { _stars = value; }
			get { return _stars; }
		}
		/// <summary>
		/// 用户组头像
		/// </summary>
		public string GroupAvatar
		{
			set { _groupAvatar = value; }
			get { return _groupAvatar; }
		}
		/// <summary>
		/// 阅读权限
		/// </summary>
		public int Readaccess
		{
			set { _readaccess = value; }
			get { return _readaccess; }
		}
		/// <summary>
		/// 允许发布文章，1允许，0不允许
		/// </summary>
		public byte AllowPost
		{
			set { _allowPost = value; }
			get { return _allowPost; }
		}
		/// <summary>
		/// 允许评论
		/// </summary>
		public byte AllowComment
		{
			set { _allowComment = value; }
			get { return _allowComment; }
		}
		/// <summary>
		/// 允许下载附件
		/// </summary>
		public byte AllowDownload
		{
			set { _allowDownload = value; }
			get { return _allowDownload; }
		}
		/// <summary>
		/// 允许使用头像，0不允许，1允许使用系统自带头像，2允许使用URL地址头像，3允许使用上传头像
		/// </summary>
		public byte AllowAvatar
		{
			set { _allowAvatar = value; }
			get { return _allowAvatar; }
		}
		/// <summary>
		/// 允许开通个人空间
		/// </summary>
		public byte AllowSpace
		{
			set { _allowSpace = value; }
			get { return _allowSpace; }
		}
		/// <summary>
		/// 允许积分转账
		/// </summary>
		public byte AllowTransfer
		{
			set { _allowTransfer = value; }
			get { return _allowTransfer; }
		}
		/// <summary>
		/// 允许查看其他用户资料
		/// </summary>
		public byte AllowViewInfo
		{
			set { _allowViewInfo = value; }
			get { return _allowViewInfo; }
		}
		/// <summary>
		/// 允许使用昵称
		/// </summary>
		public byte AllowNickname
		{
			set { _allowNickname = value; }
			get { return _allowNickname; }
		}
		/// <summary>
		/// 短消息最大条数
		/// </summary>
		public Int16 MaxPMNum
		{
			set { _maxPMNum = value; }
			get { return _maxPMNum; }
		}
		/// <summary>
		/// 签名最大字节数
		/// </summary>
		public Int16 MaxSignSize
		{
			set { _maxSignSize = value; }
			get { return _maxSignSize; }
		}
		/// <summary>
		/// 附件最大尺寸
		/// </summary>
		public int MaxAttachSize
		{
			set { _maxAttachSize = value; }
			get { return _maxAttachSize; }
		}
		/// <summary>
		/// 附件最大总尺寸
		/// </summary>
		public int MaxAttachTotalSize
		{
			set { _maxAttachTotalSize = value; }
			get { return _maxAttachTotalSize; }
		}
		/// <summary>
		/// 允许上传附件类型，例：.txt,.rar,.jpg
		/// </summary>
		public string AttachExtension
		{
			set { _attachExtension = value; }
			get { return _attachExtension; }
		}
		/// <summary>
		/// 用户组排序
		/// </summary>
		public int OrderID
		{
			set { _orderID = value; }
			get { return _orderID; }
		}
		#endregion
	}
}
