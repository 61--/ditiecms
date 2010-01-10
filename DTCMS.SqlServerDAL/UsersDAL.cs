//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 21:32:56
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
		/// <param name="UID">编号ID</param>
		/// <returns>返回影响行数</returns>
		public int Add(Users model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO " + tablePrefix + "Users(");
            strSql.Append("UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock)");
			strSql.Append(" VALUES (");
            strSql.Append("@UserName,@NickName,@Password,@SecureQuestion,@SecureAnswer,@Sex,@Email,@RoleID,@UsergroupID,@RegisterIP,@RegisterTime,@LastloginIP,@LastloginTime,@LoginCount,@PostCount,@OnlineTime,@Credits,@ExtCredits1,@ExtCredits2,@ExtCredits3,@ExtCredits4,@ExtCredits5,@Avatar,@Birthday,@PMCount,@IsVerify,@IsLock)");
			SqlParameter[] cmdParms = {
				AddInParameter("@UserName", SqlDbType.NVarChar, 50, model.UserName),
				AddInParameter("@NickName", SqlDbType.NVarChar, 50, model.NickName),
				AddInParameter("@Password", SqlDbType.Char, 32, model.Password),
				AddInParameter("@SecureQuestion", SqlDbType.NVarChar, 50, model.SecureQuestion),
				AddInParameter("@SecureAnswer", SqlDbType.NVarChar, 50, model.SecureAnswer),
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
				AddInParameter("@ExtCredits1", SqlDbType.Decimal, 18, model.ExtCredits1),
				AddInParameter("@ExtCredits2", SqlDbType.Decimal, 18, model.ExtCredits2),
				AddInParameter("@ExtCredits3", SqlDbType.Decimal, 18, model.ExtCredits3),
				AddInParameter("@ExtCredits4", SqlDbType.Decimal, 18, model.ExtCredits4),
				AddInParameter("@ExtCredits5", SqlDbType.Decimal, 18, model.ExtCredits5),
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
		/// <param name="model">实体对象</param>
		/// <returns>返回影响行数</returns>
		public int Update(Users model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE " + tablePrefix + "Users SET ");
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
				AddInParameter("@UserName", SqlDbType.NVarChar, 50, model.UserName),
				AddInParameter("@NickName", SqlDbType.NVarChar, 50, model.NickName),
				AddInParameter("@Password", SqlDbType.Char, 32, model.Password),
				AddInParameter("@SecureQuestion", SqlDbType.NVarChar, 50, model.SecureQuestion),
				AddInParameter("@SecureAnswer", SqlDbType.NVarChar, 50, model.SecureAnswer),
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
				AddInParameter("@ExtCredits1", SqlDbType.Decimal, 18, model.ExtCredits1),
				AddInParameter("@ExtCredits2", SqlDbType.Decimal, 18, model.ExtCredits2),
				AddInParameter("@ExtCredits3", SqlDbType.Decimal, 18, model.ExtCredits3),
				AddInParameter("@ExtCredits4", SqlDbType.Decimal, 18, model.ExtCredits4),
				AddInParameter("@ExtCredits5", SqlDbType.Decimal, 18, model.ExtCredits5),
				AddInParameter("@Avatar", SqlDbType.VarChar, 200, model.Avatar),
				AddInParameter("@Birthday", SqlDbType.DateTime, 4, model.Birthday),
				AddInParameter("@PMCount", SqlDbType.Int, 4, model.PMCount),
				AddInParameter("@IsVerify", SqlDbType.TinyInt, 1, model.IsVerify),
				AddInParameter("@IsLock", SqlDbType.TinyInt, 1, model.IsLock),
				AddInParameter("@UID", SqlDbType.Int, 4, model.UID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 根据ID和值更新一条数据
		/// </summary>
		/// <param name="UID">编号ID</param>
		/// <param name="value">更新值（filedName=filedValue）</param>
		/// <returns>返回影响行数</returns>
		public int Update(int UID, string value)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE " + tablePrefix + "Users SET ");
			strSql.Append(value);
			strSql.Append(" WHERE UID=");
			strSql.Append(UID);
			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		/// <param name="UID">编号ID</param>
		/// <returns>返回影响行数</returns>
		public int Delete(int UID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM " + tablePrefix + "Users");
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
				strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Users");
				strSql.Append(" WHERE UID<>{0} AND {1}={2}");
				return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), UID, filedName, filedValue))) > 0;
			}
			else
			{
				strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Users");
				strSql.Append(" WHERE UID={0}");
				return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), UID))) > 0;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		/// <param name="UID">编号ID</param>
		/// <returns>实体对象</returns>
		public Users GetModel(int UID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock FROM " + tablePrefix + "Users");
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
        /// 根据查询字段获取列表
        /// </summary>
        /// <param name="fileds">要查询的字段，多个字段用,号隔开</param>
        /// <returns>DataTable数据集合</returns>
        public DataTable GetDataTable(string fileds, string where)
        {
            string strSql = string.Format("SELECT {0} FROM {1}Users WHERE 1=1 {2}", fileds, tablePrefix, where);

            DataSet ds = dbHelper.ExecuteQuery(CommandType.Text, strSql);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

		/// <summary>
		/// 获取泛型数据列表
		/// </summary>
		/// <param name="count">返回记录总数</param>
		/// <returns>对象泛型集合</returns>
		public List<Users> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock FROM " + tablePrefix + "Users");
			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Users> lst = GetList(dr, out count);
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
		public List<Users> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT UID,UserName,NickName,Password,SecureQuestion,SecureAnswer,Sex,Email,RoleID,UsergroupID,RegisterIP,RegisterTime,LastloginIP,LastloginTime,LoginCount,PostCount,OnlineTime,Credits,ExtCredits1,ExtCredits2,ExtCredits3,ExtCredits4,ExtCredits5,Avatar,Birthday,PMCount,IsVerify,IsLock FROM " + tablePrefix + "Users");
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
		/// <param name="dr">SqlDataReader对象</param>
		/// <returns>实体对象</returns>
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
			model.ExtCredits1 = dbHelper.GetDecimal(dr["ExtCredits1"]);
            model.ExtCredits2 = dbHelper.GetDecimal(dr["ExtCredits2"]);
            model.ExtCredits3 = dbHelper.GetDecimal(dr["ExtCredits3"]);
            model.ExtCredits4 = dbHelper.GetDecimal(dr["ExtCredits4"]);
            model.ExtCredits5 = dbHelper.GetDecimal(dr["ExtCredits5"]);
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
		/// <param name="dr">SqlDataReader对象</param>
		/// <param name="count">返回记录数</param>
		/// <returns>对象泛型集合</returns>
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
		/// <param name="dr">SqlDataReader对象</param>
		/// <param name="pageSize">分页大小</param>
		/// <param name="pageIndex">当前页数</param>
		/// <param name="count">返回记录总数</param>
		/// <returns>分页对象泛型集合</returns>
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
