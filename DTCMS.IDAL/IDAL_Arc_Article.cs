using System;
using System.Data;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
	/// <summary>
	/// 接口层IDT_Arc_Article 的摘要说明。
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
		int Delete(string ID);
		/// <summary>
		/// 得到一个对象实体
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
		#endregion  成员方法

        #region 基方法
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="tb">表名</param>
        /// <param name="colist">-要查询出的字段列表,*表示全部字段</param>
        /// <param name="top">最多读取记录数 </param>
        /// <param name="pagesize">每页记录数</param>
        /// <param name="page">指定页</param>
        /// <param name="condition">查询条件</param>
        /// <param name="sql_key">用于排序的主键</param>
        /// <param name="col">-用于排序，如：id desc (多个id desc,dt asc)</param>
        /// <param name="orderby">排序,0-顺序,1-倒序</param>
        /// <param name="pagesum">总页数</param>
        /// <returns>数据表</returns>
        DataTable GetDataTable(string tb, string collist, int top, int pagesize, int page
            , string condition, string sql_key, string col, int orderby, out int pagesum);
        #endregion

    }
}
