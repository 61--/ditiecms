using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.Caching;
using DTCMS.IDAL;
using DTCMS.Entity;
using DTCMS.DBUtility;
using DTCMS.Common;

namespace DTCMS.SqlServerDAL
{
    public class Sys_NavigateDAL : BaseDAL, IDAL_Sys_Navigate
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int NvaID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DT_SYS_Navigate");
            strSql.Append(" where NvaID=@NvaID ");
            SqlParameter[] parameters = {
					new SqlParameter("@NvaID", SqlDbType.NVarChar,20)};
            parameters[0].Value = NvaID;

            return TypeConvert.ObjectToInt(SqlHelper.ExecuteScalar(CommandType.Text,strSql.ToString(), parameters))>0;
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(DT_SYS_Navigate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DT_SYS_Navigate(");
            strSql.Append("NvaID,ParentID,Name,EName,FilePath,MainURL,Target,CopyrightCode,OrderID,CreateTime,ISSys,ISEnable)");
            strSql.Append(" values (");
            strSql.Append("@NvaID,@ParentID,@Name,@EName,@FilePath,@MainURL,@Target,@CopyrightCode,@OrderID,@CreateTime,@ISSys,@ISEnable)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@NvaID", SqlDbType.NVarChar,20),
					new SqlParameter("@ParentID", SqlDbType.NVarChar,20),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@EName", SqlDbType.NVarChar,50),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@MainURL", SqlDbType.NVarChar,200),
					new SqlParameter("@Target", SqlDbType.NVarChar,20),
					new SqlParameter("@CopyrightCode", SqlDbType.Int,4),
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ISSys", SqlDbType.TinyInt,1),
					new SqlParameter("@ISEnable", SqlDbType.TinyInt,1)};
            parameters[0].Value = model.NvaID;
            parameters[1].Value = model.ParentID;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.EName;
            parameters[4].Value = model.FilePath;
            parameters[5].Value = model.MainURL;
            parameters[6].Value = model.Target;
            parameters[7].Value = model.CopyrightCode;
            parameters[8].Value = model.OrderID;
            parameters[9].Value = model.CreateTime;
            parameters[10].Value = model.ISSys;
            parameters[11].Value = model.ISEnable;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(DT_SYS_Navigate model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DT_SYS_Navigate set ");
            strSql.Append("NvaID=@NvaID,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("Name=@Name,");
            strSql.Append("EName=@EName,");
            strSql.Append("FilePath=@FilePath,");
            strSql.Append("MainURL=@MainURL,");
            strSql.Append("Target=@Target,");
            strSql.Append("CopyrightCode=@CopyrightCode,");
            strSql.Append("OrderID=@OrderID,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("ISSys=@ISSys,");
            strSql.Append("ISEnable=@ISEnable");
            strSql.Append(" where NID=@NID ");
            SqlParameter[] parameters = {
					new SqlParameter("@NID", SqlDbType.Int,4),
					new SqlParameter("@NvaID", SqlDbType.NVarChar,20),
					new SqlParameter("@ParentID", SqlDbType.NVarChar,20),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@EName", SqlDbType.NVarChar,50),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@MainURL", SqlDbType.NVarChar,200),
					new SqlParameter("@Target", SqlDbType.NVarChar,20),
					new SqlParameter("@CopyrightCode", SqlDbType.Int,4),
					new SqlParameter("@OrderID", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ISSys", SqlDbType.TinyInt,1),
					new SqlParameter("@ISEnable", SqlDbType.TinyInt,1)};
            parameters[0].Value = model.NID;
            parameters[1].Value = model.NvaID;
            parameters[2].Value = model.ParentID;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.EName;
            parameters[5].Value = model.FilePath;
            parameters[6].Value = model.MainURL;
            parameters[7].Value = model.Target;
            parameters[8].Value = model.CopyrightCode;
            parameters[9].Value = model.OrderID;
            parameters[10].Value = model.CreateTime;
            parameters[11].Value = model.ISSys;
            parameters[12].Value = model.ISEnable;

            return SqlHelper.ExecuteNonQuery(CommandType.Text,strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string NID)
        {
            string strSql = string.Format("delete DT_SYS_Navigate where NID in({0}) and ISSys<>1", NID);
            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
        }

        /// <summary>
        /// 获取导航菜单名称
        /// </summary>
        /// <param name="NvaID"></param>
        /// <returns></returns>
        public string GetSingleFileName(string filedName, string NvaID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(string.Format("select {0} from DT_SYS_Navigate", filedName));
            strSql.Append(" where NvaID=@NvaID ");
            SqlParameter[] parameters = {
					new SqlParameter("@NvaID", SqlDbType.NVarChar,20)};
            parameters[0].Value = NvaID;

            return SqlHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), parameters).ToString();
       
        }
    }
}
