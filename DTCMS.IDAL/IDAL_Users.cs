//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 22:48:15
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
    /// <summary>
    /// 接口层 IUsers
    /// </summary>
    public interface IDAL_Users : IDAL_Base
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Users model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        int Update(Users model);

        /// <summary>
        /// 根据ID和值更新一条数据
        /// </summary>
        int Update(int UID, string value);

        /// <summary>
        /// 删除一条用户数据
        /// </summary>
        int Delete(int UID);

        /// <summary>
        /// 批量删除用户
        /// </summary>
        int Delete(string UID);

        /// <summary>
        /// 批量审核用户
        /// </summary>
        int VerifyUsers(string UID);

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int UID, string filedName, string filedValue);

        /// <summary>
        /// 用户登录检测
        /// </summary>
        Users CheckLogin(string userName, string pwd, bool isAdmin);

        /// <summary>
        /// 更新用户登录时间
        /// </summary>
        void UpdateLoginInfo(int userID, string lastloginIP, DateTime lastloginTime);

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        Users GetModel(int UID);

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）
        /// </summary>
        object GetSingle(string filed, string where);

        /// <summary>
        /// 字符串缓存实现的通用分页存储过程
        /// </summary>
        DataTable GetPageList(string fieldKey, int pageCurrent, int pageSize
            , string fieldShow, string fieldOrder, string where, out int pageCount);

        /// <summary>
        /// 根据查询字段获取列表
        /// </summary>
        DataTable GetDataTable(string fileds, string where);

        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        List<Users> GetList(out int count);

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        List<Users> GetPageList(int pageSize, int pageIndex, out int count);
    }
}
