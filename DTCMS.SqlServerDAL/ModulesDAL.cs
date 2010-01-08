//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-8 11:52:52
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DTCMS.Entity;
using DTCMS.IDAL;

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
		public int Add(Modules model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Modules(");
            strSql.Append("ModuleID,ParentID,Name,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID)");
			strSql.Append(" VALUES (");
            strSql.Append("@ModuleID,@ParentID,@Name,@EName,@ModuleDepth,@ModuleURL,@Target,@Description,@CreateTime,@IsQuickMenu,@IsSystem,@IsEnable,@OrderID)");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ModuleID", DbType.AnsiStringFixedLength, model.ModuleID),
				dbHelper.CreateInDbParameter("@ParentID", DbType.AnsiStringFixedLength, model.ParentID),
				dbHelper.CreateInDbParameter("@Name", DbType.String, model.Name),
				dbHelper.CreateInDbParameter("@EName", DbType.AnsiString, model.EName),
				dbHelper.CreateInDbParameter("@ModuleDepth", DbType.Byte, model.ModuleDepth),
				dbHelper.CreateInDbParameter("@ModuleURL", DbType.AnsiString, model.ModuleURL),
				dbHelper.CreateInDbParameter("@Target", DbType.AnsiString, model.Target),
				dbHelper.CreateInDbParameter("@Description", DbType.String, model.Description),
				dbHelper.CreateInDbParameter("@CreateTime", DbType.String, model.CreateTime),
				dbHelper.CreateInDbParameter("@IsQuickMenu", DbType.Byte, model.IsQuickMenu),
				dbHelper.CreateInDbParameter("@IsSystem", DbType.Byte, model.IsSystem),
				dbHelper.CreateInDbParameter("@IsEnable", DbType.Byte, model.IsEnable),
				dbHelper.CreateInDbParameter("@OrderID", DbType.Int32, model.OrderID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Modules model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Modules SET ");
			strSql.Append("ModuleID=@ModuleID,");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("Name=@Name,");
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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ModuleID", DbType.AnsiStringFixedLength, model.ModuleID),
				dbHelper.CreateInDbParameter("@ParentID", DbType.AnsiStringFixedLength, model.ParentID),
				dbHelper.CreateInDbParameter("@Name", DbType.String, model.Name),
				dbHelper.CreateInDbParameter("@EName", DbType.AnsiString, model.EName),
				dbHelper.CreateInDbParameter("@ModuleDepth", DbType.Byte, model.ModuleDepth),
				dbHelper.CreateInDbParameter("@ModuleURL", DbType.AnsiString, model.ModuleURL),
				dbHelper.CreateInDbParameter("@Target", DbType.AnsiString, model.Target),
				dbHelper.CreateInDbParameter("@Description", DbType.String, model.Description),
				dbHelper.CreateInDbParameter("@CreateTime", DbType.String, model.CreateTime),
				dbHelper.CreateInDbParameter("@IsQuickMenu", DbType.Byte, model.IsQuickMenu),
				dbHelper.CreateInDbParameter("@IsSystem", DbType.Byte, model.IsSystem),
				dbHelper.CreateInDbParameter("@IsEnable", DbType.Byte, model.IsEnable),
				dbHelper.CreateInDbParameter("@OrderID", DbType.Int32, model.OrderID),
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, model.ID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM Modules ");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM Modules");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Modules GetModel(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,ModuleID,ParentID,Name,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID FROM Modules");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
			{
				if (dr.Read())
				{
					return GetModel(dr);
				}
				return null;
			}
		}

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		public List<Modules> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,ModuleID,ParentID,Name,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID FROM Modules");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Modules> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Modules> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,ModuleID,ParentID,Name,EName,ModuleDepth,ModuleURL,Target,Description,CreateTime,IsQuickMenu,IsSystem,IsEnable,OrderID FROM Modules");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Modules> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Modules GetModel(DbDataReader dr)
		{
			Modules model = new Modules();
			model.ID = dbHelper.GetInt(dr["ID"]);
			model.ModuleID = dbHelper.GetString(dr["ModuleID"]);
			model.ParentID = dbHelper.GetString(dr["ParentID"]);
			model.Name = dbHelper.GetString(dr["Name"]);
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
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<Modules> GetList(DbDataReader dr, out long count)
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
		/// 由DbDataReader得到分页泛型数据列表
		/// </summary>
		private List<Modules> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

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
