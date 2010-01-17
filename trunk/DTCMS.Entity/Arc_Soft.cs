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
	/// 实体类 Arc_Soft
	/// </summary>
	public class Arc_Soft
	{
		public Arc_Soft()
		{ }

		#region Model
		private int _aid;

		/// <summary>
		/// AID
		/// </summary>
		public int AID
		{
			set { _aid = value; }
			get { return _aid; }
		}
		#endregion
	}
}
