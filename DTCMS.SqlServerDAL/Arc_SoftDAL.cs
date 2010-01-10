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
	/// 数据访问类 Arc_Soft
	/// </summary>
	public class Arc_SoftDAL : BaseDAL, IDAL_Arc_Soft
	{
		public Arc_SoftDAL()
		{ }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Arc_Soft model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Arc_Soft(");
            strSql.Append("AID)");
			strSql.Append(" VALUES (");
            strSql.Append("@AID)");
			SqlParameter[] cmdParms = {
				AddInParameter("@AID", SqlDbType.Int, 4, model.AID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Arc_Soft model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Arc_Soft SET ");
			strSql.Append("AID=@AID");
			strSql.Append(" WHERE AID=@AID");
			SqlParameter[] cmdParms = {
				AddInParameter("@AID", SqlDbType.Int, 4, model.AID),
				AddInParameter("@AID", SqlDbType.Int, 4, model.AID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int AID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM Arc_Soft ");
			strSql.Append(" WHERE AID=@AID");
			SqlParameter[] cmdParms = {
				AddInParameter("@AID", SqlDbType.Int, 4, AID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM Arc_Soft");
			strSql.Append(" WHERE AID=@AID");
			SqlParameter[] cmdParms = {
				AddInParameter("@AID", SqlDbType.Int, 4, AID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Arc_Soft GetModel(int AID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AID FROM Arc_Soft");
			strSql.Append(" WHERE AID=@AID");
			SqlParameter[] cmdParms = {
				AddInParameter("@AID", SqlDbType.Int, 4, AID)};

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
		public List<Arc_Soft> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AID FROM Arc_Soft");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Soft> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Arc_Soft> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AID FROM Arc_Soft");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Soft> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region 私有方法，通常情况下无需修改
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Arc_Soft GetModel(SqlDataReader dr)
		{
			Arc_Soft model = new Arc_Soft();
			model.AID = dbHelper.GetInt(dr["AID"]);
			return model;
		}

		/// <summary>
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		private List<Arc_Soft> GetList(SqlDataReader dr, out long count)
		{
			count = 0;
			List<Arc_Soft> lst = new List<Arc_Soft>();
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
		private List<Arc_Soft> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<Arc_Soft> lst = new List<Arc_Soft>();
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
