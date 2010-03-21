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
using System.Data;
using DTCMS.Common;
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
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(Roles model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Roles model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int ID)
        {
            return dal.Delete(ID);
        }

        /// <summary>
        /// 批量删除角色
        /// </summary>
        /// <param name="UID">角色ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string UID)
        {
            return dal.Delete(UID);
        }

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int ID, string filedName, string filedValue)
        {
            return dal.Exists(ID, filedName, filedValue);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="ID">ID</param>
        /// <returns>实体对象</returns>
        public Roles GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        public List<Roles> GetList(out int count)
        {
            return dal.GetList(out count);
        }

        /// <summary>
        /// 获取角色数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetList()
        {
            return dal.GetDataTable("ID,RoleName", "", "");
        }

        /// <summary>
        /// 获取DataTable，并转换成Json格式数据
        /// </summary>
        public string GetRolesJsonData(string sortValue)
        {
            if (sortValue == null || sortValue.Length == 0)
            {
                sortValue = "OrderID";
            }
            DataTable dt = dal.GetDataTable("ID,RoleName,Description,AddDate", "", sortValue);
            if (dt != null)
            {
                return Utils.DataTableToJson(dt, dt.Rows.Count).ToString();
            }
            else
            {
                return "{totalRecord:0,dataTable:[]}";
            }
        }
    }
}
