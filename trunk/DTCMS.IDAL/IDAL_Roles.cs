//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 22:48:15
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
	/// 接口层 IRoles
	/// </summary>
    public interface IDAL_Roles : IDAL_Base
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Roles model);

		/// <summary>
		/// 更新一条数据
		/// </summary>
		int Update(Roles model);

		/// <summary>
		/// 根据ID和值更新一条数据
		/// </summary>
		int Update(int ID, string value);

		/// <summary>
		/// 删除一条数据
		/// </summary>
		int Delete(int ID);

        /// <summary>
        /// 批量删除角色
        /// </summary>
        int Delete(string UID);

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int ID, string filedName, string filedValue);

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Roles GetModel(int ID);

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）
        /// </summary>
        object GetSingle(string filed, string where);

		/// <summary>
		/// 根据查询字段获取列表
		/// </summary>
        DataTable GetDataTable(string fileds, string where, string sortValue);

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		List<Roles> GetList(out int count);
	}
}
