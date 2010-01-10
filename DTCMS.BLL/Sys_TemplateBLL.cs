//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 19:36:36
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
	/// 业务逻辑类 Sys_Template
	/// </summary>
	public class Sys_TemplateBLL
	{
		private readonly IDAL_Sys_Template dal = DataAccess.CreateFactoryDAL<IDAL_Sys_Template>("Sys_TemplateDAL");
		public Sys_TemplateBLL()
		{ }

        /// <summary>
		/// 增加一条数据
		/// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(Sys_Template model)
        {
            return dal.Add(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Sys_Template model)
        {
            return dal.Update(model);
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
        /// <param name="TemplateID">TemplateID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int TemplateID)
        {
            return dal.Delete(TemplateID);
        }

        /// <summary>
		/// 判断某个字段值是否存在
		/// </summary>
        /// <param name="TemplateID">TemplateID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int TemplateID, string filedName, string filedValue)
        {
            return dal.Exists(TemplateID, filedName, filedValue);
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        /// <param name="TemplateID">TemplateID</param>
        /// <returns>实体对象</returns>
        public Sys_Template GetModel(int TemplateID)
        {
            return dal.GetModel(TemplateID);
        }

        /// <summary>
		/// 获得泛型数据列表
		/// </summary>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        public List<Sys_Template> GetList(out long count)
        {
            return dal.GetList(out count);
        }

        /// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="count">返回记录数</param>
        /// <returns>分页对象泛型集合</returns>
        public List<Sys_Template> GetPageList(int pageSize, int pageIndex, out long count)
        {
            if (pageSize <= 0)
                throw new Exception("每页数据条数必须大于0。");

            if (pageIndex <= 0)
                throw new Exception("页索引必须大于0。");

            return dal.GetPageList(pageSize, pageIndex, out count);
        }
	}
}
