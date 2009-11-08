using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace DTCMS.DBUtility
{
    public static class SqlHelper
    {
        /// <summary>
        /// 数据库连接串
        /// </summary>
        public static String ConnString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Sqlconn"].ConnectionString;
            }
        }

        /// <summary>
        /// 数据库连接已打开对象
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(ConnString);
                connection.Open();
                return connection;
            }
        }

        #region SQL语句

        /// <summary>
        /// 执无参SQL语句,返回执行行数
        /// </summary>
        public static int ExecuteCommand(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            int result = cmd.ExecuteNonQuery();
            Connection.Close();
            Connection.Dispose();
            return result;
        }
        /// <summary>
        /// 执行带参SQL语句,返回执行行数
        /// </summary>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            int result = cmd.ExecuteNonQuery();
            Connection.Close();
            Connection.Dispose();
            return result;
        }

        /// <summary>
        /// 执行无参SQL语句，并返回首行首列
        /// </summary>
        public static object GetScalar(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            object result = Convert.ToInt32(cmd.ExecuteScalar());
            Connection.Close();
            Connection.Dispose();
            return result;
        }
        /// <summary>
        /// 执行带参SQL语句，并返回首行首列
        /// </summary>
        public static object GetScalar(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            object result = Convert.ToInt32(cmd.ExecuteScalar());
            Connection.Close();
            Connection.Dispose();
            return result;
        }

        /// <summary>
        /// 执行无参SQL语句，并返回SqlDataReader
        /// </summary>
        public static SqlDataReader GetReader(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
        /// <summary>
        /// 执行带参SQL语句，并返回SqlDataReader
        /// </summary>
        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        /// <summary>
        /// 执行无参sql语句，并返回DataSet
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string safeSql)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Connection.Close();
            Connection.Dispose();
            return ds;
        }

        /// <summary>
        /// 执行带参sql语句，并返回DataSet
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, params SqlParameter[] values)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Connection.Close();
            Connection.Dispose();
            return ds;
        }
        #endregion
    }
}
