﻿//------------------------------------------------------------------------------
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
	/// 接口层 ISYS_Template
	/// </summary>
	public interface IDAL_SYS_Template
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(SYS_Template model);

		/// <summary>
		/// 更新一条数据
		/// </summary>
		int Update(SYS_Template model);

		/// <summary>
		/// 删除一条数据
		/// </summary>
		int Delete(int TemplateID);

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int TemplateID);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		SYS_Template GetModel(int TemplateID);

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		List<SYS_Template> GetList(out long count);

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		List<SYS_Template> GetPageList(int pageSize, int pageIndex, out long count);
	}
}
