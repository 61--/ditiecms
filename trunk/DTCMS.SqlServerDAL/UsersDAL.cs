﻿//------------------------------------------------------------------------------
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
	/// 数据访问类 Users
	/// </summary>
	public class UsersDAL : BaseDAL, IDAL_Users
	{
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Users model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Users(");
            strSql.Append("UserName,NickName,Password,SecureQuestion,SecureAnswer,Email,RegisterIP,LastloginIP,ExtCredits4,ExtCredits5,Avatar,Birthday)");
			strSql.Append(" VALUES (");
            strSql.Append("@UserName,@NickName,@Password,@SecureQuestion,@SecureAnswer,@Email,@RegisterIP,@LastloginIP,@ExtCredits4,@ExtCredits5,@Avatar,@Birthday)");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@UserName", DbType.String, model.UserName),
				dbHelper.CreateInDbParameter("@NickName", DbType.String, model.NickName),
				dbHelper.CreateInDbParameter("@Password", DbType.AnsiStringFixedLength, model.Password),
				dbHelper.CreateInDbParameter("@SecureQuestion", DbType.String, model.SecureQuestion),
				dbHelper.CreateInDbParameter("@SecureAnswer", DbType.String, model.SecureAnswer),
				dbHelper.CreateInDbParameter("@Email", DbType.AnsiString, model.Email),
				dbHelper.CreateInDbParameter("@RegisterIP", DbType.AnsiStringFixedLength, model.RegisterIP),
				dbHelper.CreateInDbParameter("@LastloginIP", DbType.AnsiStringFixedLength, model.LastloginIP),
				dbHelper.CreateInDbParameter("@ExtCredits4", DbType.Double, model.ExtCredits4),
				dbHelper.CreateInDbParameter("@ExtCredits5", DbType.Double, model.ExtCredits5),
				dbHelper.CreateInDbParameter("@Avatar", DbType.AnsiString, model.Avatar),
				dbHelper.CreateInDbParameter("@Birthday", DbType.String, model.Birthday)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Users model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Users SET ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("NickName=@NickName,");
			strSql.Append("Password=@Password,");
			strSql.Append("SecureQuestion=@SecureQuestion,");
			strSql.Append("SecureAnswer=@SecureAnswer,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Email=@Email,");
			strSql.Append("RoleID=@RoleID,");
			strSql.Append("UsergroupID=@UsergroupID,");
			strSql.Append("RegisterIP=@RegisterIP,");
			strSql.Append("RegisterTime=@RegisterTime,");
			strSql.Append("LastloginIP=@LastloginIP,");
			strSql.Append("LastloginTime=@LastloginTime,");
			strSql.Append("LoginCount=@LoginCount,");
			strSql.Append("PostCount=@PostCount,");
			strSql.Append("OnlineTime=@OnlineTime,");
			strSql.Append("Credits=@Credits,");
			strSql.Append("ExtCredits1=@ExtCredits1,");
			strSql.Append("ExtCredits2=@ExtCredits2,");
			strSql.Append("ExtCredits3=@ExtCredits3,");
			strSql.Append("ExtCredits4=@ExtCredits4,");
			strSql.Append("ExtCredits5=@ExtCredits5,");
			strSql.Append("Avatar=@Avatar,");
			strSql.Append("Birthday=@Birthday,");
			strSql.Append("PMCount=@PMCount,");
			strSql.Append("IsVerify=@IsVerify,");
			strSql.Append("IsLock=@IsLock");
			strSql.Append(" WHERE UID=@UID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@UserName", DbType.String, model.UserName),
				dbHelper.CreateInDbParameter("@NickName", DbType.String, model.NickName),
				dbHelper.CreateInDbParameter("@Password", DbType.AnsiStringFixedLength, model.Password),
				dbHelper.CreateInDbParameter("@SecureQuestion", DbType.String, model.SecureQuestion),
				dbHelper.CreateInDbParameter("@SecureAnswer", DbType.String, model.SecureAnswer),
				dbHelper.CreateInDbParameter("@Sex", DbType.Byte, model.Sex),
				dbHelper.CreateInDbParameter("@Email", DbType.AnsiString, model.Email),
				dbHelper.CreateInDbParameter("@RoleID", DbType.Int32, model.RoleID),
				dbHelper.CreateInDbParameter("@UsergroupID", DbType.Int32, model.UsergroupID),
				dbHelper.CreateInDbParameter("@RegisterIP", DbType.AnsiStringFixedLength, model.RegisterIP),
				dbHelper.CreateInDbParameter("@RegisterTime", DbType.String, model.RegisterTime),
				dbHelper.CreateInDbParameter("@LastloginIP", DbType.AnsiStringFixedLength, model.LastloginIP),
				dbHelper.CreateInDbParameter("@LastloginTime", DbType.String, model.LastloginTime),
				dbHelper.CreateInDbParameter("@LoginCount", DbType.Int32, model.LoginCount),
				dbHelper.CreateInDbParameter("@PostCount", DbType.Int32, model.PostCount),
				dbHelper.CreateInDbParameter("@OnlineTime", DbType.Int32, model.OnlineTime),
				dbHelper.CreateInDbParameter("@Credits", DbType.Int32, model.Credits),
				dbHelper.CreateInDbParameter("@ExtCredits1", DbType.Double, model.ExtCredits1),
				dbHelper.CreateInDbParameter("@ExtCredits2", DbType.Double, model.ExtCredits2),
				dbHelper.CreateInDbParameter("@ExtCredits3", DbType.Double, model.ExtCredits3),
				dbHelper.CreateInDbParameter("@ExtCredits4", DbType.Double, model.ExtCredits4),
				dbHelper.CreateInDbParameter("@ExtCredits5", DbType.Double, model.ExtCredits5),
				dbHelper.CreateInDbParameter("@Avatar", DbType.AnsiString, model.Avatar),
				dbHelper.CreateInDbParameter("@Birthday", DbType.String, model.Birthday),
				dbHelper.CreateInDbParameter("@PMCount", DbType.Int32, model.PMCount),
				dbHelper.CreateInDbParameter("@IsVerify", DbType.Byte, model.IsVerify),
				dbHelper.CreateInDbParameter("@IsLock", DbType.Byte, model.IsLock),
				dbHelper.CreateInDbParameter("@UID", DbType.Int32, model.UID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int UID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM Users ");
			strSql.Append(" WHERE UID=@UID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@UID", DbType.Int32, UID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM Users");
			strSql.Append(" WHERE UID=@UID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@UID", DbType.Int32, UID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Users GetModel(int UID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock FROM Users");
			strSql.Append(" WHERE UID=@UID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@UID", DbType.Int32, UID)};

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
		public List<Users> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock FROM Users");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Users> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Users> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock FROM Users");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Users> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Users GetModel(DbDataReader dr)
		{
			Users model = new Users();
			model.UID = dbHelper.GetInt(dr["UID"]);
			model.UserName = dbHelper.GetString(dr["UserName"]);
			model.NickName = dbHelper.GetString(dr["NickName"]);
			model.Password = dbHelper.GetString(dr["Password"]);
			model.SecureQuestion = dbHelper.GetString(dr["SecureQuestion"]);
			model.SecureAnswer = dbHelper.GetString(dr["SecureAnswer"]);
			model.Sex = dbHelper.GetByte(dr["Sex"]);
			model.Email = dbHelper.GetString(dr["Email"]);
			model.RoleID = dbHelper.GetInt(dr["RoleID"]);
			model.UsergroupID = dbHelper.GetInt(dr["UsergroupID"]);
			model.RegisterIP = dbHelper.GetString(dr["RegisterIP"]);
			model.RegisterTime = dbHelper.GetDateTime(dr["RegisterTime"]);
			model.LastloginIP = dbHelper.GetString(dr["LastloginIP"]);
			model.LastloginTime = dbHelper.GetDateTime(dr["LastloginTime"]);
			model.LoginCount = dbHelper.GetInt(dr["LoginCount"]);
			model.PostCount = dbHelper.GetInt(dr["PostCount"]);
			model.OnlineTime = dbHelper.GetInt(dr["OnlineTime"]);
			model.Credits = dbHelper.GetInt(dr["Credits"]);
			model.ExtCredits1 = dbHelper.GetDouble(dr["ExtCredits1"]);
			model.ExtCredits2 = dbHelper.GetDouble(dr["ExtCredits2"]);
			model.ExtCredits3 = dbHelper.GetDouble(dr["ExtCredits3"]);
			model.ExtCredits4 = dbHelper.GetDouble(dr["ExtCredits4"]);
			model.ExtCredits5 = dbHelper.GetDouble(dr["ExtCredits5"]);
			model.Avatar = dbHelper.GetString(dr["Avatar"]);
			model.Birthday = dbHelper.GetDateTime(dr["Birthday"]);
			model.PMCount = dbHelper.GetInt(dr["PMCount"]);
			model.IsVerify = dbHelper.GetByte(dr["IsVerify"]);
			model.IsLock = dbHelper.GetByte(dr["IsLock"]);
			return model;
		}

		/// <summary>
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<Users> GetList(DbDataReader dr, out long count)
		{
			count = 0;
			List<Users> lst = new List<Users>();
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
		private List<Users> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
		{
			long first = GetFirstIndex(pageSize, pageIndex);
			long last = GetLastIndex(pageSize, pageIndex);

			count = 0;

			List<Users> lst = new List<Users>();
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