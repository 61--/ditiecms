//------------------------------------------------------------------------------
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
	/// 数据访问类 Sys_Template
	/// </summary>
	public class Sys_TemplateDAL : BaseDAL, IDAL_Sys_Template
	{
		public Sys_TemplateDAL()
		{ }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Sys_Template model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Sys_Template(");
            strSql.Append("TemplateName,TemplateDirectory,IsEnable,CreateDateTime,TemplateImg,Author)");
			strSql.Append(" VALUES (");
            strSql.Append("@TemplateName,@TemplateDirectory,@IsEnable,@CreateDateTime,@TemplateImg,@Author)");
			SqlParameter[] cmdParms = {
				AddInParameter("@TemplateName", SqlDbType.NVarChar, 100, model.TemplateName),
				AddInParameter("@TemplateDirectory", SqlDbType.VarChar, 255, model.TemplateDirectory),
				AddInParameter("@IsEnable", SqlDbType.TinyInt, 1, model.IsEnable),
				AddInParameter("@CreateDateTime", SqlDbType.DateTime, 8, model.CreateDateTime),
				AddInParameter("@TemplateImg", SqlDbType.VarChar, 255, model.TemplateImg),
				AddInParameter("@Author", SqlDbType.NVarChar, 100, model.Author)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Sys_Template model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Sys_Template SET ");
			strSql.Append("TemplateName=@TemplateName,");
			strSql.Append("TemplateDirectory=@TemplateDirectory,");
			strSql.Append("IsEnable=@IsEnable,");
			strSql.Append("CreateDateTime=@CreateDateTime,");
			strSql.Append("TemplateImg=@TemplateImg,");
			strSql.Append("Author=@Author");
			strSql.Append(" WHERE TemplateID=@TemplateID");
			SqlParameter[] cmdParms = {
				AddInParameter("@TemplateName", SqlDbType.NVarChar, 100, model.TemplateName),
				AddInParameter("@TemplateDirectory", SqlDbType.VarChar, 255, model.TemplateDirectory),
				AddInParameter("@IsEnable", SqlDbType.TinyInt, 1, model.IsEnable),
				AddInParameter("@CreateDateTime", SqlDbType.DateTime, 8, model.CreateDateTime),
				AddInParameter("@TemplateImg", SqlDbType.VarChar, 255, model.TemplateImg),
				AddInParameter("@Author", SqlDbType.NVarChar, 100, model.Author),
				AddInParameter("@TemplateID", SqlDbType.Int, 4, model.TemplateID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int TemplateID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM Sys_Template ");
			strSql.Append(" WHERE TemplateID=@TemplateID");
			SqlParameter[] cmdParms = {
				AddInParameter("@TemplateID", SqlDbType.Int, 4, TemplateID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TemplateID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM Sys_Template");
			strSql.Append(" WHERE TemplateID=@TemplateID");
			SqlParameter[] cmdParms = {
				AddInParameter("@TemplateID", SqlDbType.Int, 4, TemplateID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sys_Template GetModel(int TemplateID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT TemplateID,TemplateName,TemplateDirectory,IsEnable,CreateDateTime,TemplateImg,Author FROM Sys_Template");
			strSql.Append(" WHERE TemplateID=@TemplateID");
			SqlParameter[] cmdParms = {
				AddInParameter("@TemplateID", SqlDbType.Int, 4, TemplateID)};

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
		public List<Sys_Template> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT TemplateID,TemplateName,TemplateDirectory,IsEnable,CreateDateTime,TemplateImg,Author FROM Sys_Template");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Sys_Template> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Sys_Template> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT TemplateID,TemplateName,TemplateDirectory,IsEnable,CreateDateTime,TemplateImg,Author FROM Sys_Template");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Sys_Template> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region 私有方法，通常情况下无需修改
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Sys_Template GetModel(SqlDataReader dr)
		{
			Sys_Template model = new Sys_Template();
			model.TemplateID = dbHelper.GetInt(dr["TemplateID"]);
			model.TemplateName = dbHelper.GetString(dr["TemplateName"]);
			model.TemplateDirectory = dbHelper.GetString(dr["TemplateDirectory"]);
			model.IsEnable = dbHelper.GetByte(dr["IsEnable"]);
			model.CreateDateTime = dbHelper.GetDateTime(dr["CreateDateTime"]);
			model.TemplateImg = dbHelper.GetString(dr["TemplateImg"]);
			model.Author = dbHelper.GetString(dr["Author"]);
			return model;
		}

		/// <summary>
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		private List<Sys_Template> GetList(SqlDataReader dr, out long count)
		{
			count = 0;
			List<Sys_Template> lst = new List<Sys_Template>();
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
		private List<Sys_Template> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<Sys_Template> lst = new List<Sys_Template>();
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
