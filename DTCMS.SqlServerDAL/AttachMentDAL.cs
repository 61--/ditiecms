﻿//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 13:57:20
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
	/// 数据访问类 AttachMent
	/// </summary>
	public class AttachMentDAL : BaseDAL, IDAL_AttachMent
	{
		public AttachMentDAL()
		{ }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(AttachMent model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO AttachMent(");
            strSql.Append("Attribute,DisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription)");
			strSql.Append(" VALUES (");
            strSql.Append("@Attribute,@DisplayName,@AttachMentPath,@AttachMentSize,@AbbrPhotoPath,@PubLisher,@AddDate,@PhotoDescription)");
			SqlParameter[] cmdParms = {
				AddInParameter("@Attribute", SqlDbType.TinyInt, 1, model.Attribute),
				AddInParameter("@DisplayName", SqlDbType.NVarChar, 100, model.DisplayName),
				AddInParameter("@AttachMentPath", SqlDbType.VarChar, 255, model.AttachMentPath),
				AddInParameter("@AttachMentSize", SqlDbType.Int, 4, model.AttachMentSize),
				AddInParameter("@AbbrPhotoPath", SqlDbType.VarChar, 255, model.AbbrPhotoPath),
				AddInParameter("@PubLisher", SqlDbType.NVarChar, 100, model.PubLisher),
				AddInParameter("@AddDate", SqlDbType.DateTime, 8, model.AddDate),
				AddInParameter("@PhotoDescription", SqlDbType.NVarChar, 200, model.PhotoDescription)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(AttachMent model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE AttachMent SET ");
			strSql.Append("Attribute=@Attribute,");
			strSql.Append("DisplayName=@DisplayName,");
			strSql.Append("AttachMentPath=@AttachMentPath,");
			strSql.Append("AttachMentSize=@AttachMentSize,");
			strSql.Append("AbbrPhotoPath=@AbbrPhotoPath,");
			strSql.Append("PubLisher=@PubLisher,");
			strSql.Append("AddDate=@AddDate,");
			strSql.Append("PhotoDescription=@PhotoDescription");
			strSql.Append(" WHERE AID=@AID");
			SqlParameter[] cmdParms = {
				AddInParameter("@Attribute", SqlDbType.TinyInt, 1, model.Attribute),
				AddInParameter("@DisplayName", SqlDbType.NVarChar, 100, model.DisplayName),
				AddInParameter("@AttachMentPath", SqlDbType.VarChar, 255, model.AttachMentPath),
				AddInParameter("@AttachMentSize", SqlDbType.Int, 4, model.AttachMentSize),
				AddInParameter("@AbbrPhotoPath", SqlDbType.VarChar, 255, model.AbbrPhotoPath),
				AddInParameter("@PubLisher", SqlDbType.NVarChar, 100, model.PubLisher),
				AddInParameter("@AddDate", SqlDbType.DateTime, 8, model.AddDate),
				AddInParameter("@PhotoDescription", SqlDbType.NVarChar, 200, model.PhotoDescription),
				AddInParameter("@AID", SqlDbType.Int, 4, model.AID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int AID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM AttachMent ");
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
			strSql.Append("SELECT COUNT(1) FROM AttachMent");
			strSql.Append(" WHERE AID=@AID");
			SqlParameter[] cmdParms = {
				AddInParameter("@AID", SqlDbType.Int, 4, AID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public AttachMent GetModel(int AID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AID,Attribute,DisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription FROM AttachMent");
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
		public List<AttachMent> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT AID,Attribute,DisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription FROM AttachMent");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
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
			strSql.Append("SELECT AID,Attribute,DisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription FROM AttachMent");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<AttachMent> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region 私有方法，通常情况下无需修改
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private AttachMent GetModel(SqlDataReader dr)
		{
			AttachMent model = new AttachMent();
			model.AID = dbHelper.GetInt(dr["AID"]);
			model.Attribute = dbHelper.GetByte(dr["Attribute"]);
			model.DisplayName = dbHelper.GetString(dr["DisplayName"]);
			model.AttachMentPath = dbHelper.GetString(dr["AttachMentPath"]);
			model.AttachMentSize = dbHelper.GetInt(dr["AttachMentSize"]);
			model.AbbrPhotoPath = dbHelper.GetString(dr["AbbrPhotoPath"]);
			model.PubLisher = dbHelper.GetString(dr["PubLisher"]);
			model.AddDate = dbHelper.GetDateTime(dr["AddDate"]);
			model.PhotoDescription = dbHelper.GetString(dr["PhotoDescription"]);
			return model;
		}

		/// <summary>
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		private List<AttachMent> GetList(SqlDataReader dr, out long count)
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
		/// 由SqlDataReader得到分页泛型数据列表
		/// </summary>
		private List<AttachMent> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
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
