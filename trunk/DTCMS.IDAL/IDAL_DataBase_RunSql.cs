//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 19:36:36
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
    public interface IDAL_DataBase_RunSql
    {
        /// <summary>
        /// 获取系统表
        /// </summary>
        /// <returns></returns>
        DataTable GetSysObjectDataTable();
        /// <summary>
        /// 获取列名
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        DataTable GetSysColumnsDataTable(string tablename);
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        int ExecuteSql(string strSql);
		
    }
}
