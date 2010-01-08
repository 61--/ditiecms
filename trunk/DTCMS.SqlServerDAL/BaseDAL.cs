//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: V1.0 创建于 2010-1-8 11:52:52
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Reflection;
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

        /// <summary>
        /// 绑定DataReader到实体对象 通用方法
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="reader">DataReader数据集</param>
        /// <returns></returns>       
        protected T DataReaderToModel<T>(DbDataReader reader) where T : new()
        {
            PropertyInfo info = null;
            Type type = typeof(T);
            T entity = new T();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader[i] != null && reader[i] != DBNull.Value)
                {
                    info = type.GetProperty(reader.GetName(i));
                    if (info == null) return default(T);
                    info.SetValue(entity, reader[i], null);
                }
            }
            return entity;
        }

        /// <summary>
        /// 字符串缓存实现的通用分页存储过程
        /// </summary>
        /// <param name="tbname">要分页显示的表名，可以使用表联合  </param>
        /// <param name="FieldKey">用于定位记录的主键(惟一键)字段,只能是单个字段  </param>
        /// <param name="PageCurrent">要显示的页码  </param>
        /// <param name="PageSize">每页的大小(记录数)  </param>
        /// <param name="FieldShow">以逗号分隔的要显示的字段列表,如果不指定,则显示所有字段  </param>
        /// <param name="FieldOrder">用于指定排序顺序  </param>
        /// <param name="Where">查询条件  </param>
        /// <param name="PageCount">总页数  </param>
        /// <returns></returns>
        public DataTable GetDataTable(string tbname, string FieldKey, int PageCurrent, int PageSize, string FieldShow, string FieldOrder, string Where, out int PageCount)
        {
            DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@tbname", DbType.String, tbname),
				dbHelper.CreateInDbParameter("@FieldKey", DbType.String, FieldKey),
				dbHelper.CreateInDbParameter("@PageCurrent", DbType.Int32, PageCurrent),
				dbHelper.CreateInDbParameter("@PageSize", DbType.Int32, PageSize),
				dbHelper.CreateInDbParameter("@FieldShow", DbType.String, FieldShow),
                dbHelper.CreateInDbParameter("@FieldOrder", DbType.String, FieldOrder),
                dbHelper.CreateInDbParameter("@Where", DbType.String, Where),
                dbHelper.CreateOutDbParameter("@PageCount", DbType.String, 0)};

            DataSet ds = dbHelper.ExecuteQuery(CommandType.StoredProcedure, "pagehelper", cmdParms);

            PageCount = int.Parse(cmdParms[7].Value.ToString());
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
