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

        /// <summary>
        /// 添加模板风格数据
        /// </summary>
        /// <param name="model">模板风格实体</param>
        /// <returns></returns>
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
        /// <summary>
        /// 更新模板风格
        /// </summary>
        /// <param name="model">模板实体</param>
        /// <returns></returns>
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
        /// <summary>
        /// 删除模板风格数据
        /// </summary>
        /// <param name="TemplateID">主键</param>
        /// <returns></returns>
        public int Delete(string TemplateID)
        {
            string strSql = string.Format("delete DT_SYS_Template  where CID in ({0})", TemplateID);
            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql);	
        }
        /// <summary>
        /// 获取模板风格实体
        /// </summary>
        /// <param name="ID">模板风格主键</param>
        /// <returns>模板风格实体</returns>
        public Sys_Template GetModel(int TemplateID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TemplateID,TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg from DT_SYS_Template ");
            strSql.Append(" where TemplateID=@TemplateID ");
            SqlParameter[] parameters = { new SqlParameter("@TemplateID", SqlDbType.Int, 4) };
            parameters[0].Value = TemplateID;
            Sys_Template model=new Sys_Template ();
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(CommandType.Text, strSql.ToString(), parameters))
            {
                if (dataReader.Read())
                {
                    //object ojb;
                    //ojb = dataReader["TemplateID"];
                    //if (ojb != null && ojb != DBNull.Value)
                    //{
                    //    model.TemplateID = (int)ojb;
                    //}
                    //model.TemplateName = dataReader["TemplateName"].ToString();
                    //model.TemplateDirectory = dataReader["TemplateDirectory"].ToString();
                    //ojb = dataReader["isEnable"];
                    //if (ojb != null && ojb != DBNull.Value)
                    //{
                    //    model.isEnable = Convert.ToInt32(ojb);
                    //}
                    //ojb = dataReader["CreateDateTime"];
                    //if (ojb != null && ojb != DBNull.Value)
                    //{
                    //    model.CreateDateTime = (DateTime)ojb;
                    //}
                    //model.TemplateImg = dataReader["TemplateImg"].ToString();
                    //return model;
                     model = DataReaderBind<Sys_Template>(dataReader);
                }
            }
           
            return model;
        }

        #endregion
    }
}
