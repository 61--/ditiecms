//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-7 23:34:18
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
	/// 业务逻辑类 SYS_Template
	/// </summary>
	public class SYS_TemplateBLL
	{
		private readonly IDAL_SYS_Template dal = DataAccess.CreateFactoryDAL<IDAL_SYS_Template>("SYS_TemplateDAL");
		public SYS_Template()
		{ }

        /// <summary>
		/// 增加一条数据
		/// </summary>
        public void Add(SYS_Template model)
        {
            dal.Add(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(SYS_Template model)
        {
            dal.Update(model);
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(int TemplateID)
        {
            dal.Delete(TemplateID);
        }

        /// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(int TemplateID)
        {
            return dal.Exists(TemplateID);
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        public SYS_Template GetModel(int TemplateID)
        {
            return dal.GetModel(TemplateID);
        }

        /// <summary>
		/// 获得泛型数据列表
		/// </summary>
        public List<SYS_Template> GetList(out long count)
        {
            return dal.GetList(out count);
        }

        /// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
        public List<SYS_Template> GetPageList(int pageSize, int pageIndex, out long count)
        {
            if (pageSize <= 0)
                throw new Exception("每页数据条数必须大于0。");

            if (pageIndex <= 0)
                throw new Exception("页索引必须大于0。");

            return dal.GetPageList(pageSize, pageIndex, out count);
        }
	}
}
