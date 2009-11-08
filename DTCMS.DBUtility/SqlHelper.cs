﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace DTCMS.DBUtility
{
    public static class SqlHelper
    {
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private static SqlConnection connection;

        /// <summary>
        /// 数据库连接串
        /// </summary>
        public static String ConnString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            }
        }

        /// <summary>
        /// 数据库连接已打开对象
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                try
                {
                    if (connection != null)
                    {
                        connection = new SqlConnection(ConnString);
                    }
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    return connection;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void  CloseSqlConn(){
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }

        #region SQL语句

        /// <summary>
        /// 执无参SQL语句,返回执行行数
        /// </summary>
        public static int ExecuteCommand(string safeSql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseSqlConn();
            }
        }
        /// <summary>
        /// 执行带参SQL语句,返回执行行数
        /// </summary>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);

                foreach (SqlParameter param in values)
                {
                    cmd.Parameters.Add(param);
                }
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseSqlConn();
            }
        }

        /// <summary>
        /// 执行无参SQL语句，并返回首行首列
        /// </summary>
        public static object GetScalar(string safeSql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                object result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseSqlConn();
            }
        }
        /// <summary>
        /// 执行带参SQL语句，并返回首行首列
        /// </summary>
        public static object GetScalar(string sql, params SqlParameter[] values)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
                object result = Convert.ToInt32(cmd.ExecuteScalar());
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseSqlConn();
            }
        }

        /// <summary>
        /// 执行无参SQL语句，并返回SqlDataReader
        /// </summary>
        public static SqlDataReader GetReader(string safeSql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 执行带参SQL语句，并返回SqlDataReader
        /// </summary>
        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 执行无参sql语句，并返回DataSet
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string safeSql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(safeSql, Connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseSqlConn();
            }
        }

        /// <summary>
        /// 执行带参sql语句，并返回DataSet
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, params SqlParameter[] values)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.Parameters.AddRange(values);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseSqlConn();
            }
        }
        #endregion
    }
}