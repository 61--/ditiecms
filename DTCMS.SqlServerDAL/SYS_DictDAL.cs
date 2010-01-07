//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-7 23:34:18
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
	/// 数据访问类 SYS_Dict
	/// </summary>
	public class SYS_DictDAL : BaseDAL, IDAL_SYS_Dict
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SYS_Dict model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO SYS_Dict(");
            strSql.Append("Type,Title,Url,Email)");
			strSql.Append(" VALUES (");
            strSql.Append("@Type,@Title,@Url,@Email)");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@Type", DbType.String, model.Type),
				dbHelper.CreateInDbParameter("@Title", DbType.String, model.Title),
				dbHelper.CreateInDbParameter("@Url", DbType.String, model.Url),
				dbHelper.CreateInDbParameter("@Email", DbType.String, model.Email)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(SYS_Dict model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE SYS_Dict SET ");
			strSql.Append("Type=@Type,");
			strSql.Append("Title=@Title,");
			strSql.Append("Url=@Url,");
			strSql.Append("Email=@Email,");
			strSql.Append("Hits=@Hits");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@Type", DbType.String, model.Type),
				dbHelper.CreateInDbParameter("@Title", DbType.String, model.Title),
				dbHelper.CreateInDbParameter("@Url", DbType.String, model.Url),
				dbHelper.CreateInDbParameter("@Email", DbType.String, model.Email),
				dbHelper.CreateInDbParameter("@Hits", DbType.Int32, model.Hits),
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, model.ID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM SYS_Dict ");
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
			strSql.Append("SELECT COUNT(1) FROM SYS_Dict");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SYS_Dict GetModel(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,Type,Title,Url,Email,Hits FROM SYS_Dict");
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
		public List<SYS_Dict> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,Type,Title,Url,Email,Hits FROM SYS_Dict");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<SYS_Dict> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<SYS_Dict> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,Type,Title,Url,Email,Hits FROM SYS_Dict");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<SYS_Dict> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private SYS_Dict GetModel(DbDataReader dr)
		{
			SYS_Dict model = new SYS_Dict();
			model.ID = dbHelper.GetInt(dr["ID"]);
			model.Type = dbHelper.GetString(dr["Type"]);
			model.Title = dbHelper.GetString(dr["Title"]);
			model.Url = dbHelper.GetString(dr["Url"]);
			model.Email = dbHelper.GetString(dr["Email"]);
			model.Hits = dbHelper.GetInt(dr["Hits"]);
			return model;
		}

		/// <summary>
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<SYS_Dict> GetList(DbDataReader dr, out long count)
		{
			count = 0;
			List<SYS_Dict> lst = new List<SYS_Dict>();
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
		private List<SYS_Dict> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<SYS_Dict> lst = new List<SYS_Dict>();
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
