//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2009-10-29 11:51:05
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Data.OleDb;

namespace DTCMS.DBUtility
{
    /// <summary>
    /// 数据库操作基类(for OleDb)
    /// </summary>
    internal class OleDbHelper : IDBHelper
    {
        /// <summary>
        /// 执行查询，返回DataSet
        /// </summary>
        public DataSet ExecuteQuery(string connectionString, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                        return ds;
                    }
                }
            }
        }

        /// <summary>
        /// 在事务中执行查询，返回DataSet
        /// </summary>
        public DataSet ExecuteQuery(DbTransaction trans, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, cmdParms);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "ds");
            cmd.Parameters.Clear();
            return ds;
        }

        /// <summary>
        /// 执行 Transact-SQL 语句并返回受影响的行数。
        /// </summary>
        public int ExecuteNonQuery(string connectionString, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 在事务中执行 Transact-SQL 语句并返回受影响的行数。
        /// </summary>
        public int ExecuteNonQuery(DbTransaction trans, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, cmdParms);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// 执行查询，返回DataReader
        /// </summary>
        public DbDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection conn = new OleDbConnection(connectionString);

            try
            {
                PrepareCommand(cmd, conn, null, cmdType, cmdText, cmdParms);
                OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        /// <summary>
        /// 在事务中执行查询，返回DataReader
        /// </summary>
        public DbDataReader ExecuteReader(DbTransaction trans, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, cmdParms);
            OleDbDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Parameters.Clear();
            return rdr;
        }

        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        public object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                PrepareCommand(cmd, connection, null, cmdType, cmdText, cmdParms);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }

        /// <summary>
        /// 在事务中执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行。
        /// </summary>
        public object ExecuteScalar(DbTransaction trans, CommandType cmdType, string cmdText,
            params DbParameter[] cmdParms)
        {
            OleDbCommand cmd = new OleDbCommand();
            PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, cmdParms);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }

        /// <summary>
        /// 生成要执行的命令
        /// </summary>
        private static void PrepareCommand(DbCommand cmd, DbConnection conn, DbTransaction trans, CommandType cmdType,
            string cmdText, DbParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            cmd.Connection = conn;
            cmd.CommandText = cmdText.Replace("?", "@").Replace(":", "@");

            if (trans != null)
                cmd.Transaction = trans;

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (OleDbParameter parm in cmdParms)
                {
                    parm.ParameterName = parm.ParameterName.Replace("?", "@").Replace(":", "@");
                    cmd.Parameters.Add(parm);
                }
            }
        }
    }
}
