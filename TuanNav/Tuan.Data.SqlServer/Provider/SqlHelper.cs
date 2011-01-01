using System;
using System.Data;
using System.Data.SqlClient;
using Tuan.Data.Provider;
using Tuan.Entity;

namespace Tuan.Data.SqlServer
{
    /// <summary>
    /// 数据库通用访问代码
    /// </summary>
    public class SqlHelper : DbHelper
    {
        public SqlHelper()
        { }

        private static int _sqlVersion;

        public static int SqlVersion
        {
            get
            {
                if (_sqlVersion == 0)
                {
                    using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                    {
                        try
                        {
                            conn.Open();
                            _sqlVersion = int.Parse(conn.ServerVersion.Substring(0, 2));
                            return _sqlVersion;
                        }
                        catch
                        {
                            throw new Exception("无法连接到目标数据库，请确认数据库连接字符串是否正确！");
                        }
                    }
                }
                else
                {
                    return _sqlVersion;
                }
            }
        }

        #region ExecuteNonQuery
        /// <summary>
        /// 执行一条不返回结果的SqlCommand
        /// </summary>
        /// <param name="cmdType">SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)</param>
        /// <param name="cmdText">存储过程的名字或者 T-SQL 语句</param>
        /// <param name="parms">以数组形式提供SqlCommand命令中用到的参数列表</param>
        /// <returns>返回一个数值表示此SqlCommand命令执行后影响的行数</returns>
        public static int ExecuteNonQuery(CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                SqlCommand cmd = new SqlCommand();

                PrepareCommand(cmd, conn, null, cmdType, cmdText, parms);
                int result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return result;
            }
        }

