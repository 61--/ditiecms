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
	/// 实体类 ModuleControl
	/// </summary>
	public class ModuleControl
	{
		public ModuleControl()
		{ }

		#region Model
		private int _iD;
		private string _controlName;
		private int _moduleID;
		private int _controlValue;
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
		/// ControlName
		/// </summary>
		public string ControlName
		{
			set { _controlName = value; }
			get { return _controlName; }
		}
		/// <summary>
		/// ModuleID
		/// </summary>
		public int ModuleID
		{
			set { _moduleID = value; }
			get { return _moduleID; }
		}
		/// <summary>
		/// ControlValue
		/// </summary>
		public int ControlValue
		{
			set { _controlValue = value; }
			get { return _controlValue; }
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
