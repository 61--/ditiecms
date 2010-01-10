//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 19:36:36
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
	/// 数据访问类 Userfields
	/// </summary>
	public class UserfieldsDAL : BaseDAL, IDAL_Userfields
	{
		public UserfieldsDAL()
		{ }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		/// <param name="UID">编号ID</param>
		/// <returns>返回影响行数</returns>
		public int Add(Userfields model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO " + tablePrefix + "Userfields(");
            strSql.Append("UID,Realname,QQ,MSN,Skype,Phone,Mobilephone,Location,Adress,IDcard,Signature,Introduce,Website)");
			strSql.Append(" VALUES (");
            strSql.Append("@UID,@Realname,@QQ,@MSN,@Skype,@Phone,@Mobilephone,@Location,@Adress,@IDcard,@Signature,@Introduce,@Website)");
			SqlParameter[] cmdParms = {
				AddInParameter("@UID", SqlDbType.Int, 4, model.UID),
				AddInParameter("@Realname", SqlDbType.NVarChar, 50, model.Realname),
				AddInParameter("@QQ", SqlDbType.VarChar, 50, model.QQ),
				AddInParameter("@MSN", SqlDbType.VarChar, 50, model.MSN),
				AddInParameter("@Skype", SqlDbType.VarChar, 50, model.Skype),
				AddInParameter("@Phone", SqlDbType.Char, 16, model.Phone),
				AddInParameter("@Mobilephone", SqlDbType.Char, 11, model.Mobilephone),
				AddInParameter("@Location", SqlDbType.NVarChar, 50, model.Location),
				AddInParameter("@Adress", SqlDbType.NVarChar, 200, model.Adress),
				AddInParameter("@IDcard", SqlDbType.VarChar, 18, model.IDcard),
				AddInParameter("@Signature", SqlDbType.NVarChar, 200, model.Signature),
				AddInParameter("@Introduce", SqlDbType.NVarChar, 500, model.Introduce),
				AddInParameter("@Website", SqlDbType.VarChar, 200, model.Website)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		/// <param name="model">实体对象</param>
		/// <returns>返回影响行数</returns>
		public int Update(Userfields model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE " + tablePrefix + "Userfields SET ");
			strSql.Append("Realname=@Realname,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("MSN=@MSN,");
			strSql.Append("Skype=@Skype,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Mobilephone=@Mobilephone,");
			strSql.Append("Location=@Location,");
			strSql.Append("Adress=@Adress,");
			strSql.Append("IDcard=@IDcard,");
			strSql.Append("Signature=@Signature,");
			strSql.Append("Introduce=@Introduce,");
			strSql.Append("Website=@Website");
			strSql.Append(" WHERE UID=@UID");
			SqlParameter[] cmdParms = {
				AddInParameter("@Realname", SqlDbType.NVarChar, 50, model.Realname),
				AddInParameter("@QQ", SqlDbType.VarChar, 50, model.QQ),
				AddInParameter("@MSN", SqlDbType.VarChar, 50, model.MSN),
				AddInParameter("@Skype", SqlDbType.VarChar, 50, model.Skype),
				AddInParameter("@Phone", SqlDbType.Char, 16, model.Phone),
				AddInParameter("@Mobilephone", SqlDbType.Char, 11, model.Mobilephone),
				AddInParameter("@Location", SqlDbType.NVarChar, 50, model.Location),
				AddInParameter("@Adress", SqlDbType.NVarChar, 200, model.Adress),
				AddInParameter("@IDcard", SqlDbType.VarChar, 18, model.IDcard),
				AddInParameter("@Signature", SqlDbType.NVarChar, 200, model.Signature),
				AddInParameter("@Introduce", SqlDbType.NVarChar, 500, model.Introduce),
				AddInParameter("@Website", SqlDbType.VarChar, 200, model.Website),
				AddInParameter("@UID", SqlDbType.Int, 4, model.UID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		/// <param name="UID">编号ID</param>
		/// <returns>返回影响行数</returns>
		public int Delete(int UID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM " + tablePrefix + "Userfields");
			strSql.Append(" WHERE UID=@UID");
			SqlParameter[] cmdParms = {
				AddInParameter("@UID", SqlDbType.Int, 4, UID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		/// <param name="UID">编号ID</param>
		/// <param name="filedName">字段名称</param>
		/// <param name="filedValue">字段值</param>
		/// <returns>存在返回true，不存在返回false</returns>
		public bool Exists(int UID, string filedName, string filedValue)
		{
			StringBuilder strSql = new StringBuilder();
			if (filedName != "")
			{
				strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Userfields");
				strSql.Append(" WHERE UID<>{0} AND {1}={2}");
				return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), UID, filedName, filedValue))) > 0;
			}
			else
			{
				strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Userfields");
				strSql.Append(" WHERE UID={0}");
				return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), UID))) > 0;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		/// <param name="UID">编号ID</param>
		/// <returns>实体对象</returns>
		public Userfields GetModel(int UID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,Realname,QQ,MSN,Skype,Phone,Mobilephone,Location,Adress,IDcard,Signature,Introduce,Website FROM " + tablePrefix + "Userfields");
			strSql.Append(" WHERE UID=@UID");
			SqlParameter[] cmdParms = {
				AddInParameter("@UID", SqlDbType.Int, 4, UID)};

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
		/// <param name="count">返回记录总数</param>
		/// <returns>对象泛型集合</returns>
		public List<Userfields> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,Realname,QQ,MSN,Skype,Phone,Mobilephone,Location,Adress,IDcard,Signature,Introduce,Website FROM " + tablePrefix + "Userfields");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Userfields> lst = GetList(dr, out count);
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
		public List<Userfields> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,Realname,QQ,MSN,Skype,Phone,Mobilephone,Location,Adress,IDcard,Signature,Introduce,Website FROM " + tablePrefix + "Userfields");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Userfields> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region 私有方法，通常情况下无需修改
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		/// <param name="dr">SqlDataReader对象</param>
		/// <returns>实体对象</returns>
		private Userfields GetModel(SqlDataReader dr)
		{
			Userfields model = new Userfields();
			model.UID = dbHelper.GetInt(dr["UID"]);
			model.Realname = dbHelper.GetString(dr["Realname"]);
			model.QQ = dbHelper.GetString(dr["QQ"]);
			model.MSN = dbHelper.GetString(dr["MSN"]);
			model.Skype = dbHelper.GetString(dr["Skype"]);
			model.Phone = dbHelper.GetString(dr["Phone"]);
			model.Mobilephone = dbHelper.GetString(dr["Mobilephone"]);
			model.Location = dbHelper.GetString(dr["Location"]);
			model.Adress = dbHelper.GetString(dr["Adress"]);
			model.IDcard = dbHelper.GetString(dr["IDcard"]);
			model.Signature = dbHelper.GetString(dr["Signature"]);
			model.Introduce = dbHelper.GetString(dr["Introduce"]);
			model.Website = dbHelper.GetString(dr["Website"]);
			return model;
		}

		/// <summary>
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		/// <param name="dr">SqlDataReader对象</param>
		/// <param name="count">返回记录数</param>
		/// <returns>对象泛型集合</returns>
		private List<Userfields> GetList(SqlDataReader dr, out long count)
		{
			count = 0;
			List<Userfields> lst = new List<Userfields>();
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
		private List<Userfields> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<Userfields> lst = new List<Userfields>();
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
