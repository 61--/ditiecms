using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.Entity;
using DTCMS.IDAL;
using System.Data.SqlClient;
using DTCMS.DBUtility;
using System.Data;
namespace DTCMS.SqlServerDAL
{
    public class Sys_TemplateDAL:BaseDAL,IDAL_Sys_Template
    {

        #region IDAL_Sys_Template 成员

        public int Add(Sys_Template model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DT_SYS_Template(");
            strSql.Append("TemplateID,TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg)");
            strSql.Append(" values (");
            strSql.Append("@TemplateID,@TemplateName,@TemplateDirectory,@isEnable,@CreateDateTime,@TemplateImg)");
            SqlParameter[] parameters = {
					new SqlParameter("@TemplateID", SqlDbType.Int,4),
					new SqlParameter("@TemplateName", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateDirectory", SqlDbType.NVarChar,200),
					new SqlParameter("@isEnable", SqlDbType.TinyInt,1),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@TemplateImg", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.TemplateID;
            parameters[1].Value = model.TemplateName;
            parameters[2].Value = model.TemplateDirectory;
            parameters[3].Value = model.isEnable;
            parameters[4].Value = model.CreateDateTime;
            parameters[5].Value = model.TemplateImg;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }

        public int Update(Sys_Template model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DT_SYS_Template set ");
            strSql.Append("TemplateName=@TemplateName,");
            strSql.Append("TemplateDirectory=@TemplateDirectory,");
            strSql.Append("isEnable=@isEnable,");
            strSql.Append("CreateDateTime=@CreateDateTime,");
            strSql.Append("TemplateImg=@TemplateImg");
            strSql.Append(" where TemplateID=@TemplateID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TemplateID", SqlDbType.Int,4),
					new SqlParameter("@TemplateName", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateDirectory", SqlDbType.NVarChar,200),
					new SqlParameter("@isEnable", SqlDbType.TinyInt,1),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@TemplateImg", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.TemplateID;
            parameters[1].Value = model.TemplateName;
            parameters[2].Value = model.TemplateDirectory;
            parameters[3].Value = model.isEnable;
            parameters[4].Value = model.CreateDateTime;
            parameters[5].Value = model.TemplateImg;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }

        public int Delete(string ID)
        {
            throw new NotImplementedException();
        }

        public Sys_Template GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TemplateID,TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg from DT_SYS_Template ");
            strSql.Append(" where TemplateID=@TemplateID ");
            SqlParameter[] parameters = { new SqlParameter("@TemplateID", SqlDbType.Int, 4) };
            parameters[0].Value = ID;
            Sys_Template model=new Sys_Template ();
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(CommandType.Text,strSql.ToString(),parameters))
            {
                if (dataReader.Read())
                {
                    model = DataReaderBind<Sys_Template>(dataReader);
                }
            }
            return model;
        }

        #endregion
    }
}
