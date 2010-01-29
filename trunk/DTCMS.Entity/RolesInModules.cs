//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-9 0:23:01
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;

namespace DTCMS.Entity
{
	/// <summary>
	/// 实体类 RolesInModules
	/// </summary>
	public class RolesInModules
	{
		public RolesInModules()
		{ }

		#region Model
		private int _id;
		private int _roleID;
		private string _moduleID;
		private int _controlValue;

		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			set { _id = value; }
			get { return _id; }
		}
		/// <summary>
		/// 角色ID
		/// </summary>
		public int RoleID
		{
			set { _roleID = value; }
			get { return _roleID; }
		}
		/// <summary>
		/// 模块ID
		/// </summary>
		public string ModuleID
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
		#endregion
	}
}
