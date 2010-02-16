//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-09 0:23:01
// 功能描述: 
// 修改标识: LinPanxing 修改于2010-02-14 20:03:30
// 修改描述: 增加添加时间字段
//------------------------------------------------------------------------------
using System;

namespace DTCMS.Entity
{
	/// <summary>
	/// 用户角色实体类
	/// </summary>
	public class Roles
	{
		public Roles()
		{ }

		#region Model
		private int _id;
		private string _roleName;
		private string _description;
        private DateTime _addDate;
		private int _orderID;

		/// <summary>
		/// 角色ID
		/// </summary>
		public int ID
		{
			set { _id = value; }
			get { return _id; }
		}
		/// <summary>
		/// 角色名称
		/// </summary>
		public string RoleName
		{
			set { _roleName = value; }
			get { return _roleName; }
		}
		/// <summary>
		/// 角色描述
		/// </summary>
		public string Description
		{
			set { _description = value; }
			get { return _description; }
		}
        public DateTime AddDate
        {
            set { _addDate = value; }
            get { return _addDate; }
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
