using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTCMS.DBUtility;
using System.Reflection;

namespace DTCMS.SqlServerDAL
{
    public class BaseDAL
    {
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
        public DataTable GetDataTable(string tbname, string FieldKey, int PageCurrent, int PageSize
            , string FieldShow, string FieldOrder, string Where,out int PageCount)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@tbname",SqlDbType.NVarChar,1000),
                new SqlParameter("@FieldKey",SqlDbType.NVarChar,1000),
                new SqlParameter("@PageCurrent",SqlDbType.Int),
                new SqlParameter("@PageSize",SqlDbType.Int),
                new SqlParameter("@FieldShow",SqlDbType.NVarChar,1000),
                new SqlParameter("@FieldOrder",SqlDbType.NVarChar,1000),
                new SqlParameter("@Where",SqlDbType.NVarChar,1000),
                new SqlParameter("@PageCount",SqlDbType.NVarChar,1000),

            };
            int n=0;
            parameters[n++].Value = tbname;
            parameters[n++].Value = FieldKey;
            parameters[n++].Value = PageCurrent;
            parameters[n++].Value = PageSize;
            parameters[n++].Value = FieldShow;
            parameters[n++].Value = FieldOrder;
            parameters[n++].Value = Where;

            parameters[n].Direction = ParameterDirection.Output;

            DataSet ds = SqlHelper.FillDataset(CommandType.StoredProcedure,"pagehelper", parameters);
            PageCount = int.Parse(parameters[n].Value.ToString());
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
                if (reader[i] != null && reader[i]!=DBNull.Value)
                {
                    info = type.GetProperty(reader.GetName(i));
                    if (info == null) return default(T);
                    info.SetValue(entity,reader[i], null);
                }
            }
            return entity;
        }
    }
}
