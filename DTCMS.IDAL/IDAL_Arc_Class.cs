//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-7 23:34:18
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
	/// <summary>
	/// 接口层 IArc_Class
	/// </summary>
	public interface IDAL_Arc_Class
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Arc_Class model);

		/// <summary>
		/// 更新一条数据
		/// </summary>
		int Update(Arc_Class model);

		/// <summary>
		/// 删除一条数据
		/// </summary>
		int Delete(int CID);

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int CID);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Arc_Class GetModel(int CID);

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		List<Arc_Class> GetList(out long count);

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		List<Arc_Class> GetPageList(int pageSize, int pageIndex, out long count);
	}
}
