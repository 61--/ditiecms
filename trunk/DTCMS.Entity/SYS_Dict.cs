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
	/// 实体类 Sys_Dict
	/// </summary>
	public class Sys_Dict
	{
		public Sys_Dict()
		{ }

		#region Model
		private int _iD;
		private string _type;
		private string _title;
		private string _url;
		private string _email;
		private int _click;
		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			set { _iD = value; }
			get { return _iD; }
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string Type
		{
			set { _type = value; }
			get { return _type; }
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			set { _title = value; }
			get { return _title; }
		}
		/// <summary>
		/// Url
		/// </summary>
		public string Url
		{
			set { _url = value; }
			get { return _url; }
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
		/// 点击数
		/// </summary>
		public int Click
		{
			set { _click = value; }
			get { return _click; }
		}
		#endregion
	}
}
