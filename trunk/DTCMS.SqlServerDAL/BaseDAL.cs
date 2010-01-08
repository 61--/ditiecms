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

        #region 创造SqlParameter的实例
        /// <summary>
        /// 创造输入SqlParameter的实例
        /// </summary>
        protected static SqlParameter AddInParameter(string paraName, SqlDbType SqlDbType, int size, object value)
        {
            return AddSqlParameter(paraName, SqlDbType, size, value, ParameterDirection.Input);
        }

        /// <summary>
        /// 创造输入SqlParameter的实例
        /// </summary>
        protected static SqlParameter AddInParameter(string paraName, SqlDbType SqlDbType, object value)
        {
            return AddSqlParameter(paraName, SqlDbType, 0, value, ParameterDirection.Input);
        }

        /// <summary>
        /// 创造输出SqlParameter的实例
        /// </summary>        
        protected static SqlParameter AddOutParameter(string paraName, SqlDbType SqlDbType, int size)
        {
            return AddSqlParameter(paraName, SqlDbType, size, null, ParameterDirection.Output);
        }

        /// <summary>
        /// 创造输出SqlParameter的实例
        /// </summary>        
        protected static SqlParameter AddOutParameter(string paraName, SqlDbType SqlDbType)
        {
            return AddSqlParameter(paraName, SqlDbType, 0, null, ParameterDirection.Output);
        }

        /// <summary>
        /// 创造返回SqlParameter的实例
        /// </summary>        
        protected static SqlParameter AddReturnParameter(string paraName, SqlDbType SqlDbType, int size)
        {
            return AddSqlParameter(paraName, SqlDbType, size, null, ParameterDirection.ReturnValue);
        }

        /// <summary>
        /// 创造返回SqlParameter的实例
        /// </summary>        
        protected static SqlParameter AddReturnParameter(string paraName, SqlDbType SqlDbType)
        {
            return AddSqlParameter(paraName, SqlDbType, 0, null, ParameterDirection.ReturnValue);
        }

        /// <summary>
        /// 创造SqlParameter的实例
        /// </summary>
        private static SqlParameter AddSqlParameter(string paraName, SqlDbType SqlDbType, int size, object value, ParameterDirection direction)
        {
            SqlParameter param = new SqlParameter();

            param.ParameterName = paraName;

            if (size != 0)
                param.Size = size;

            param.SqlDbType = SqlDbType;

            if (value != null)
                param.Value = value;

            param.Direction = direction;

            return param;
        }
        #endregion

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
