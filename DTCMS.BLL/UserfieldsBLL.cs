//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 19:36:36
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
	/// 业务逻辑类 Userfields
	/// </summary>
	public class UserfieldsBLL
	{
		private readonly IDAL_Userfields dal = DataAccess.CreateFactoryDAL<IDAL_Userfields>("UserfieldsDAL");
		public UserfieldsBLL()
		{ }

        /// <summary>
		/// 增加一条数据
		/// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(Userfields model)
        {
            return dal.Add(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Userfields model)
        {
            return dal.Update(model);
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
        /// <param name="UID">UID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int UID)
        {
            return dal.Delete(UID);
        }

        /// <summary>
		/// 判断某个字段值是否存在
		/// </summary>
        /// <param name="UID">UID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int UID, string filedName, string filedValue)
        {
            return dal.Exists(UID, filedName, filedValue);
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        /// <param name="UID">UID</param>
        /// <returns>实体对象</returns>
        public Userfields GetModel(int UID)
        {
            return dal.GetModel(UID);
        }
	}
}
