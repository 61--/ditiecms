//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: V5.0.0.2 创建于 2010-1-7 23:34:18
//
// 功能描述: 
//
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System.Configuration;
using System.Web;
using DTCMS.DBUtility;

namespace DTCMS.SqlServerDAL
{
    public class BaseDAL
    {
        protected static DBHelper dbHelper = GetHelper("DB");

        /// <summary>
        /// 从Web.config从读取数据库的连接以及数据库类型
        /// </summary>
        private static DBHelper GetHelper(string connectionStringName)
        {
            DBHelper dbHelper = new DBHelper();

            // 从Web.config中读取数据库类型
            string providerName = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ProviderName;
            switch (providerName)
            {
                case "System.Data.OracleClient":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.Oracle;
                    break;
                case "MySql.Data.MySqlClient":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.MySql;
                    break;
                case "System.Data.OleDb":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.OleDb;
                    break;
                case "System.Data.SqlClient":
                default:
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.Sql;
                    break;
            }

            // 从Web.config中读取数据库连接
            switch (dbHelper.DatabaseType)
            {
                case DBHelper.DatabaseTypes.OleDb:
                    dbHelper.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Persist Security Info=true;Data Source="
                        + HttpContext.Current.Request.PhysicalApplicationPath
                        + System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
                    break;
                default:
                    dbHelper.ConnectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
                    break;
            }

            return dbHelper;
        }

        /// <summary>
        /// 取得分页数据的第一个索引
        /// </summary>
        /// <param name="pageSize">页大小</param>
        /// <param name="pageIndex">页索引</param>
        /// <returns>分页数据的第一个索引</returns>
        protected static long GetFirstIndex(int pageSize, int pageIndex)
        {
            return pageSize * (pageIndex - 1) + 1;
        }

        /// <summary>
        /// 取得分页数据的最后一个索引
        /// </summary>
        /// <param name="pageSize">页大小</param>
        /// <param name="pageIndex">页索引</param>
        /// <returns>分页数据的最后一个索引</returns>
        protected static long GetLastIndex(int pageSize, int pageIndex)
        {
            return pageSize * pageIndex;
        }
    }
}
