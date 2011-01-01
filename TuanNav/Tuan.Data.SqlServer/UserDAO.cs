using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tuan.Data;
using Tuan.Entity;

namespace Tuan.Data.SqlServer
{
    public class UserDAO : Tuan.Data.DAO.UserDAO
    {
        public override ModelList GetUser()
        {
            ModelList modelList = new ModelList();

            return SqlHelper.ExecuteList(CommandType.Text, "select * from TN_Users", null);
        }

        /// <summary>
        /// 判断用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回登录用户实体</returns>
        public override LoginUser UserLogin(string userName, string password, string loginIP)
        {
            SqlParameter[] parms = {
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@Password", SqlDbType.NVarChar,64),
					new SqlParameter("@LoginIP", SqlDbType.Char,15)};
            parms[0].Value = userName;
            parms[1].Value = password;
            parms[2].Value = loginIP;

            using (SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.StoredProcedure, "Proc_UserLogin", parms))
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    LoginUser loginUser = new LoginUser();
                    loginUser.UserID = SqlHelper.GetInt(dr["UID"]);
                    loginUser.UserName = SqlHelper.GetString(dr["UserName"]);
                    loginUser.UsergroupID = SqlHelper.GetInt(dr["UsergroupID"]);
                    loginUser.LastloginIP = SqlHelper.GetString(dr["LastloginIP"]);
                    loginUser.LastloginTime = SqlHelper.GetDateTime(dr["LastloginTime"]);
                    loginUser.LoginCount = SqlHelper.GetInt(dr["LoginCount"]);
                    loginUser.OnlineTime = SqlHelper.GetInt(dr["OnlineTime"]);
                    loginUser.Credits = SqlHelper.GetInt(dr["Credits"]);
                    loginUser.PMCount = SqlHelper.GetInt(dr["PMCount"]);
                    loginUser.IsVerify = SqlHelper.GetByte(dr["IsVerify"]);
                    loginUser.IsLock = SqlHelper.GetByte(dr["IsLock"]);

                    return loginUser;
                }
                else
                    return null;
            }
        }
    }
}
