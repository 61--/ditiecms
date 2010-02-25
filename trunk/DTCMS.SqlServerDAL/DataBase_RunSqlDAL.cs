//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 22:48:15
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using DTCMS.Entity;
using DTCMS.IDAL;

namespace DTCMS.SqlServerDAL
{
    public class DataBase_RunSqlDAL : BaseDAL, IDAL_DataBase_RunSql
    {
        /// <summary>
        /// 获取系统表
        /// </summary>
        /// <returns></returns>
        public DataTable GetSysObjectDataTable()
        {
            string strSql = "select [name] from sysobjects where xtype='u' and status>=0";
            DataSet ds = dbHelper.ExecuteQuery(CommandType.Text, strSql);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取列名
        /// </summary>
        /// <param name="tablename"></param>
        /// <returns></returns>
        public DataTable GetSysColumnsDataTable(string tablename)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select '*' as name,'全部' as value union all ");
            strSql.Append("select name,");
            strSql.Append("(select value from sysproperties where id = syscolumns.id and smallid=syscolumns.colid) as 描述 ");
            strSql.Append(string.Format("from syscolumns where id=object_id('{0}')",tablename));

            DataSet ds = dbHelper.ExecuteQuery(CommandType.Text, strSql.ToString());
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        public int ExecuteSql(string strSql)
        {
            return dbHelper.ExecuteNonQuery(CommandType.Text,strSql);
        }

        /// <summary>
        /// 执行SQL语句
        /// </summary>
        public DataTable ExecuteSqlToDataTable(string strSql)
        {
            DataSet ds = dbHelper.ExecuteQuery(CommandType.Text, strSql);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }

        }
    }
}
