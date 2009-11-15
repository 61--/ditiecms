using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DTCMS.IDAL;
using DTCMS.Entity;
using DTCMS.DBUtility;

namespace DTCMS.SqlServerDAL
{
    public class Arc_ClassDAL:IDAL_Arc_Class
    {

        #region IDAL_Arc_Class 成员
        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns></returns>
        public bool Exists(int CID, string filedName, string filedValue)
        {
            string strSql = "select count(1) from DT_Arc_Class where CID={0} ";
            if (filedName != "")
            {
                strSql += "{1}='{2}'";
                return SqlHelper.ExecuteNonQuery(string.Format(strSql, CID, filedName, filedValue)) > 0;
            }
            else
            {
                return SqlHelper.ExecuteNonQuery(string.Format(strSql,CID)) > 0;
            }
        }
        /// <summary>
        /// 添加栏目
        /// </summary>
        /// <param name="model">栏目实体对象</param>
        /// <returns></returns>
        public int Add(Arc_Class model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DT_Arc_Class(");
            strSql.Append("ParentID,Attribute,ClassName,ClassUrl,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content)");
            strSql.Append(" values (");
            strSql.Append("@ParentID,@Attribute,@ClassName,@ClassUrl,@ClassPath,@IndexTemplet,@ListTemplet,@ArchiveTemplet,@ListRule,@ArchiveRule,@ClassPage,@Description,@IsHidden,@IsHtml,@IsComment,@Readaccess,@SiteID,@AddDate,@Relation,@OrderID,@ImgUrl,@Keywords,@CrossID,@Content)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Attribute", SqlDbType.TinyInt,1),
					new SqlParameter("@ClassName", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPath", SqlDbType.NVarChar,200),
					new SqlParameter("@IndexTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ListTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ListRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPage", SqlDbType.TinyInt,1),
					new SqlParameter("@Description", SqlDbType.NVarChar,500),
					new SqlParameter("@IsHidden", SqlDbType.TinyInt,1),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@IsComment", SqlDbType.TinyInt,1),
					new SqlParameter("@Readaccess", SqlDbType.SmallInt,2),
					new SqlParameter("@SiteID", SqlDbType.TinyInt,1),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@Relation", SqlDbType.NVarChar,200),
					new SqlParameter("@OrderID", SqlDbType.SmallInt,2),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Keywords", SqlDbType.NVarChar,200),
					new SqlParameter("@CrossID", SqlDbType.NVarChar,200),
					new SqlParameter("@Content", SqlDbType.NText)};
            parameters[0].Value = model.ParentID;
            parameters[1].Value = model.Attribute;
            parameters[2].Value = model.ClassName;
            parameters[3].Value = model.ClassUrl;
            parameters[4].Value = model.ClassPath;
            parameters[5].Value = model.IndexTemplet;
            parameters[6].Value = model.ListTemplet;
            parameters[7].Value = model.ArchiveTemplet;
            parameters[8].Value = model.ListRule;
            parameters[9].Value = model.ArchiveRule;
            parameters[10].Value = model.ClassPage;
            parameters[11].Value = model.Description;
            parameters[12].Value = model.IsHidden;
            parameters[13].Value = model.IsHtml;
            parameters[14].Value = model.IsComment;
            parameters[15].Value = model.Readaccess;
            parameters[16].Value = model.SiteID;
            parameters[17].Value = model.AddDate;
            parameters[18].Value = model.Relation;
            parameters[19].Value = model.OrderID;
            parameters[20].Value = model.ImgUrl;
            parameters[21].Value = model.Keywords;
            parameters[22].Value = model.CrossID;
            parameters[23].Value = model.Content;

            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新栏目
        /// </summary>
        /// <param name="model">栏目实体对象</param>
        /// <returns></returns>
        public int Update(Arc_Class model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DT_Arc_Class set ");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("Attribute=@Attribute,");
            strSql.Append("ClassName=@ClassName,");
            strSql.Append("ClassUrl=@ClassUrl,");
            strSql.Append("ClassPath=@ClassPath,");
            strSql.Append("IndexTemplet=@IndexTemplet,");
            strSql.Append("ListTemplet=@ListTemplet,");
            strSql.Append("ArchiveTemplet=@ArchiveTemplet,");
            strSql.Append("ListRule=@ListRule,");
            strSql.Append("ArchiveRule=@ArchiveRule,");
            strSql.Append("ClassPage=@ClassPage,");
            strSql.Append("Description=@Description,");
            strSql.Append("IsHidden=@IsHidden,");
            strSql.Append("IsHtml=@IsHtml,");
            strSql.Append("IsComment=@IsComment,");
            strSql.Append("Readaccess=@Readaccess,");
            strSql.Append("SiteID=@SiteID,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("Relation=@Relation,");
            strSql.Append("OrderID=@OrderID,");
            strSql.Append("ImgUrl=@ImgUrl,");
            strSql.Append("Keywords=@Keywords,");
            strSql.Append("CrossID=@CrossID,");
            strSql.Append("Content=@Content");
            strSql.Append(" where CID=@CID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Attribute", SqlDbType.TinyInt,1),
					new SqlParameter("@ClassName", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPath", SqlDbType.NVarChar,200),
					new SqlParameter("@IndexTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ListTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ListRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPage", SqlDbType.TinyInt,1),
					new SqlParameter("@Description", SqlDbType.NVarChar,500),
					new SqlParameter("@IsHidden", SqlDbType.TinyInt,1),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@IsComment", SqlDbType.TinyInt,1),
					new SqlParameter("@Readaccess", SqlDbType.SmallInt,2),
					new SqlParameter("@SiteID", SqlDbType.TinyInt,1),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@Relation", SqlDbType.NVarChar,200),
					new SqlParameter("@OrderID", SqlDbType.SmallInt,2),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Keywords", SqlDbType.NVarChar,200),
					new SqlParameter("@CrossID", SqlDbType.NVarChar,200),
					new SqlParameter("@Content", SqlDbType.NText)};
            parameters[0].Value = model.CID;
            parameters[1].Value = model.ParentID;
            parameters[2].Value = model.Attribute;
            parameters[3].Value = model.ClassName;
            parameters[4].Value = model.ClassUrl;
            parameters[5].Value = model.ClassPath;
            parameters[6].Value = model.IndexTemplet;
            parameters[7].Value = model.ListTemplet;
            parameters[8].Value = model.ArchiveTemplet;
            parameters[9].Value = model.ListRule;
            parameters[10].Value = model.ArchiveRule;
            parameters[11].Value = model.ClassPage;
            parameters[12].Value = model.Description;
            parameters[13].Value = model.IsHidden;
            parameters[14].Value = model.IsHtml;
            parameters[15].Value = model.IsComment;
            parameters[16].Value = model.Readaccess;
            parameters[17].Value = model.SiteID;
            parameters[18].Value = model.AddDate;
            parameters[19].Value = model.Relation;
            parameters[20].Value = model.OrderID;
            parameters[21].Value = model.ImgUrl;
            parameters[22].Value = model.Keywords;
            parameters[23].Value = model.CrossID;
            parameters[24].Value = model.Content;

            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
		
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns></returns>
        public int Delete(int CID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete DT_Arc_Class ");
            strSql.Append(" where CID=@CID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CID", SqlDbType.Int,4)};
            parameters[0].Value = CID;

            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
		
        }
        /// <summary>
        /// 得到一条数据
        /// </summary>
        /// <param name="CID"></param>
        /// <returns></returns>
        public Arc_Class GetModel(int CID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CID,ParentID,Attribute,ClassName,ClassUrl,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content from DT_Arc_Class ");
            strSql.Append(" where CID=@CID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CID", SqlDbType.Int,4)};
            parameters[0].Value = CID;

            DTCMS.Entity.Arc_Class model = new DTCMS.Entity.Arc_Class();
            DataSet ds = SqlHelper.ExecuteDataSet(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["CID"].ToString() != "")
                {
                    model.CID = int.Parse(ds.Tables[0].Rows[0]["CID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Attribute"].ToString() != "")
                {
                    model.Attribute = int.Parse(ds.Tables[0].Rows[0]["Attribute"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                model.ClassUrl = ds.Tables[0].Rows[0]["ClassUrl"].ToString();
                model.ClassPath = ds.Tables[0].Rows[0]["ClassPath"].ToString();
                model.IndexTemplet = ds.Tables[0].Rows[0]["IndexTemplet"].ToString();
                model.ListTemplet = ds.Tables[0].Rows[0]["ListTemplet"].ToString();
                model.ArchiveTemplet = ds.Tables[0].Rows[0]["ArchiveTemplet"].ToString();
                model.ListRule = ds.Tables[0].Rows[0]["ListRule"].ToString();
                model.ArchiveRule = ds.Tables[0].Rows[0]["ArchiveRule"].ToString();
                if (ds.Tables[0].Rows[0]["ClassPage"].ToString() != "")
                {
                    model.ClassPage = int.Parse(ds.Tables[0].Rows[0]["ClassPage"].ToString());
                }
                model.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                if (ds.Tables[0].Rows[0]["IsHidden"].ToString() != "")
                {
                    model.IsHidden = int.Parse(ds.Tables[0].Rows[0]["IsHidden"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsHtml"].ToString() != "")
                {
                    model.IsHtml = int.Parse(ds.Tables[0].Rows[0]["IsHtml"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsComment"].ToString() != "")
                {
                    model.IsComment = int.Parse(ds.Tables[0].Rows[0]["IsComment"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Readaccess"].ToString() != "")
                {
                    model.Readaccess = int.Parse(ds.Tables[0].Rows[0]["Readaccess"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SiteID"].ToString() != "")
                {
                    model.SiteID = int.Parse(ds.Tables[0].Rows[0]["SiteID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
                model.Relation = ds.Tables[0].Rows[0]["Relation"].ToString();
                if (ds.Tables[0].Rows[0]["OrderID"].ToString() != "")
                {
                    model.OrderID = int.Parse(ds.Tables[0].Rows[0]["OrderID"].ToString());
                }
                model.ImgUrl = ds.Tables[0].Rows[0]["ImgUrl"].ToString();
                model.Keywords = ds.Tables[0].Rows[0]["Keywords"].ToString();
                model.CrossID = ds.Tables[0].Rows[0]["CrossID"].ToString();
                model.Content = ds.Tables[0].Rows[0]["Content"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
