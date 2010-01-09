//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: V1.0 创建于 2010-1-9 0:17:56
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Web;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
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

        /// <summary>
        /// -- 字符串缓存实现的通用分页存储过程(转自邹建)  
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
            PageCount = 0;
            SqlParameter[] cmdParms = {
                AddInParameter("@tbname",SqlDbType.NVarChar,tbname),
                AddInParameter("@FieldKey",SqlDbType.NVarChar,FieldKey),
                AddInParameter("@PageCurrent",SqlDbType.Int,PageCurrent),
                AddInParameter("@PageSize",SqlDbType.Int,PageSize),
                AddInParameter("@FieldShow",SqlDbType.NVarChar,FieldShow),
                AddInParameter("@FieldOrder",SqlDbType.NVarChar,FieldOrder),
                AddInParameter("@Where",SqlDbType.NVarChar,Where),
                AddOutParameter("@PageCount",SqlDbType.NVarChar,PageCount),

            };

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

        /// <summary>
        /// 绑定DataReader到实体对象 通用方法
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="reader">DataReader数据集</param>
        /// <returns></returns>       
        protected T DataReaderToModel<T>(SqlDataReader reader) where T : new()
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
    }
}
