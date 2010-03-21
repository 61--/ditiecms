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
	/// 接口层 IArc_Article
	/// </summary>
    public interface IDAL_Arc_Article : IDAL_Base
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Arc_Article model);

		/// <summary>
		/// 更新一条数据
		/// </summary>
		int Update(Arc_Article model);

		/// <summary>
		/// 删除一条数据
		/// </summary>
		int Delete(int ID);

        /// <summary>
        /// 批量删除文章
        /// </summary>
        int Delete(string ID);

        /// <summary>
        /// 批量审核文章
        /// </summary>
        int VerifyArticle(string ID);

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int ID, string filedName, string filedValue);

        /// <summary>
        /// 根据栏目ID判断此栏目是否存在文章
        /// </summary>
        bool ExistAtricleToClass(int CID);
       

        /// <summary>
        /// 判断文章是否已经存在
        /// </summary>
        bool ExistsArticleName(int ArticleID, string Title);
        
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Arc_Article GetModel(int ID);

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）
        /// </summary>
        object GetSingle(string filed, string where);

        /// <summary>
        /// 字符串缓存实现的通用分页存储过程
        /// </summary>
        DataTable GetPageList(string fieldKey, int pageCurrent, int pageSize
            , string fieldShow, string fieldOrder, string where, out int pageCount);

        /// <summary>
        /// 根据查询字段获取列表
        /// </summary>
        DataTable GetDataTable(string fileds, string where);

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		List<Arc_Article> GetList(out int count);

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		List<Arc_Article> GetPageList(int pageSize, int pageIndex, out int count);
        
	}
}
