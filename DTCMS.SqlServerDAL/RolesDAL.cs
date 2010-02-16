//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-10 22:48:15
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using DTCMS.Entity;
using DTCMS.IDAL;

namespace DTCMS.SqlServerDAL
{
    /// <summary>
    /// 数据访问类 Roles
    /// </summary>
    public class RolesDAL : BaseDAL, IDAL_Roles
    {
        public RolesDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <returns>返回影响行数</returns>
        public int Add(Roles model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO " + tablePrefix + "Roles(");
            strSql.Append("ID,RoleName,Description,AddDate,OrderID)");
            strSql.Append(" VALUES (");
            strSql.Append("@ID,@RoleName,@Description,@AddDate,@OrderID)");
            SqlParameter[] cmdParms = {
                AddInParameter("@ID",SqlDbType.Int,4,model.ID),
				AddInParameter("@RoleName", SqlDbType.NVarChar, 50, model.RoleName),
				AddInParameter("@Description", SqlDbType.NVarChar, 200, model.Description),
                AddInParameter("@AddDate",SqlDbType.DateTime,8,model.AddDate),
				AddInParameter("@OrderID", SqlDbType.Int, 4, model.OrderID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Roles model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE " + tablePrefix + "Roles SET ");
            strSql.Append("RoleName=@RoleName,");
            strSql.Append("Description=@Description,");
            strSql.Append("OrderID=@OrderID");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@RoleName", SqlDbType.NVarChar, 50, model.RoleName),
				AddInParameter("@Description", SqlDbType.NVarChar, 200, model.Description),
				AddInParameter("@OrderID", SqlDbType.Int, 4, model.OrderID),
				AddInParameter("@ID", SqlDbType.Int, 4, model.ID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// 根据ID和值更新一条数据
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <param name="value">更新值（filedName=filedValue）</param>
        /// <returns>返回影响行数</returns>
        public int Update(int ID, string value)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE " + tablePrefix + "Roles SET ");
            strSql.Append(value);
            strSql.Append(" WHERE ID=");
            strSql.Append(ID);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM " + tablePrefix + "Roles");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@ID", SqlDbType.Int, 4, ID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// 批量删除角色
        /// </summary>
        /// <param name="UID">角色ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string UID)
        {
            string strSql = string.Format("DELETE FROM {0}Roles WHERE ID IN({1})", tablePrefix, UID);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>存在返回true，不存在返回false</returns>
        public bool Exists(int ID, string filedName, string filedValue)
        {
            StringBuilder strSql = new StringBuilder();
            if (filedName != "")
            {
                strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Roles");
                strSql.Append(" WHERE ID<>{0} AND {1}={2}");
                return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), ID, filedName, filedValue))) > 0;
            }
            else
            {
                strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Roles");
                strSql.Append(" WHERE ID={0}");
                return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), ID))) > 0;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <returns>实体对象</returns>
        public Roles GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,RoleName,Description,AddDate,OrderID FROM " + tablePrefix + "Roles");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@ID", SqlDbType.Int, 4, ID)};

            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
            {
                if (dr.Read())
                {
                    return GetModel(dr);
                }
                return null;
            }
        }

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）
        /// </summary>
        /// <param name="filed">要查询的字段</param>
        /// <param name="where">查询条件</param>
        /// <returns>Object对象</returns>
        public object GetSingle(string filed, string where)
        {
            string strSql = "";
            if (where == "")
            {
                strSql = string.Format("SELECT TOP 1 {0} FROM {1}Roles", filed, tablePrefix);
            }
            else
            {
                strSql = string.Format("SELECT TOP 1 {0} FROM {1}Roles WHERE {2}", filed, tablePrefix, where);
            }

            object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql);
            return obj;
        }

        /// <summary>
        /// 根据查询字段获取列表
        /// </summary>
        /// <param name="fileds">要查询的字段，多个字段用,号隔开</param>
        /// <returns>DataTable数据集合</returns>
        public DataTable GetDataTable(string fileds, string where)
        {
            string strSql = "";
            if (where == "")
            {
                strSql = string.Format("SELECT {0} FROM {1}Roles ORDER BY OrderID", fileds, tablePrefix);
            }
            else
            {
                strSql = string.Format("SELECT {0} FROM {1}Roles WHERE {2} ORDER BY OrderID", fileds, tablePrefix, where);
            }

            DataSet ds = dbHelper.ExecuteQuery(CommandType.Text, strSql);
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
        /// 获取泛型数据列表
        /// </summary>
        /// <param name="count">返回记录总数</param>
        /// <returns>对象泛型集合</returns>
        public List<Roles> GetList(out int count)
        {
            string strSql = string.Format("SELECT ID,RoleName,Description,AddDate,OrderID FROM {0}Roles", tablePrefix);
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<Roles> lst = GetList(dr, out count);
                return lst;
            }
        }

        #region 私有方法，通常情况下无需修改
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <returns>实体对象</returns>
        private Roles GetModel(SqlDataReader dr)
        {
            Roles model = new Roles();
            model.ID = dbHelper.GetInt(dr["ID"]);
            model.RoleName = dbHelper.GetString(dr["RoleName"]);
            model.Description = dbHelper.GetString(dr["Description"]);
            model.AddDate = dbHelper.GetDateTime(dr["AddDate"]);
            model.OrderID = dbHelper.GetInt(dr["OrderID"]);
            return model;
        }

        /// <summary>
        /// 由SqlDataReader得到泛型数据列表
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        private List<Roles> GetList(SqlDataReader dr, out int count)
        {
            count = 0;
            List<Roles> lst = new List<Roles>();
            while (dr.Read())
            {
                count++;
                lst.Add(GetModel(dr));
            }
            return lst;
        }
        #endregion
    }
}
