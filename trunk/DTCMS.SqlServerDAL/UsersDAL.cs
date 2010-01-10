//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 13:39:54
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
	/// 数据访问类 Users
	/// </summary>
	public class UsersDAL : BaseDAL, IDAL_Users
	{
		public UsersDAL()
		{ }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Users model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Users(");
            strSql.Append("UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock)");
			strSql.Append(" VALUES (");
            strSql.Append("@UserName,@NickName,@Password,@SecureQuestion,@SecureAnswer,@Sex,@Email,@RoleID,@UsergroupID,@RegisterIP,@RegisterTime,@LastloginIP,@LastloginTime,@LoginCount,@PostCount,@OnlineTime,@Credits,@ExtCredits1,@ExtCredits2,@ExtCredits3,@ExtCredits4,@ExtCredits5,@Avatar,@Birthday,@PMCount,@IsVerify,@IsLock)");
			SqlParameter[] cmdParms = {
				AddInParameter("@UserName", SqlDbType.NVarChar, 100, model.UserName),
				AddInParameter("@NickName", SqlDbType.NVarChar, 100, model.NickName),
				AddInParameter("@Password", SqlDbType.Char, 32, model.Password),
				AddInParameter("@SecureQuestion", SqlDbType.NVarChar, 100, model.SecureQuestion),
				AddInParameter("@SecureAnswer", SqlDbType.NVarChar, 100, model.SecureAnswer),
				AddInParameter("@Sex", SqlDbType.TinyInt, 1, model.Sex),
				AddInParameter("@Email", SqlDbType.VarChar, 50, model.Email),
				AddInParameter("@RoleID", SqlDbType.Int, 4, model.RoleID),
				AddInParameter("@UsergroupID", SqlDbType.Int, 4, model.UsergroupID),
				AddInParameter("@RegisterIP", SqlDbType.Char, 15, model.RegisterIP),
				AddInParameter("@RegisterTime", SqlDbType.DateTime, 8, model.RegisterTime),
				AddInParameter("@LastloginIP", SqlDbType.Char, 15, model.LastloginIP),
				AddInParameter("@LastloginTime", SqlDbType.DateTime, 8, model.LastloginTime),
				AddInParameter("@LoginCount", SqlDbType.Int, 4, model.LoginCount),
				AddInParameter("@PostCount", SqlDbType.Int, 4, model.PostCount),
				AddInParameter("@OnlineTime", SqlDbType.Int, 4, model.OnlineTime),
				AddInParameter("@Credits", SqlDbType.Int, 4, model.Credits),
				AddInParameter("@ExtCredits1", SqlDbType.Float, 9, model.ExtCredits1),
				AddInParameter("@ExtCredits2", SqlDbType.Float, 9, model.ExtCredits2),
				AddInParameter("@ExtCredits3", SqlDbType.Float, 9, model.ExtCredits3),
				AddInParameter("@ExtCredits4", SqlDbType.Float, 9, model.ExtCredits4),
				AddInParameter("@ExtCredits5", SqlDbType.Float, 9, model.ExtCredits5),
				AddInParameter("@Avatar", SqlDbType.VarChar, 200, model.Avatar),
				AddInParameter("@Birthday", SqlDbType.DateTime, 4, model.Birthday),
				AddInParameter("@PMCount", SqlDbType.Int, 4, model.PMCount),
				AddInParameter("@IsVerify", SqlDbType.TinyInt, 1, model.IsVerify),
				AddInParameter("@IsLock", SqlDbType.TinyInt, 1, model.IsLock)};

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
			SqlParameter[] cmdParms = {
				AddInParameter("@UserName", SqlDbType.NVarChar, 100, model.UserName),
				AddInParameter("@NickName", SqlDbType.NVarChar, 100, model.NickName),
				AddInParameter("@Password", SqlDbType.Char, 32, model.Password),
				AddInParameter("@SecureQuestion", SqlDbType.NVarChar, 100, model.SecureQuestion),
				AddInParameter("@SecureAnswer", SqlDbType.NVarChar, 100, model.SecureAnswer),
				AddInParameter("@Sex", SqlDbType.TinyInt, 1, model.Sex),
				AddInParameter("@Email", SqlDbType.VarChar, 50, model.Email),
				AddInParameter("@RoleID", SqlDbType.Int, 4, model.RoleID),
				AddInParameter("@UsergroupID", SqlDbType.Int, 4, model.UsergroupID),
				AddInParameter("@RegisterIP", SqlDbType.Char, 15, model.RegisterIP),
				AddInParameter("@RegisterTime", SqlDbType.DateTime, 8, model.RegisterTime),
				AddInParameter("@LastloginIP", SqlDbType.Char, 15, model.LastloginIP),
				AddInParameter("@LastloginTime", SqlDbType.DateTime, 8, model.LastloginTime),
				AddInParameter("@LoginCount", SqlDbType.Int, 4, model.LoginCount),
				AddInParameter("@PostCount", SqlDbType.Int, 4, model.PostCount),
				AddInParameter("@OnlineTime", SqlDbType.Int, 4, model.OnlineTime),
				AddInParameter("@Credits", SqlDbType.Int, 4, model.Credits),
				AddInParameter("@ExtCredits1", SqlDbType.Float, 9, model.ExtCredits1),
				AddInParameter("@ExtCredits2", SqlDbType.Float, 9, model.ExtCredits2),
				AddInParameter("@ExtCredits3", SqlDbType.Float, 9, model.ExtCredits3),
				AddInParameter("@ExtCredits4", SqlDbType.Float, 9, model.ExtCredits4),
				AddInParameter("@ExtCredits5", SqlDbType.Float, 9, model.ExtCredits5),
				AddInParameter("@Avatar", SqlDbType.VarChar, 200, model.Avatar),
				AddInParameter("@Birthday", SqlDbType.DateTime, 4, model.Birthday),
				AddInParameter("@PMCount", SqlDbType.Int, 4, model.PMCount),
				AddInParameter("@IsVerify", SqlDbType.TinyInt, 1, model.IsVerify),
				AddInParameter("@IsLock", SqlDbType.TinyInt, 1, model.IsLock),
				AddInParameter("@UID", SqlDbType.Int, 4, model.UID)};

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
			SqlParameter[] cmdParms = {
				AddInParameter("@UID", SqlDbType.Int, 4, model.UID)};

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
			SqlParameter[] cmdParms = {
				AddInParameter("@UID", SqlDbType.Int, 4, model.UID)};

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
			SqlParameter[] cmdParms = {
				AddInParameter("@UID", SqlDbType.Int, 4, model.UID)};

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
		public List<Users> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock FROM Users");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
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
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Users> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region 私有方法，通常情况下无需修改
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Users GetModel(SqlDataReader dr)
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
		/// 由SqlDataReader得到泛型数据列表
		/// </summary>
		private List<Users> GetList(SqlDataReader dr, out long count)
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
		/// 由SqlDataReader得到分页泛型数据列表
		/// </summary>
		private List<Users> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
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
