using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTCMS.Entity;
using DTCMS.IDAL;
using DTCMS.DBUtility;

namespace DTCMS.SqlServerDAL
{
    public class Atr_AttachMentDAL:BaseDAL,IDAL_Atr_AttachMent
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Atr_AttachMent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DT_Atr_AttachMent(");
            strSql.Append("AttachMentAttribute,AttachMentDisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription)");
            strSql.Append(" values (");
            strSql.Append("@AttachMentAttribute,@AttachMentDisplayName,@AttachMentPath,@AttachMentSize,@AbbrPhotoPath,@PubLisher,@AddDate,@PhotoDescription)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@AttachMentAttribute", SqlDbType.Int,4),
					new SqlParameter("@AttachMentDisplayName", SqlDbType.NVarChar,50),
					new SqlParameter("@AttachMentPath", SqlDbType.NVarChar,50),
					new SqlParameter("@AttachMentSize", SqlDbType.NVarChar,50),
					new SqlParameter("@AbbrPhotoPath", SqlDbType.NVarChar,50),
					new SqlParameter("@PubLisher", SqlDbType.NVarChar,50),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@PhotoDescription", SqlDbType.NVarChar,100)};
            parameters[0].Value = model.AttachMentAttribute;
            parameters[1].Value = model.AttachMentDisplayName;
            parameters[2].Value = model.AttachMentPath;
            parameters[3].Value = model.AttachMentSize;
            parameters[4].Value = model.AbbrPhotoPath;
            parameters[5].Value = model.PubLisher;
            parameters[6].Value = model.AddDate;
            parameters[7].Value = model.PhotoDescription;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }       



    }
}
