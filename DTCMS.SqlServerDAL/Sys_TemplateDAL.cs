using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTCMS.Entity;
using DTCMS.IDAL;
using DTCMS.DBUtility;
using DTCMS.Common;
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
            strSql.Append("TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg,Author)");
            strSql.Append(" values (");
            strSql.Append("@TemplateName,@TemplateDirectory,@isEnable,@CreateDateTime,@TemplateImg,@Author)");
            SqlParameter[] parameters = {
					new SqlParameter("@TemplateName", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateDirectory", SqlDbType.NVarChar,200),
					new SqlParameter("@isEnable", SqlDbType.TinyInt,1),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@TemplateImg", SqlDbType.NVarChar,200),
                    new SqlParameter("@Author",SqlDbType.NVarChar,50)};
           
            parameters[0].Value = model.TemplateName;
            parameters[1].Value = model.TemplateDirectory;
            parameters[2].Value = model.isEnable;
            parameters[3].Value = model.CreateDateTime;
            parameters[4].Value = model.TemplateImg;
            parameters[5].Value = model.Author;
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
            strSql.Append("TemplateImg=@TemplateImg,");
            strSql.Append("Author=@Author");
            strSql.Append(" where TemplateID=@TemplateID ");
            SqlParameter[] parameters = {
					new SqlParameter("@TemplateID", SqlDbType.Int,4),
					new SqlParameter("@TemplateName", SqlDbType.NVarChar,50),
					new SqlParameter("@TemplateDirectory", SqlDbType.NVarChar,200),
					new SqlParameter("@isEnable", SqlDbType.TinyInt,1),
					new SqlParameter("@CreateDateTime", SqlDbType.DateTime),
					new SqlParameter("@TemplateImg", SqlDbType.NVarChar,200),
                    new SqlParameter("@Author",SqlDbType.NVarChar,50)};
            parameters[0].Value = model.TemplateID;
            parameters[1].Value = model.TemplateName;
            parameters[2].Value = model.TemplateDirectory;
            parameters[3].Value = model.isEnable;
            parameters[4].Value = model.CreateDateTime;
            parameters[5].Value = model.TemplateImg;
            parameters[6].Value = model.Author;
            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除模板风格数据
        /// </summary>
        /// <param name="TemplateID">主键</param>
        /// <returns></returns>
        public int Delete(string TemplateID)
        {
            string strSql = string.Format("delete DT_SYS_Template  where TemplateID in ({0})", TemplateID);
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
            strSql.Append("select TemplateID,TemplateName,TemplateDirectory,isEnable,CreateDateTime,TemplateImg,Author from DT_SYS_Template ");
            strSql.Append(" where TemplateID=@TemplateID ");
            SqlParameter[] parameters = { new SqlParameter("@TemplateID", SqlDbType.Int, 4) };
            parameters[0].Value = TemplateID;
            Sys_Template model=new Sys_Template ();
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(CommandType.Text, strSql.ToString(), parameters))
            {
                if (dataReader.Read())
                {
                    model = DataReaderToModel<Sys_Template>(dataReader);
                }
            }
           
            return model;
        }

        /// <summary>
        /// 设置风格为启动状态
        /// </summary>
        /// <param name="tempID">风格编号</param>
        /// <param name="isEnable"> 1启动 </param>
        /// <returns></returns>
        public bool UpdateEnable(int TemplateID,int isEnable)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" UPDATE DT_Sys_Template SET isEnable=0 WHERE isEnable=1 ");
            strSql.Append(" UPDATE DT_Sys_Template SET isEnable=1 WHERE TemplateID=@TemplateID ");

            SqlParameter[] parameters = { new SqlParameter("@TemplateID",SqlDbType.Int,4) };
            parameters[0].Value = TemplateID;
       
            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters)>0;
           
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="CID">类别主键</param>
        /// <param name="FiledName">字段名称</param>
        /// <param name="FiledValue">字段值</param>
        public bool Exists(int TemplateID, string filedName, string filedValue) 
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT Count(TemplateID) FROM DT_Sys_Template WHERE ");
            strSql.Append(string.Format(" {0}=@{0} ",filedName));
            strSql.Append(" AND TemplateID=@TemplateID ");

            SqlParameter[] parameters = { new SqlParameter("@TemplateID", SqlDbType.Int, 4),
                                          new SqlParameter(string.Format("@{0}",filedName), SqlDbType.NVarChar,100) 
                                        };
            parameters[0].Value = TemplateID;
            parameters[1].Value = filedValue;

            return TypeConvert.ObjectToInt(SqlHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), parameters)) > 0;
        }


        /// <summary>
        /// 获取风格数据
        /// </summary>
        /// <param name="Fileds">要查询的字段</param>
        /// <returns></returns>
        public DataTable GetDataTable(string Fileds)
        {
            string strSql = string.Format(" SELECT {0} FROM DT_Sys_Template ", Fileds);
            DataSet ds = SqlHelper.FillDataset(CommandType.Text, strSql);
            if (ds != null && ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
