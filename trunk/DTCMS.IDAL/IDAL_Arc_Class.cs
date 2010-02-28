//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 19:36:36
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
    public interface IDAL_Arc_Class : IDAL_Base
	{
		/// <summary>
        /// 添加一条栏目
		/// </summary>
		/// <param name="model">栏目实体对象</param>
		/// <returns>返回影响行数</returns>
		int Add(Arc_Class model);

		/// <summary>
		/// 更新一个栏目
		/// </summary>
        /// <param name="model">栏目实体</param>
		/// <returns>返回影响行数</returns>
		int Update(Arc_Class model);

        /// <summary>
        /// 根据ID和值更新一条数据
        /// </summary>
        /// <param name="CID">栏目ID</param>
        /// <param name="value">更新值（filedName=filedValue）</param>
        /// <returns>返回影响行数</returns>
        int Update(int CID, string value);

		/// <summary>
		/// 删除一个栏目
		/// </summary>
        /// <param name="CID">栏目ID</param>
		/// <returns>返回影响行数</returns>
		int Delete(int CID);

        /// <summary>
        /// 批量删除栏目
        /// </summary>
        /// <param name="ID">栏目ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        int Delete(string CID);
       
		/// <summary>
		/// 是否存在该栏目记录
		/// </summary>
        /// <param name="CID">栏目ID</param>
		/// <param name="filedName">字段名称</param>
		/// <param name="filedValue">字段值</param>
		/// <returns>存在返回true，不存在返回false</returns>
		bool Exists(int CID, string filedName, string filedValue);

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）
        /// </summary>
        /// <param name="filed"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        object GetSingle(string filed, string where);

        /// <summary>
        /// 根据查询字段查询栏目数据
        /// </summary>
        /// <param name="Fileds">要查询的字段</param>
        /// <returns>DataTable数据集合</returns>
        DataTable GetDataTable(string Fileds, string where);

        /// <summary>
        /// 判断当前栏目是否存在子栏目
        /// </summary>
        /// <param name="ParentID">父栏目ID</param>
        /// <returns>存在返回true，不存在返回false</returns>
        bool ExistsChildNode(int CID);

		/// <summary>
		/// 得到一个栏目对象实体
		/// </summary>
		/// <param name="CID">栏目ID</param>
        /// <returns>栏目实体</returns>
		Arc_Class GetModel(int CID);

		/// <summary>
		/// 获取泛型栏目列表
		/// </summary>
		/// <param name="count">返回记录数</param>
        /// <returns>栏目泛型集合</returns>
		List<Arc_Class> GetList(out int count);

		/// <summary>
        /// 分页获取泛型栏目列表
		/// </summary>
		/// <param name="pageSize">分页大小</param>
		/// <param name="pageIndex">当前页数</param>
		/// <param name="count">返回记录总数</param>
		/// <returns>分页栏目泛型集合</returns>
		List<Arc_Class> GetPageList(int pageSize, int pageIndex, out int count);
	}
}
