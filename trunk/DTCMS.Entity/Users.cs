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
	/// 实体类 Users
	/// </summary>
	public class Users
	{
		public Users()
		{ }

		#region Model
		private int _uID;
		private string _userName;
		private string _nickName;
		private string _password;
		private string _secureQuestion;
		private string _secureAnswer;
		private byte _sex;
		private string _email;
		private int _roleID;
		private int _usergroupID;
		private string _registerIP;
		private DateTime _registerTime;
		private string _lastloginIP;
		private DateTime _lastloginTime;
		private int _loginCount;
		private int _postCount;
		private int _onlineTime;
		private int _credits;
		private double _extCredits1;
		private double _extCredits2;
		private double _extCredits3;
		private double _extCredits4;
		private double _extCredits5;
		private string _avatar;
		private DateTime _birthday;
		private int _pMCount;
		private byte _isVerify;
		private byte _isLock;
		/// <summary>
		/// 用户UID编号
		/// </summary>
		public int UID
		{
			set { _uID = value; }
			get { return _uID; }
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			set { _userName = value; }
			get { return _userName; }
		}
		/// <summary>
		/// 用户昵称
		/// </summary>
		public string NickName
		{
			set { _nickName = value; }
			get { return _nickName; }
		}
		/// <summary>
		/// Password
		/// </summary>
		public string Password
		{
			set { _password = value; }
			get { return _password; }
		}
		/// <summary>
		/// 安全提示问题
		/// </summary>
		public string SecureQuestion
		{
			set { _secureQuestion = value; }
			get { return _secureQuestion; }
		}
		/// <summary>
		/// 安全提示答案
		/// </summary>
		public string SecureAnswer
		{
			set { _secureAnswer = value; }
			get { return _secureAnswer; }
		}
		/// <summary>
		/// 性别
		/// </summary>
		public byte Sex
		{
			set { _sex = value; }
			get { return _sex; }
		}
		/// <summary>
		/// Email地址
		/// </summary>
		public string Email
		{
			set { _email = value; }
			get { return _email; }
		}
		/// <summary>
		/// 用户权限ID
		/// </summary>
		public int RoleID
		{
			set { _roleID = value; }
			get { return _roleID; }
		}
		/// <summary>
		/// 用户组ID
		/// </summary>
		public int UsergroupID
		{
			set { _usergroupID = value; }
			get { return _usergroupID; }
		}
		/// <summary>
		/// 注册IP
		/// </summary>
		public string RegisterIP
		{
			set { _registerIP = value; }
			get { return _registerIP; }
		}
		/// <summary>
		/// 注册时间
		/// </summary>
		public DateTime RegisterTime
		{
			set { _registerTime = value; }
			get { return _registerTime; }
		}
		/// <summary>
		/// 上次登陆IP
		/// </summary>
		public string LastloginIP
		{
			set { _lastloginIP = value; }
			get { return _lastloginIP; }
		}
		/// <summary>
		/// 上次登陆时间
		/// </summary>
		public DateTime LastloginTime
		{
			set { _lastloginTime = value; }
			get { return _lastloginTime; }
		}
		/// <summary>
		/// 登陆次数
		/// </summary>
		public int LoginCount
		{
			set { _loginCount = value; }
			get { return _loginCount; }
		}
		/// <summary>
		/// 发布文章数
		/// </summary>
		public int PostCount
		{
			set { _postCount = value; }
			get { return _postCount; }
		}
		/// <summary>
		/// 在线时间（单位：分钟）
		/// </summary>
		public int OnlineTime
		{
			set { _onlineTime = value; }
			get { return _onlineTime; }
		}
		/// <summary>
		/// 用户积分
		/// </summary>
		public int Credits
		{
			set { _credits = value; }
			get { return _credits; }
		}
		/// <summary>
		/// 扩展积分
		/// </summary>
		public double ExtCredits1
		{
			set { _extCredits1 = value; }
			get { return _extCredits1; }
		}
		/// <summary>
		/// 扩展积分2
		/// </summary>
		public double ExtCredits2
		{
			set { _extCredits2 = value; }
			get { return _extCredits2; }
		}
		/// <summary>
		/// 扩展积分3
		/// </summary>
		public double ExtCredits3
		{
			set { _extCredits3 = value; }
			get { return _extCredits3; }
		}
		/// <summary>
		/// 扩展积分4
		/// </summary>
		public double ExtCredits4
		{
			set { _extCredits4 = value; }
			get { return _extCredits4; }
		}
		/// <summary>
		/// 扩展积分
		/// </summary>
		public double ExtCredits5
		{
			set { _extCredits5 = value; }
			get { return _extCredits5; }
		}
		/// <summary>
		/// 用户头像
		/// </summary>
		public string Avatar
		{
			set { _avatar = value; }
			get { return _avatar; }
		}
		/// <summary>
		/// 生日
		/// </summary>
		public DateTime Birthday
		{
			set { _birthday = value; }
			get { return _birthday; }
		}
		/// <summary>
		/// 新短消息数
		/// </summary>
		public int PMCount
		{
			set { _pMCount = value; }
			get { return _pMCount; }
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
		/// 是否锁定
		/// </summary>
		public byte IsLock
		{
			set { _isLock = value; }
			get { return _isLock; }
		}
		#endregion
	}
}
