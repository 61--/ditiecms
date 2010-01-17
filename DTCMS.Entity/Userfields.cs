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
	/// 用户扩展信息实体类
	/// </summary>
	public class Userfields
	{
		public Userfields()
		{ }

		#region Model
		private int _uid;
		private string _realname;
		private string _qQ;
		private string _mSN;
		private string _skype;
		private string _phone;
		private string _mobilephone;
		private string _location;
		private string _adress;
		private string _iDcard;
		private string _signature;
		private string _introduce;
		private string _website;
		/// <summary>
		/// 用户ID，user表外键
		/// </summary>
		public int UID
		{
			set { _uid = value; }
			get { return _uid; }
		}
		/// <summary>
		/// 真实姓名
		/// </summary>
		public string Realname
		{
			set { _realname = value; }
			get { return _realname; }
		}
		/// <summary>
		/// QQ号码，支持Email帐号
		/// </summary>
		public string QQ
		{
			set { _qQ = value; }
			get { return _qQ; }
		}
		/// <summary>
		/// MSN帐号
		/// </summary>
		public string MSN
		{
			set { _mSN = value; }
			get { return _mSN; }
		}
		/// <summary>
		/// Skype帐号
		/// </summary>
		public string Skype
		{
			set { _skype = value; }
			get { return _skype; }
		}
		/// <summary>
		/// 固定电话
		/// </summary>
		public string Phone
		{
			set { _phone = value; }
			get { return _phone; }
		}
		/// <summary>
		/// Mobilephone
		/// </summary>
		public string Mobilephone
		{
			set { _mobilephone = value; }
			get { return _mobilephone; }
		}
		/// <summary>
		/// Location
		/// </summary>
		public string Location
		{
			set { _location = value; }
			get { return _location; }
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Adress
		{
			set { _adress = value; }
			get { return _adress; }
		}
		/// <summary>
		/// 身份证
		/// </summary>
		public string IDcard
		{
			set { _iDcard = value; }
			get { return _iDcard; }
		}
		/// <summary>
		/// 个性签名
		/// </summary>
		public string Signature
		{
			set { _signature = value; }
			get { return _signature; }
		}
		/// <summary>
		/// 个人简介
		/// </summary>
		public string Introduce
		{
			set { _introduce = value; }
			get { return _introduce; }
		}
		/// <summary>
		/// 个人网站
		/// </summary>
		public string Website
		{
			set { _website = value; }
			get { return _website; }
		}
		#endregion
	}
}
