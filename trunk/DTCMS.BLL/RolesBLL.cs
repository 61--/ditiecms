//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-9 0:23:01
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
	/// 业务逻辑类 Roles
	/// </summary>
	public class RolesBLL
	{
		private readonly IDAL_Roles dal = DataAccess.CreateFactoryDAL<IDAL_Roles>("RolesDAL");
		public RolesBLL()
		{ }

        /// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(Roles model)
        {
            dal.Add(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(Roles model)
        {
            dal.Update(model);
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(int ID)
        {
            dal.Delete(ID);
        }

        /// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        public Roles GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
		/// 获得泛型数据列表
		/// </summary>
        public List<Roles> GetList(out long count)
        {
            return dal.GetList(out count);
        }

        /// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
        public List<Roles> GetPageList(int pageSize, int pageIndex, out long count)
        {
            if (pageSize <= 0)
                throw new Exception("每页数据条数必须大于0。");

            if (pageIndex <= 0)
                throw new Exception("页索引必须大于0。");

            return dal.GetPageList(pageSize, pageIndex, out count);
        }
	}
}
