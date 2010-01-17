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
	/// 系统模块实体类
	/// </summary>
	public class Modules
	{
		public Modules()
		{ }

		#region Model
		private int _id;
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
			set { _id = value; }
			get { return _id; }
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
		/// 模块父ID
		/// </summary>
		public string ParentID
		{
			set { _parentID = value; }
			get { return _parentID; }
		}
		/// <summary>
		/// 模块名称
		/// </summary>
		public string Name
		{
			set { _name = value; }
			get { return _name; }
		}
		/// <summary>
		/// 模块英文名
		/// </summary>
		public string EName
		{
			set { _eName = value; }
			get { return _eName; }
		}
		/// <summary>
		/// 模块深度，1为顶级模块分类
		/// </summary>
		public byte ModuleDepth
		{
			set { _moduleDepth = value; }
			get { return _moduleDepth; }
		}
		/// <summary>
		/// 模块URL地址
		/// </summary>
		public string ModuleURL
		{
			set { _moduleURL = value; }
			get { return _moduleURL; }
		}
		/// <summary>
		/// 页面打开方式
		/// </summary>
		public string Target
		{
			set { _target = value; }
			get { return _target; }
		}
		/// <summary>
		/// 模块说明
		/// </summary>
		public string Description
		{
			set { _description = value; }
			get { return _description; }
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			set { _createTime = value; }
			get { return _createTime; }
		}
		/// <summary>
		/// 是否添加到快捷菜单
		/// </summary>
		public byte IsQuickMenu
		{
			set { _isQuickMenu = value; }
			get { return _isQuickMenu; }
		}
		/// <summary>
		/// 是否系统导航
		/// </summary>
		public byte IsSystem
		{
			set { _isSystem = value; }
			get { return _isSystem; }
		}
		/// <summary>
		/// 是否应用
		/// </summary>
		public byte IsEnable
		{
			set { _isEnable = value; }
			get { return _isEnable; }
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
