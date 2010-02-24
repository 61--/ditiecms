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
using System.Data;

namespace DTCMS.BLL
{
	/// <summary>
	/// 业务逻辑类 AttachMent
	/// </summary>
	public class AttachMentBLL
	{
		private readonly IDAL_AttachMent dal = DataAccess.CreateFactoryDAL<IDAL_AttachMent>("AttachMentDAL");
		public AttachMentBLL()
		{ }

        /// <summary>
		/// 增加一条数据
		/// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(AttachMent model)
        {
            return dal.Add(model);
        }

        /// <summary>
		/// 更新一条数据
		/// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(AttachMent model)
        {
            return dal.Update(model);
        }

        /// <summary>
		/// 删除一条数据
		/// </summary>
        /// <param name="AID">AID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int AID)
        {
            return dal.Delete(AID);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        /// <param name="ID">文章ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string AID)
        {
            return dal.Delete( AID );
        }

        /// <summary>
		/// 判断某个字段值是否存在
		/// </summary>
        /// <param name="AID">AID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int AID, string filedName, string filedValue)
        {
            return dal.Exists(AID, filedName, filedValue);
        }

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        /// <param name="AID">AID</param>
        /// <returns>实体对象</returns>
        public AttachMent GetModel(int AID)
        {
            return dal.GetModel(AID);
        }

        /// <summary>
		/// 获得泛型数据列表
		/// </summary>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        public List<AttachMent> GetList(out int count)
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
        public List<AttachMent> GetPageList(int pageSize, int pageIndex, out int count)
        {
            if (pageSize <= 0)
                throw new Exception("每页数据条数必须大于0。");

            if (pageIndex <= 0)
                throw new Exception("页索引必须大于0。");

            return dal.GetPageList(pageSize, pageIndex, out count);
        }

        /// <summary>
        /// 获取附件-图片
        /// </summary>
        /// <param name="pageCurrent">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="where">查询条件</param>
        /// <param name="pagecount">总页数</param>
        /// <returns></returns>
        public DataTable GetAttachmentList(int pageCurrent, int pageSize, string where, out int pagecount)
        {
            return dal.GetPageList("DT_AttachMent", "AttachMentID", pageCurrent, pageSize
                , "DisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription"
                , "AddDate desc", where, out pagecount);
        }
	}
}
