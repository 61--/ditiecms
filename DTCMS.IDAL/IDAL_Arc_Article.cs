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
        DataTable GetDataTable(string tb, string collist, int top, int pagesize, int page
            , string condition, string sql_key, string col, int orderby, out int pagesum);
        #endregion

    }
}
