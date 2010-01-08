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
            strSql.Append("TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg,Author)");
			strSql.Append(" VALUES (");
            strSql.Append("@TemplateName,@TemplateDirectory,@isEnable,@CreateDateTime,@TemplateImg,@Author)");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@TemplateName", DbType.String, model.TemplateName),
				dbHelper.CreateInDbParameter("@TemplateDirectory", DbType.AnsiString, model.TemplateDirectory),
				dbHelper.CreateInDbParameter("@isEnable", DbType.Byte, model.isEnable),
				dbHelper.CreateInDbParameter("@CreateDateTime", DbType.String, model.CreateDateTime),
				dbHelper.CreateInDbParameter("@TemplateImg", DbType.AnsiString, model.TemplateImg),
				dbHelper.CreateInDbParameter("@Author", DbType.String, model.Author)};

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
			strSql.Append("isEnable=@isEnable,");
			strSql.Append("CreateDateTime=@CreateDateTime,");
			strSql.Append("TemplateImg=@TemplateImg,");
			strSql.Append("Author=@Author");
			strSql.Append(" WHERE TemplateID=@TemplateID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@TemplateName", DbType.String, model.TemplateName),
				dbHelper.CreateInDbParameter("@TemplateDirectory", DbType.AnsiString, model.TemplateDirectory),
				dbHelper.CreateInDbParameter("@isEnable", DbType.Byte, model.isEnable),
				dbHelper.CreateInDbParameter("@CreateDateTime", DbType.String, model.CreateDateTime),
				dbHelper.CreateInDbParameter("@TemplateImg", DbType.AnsiString, model.TemplateImg),
				dbHelper.CreateInDbParameter("@Author", DbType.String, model.Author),
				dbHelper.CreateInDbParameter("@TemplateID", DbType.Int32, model.TemplateID)};

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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@TemplateID", DbType.Int32, TemplateID)};

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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@TemplateID", DbType.Int32, TemplateID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Sys_Template GetModel(int TemplateID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT TemplateID,TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg,Author FROM Sys_Template");
			strSql.Append(" WHERE TemplateID=@TemplateID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@TemplateID", DbType.Int32, TemplateID)};

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
		public List<Sys_Template> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT TemplateID,TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg,Author FROM Sys_Template");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
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
			strSql.Append("SELECT TemplateID,TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg,Author FROM Sys_Template");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Sys_Template> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Sys_Template GetModel(DbDataReader dr)
		{
			Sys_Template model = new Sys_Template();
			model.TemplateID = dbHelper.GetInt(dr["TemplateID"]);
			model.TemplateName = dbHelper.GetString(dr["TemplateName"]);
			model.TemplateDirectory = dbHelper.GetString(dr["TemplateDirectory"]);
			model.isEnable = dbHelper.GetByte(dr["isEnable"]);
			model.CreateDateTime = dbHelper.GetDateTime(dr["CreateDateTime"]);
			model.TemplateImg = dbHelper.GetString(dr["TemplateImg"]);
			model.Author = dbHelper.GetString(dr["Author"]);
			return model;
		}

		/// <summary>
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<Sys_Template> GetList(DbDataReader dr, out long count)
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
		/// 由DbDataReader得到分页泛型数据列表
		/// </summary>
		private List<Sys_Template> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
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
