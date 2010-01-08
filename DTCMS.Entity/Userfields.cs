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
	/// 实体类 Userfields
	/// </summary>
	public class Userfields
	{
		public Userfields()
		{ }

		#region Model
		private int _uID;
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
		/// UID
		/// </summary>
		public int UID
		{
			set { _uID = value; }
			get { return _uID; }
		}
		/// <summary>
		/// Realname
		/// </summary>
		public string Realname
		{
			set { _realname = value; }
			get { return _realname; }
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
		/// MSN
		/// </summary>
		public string MSN
		{
			set { _mSN = value; }
			get { return _mSN; }
		}
		/// <summary>
		/// Skype
		/// </summary>
		public string Skype
		{
			set { _skype = value; }
			get { return _skype; }
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
		/// Adress
		/// </summary>
		public string Adress
		{
			set { _adress = value; }
			get { return _adress; }
		}
		/// <summary>
		/// IDcard
		/// </summary>
		public string IDcard
		{
			set { _iDcard = value; }
			get { return _iDcard; }
		}
		/// <summary>
		/// Signature
		/// </summary>
		public string Signature
		{
			set { _signature = value; }
			get { return _signature; }
		}
		/// <summary>
		/// Introduce
		/// </summary>
		public string Introduce
		{
			set { _introduce = value; }
			get { return _introduce; }
		}
		/// <summary>
		/// Website
		/// </summary>
		public string Website
		{
			set { _website = value; }
			get { return _website; }
		}
		#endregion
	}
}