        /// <summary>
        /// 执行一条不返回结果的SqlCommand，通过一个已经存在的数据库事物处理 
        /// </summary>
        /// <param name="trans">一个存在的 sql 事物处理</param>
        /// <param name="commandType">SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)</param>
        /// <param name="commandText">存储过程的名字或者 T-SQL 语句</param>
        /// <param name="commandParameters">以数组形式提供SqlCommand命令中用到的参数列表</param>
        /// <returns>返回一个数值表示此SqlCommand命令执行后影响的行数</returns>
        public static int ExecuteNonQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            if (trans == null) throw new ArgumentNullException("transaction");
            if (trans.Connection == null) throw new ArgumentNullException("Connection");

            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, parms);
            int result = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return result;
        }
        #endregion ExecuteNonQuery

        #region ExecuteReader
        /// <summary>
        /// 执行一条返回结果集的SqlCommand命令
        /// </summary>
        /// <param name="cmdType">SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)</param>
        /// <param name="cmdText">存储过程的名字或者 T-SQL 语句</param>
        /// <param name="parms">以数组形式提供SqlCommand命令中用到的参数列表</param>
        /// <returns>返回一个包含结果的SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(CONNECTIONSTRING);

            //在这里使用try/catch处理是因为如果方法出现异常，则SqlDataReader就不存在，
            //CommandBehavior.CloseConnection的语句就不会执行，触发的异常由catch捕获。
            //关闭数据库连接，并通过throw再次引发捕捉到的异常。
            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, parms);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return sdr;
            }
            catch
            {
                conn.Close();
                conn.Dispose();
                throw;
            }
        }

        #endregion ExecuteReader

        #region ExecuteScalar
        /// <summary>
        /// 执行一条返回第一条记录第一列的SqlCommand命令
        /// 使用参数数组提供参数
        /// </summary>
        /// <param name="cmdType">SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)</param>
        /// <param name="cmdText">存储过程的名字或者 T-SQL 语句</param>
        /// <param name="parms">以数组形式提供SqlCommand命令中用到的参数列表</param>
        /// <returns>返回一个object类型的数据，可以通过 Convert.To{Type}方法转换类型</returns>
        public static object ExecuteScalar(CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, parms);
                object result = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return result;
            }
        }

        #endregion ExecuteScalar

        #region ExecuteQuery
        /// <summary>
        /// 执行指定SQL的命令,映射数据表并填充数据集
        /// </summary>
        /// <param name="cmdType">命令类型 (存储过程,命令文本或其它)</param>
        /// <param name="cmdText">存储过程名称或SQL语句</param>
        /// <param name="parms">分配给命令的SqlParamter参数数组</param>
        public static DataSet ExecuteQuery(CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            return ExecuteQuery(null, cmdType, cmdText, parms);
        }

        /// <summary>
        /// 执行指定事务的命令,映射数据表并填充数据集
        /// </summary>
        /// <param name="transaction">一个有效的连接事务</param>
        /// <param name="cmdType">命令类型 (存储过程,命令文本或其它)</param>
        /// <param name="cmdText">存储过程名称或SQL语句</param>
        /// <param name="parms">分配给命令的SqlParamter参数数组</param>
        public static DataSet ExecuteQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            DataSet dataSet = new DataSet();
            // 创建DbCommand命令,并进行预处理
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                PrepareCommand(cmd, conn, trans, cmdType, cmdText, parms);

                // 执行命令
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    // 填充数据集使用默认表名称
                    da.Fill(dataSet);
                    // 清除参数,以便再次使用.
                    cmd.Parameters.Clear();
                }
                return dataSet;
            }
        }

        #endregion ExecuteQuery

        #region ExecuteList
        /// <summary>
        /// 执行指定SQL的命令，返回数据字典集合
        /// </summary>
        /// <param name="cmdType">命令类型 (存储过程,命令文本或其它)</param>
        /// <param name="cmdText">存储过程名称或SQL语句</param>
        /// <param name="parms">分配给命令的SqlParamter参数数组</param>
        /// <returns>返回指定列数据字典集合</returns>
        public static ModelList ExecuteList(CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            return ExecuteList(null, cmdType, cmdText, parms);
        }

        /// <summary>
        /// 执行指定SQL的命令，返回数据字典集合
        /// </summary>
        /// <param name="transaction">一个有效的连接事务</param>
        /// <param name="cmdType">命令类型 (存储过程,命令文本或其它)</param>
        /// <param name="cmdText">存储过程名称或SQL语句</param>
        /// <param name="parms">分配给命令的SqlParamter参数数组</param>
        /// <returns>返回指定列数据字典集合</returns>
        public static ModelList ExecuteList(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] parms)
        {
            QueryCount++;

            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                PrepareCommand(cmd, conn, trans, cmdType, cmdText, parms);
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        ModelList list = new ModelList();
                        do
                        {
                            while (rdr.Read())
                            {
                                Model model = new Model();
                                for (int i = 0; i < rdr.FieldCount; i++)
                                {
                                    model.Add(rdr.GetName(i), rdr[i].ToString());
                                }
                                list.Add(model);
                            }
                        } while (rdr.NextResult());
                        return list;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
        #endregion

        #region ExecutePageList
        /// <summary>
        /// 获取分页数据列表
        /// </summary>
        /// <returns>返回DataSet数据集</returns>
        public static DataSet ExecutePageList(PagerInfo pager, params SqlParameter[] parms)
        {
            QueryCount++;

            SqlCommand cmd = new SqlCommand();
            using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
            {
                string cmdText = pager.CreateCommandText(cmd.Parameters);
                PrepareCommand(cmd, conn, null, CommandType.Text, cmdText, parms);

                DataSet dataSet = new DataSet();
                // 执行命令
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    // 填充数据集使用默认表名称
                    da.Fill(dataSet);
                    // 清除参数,以便再次使用.
                    cmd.Parameters.Clear();
                }
                return dataSet;
            }
        }
        #endregion

        #region 创造返回SqlParameter的实例
        public static SqlParameter CreateParameter<T>(string name, T value, SqlDbType type)
        {
            return CreateParameter<T>(name, value, type, null, null);
        }

        public static SqlParameter CreateParameter<T>(string name, T value, SqlDbType type, int size)
        {
            return CreateParameter<T>(name, value, type, size, null);
        }

        public static SqlParameter CreateParameter<T>(string name, T value, SqlDbType type, ParameterDirection direction)
        {
            return CreateParameter<T>(name, value, type, null, direction);
        }

        public static SqlParameter CreateParameter<T>(string name, SqlDbType type, ParameterDirection direction)
        {
            return CreateParameter<T>(name, default(T), type, null, direction);
        }

        public static SqlParameter CreateParameter<T>(string name, SqlDbType type, int size, ParameterDirection direction)
        {
            return CreateParameter<T>(name, default(T), type, size, direction);
        }

        private static SqlParameter CreateParameter<T>(string name, T value, SqlDbType type, int? size, ParameterDirection? direction)
        {
            SqlParameter param = new SqlParameter();

            param.ParameterName = name;

            param.SqlDbType = type;

            if (value == null)
                param.Value = DBNull.Value;
            else
                param.Value = value;

            if (size != null)
                param.Size = size.Value;

            if (direction != null)
                param.Direction = direction.Value;

            return param;
        }

        #endregion

        /// <summary>
        /// 为执行命令准备参数
        /// </summary>
        /// <param name="cmd">SqlCommand 命令</param>
        /// <param name="conn">已经存在的数据库连接</param>
        /// <param name="trans">数据库事物处理</param>
        /// <param name="cmdType">SqlCommand命令类型 (存储过程， T-SQL语句， 等等。)</param>
        /// <param name="cmdText">Command text，T-SQL语句 例如 Select * from Products</param>
        /// <param name="parms">返回带参数的命令</param>
        private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] parms)
        {
            //判断数据库连接状态
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            //判断是否需要事物处理
            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (parms != null)
            {
                foreach (SqlParameter parm in parms)
                    cmd.Parameters.Add(parm);
            }
        }
    }
}