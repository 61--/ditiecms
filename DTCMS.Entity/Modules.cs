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
	/// 实体类 Modules
	/// </summary>
	public class Modules
	{
		public Modules()
		{ }

		#region Model
		private int _iD;
		private string _moduleID;
		private string _parentID;
		private string _name;
		private string _eName;
		private byte _moduleDepth;
		private string _moduleURL;
		private string _target;
		private string _description;
		private DateTime _createTime;
		private byte _isQuickMenu;
		private byte _isSystem;
		private byte _isEnable;
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
		/// ModuleID
		/// </summary>
		public string ModuleID
		{
			set { _moduleID = value; }
			get { return _moduleID; }
		}
		/// <summary>
		/// ParentID
		/// </summary>
		public string ParentID
		{
			set { _parentID = value; }
			get { return _parentID; }
		}
		/// <summary>
		/// Name
		/// </summary>
		public string Name
		{
			set { _name = value; }
			get { return _name; }
		}
		/// <summary>
		/// EName
		/// </summary>
		public string EName
		{
			set { _eName = value; }
			get { return _eName; }
		}
		/// <summary>
		/// ModuleDepth
		/// </summary>
		public byte ModuleDepth
		{
			set { _moduleDepth = value; }
			get { return _moduleDepth; }
		}
		/// <summary>
		/// ModuleURL
		/// </summary>
		public string ModuleURL
		{
			set { _moduleURL = value; }
			get { return _moduleURL; }
		}
		/// <summary>
		/// Target
		/// </summary>
		public string Target
		{
			set { _target = value; }
			get { return _target; }
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
		/// CreateTime
		/// </summary>
		public DateTime CreateTime
		{
			set { _createTime = value; }
			get { return _createTime; }
		}
		/// <summary>
		/// IsQuickMenu
		/// </summary>
		public byte IsQuickMenu
		{
			set { _isQuickMenu = value; }
			get { return _isQuickMenu; }
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
		/// IsEnable
		/// </summary>
		public byte IsEnable
		{
			set { _isEnable = value; }
			get { return _isEnable; }
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
