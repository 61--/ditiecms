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
using DTCMS.Entity;
using DTCMS.Common;
using DTCMS.IDAL;
using DTCMS.DALFactory;

namespace DTCMS.BLL
{
    public class DataBase_RunSqlBLL
    {
        private readonly IDAL_DataBase_RunSql dalDatabaseRunsql = DataAccess.CreateFactoryDAL<IDAL_DataBase_RunSql>("DataBase_RunSqlDAL");

        /// <summary>
        /// 获取系统表
        /// </summary>
        public DataTable GetSysObjectDataTable()
        {
            return dalDatabaseRunsql.GetSysObjectDataTable();
        }
        /// <summary>
        /// 获取列名
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public DataTable GetSysColumnsDataTable(string tablename)
        {
            if (tablename == string.Empty || tablename == null) throw new ArgumentNullException("表明不能为空！");
            return dalDatabaseRunsql.GetSysColumnsDataTable(tablename);
        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        public int ExecuteSql(string strSql)
        {           
            //验证
            return dalDatabaseRunsql.ExecuteSql(strSql);
        }
    }
}
