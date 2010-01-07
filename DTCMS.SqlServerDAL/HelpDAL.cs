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
	/// 数据访问类 Help
	/// </summary>
	public class HelpDAL : BaseDAL, IDAL_Help
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Help model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Help(");
            strSql.Append("HelpID,PID,Title,Message)");
			strSql.Append(" VALUES (");
            strSql.Append("@HelpID,@PID,@Title,@Message)");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@HelpID", DbType.AnsiStringFixedLength, model.HelpID),
				dbHelper.CreateInDbParameter("@PID", DbType.AnsiStringFixedLength, model.PID),
				dbHelper.CreateInDbParameter("@Title", DbType.String, model.Title),
				dbHelper.CreateInDbParameter("@Message", DbType.String, model.Message)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Help model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Help SET ");
			strSql.Append("HelpID=@HelpID,");
			strSql.Append("PID=@PID,");
			strSql.Append("Title=@Title,");
			strSql.Append("Message=@Message,");
			strSql.Append("OrderID=@OrderID");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@HelpID", DbType.AnsiStringFixedLength, model.HelpID),
				dbHelper.CreateInDbParameter("@PID", DbType.AnsiStringFixedLength, model.PID),
				dbHelper.CreateInDbParameter("@Title", DbType.String, model.Title),
				dbHelper.CreateInDbParameter("@Message", DbType.String, model.Message),
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
			strSql.Append("DELETE FROM Help ");
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
			strSql.Append("SELECT COUNT(1) FROM Help");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Help GetModel(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,HelpID,PID,Title,Message,OrderID FROM Help");
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
		public List<Help> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,HelpID,PID,Title,Message,OrderID FROM Help");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Help> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Help> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,HelpID,PID,Title,Message,OrderID FROM Help");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Help> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Help GetModel(DbDataReader dr)
		{
			Help model = new Help();
			model.ID = dbHelper.GetInt(dr["ID"]);
			model.HelpID = dbHelper.GetString(dr["HelpID"]);
			model.PID = dbHelper.GetString(dr["PID"]);
			model.Title = dbHelper.GetString(dr["Title"]);
			model.Message = dbHelper.GetString(dr["Message"]);
			model.OrderID = dbHelper.GetInt(dr["OrderID"]);
			return model;
		}

		/// <summary>
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<Help> GetList(DbDataReader dr, out long count)
		{
			count = 0;
			List<Help> lst = new List<Help>();
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
		private List<Help> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<Help> lst = new List<Help>();
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
