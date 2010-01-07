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
	/// 数据访问类 AttachMent
	/// </summary>
	public class AttachMentDAL : BaseDAL, IDAL_AttachMent
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AttachMent model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO AttachMent(");
            strSql.Append("AttachMentAttribute,AttachMentDisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription)");
			strSql.Append(" VALUES (");
            strSql.Append("@AttachMentAttribute,@AttachMentDisplayName,@AttachMentPath,@AttachMentSize,@AbbrPhotoPath,@PubLisher,@AddDate,@PhotoDescription)");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@AttachMentAttribute", DbType.Int32, model.AttachMentAttribute),
				dbHelper.CreateInDbParameter("@AttachMentDisplayName", DbType.String, model.AttachMentDisplayName),
				dbHelper.CreateInDbParameter("@AttachMentPath", DbType.String, model.AttachMentPath),
				dbHelper.CreateInDbParameter("@AttachMentSize", DbType.String, model.AttachMentSize),
				dbHelper.CreateInDbParameter("@AbbrPhotoPath", DbType.String, model.AbbrPhotoPath),
				dbHelper.CreateInDbParameter("@PubLisher", DbType.String, model.PubLisher),
				dbHelper.CreateInDbParameter("@AddDate", DbType.String, model.AddDate),
				dbHelper.CreateInDbParameter("@PhotoDescription", DbType.String, model.PhotoDescription)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(AttachMent model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE AttachMent SET ");
			strSql.Append("AttachMentAttribute=@AttachMentAttribute,");
			strSql.Append("AttachMentDisplayName=@AttachMentDisplayName,");
			strSql.Append("AttachMentPath=@AttachMentPath,");
			strSql.Append("AttachMentSize=@AttachMentSize,");
			strSql.Append("AbbrPhotoPath=@AbbrPhotoPath,");
			strSql.Append("PubLisher=@PubLisher,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("PhotoDescription=@PhotoDescription");
			strSql.Append(" WHERE AttachMentID=@AttachMentID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@AttachMentAttribute", DbType.Int32, model.AttachMentAttribute),
				dbHelper.CreateInDbParameter("@AttachMentDisplayName", DbType.String, model.AttachMentDisplayName),
				dbHelper.CreateInDbParameter("@AttachMentPath", DbType.String, model.AttachMentPath),
				dbHelper.CreateInDbParameter("@AttachMentSize", DbType.String, model.AttachMentSize),
				dbHelper.CreateInDbParameter("@AbbrPhotoPath", DbType.String, model.AbbrPhotoPath),
				dbHelper.CreateInDbParameter("@PubLisher", DbType.String, model.PubLisher),
				dbHelper.CreateInDbParameter("@AddDate", DbType.String, model.AddDate),
				dbHelper.CreateInDbParameter("@PhotoDescription", DbType.String, model.PhotoDescription),
				dbHelper.CreateInDbParameter("@AttachMentID", DbType.Int32, model.AttachMentID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int AttachMentID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM AttachMent ");
			strSql.Append(" WHERE AttachMentID=@AttachMentID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@AttachMentID", DbType.Int32, AttachMentID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AttachMentID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM AttachMent");
			strSql.Append(" WHERE AttachMentID=@AttachMentID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@AttachMentID", DbType.Int32, AttachMentID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AttachMent GetModel(int AttachMentID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AttachMentID,AttachMentAttribute,AttachMentDisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription FROM AttachMent");
			strSql.Append(" WHERE AttachMentID=@AttachMentID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@AttachMentID", DbType.Int32, AttachMentID)};

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
		public List<AttachMent> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AttachMentID,AttachMentAttribute,AttachMentDisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription FROM AttachMent");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<AttachMent> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<AttachMent> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AttachMentID,AttachMentAttribute,AttachMentDisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription FROM AttachMent");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<AttachMent> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private AttachMent GetModel(DbDataReader dr)
		{
			AttachMent model = new AttachMent();
			model.AttachMentID = dbHelper.GetInt(dr["AttachMentID"]);
			model.AttachMentAttribute = dbHelper.GetInt(dr["AttachMentAttribute"]);
			model.AttachMentDisplayName = dbHelper.GetString(dr["AttachMentDisplayName"]);
			model.AttachMentPath = dbHelper.GetString(dr["AttachMentPath"]);
			model.AttachMentSize = dbHelper.GetString(dr["AttachMentSize"]);
			model.AbbrPhotoPath = dbHelper.GetString(dr["AbbrPhotoPath"]);
			model.PubLisher = dbHelper.GetString(dr["PubLisher"]);
			model.AddDate = dbHelper.GetDateTime(dr["AddDate"]);
			model.PhotoDescription = dbHelper.GetString(dr["PhotoDescription"]);
			return model;
		}

		/// <summary>
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<AttachMent> GetList(DbDataReader dr, out long count)
		{
			count = 0;
			List<AttachMent> lst = new List<AttachMent>();
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
		private List<AttachMent> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<AttachMent> lst = new List<AttachMent>();
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
