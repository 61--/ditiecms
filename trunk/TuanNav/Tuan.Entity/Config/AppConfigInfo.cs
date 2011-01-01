using System;
using System.Collections.Generic;
using System.Text;

namespace Tuan.Entity.Config
{
    [Serializable]
    public class AppConfigInfo : IConfigInfo
    {
        private string _dbConnection;
        private string _tablePrefix;
        private string _dbType;
        private string _appPath;
        private string _founderID;

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string DbConnection
        {
            get { return _dbConnection; }
            set { _dbConnection = value; }
        }

        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DbType
        {
            get { return _dbType; }
            set { _dbType = value; }
        }

        /// <summary>
        /// 数据库表前缀
        /// </summary>
        public string TablePrefix
        {
            get { return _tablePrefix; }
            set { _tablePrefix = value; }
        }

        /// <summary>
        /// 程序安装目录
        /// </summary>
        public string AppPath
        {
            get { return _appPath; }
            set { _appPath = value; }
        }

        /// <summary>
        /// 网站创始人ID
        /// </summary>
        public string FounderID
        {
            get { return _founderID; }
            set { _founderID = value; }
        }
    }
}
