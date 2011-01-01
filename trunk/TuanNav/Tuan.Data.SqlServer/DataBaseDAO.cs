using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Tuan.Data;
using Tuan.Entity;
using Tuan.Entity.Global;

namespace Tuan.Data.SqlServer
{
    public class DataBaseDAO : Tuan.Data.DAO.DataBaseDAO
    {
        /// <summary>
        /// 获取数据库基本信息
        /// </summary>
        public override DataBaseInfo GetDataBaseInfo()
        {
            string strSql = "SELECT size*8,(status & 0x40) as type FROM sysfiles;SELECT @@VERSION;";
            DataBaseInfo dbInfo = new DataBaseInfo();

            using (SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strSql))
            {
                int dataSize = 0;
                int logSize = 0;

                while (dr.Read())
                {
                    if (dr.GetInt32(1) == 0)
                        dataSize += dr.GetInt32(0);
                    else
                        logSize += dr.GetInt32(0);
                }
                if (dr.NextResult())
                {
                    while (dr.Read())
                        dbInfo.Version = dr.GetString(0);
                }
                dbInfo.DataSize = dataSize;
                dbInfo.LogSize = logSize;
            }
            return dbInfo;
        }

        /// <summary>
        /// 获取网站基本统计信息
        /// </summary>
        public override ModelList GetBaseStats()
        {
            string procName = "[Proc_GetBaseStats]";

            ModelList model = SqlHelper.ExecuteList(CommandType.StoredProcedure, procName, null);
            return model;
        }
    }
}
