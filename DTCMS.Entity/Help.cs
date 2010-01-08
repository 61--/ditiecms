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
	/// 实体类 Help
	/// </summary>
	public class Help
	{
		public Help()
		{ }

		#region Model
		private int _iD;
		private string _helpID;
		private string _pID;
		private string _title;
		private string _message;
		private int _orderID;
		/// <summary>
		/// ID，自增列
		/// </summary>
		public int ID
		{
			set { _iD = value; }
			get { return _iD; }
		}
		/// <summary>
		/// 帮助ID，例：H0201001
		/// </summary>
		public string HelpID
		{
			set { _helpID = value; }
			get { return _helpID; }
		}
		/// <summary>
		/// 帮助父ID
		/// </summary>
		public string PID
		{
			set { _pID = value; }
			get { return _pID; }
		}
		/// <summary>
		/// 帮助主题
		/// </summary>
		public string Title
		{
			set { _title = value; }
			get { return _title; }
		}
		/// <summary>
		/// 帮助信息
		/// </summary>
		public string Message
		{
			set { _message = value; }
			get { return _message; }
		}
		/// <summary>
		/// 帮助排序
		/// </summary>
		public int OrderID
		{
			set { _orderID = value; }
			get { return _orderID; }
		}
		#endregion
	}
}
