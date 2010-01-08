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
	/// 接口层 IArc_Article
	/// </summary>
	public interface IDAL_Arc_Article
	{
        #region  成员方法

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        bool Exists(int CID, string filedName, string filedValue);

        /// <summary>
        /// 增加一篇文章
        /// </summary>
        int Add(Arc_Article model);

        /// <summary>
        /// 更新一篇文章
        /// </summary>
        int Update(Arc_Article model);

        /// <summary>
        /// 删除一篇文章
        /// </summary>
        int Delete(int id);

        /// <summary>
        /// 批量删除文章
        /// </summary>
        int Delete(string ID);

        /// <summary>
        /// 获取一篇文章实体
        /// </summary>
        Arc_Article GetModel(int ID);

        /// <summary>
        /// 根据栏目id 判断此栏目是否存在文章
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>true存在,false不存在</returns>
        bool ExistAtricleToClass(int CID);

        /// <summary>
        /// 判断文章是否已经存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        bool ExistsArticleName(int ArticleID, string Title);

        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        List<Arc_Article> GetList(out long count);

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        List<Arc_Article> GetPageList(int pageSize, int pageIndex, out long count);
        #endregion  成员方法

        #region 基方法
        /// <summary>
        /// 字符串缓存实现的通用分页存储过程
        /// </summary>
        /// <param name="tbname">要分页显示的表名，可以使用表联合  </param>
        /// <param name="FieldKey">用于定位记录的主键(惟一键)字段,只能是单个字段  </param>
        /// <param name="PageCurrent">要显示的页码  </param>
        /// <param name="PageSize">每页的大小(记录数)  </param>
        /// <param name="FieldShow">以逗号分隔的要显示的字段列表,如果不指定,则显示所有字段  </param>
        /// <param name="FieldOrder">用于指定排序顺序  </param>
        /// <param name="Where">查询条件  </param>
        /// <param name="PageCount">总页数  </param>
        /// <returns></returns>
        DataTable GetDataTable(string tbname, string FieldKey, int PageCurrent, int PageSize , string FieldShow, string FieldOrder, string Where, out int PageCount);

        #endregion
    }
}
