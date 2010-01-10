//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 14:24:59
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
	/// 数据访问类 Sys_Dict
	/// </summary>
	public class Sys_DictDAL : BaseDAL, IDAL_Sys_Dict
	{
		public Sys_DictDAL()
		{ }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sys_Dict model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Sys_Dict(");
            strSql.Append("Type,Title,Url,Email,Click)");
			strSql.Append(" VALUES (");
            strSql.Append("@Type,@Title,@Url,@Email,@Click)");
			SqlParameter[] cmdParms = {
				AddInParameter("@Type", SqlDbType.VarChar, 50, model.Type),
				AddInParameter("@Title", SqlDbType.NVarChar, 50, model.Title),
				AddInParameter("@Url", SqlDbType.VarChar, 255, model.Url),
				AddInParameter("@Email", SqlDbType.VarChar, 50, model.Email),
				AddInParameter("@Click", SqlDbType.Int, 4, model.Click)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Sys_Dict model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Sys_Dict SET ");
			strSql.Append("Type=@Type,");
			strSql.Append("Title=@Title,");
			strSql.Append("Url=@Url,");
			strSql.Append("Email=@Email,");
			strSql.Append("Click=@Click");
			strSql.Append(" WHERE ID=@ID");
			SqlParameter[] cmdParms = {
				AddInParameter("@Type", SqlDbType.VarChar, 50, model.Type),
				AddInParameter("@Title", SqlDbType.NVarChar, 25, model.Title),
				AddInParameter("@Url", SqlDbType.VarChar, 255, model.Url),
				AddInParameter("@Email", SqlDbType.VarChar, 50, model.Email),
				AddInParameter("@Click", SqlDbType.Int, 4, model.Click),
				AddInParameter("@ID", SqlDbType.Int, 4, model.ID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM Sys_Dict ");
			strSql.Append(" WHERE ID=@ID");
			SqlParameter[] cmdParms = {
				AddInParameter("@ID", SqlDbType.Int, 4, ID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM Sys_Dict");
			strSql.Append(" WHERE ID=@ID");
			SqlParameter[] cmdParms = {
				AddInParameter("@ID", SqlDbType.Int, 4, ID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sys_Dict GetModel(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,Type,Title,Url,Email,Click FROM Sys_Dict");
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
		/// 获取泛型数据列表
		/// </summary>
		public List<Sys_Dict> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,Type,Title,Url,Email,Click FROM Sys_Dict");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Sys_Dict> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Sys_Dict> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,Type,Title,Url,Email,Click FROM Sys_Dict");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Sys_Dict> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region 私有方法，通常情况下无需修改
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Sys_Dict GetModel(SqlDataReader dr)
		{
			Sys_Dict model = new Sys_Dict();
			model.ID = dbHelper.GetInt(dr["ID"]);
			model.Type = dbHelper.GetString(dr["Type"]);
			model.Title = dbHelper.GetString(dr["Title"]);
			model.Url = dbHelper.GetString(dr["Url"]);
			model.Email = dbHelper.GetString(dr["Email"]);
			model.Click = dbHelper.GetInt(dr["Click"]);
			return model;
		}

		/// <summary>
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		private List<Sys_Dict> GetList(SqlDataReader dr, out long count)
		{
			count = 0;
			List<Sys_Dict> lst = new List<Sys_Dict>();
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
		private List<Sys_Dict> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<Sys_Dict> lst = new List<Sys_Dict>();
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
