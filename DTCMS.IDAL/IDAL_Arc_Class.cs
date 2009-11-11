using System;
using System.Data;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
	/// <summary>
	/// 接口层IDT_Arc_Class 的摘要说明。
	/// </summary>
	public interface IDAL_Arc_Class
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        /// <param name="CID">类别主键</param>
        /// <param name="FiledName">字段名称</param>
        /// <param name="FiledValue">字段值</param>
		bool Exists(int CID,string filedName,string filedValue);
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
		/// 得到一个对象实体
		/// </summary>
		Arc_Class GetModel(int CID);
		#endregion  成员方法
	}
}
