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
        /// 增加附件数据
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
					new SqlParameter("@AttachMentPath", SqlDbType.NVarChar,500),
					new SqlParameter("@AttachMentSize", SqlDbType.NVarChar,50),
					new SqlParameter("@AbbrPhotoPath", SqlDbType.NVarChar,500),
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


        /// <summary>
        /// 更新附件数据
        /// </summary>
        public int Update(Atr_AttachMent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DT_Atr_AttachMent set ");
            strSql.Append("AttachMentAttribute=@AttachMentAttribute,");
            strSql.Append("AttachMentDisplayName=@AttachMentDisplayName,");
            strSql.Append("AttachMentPath=@AttachMentPath,");
            strSql.Append("AttachMentSize=@AttachMentSize,");
            strSql.Append("AbbrPhotoPath=@AbbrPhotoPath,");
            strSql.Append("PubLisher=@PubLisher,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("PhotoDescription=@PhotoDescription");
            strSql.Append(" where AttachMentID=@AttachMentID ");
            SqlParameter[] parameters = {
					new SqlParameter("@AttachMentID", SqlDbType.Int,4),
					new SqlParameter("@AttachMentAttribute", SqlDbType.Int,4),
					new SqlParameter("@AttachMentDisplayName", SqlDbType.NVarChar,50),
					new SqlParameter("@AttachMentPath", SqlDbType.NVarChar,500),
					new SqlParameter("@AttachMentSize", SqlDbType.NVarChar,50),
					new SqlParameter("@AbbrPhotoPath", SqlDbType.NVarChar,500),
					new SqlParameter("@PubLisher", SqlDbType.NVarChar,50),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@PhotoDescription", SqlDbType.NVarChar,100)};
            parameters[0].Value = model.AttachMentID;
            parameters[1].Value = model.AttachMentAttribute;
            parameters[2].Value = model.AttachMentDisplayName;
            parameters[3].Value = model.AttachMentPath;
            parameters[4].Value = model.AttachMentSize;
            parameters[5].Value = model.AbbrPhotoPath;
            parameters[6].Value = model.PubLisher;
            parameters[7].Value = model.AddDate;
            parameters[8].Value = model.PhotoDescription;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除附件数据
        /// </summary>
        public int Delete(string AttachMentID)
        {
            string strSql = string.Format("delete DT_Atr_AttachMent where AttachMentID in({0})",AttachMentID);

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql);
        }
        /// <summary>
        /// 获取一个附件
        /// </summary>
        /// <param name="AttachMentID">附件ID</param>
        public Atr_AttachMent GetModel(int AttachMentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 AttachMentID,AttachMentAttribute,AttachMentDisplayName,AttachMentPath,AttachMentSize,AbbrPhotoPath,PubLisher,AddDate,PhotoDescription from DT_Atr_AttachMent ");
            strSql.Append(" where AttachMentID=@AttachMentID ");
            SqlParameter[] parameters = {
					new SqlParameter("@AttachMentID", SqlDbType.Int,4)};
            parameters[0].Value = AttachMentID;
            Atr_AttachMent model = new Atr_AttachMent();
            using (SqlDataReader dataRead = SqlHelper.ExecuteReader(CommandType.Text, strSql.ToString(), parameters))
            {
                if (dataRead.Read())
                {
                    model = DataReaderToModel<Atr_AttachMent>(dataRead);
                }
            }
            return model;
        }
    }
}
