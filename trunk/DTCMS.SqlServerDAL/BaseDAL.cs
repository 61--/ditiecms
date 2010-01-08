//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: V1.0 创建于 2010-1-9 0:17:56
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Configuration;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using DTCMS.DBUtility;

namespace DTCMS.SqlServerDAL
{
    public class BaseDAL
    {
        protected static SqlHelper dbHelper = new SqlHelper();

        #region === 创造SqlParameter的实例 ===
        /// <summary>
        /// 创造输入SqlParameter的实例
        /// </summary>
        public SqlParameter AddInSqlParameter(string paraName, DbType dbType, int size, object value)
        {
            return AddSqlParameter(paraName, dbType, size, value, ParameterDirection.Input);
        }

        /// <summary>
        /// 创造输入SqlParameter的实例
        /// </summary>
        public SqlParameter AddInSqlParameter(string paraName, DbType dbType, object value)
        {
            return AddSqlParameter(paraName, dbType, 0, value, ParameterDirection.Input);
        }

        /// <summary>
        /// 创造输出SqlParameter的实例
        /// </summary>        
        public SqlParameter AddOutSqlParameter(string paraName, DbType dbType, int size)
        {
            return AddSqlParameter(paraName, dbType, size, null, ParameterDirection.Output);
        }

        /// <summary>
        /// 创造输出SqlParameter的实例
        /// </summary>        
        public SqlParameter AddOutSqlParameter(string paraName, DbType dbType)
        {
            return AddSqlParameter(paraName, dbType, 0, null, ParameterDirection.Output);
        }

        /// <summary>
        /// 创造返回SqlParameter的实例
        /// </summary>        
        public SqlParameter AddReturnSqlParameter(string paraName, DbType dbType, int size)
        {
            return AddSqlParameter(paraName, dbType, size, null, ParameterDirection.ReturnValue);
        }

        /// <summary>
        /// 创造返回SqlParameter的实例
        /// </summary>        
        public SqlParameter AddReturnSqlParameter(string paraName, DbType dbType)
        {
            return AddSqlParameter(paraName, dbType, 0, null, ParameterDirection.ReturnValue);
        }

        /// <summary>
        /// 创造SqlParameter的实例
        /// </summary>
        public SqlParameter AddSqlParameter(string paraName, DbType dbType, int size, object value, ParameterDirection direction)
        {
            SqlParameter para;
            switch (_databaseType)
            {
                case DatabaseTypes.MySql:
                    para = new MySqlParameter();
                    break;
                case DatabaseTypes.Oracle:
                    para = new OracleParameter();
                    break;
                case DatabaseTypes.OleDb:
                    para = new OleSqlParameter();
                    break;
                case DatabaseTypes.Sql:
                default:
                    para = new SqlParameter();
                    break;
            }
            para.ParameterName = paraName;

            if (size != 0)
                para.Size = size;

            para.DbType = dbType;

            if (value != null)
                para.Value = value;

            para.Direction = direction;

            return para;
        }
        #endregion
    }
}
