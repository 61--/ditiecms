//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-8 11:52:52
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
	/// 接口层 IModuleControl
	/// </summary>
	public interface IDAL_ModuleControl
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(ModuleControl model);

		/// <summary>
		/// 更新一条数据
		/// </summary>
		int Update(ModuleControl model);

		/// <summary>
		/// 删除一条数据
		/// </summary>
		int Delete(int ID);

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int ID);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		ModuleControl GetModel(int ID);

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		List<ModuleControl> GetList(out long count);

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		List<ModuleControl> GetPageList(int pageSize, int pageIndex, out long count);
	}
}
