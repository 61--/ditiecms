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
	/// 模块操作方法权限实体类
	/// </summary>
	public class ModuleControl
	{
		public ModuleControl()
		{ }

		#region Model
		private int _id;
		private string _controlName;
		private int _moduleID;
		private int _controlValue;
		private int _orderID;
		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			set { _id = value; }
			get { return _id; }
		}
		/// <summary>
		/// 操作名字
		/// </summary>
		public string ControlName
		{
			set { _controlName = value; }
			get { return _controlName; }
		}
		/// <summary>
		/// 模块ID
		/// </summary>
		public int ModuleID
		{
			set { _moduleID = value; }
			get { return _moduleID; }
		}
		/// <summary>
		/// 操作值
		/// </summary>
		public int ControlValue
		{
			set { _controlValue = value; }
			get { return _controlValue; }
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int OrderID
		{
			set { _orderID = value; }
			get { return _orderID; }
		}
		#endregion
	}
}
