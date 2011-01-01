using System;
using System.Collections.Generic;
using System.Text;
using Tuan.Entity;

namespace Tuan.Data.DAO
{
    public abstract class UserDAO : BaseDAO<UserDAO>
    {
        public abstract ModelList GetUser();

        /// <summary>
        /// 判断用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>返回登录用户实体</returns>
        public abstract LoginUser UserLogin(string userName, string password, string loginIP);
    }
}
