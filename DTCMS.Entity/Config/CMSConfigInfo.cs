//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-08-02 23:38:37
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Xml.Serialization;

namespace DTCMS.Entity
{
    [Serializable]
    public class CMSConfigInfo
    {
        private string _dbConnection;
        private string _tablePrefix;
        private string _dbType;
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
        /// 网站创始人ID
        /// </summary>
        public string FounderID
        {
            get { return _founderID; }
            set { _founderID = value; }
        }
    }
}
