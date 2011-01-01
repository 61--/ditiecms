using System;

namespace Tuan.Entity
{
    public class LoginUser
    {
        private int _userID;
        private string _userName;
        private int _usergroupID;
        private DateTime _lastloginTime;
        private string _lastloginIP;
        private int _loginCount;
        private int _onlineTime;
        private int _credits;
        private string _avatar;
        private int _PMCount;
        private byte _isVerify;
        private byte _isLock;

        /// <summary>
        /// 用户UID编号
        /// </summary>
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { _userName = value; }
            get { return _userName; }
        }
        
        /// <summary>
        /// 用户组ID
        /// </summary>
        public int UsergroupID
        {
            set { _usergroupID = value; }
            get { return _usergroupID; }
        }
        
        /// <summary>
        /// 上次登陆IP
        /// </summary>
        public string LastloginIP
        {
            set { _lastloginIP = value; }
            get { return _lastloginIP; }
        }

        /// <summary>
        /// 上次登陆时间
        /// </summary>
        public DateTime LastloginTime
        {
            set { _lastloginTime = value; }
            get { return _lastloginTime; }
        }

        /// <summary>
        /// 登陆次数
        /// </summary>
        public int LoginCount
        {
            set { _loginCount = value; }
            get { return _loginCount; }
        }

        /// <summary>
        /// 在线时间（单位：分钟）
        /// </summary>
        public int OnlineTime
        {
            set { _onlineTime = value; }
            get { return _onlineTime; }
        }
        /// <summary>
        /// 用户积分
        /// </summary>
        public int Credits
        {
            set { _credits = value; }
            get { return _credits; }
        }
        
        /// <summary>
        /// 用户头像
        /// </summary>
        public string Avatar
        {
            set { _avatar = value; }
            get { return _avatar; }
        }
        
        /// <summary>
        /// 新短消息数
        /// </summary>
        public int PMCount
        {
            set { _PMCount = value; }
            get { return _PMCount; }
        }
        /// <summary>
        /// 是否审核
        /// </summary>
        public byte IsVerify
        {
            set { _isVerify = value; }
            get { return _isVerify; }
        }
        /// <summary>
        /// 是否锁定
        /// </summary>
        public byte IsLock
        {
            set { _isLock = value; }
            get { return _isLock; }
        }
    }
}
