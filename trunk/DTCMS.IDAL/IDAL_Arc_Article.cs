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
		/// 是否存在该记录
		/// </summary>
		bool Exists(int ID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(Arc_Article model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
        void Update(Arc_Article model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		void Delete(int ID);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		Arc_Article GetModel(int ID);
		#endregion  成员方法
	}
}
