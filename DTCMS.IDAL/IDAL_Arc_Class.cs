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
		bool Exists(int CID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
        int Add(Arc_Class model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
        void Update(Arc_Class model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		void Delete(int CID);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Arc_Class GetModel(int CID);
		#endregion  成员方法
	}
}
