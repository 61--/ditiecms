//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-8 11:52:52
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Entity;
using DTCMS.IDAL;
using DTCMS.DALFactory;

namespace DTCMS.BLL
{
	/// <summary>
	/// 业务逻辑类 Arc_Soft
	/// </summary>
	public class Arc_SoftBLL
	{
		private readonly IDAL_Arc_Soft dal = DataAccess.CreateFactoryDAL<IDAL_Arc_Soft>("Arc_SoftDAL");
		public Arc_SoftBLL()
		{ }

        /// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(Arc_Soft model)
        {
            dal.Add(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(Arc_Soft model)
        {
            dal.Update(model);
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(int AID)
        {
            dal.Delete(AID);
        }

        /// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(int AID)
        {
            return dal.Exists(AID);
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        public Arc_Soft GetModel(int AID)
        {
            return dal.GetModel(AID);
        }

        /// <summary>
		/// 获得泛型数据列表
		/// </summary>
        public List<Arc_Soft> GetList(out long count)
        {
            return dal.GetList(out count);
        }

        /// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
        public List<Arc_Soft> GetPageList(int pageSize, int pageIndex, out long count)
        {
            if (pageSize <= 0)
                throw new Exception("每页数据条数必须大于0。");

            if (pageIndex <= 0)
                throw new Exception("页索引必须大于0。");

            return dal.GetPageList(pageSize, pageIndex, out count);
        }
	}
}
