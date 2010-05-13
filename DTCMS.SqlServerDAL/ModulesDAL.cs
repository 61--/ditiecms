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
using DTCMS.SqlProvider;

namespace DTCMS.SqlServerDAL
{
    /// <summary>
    /// 数据访问类 Modules
    /// </summary>
    public class ModulesDAL : BaseDAL, IDAL_Modules
    {
        public ModulesDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <returns>返回影响行数</returns>
        public int Add(Modules model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO " + tablePrefix + "Modules(");
            strSql.Append("ModuleID,ParentID,ModuleName,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID)");
            strSql.Append(" VALUES (");
            strSql.Append("@ModuleID,@ParentID,@ModuleName,@EName,@ModuleDepth,@ModuleURL,@Target,@Description,@CreateTime,@IsQuickMenu,@IsSystem,@IsEnable,@OrderID)");
            SqlParameter[] cmdParms = {
				AddInParameter("@ModuleID", SqlDbType.VarChar, 8, model.ModuleID),
				AddInParameter("@ParentID", SqlDbType.VarChar, 8, model.ParentID),
				AddInParameter("@ModuleName", SqlDbType.NVarChar, 50, model.ModuleName),
				AddInParameter("@EName", SqlDbType.VarChar, 50, model.EName),
				AddInParameter("@ModuleDepth", SqlDbType.TinyInt, 1, model.ModuleDepth),
				AddInParameter("@ModuleURL", SqlDbType.VarChar, 255, model.ModuleURL),
				AddInParameter("@Target", SqlDbType.VarChar, 20, model.Target),
				AddInParameter("@Description", SqlDbType.NVarChar, 200, model.Description),
				AddInParameter("@CreateTime", SqlDbType.DateTime, 8, model.CreateTime),
				AddInParameter("@IsQuickMenu", SqlDbType.TinyInt, 1, model.IsQuickMenu),
				AddInParameter("@IsSystem", SqlDbType.TinyInt, 1, model.IsSystem),
				AddInParameter("@IsEnable", SqlDbType.TinyInt, 1, model.IsEnable),
				AddInParameter("@OrderID", SqlDbType.Int, 4, model.OrderID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Modules model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE " + tablePrefix + "Modules SET ");
            strSql.Append("ModuleID=@ModuleID,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("ModuleName=@ModuleName,");
            strSql.Append("EName=@EName,");
            strSql.Append("ModuleDepth=@ModuleDepth,");
            strSql.Append("ModuleURL=@ModuleURL,");
            strSql.Append("Target=@Target,");
            strSql.Append("Description=@Description,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("IsQuickMenu=@IsQuickMenu,");
            strSql.Append("IsSystem=@IsSystem,");
            strSql.Append("IsEnable=@IsEnable,");
            strSql.Append("OrderID=@OrderID");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@ModuleID", SqlDbType.VarChar, 8, model.ModuleID),
				AddInParameter("@ParentID", SqlDbType.VarChar, 8, model.ParentID),
				AddInParameter("@ModuleName", SqlDbType.NVarChar, 50, model.ModuleName),
				AddInParameter("@EName", SqlDbType.VarChar, 50, model.EName),
				AddInParameter("@ModuleDepth", SqlDbType.TinyInt, 1, model.ModuleDepth),
				AddInParameter("@ModuleURL", SqlDbType.VarChar, 255, model.ModuleURL),
				AddInParameter("@Target", SqlDbType.VarChar, 20, model.Target),
				AddInParameter("@Description", SqlDbType.NVarChar, 200, model.Description),
				AddInParameter("@CreateTime", SqlDbType.DateTime, 8, model.CreateTime),
				AddInParameter("@IsQuickMenu", SqlDbType.TinyInt, 1, model.IsQuickMenu),
				AddInParameter("@IsSystem", SqlDbType.TinyInt, 1, model.IsSystem),
				AddInParameter("@IsEnable", SqlDbType.TinyInt, 1, model.IsEnable),
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
            strSql.Append("UPDATE " + tablePrefix + "Modules SET ");
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
            strSql.Append("DELETE FROM " + tablePrefix + "Modules");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@ID", SqlDbType.Int, 4, ID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
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
                strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Modules");
                strSql.Append(" WHERE ID<>{0} AND {1}={2}");
                return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), ID, filedName, filedValue))) > 0;
            }
            else
            {
                strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Modules");
                strSql.Append(" WHERE ID={0}");
                return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), ID))) > 0;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <returns>实体对象</returns>
        public Modules GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,ModuleID,ParentID,ModuleName,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID FROM " + tablePrefix + "Modules");
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
                strSql = string.Format("SELECT TOP 1 {0} FROM {1}Modules", filed, tablePrefix);
            }
            else
            {
                strSql = string.Format("SELECT TOP 1 {0} FROM {1}Modules WHERE {2}", filed, tablePrefix, where);
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
                strSql = string.Format("SELECT {0} FROM {1}Modules", fileds, tablePrefix);
            }
            else
            {
                strSql = string.Format("SELECT {0} FROM {1}Modules WHERE {2}", fileds, tablePrefix, where);
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
        /// 通过ModuleControl获取模块
        /// </summary>
        public DataTable GetModulesByControl()
        {
            string strSql = "SELECT M.ModuleID,ParentID,ModuleName,M.OrderID FROM dt_Modules M INNER JOIN DT_ModuleControl C ON M.ModuleID=C.ModuleID GROUP BY M.ModuleID,ParentID,ModuleName,ModuleDepth,M.OrderID";

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
        /// 根据查询条件获取模块泛型数据列表
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="count">返回记录总数</param>
        /// <returns>模块对象泛型集合</returns>
        public List<Modules> GetList(SqlLoading sl, out int count)
        {
            string strSql = string.Format("SELECT ID,ModuleID,ParentID,ModuleName,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID FROM {0}Modules{1} ORDER BY OrderID", tablePrefix, sl.GetSqlWhereString());

            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql, null))
            {
                List<Modules> lst = GetList(dr, out count);
                return lst;
            }
        }

        /// <summary>
        /// 获取模块泛型数据列表
        /// </summary>
        /// <param name="count">返回记录总数</param>
        /// <returns>模块对象泛型集合</returns>
        public List<Modules> GetList(out int count)
        {
            string strSql = string.Format("SELECT ID,ModuleID,ParentID,ModuleName,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID FROM {0}Modules ORDER BY OrderID", tablePrefix);
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql, null))
            {
                List<Modules> lst = GetList(dr, out count);
                return lst;
            }
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="count">返回记录数</param>
        /// <returns>分页对象泛型集合</returns>
        public List<Modules> GetPageList(int pageSize, int pageIndex, out int count)
        {
            string strSql = string.Format("SELECT ID,ModuleID,ParentID,ModuleName,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable FROM {0}Modules ORDER BY OrderID", tablePrefix);
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql, null))
            {
                List<Modules> lst = GetPageList(dr, pageSize, pageIndex, out count);
                return lst;
            }
        }

        #region 私有方法，通常情况下无需修改
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <returns>实体对象</returns>
        private Modules GetModel(SqlDataReader dr)
        {
            Modules model = new Modules();
            model.ID = dbHelper.GetInt(dr["ID"]);
            model.ModuleID = dbHelper.GetString(dr["ModuleID"]);
            model.ParentID = dbHelper.GetString(dr["ParentID"]);
            model.ModuleName = dbHelper.GetString(dr["ModuleName"]);
            model.EName = dbHelper.GetString(dr["EName"]);
            model.ModuleDepth = dbHelper.GetByte(dr["ModuleDepth"]);
            model.ModuleURL = dbHelper.GetString(dr["ModuleURL"]);
            model.Target = dbHelper.GetString(dr["Target"]);
            model.Description = dbHelper.GetString(dr["Description"]);
            model.CreateTime = dbHelper.GetDateTime(dr["CreateTime"]);
            model.IsQuickMenu = dbHelper.GetByte(dr["IsQuickMenu"]);
            model.IsSystem = dbHelper.GetByte(dr["IsSystem"]);
            model.IsEnable = dbHelper.GetByte(dr["IsEnable"]);
            model.OrderID = dbHelper.GetInt(dr["OrderID"]);
            return model;
        }

        /// <summary>
        /// 由SqlDataReader得到泛型数据列表
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        private List<Modules> GetList(SqlDataReader dr, out int count)
        {
            count = 0;
            List<Modules> lst = new List<Modules>();
            while (dr.Read())
            {
                count++;
                lst.Add(GetModel(dr));
            }
            return lst;
        }

        /// <summary>
        /// 由SqlDataReader得到分页泛型数据列表
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="count">返回记录总数</param>
        /// <returns>分页对象泛型集合</returns>
        private List<Modules> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out int count)
        {
            int first = GetFirstIndex(pageSize, pageIndex);
            int last = GetLastIndex(pageSize, pageIndex);

            count = 0;

            List<Modules> lst = new List<Modules>();
            while (dr.Read())
            {
                count++;
                if (count >= first && count <= last)
                    lst.Add(GetModel(dr));
            }
            return lst;
        }
        #endregion
    }
}
