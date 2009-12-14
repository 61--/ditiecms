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
        /// 获取数据
        /// </summary>
        /// <param name="tb">表名</param>
        /// <param name="colist">-要查询出的字段列表,*表示全部字段</param>
        /// <param name="top">最多读取记录数 </param>
        /// <param name="pagesize">每页记录数</param>
        /// <param name="page">指定页</param>
        /// <param name="condition">查询条件</param>
        /// <param name="sql_key">用于排序的主键</param>
        /// <param name="col">-用于排序，如：id desc (多个id desc,dt asc)</param>
        /// <param name="orderby">排序,0-顺序,1-倒序</param>
        /// <param name="pagesum">总页数</param>
        /// <returns>数据表</returns>
        public DataTable GetDataTable(string tb, string collist, int top, int pagesize, int page
            ,string condition,string sql_key,string col,int orderby,out int pagesum)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@tb",SqlDbType.VarChar,512),
                new SqlParameter("@collist",SqlDbType.VarChar,2048),
                new SqlParameter("@top",SqlDbType.Int),
                new SqlParameter("@pagesize",SqlDbType.Int),
                new SqlParameter("@page",SqlDbType.Int),
                new SqlParameter("@condition",SqlDbType.VarChar,2048),
                new SqlParameter("@sql_key",SqlDbType.VarChar,20),
                new SqlParameter("@col",SqlDbType.VarChar,50),
                new SqlParameter("@orderby",SqlDbType.Bit),
                new SqlParameter("@pages",SqlDbType.Int)

            };
            int n=0;
            parameters[n++].Value= tb;
            parameters[n++].Value = collist;
            parameters[n++].Value = top;
            parameters[n++].Value = pagesize;
            parameters[n++].Value = page;
            parameters[n++].Value = condition;
            parameters[n++].Value = sql_key;
            parameters[n++].Value = col;
            parameters[n++].Value = orderby;

            parameters[n].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.FillDataset(CommandType.StoredProcedure,"pagehelper", parameters);
            pagesum = int.Parse(parameters[n].Value.ToString());
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
        /// 绑定实体对象到实体
        /// </summary>
        /// <typeparam name="T">实体对象</typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>       
        public T DataReaderBind<T>(SqlDataReader reader) where T:new()
        {
            PropertyInfo info = null;
            Type type = typeof(T);
            T entity = new T();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader[i] != null && (!System.DBNull.Value.Equals(reader[i])))
                {
                    info = type.GetProperty(reader.GetName(i));
                    if (info == null) return default(T);
                    if(reader[i]!=null&&reader[i]!=DBNull.Value)
                        info.SetValue(entity,reader[i], null);
                }
            }
            return entity;
        }
    }
}
