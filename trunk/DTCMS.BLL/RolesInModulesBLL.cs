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
using DTCMS.Entity.Enum;
using DTCMS.Common;
using DTCMS.IDAL;
using DTCMS.DALFactory;

namespace DTCMS.BLL
{
    /// <summary>
    /// 业务逻辑类 RolesInModules
    /// </summary>
    public class RolesInModulesBLL
    {
        private readonly IDAL_RolesInModules dal = DataAccess.CreateFactoryDAL<IDAL_RolesInModules>("RolesInModulesDAL");
        public RolesInModulesBLL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(RolesInModules model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(RolesInModules model)
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
        public RolesInModules GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获取指定ID角色对指定ID模块的操作码
        /// </summary>
        /// <param name="rolesID">角色ID</param>
        /// <param name="moduleID">模块ID</param>
        /// <returns>模块操作码</returns>
        public int GetRolesControlValue(int rolesID, string moduleID)
        {
            object obj = dal.GetSingle("ControlValue", string.Format("AND RolesID={0} AND ModuleID={1}", rolesID, moduleID));
            return TypeConvert.ToInt32(obj);
        }

        /// <summary>
        /// 判断指定ID角色对指定ID模块是否具有操作权限
        /// </summary>
        /// <param name="rolesID">角色ID</param>
        /// <param name="moduleID">模块ID</param>
        /// <param name="controlFlag">系统操作权限枚举</param>
        /// <returns>有权限返回true，无权限返回false</returns>
        public bool IsRoleInModuleRight(int rolesID, string moduleID, EControlFlag controlFlag)
        {
            int controlValue = GetRolesControlValue(rolesID, moduleID);

            if ((controlValue & (int)controlFlag) == (int)controlFlag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得泛型数据列表
        /// </summary>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        public List<RolesInModules> GetList(out int count)
        {
            return dal.GetList(out count);
        }
    }
}
