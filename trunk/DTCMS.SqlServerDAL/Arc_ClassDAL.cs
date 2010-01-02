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
    public class Arc_ClassDAL:IDAL_Arc_Class
    {
        #region IDAL_Arc_Class 成员

        /// <summary>
        /// 判断某个字段值是否存在
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>成功返回true，失败返回false</returns>
        public bool Exists(int CID, string filedName, string filedValue)
        {
            string strSql = "";

            if (filedName != "" && filedValue != "")
            {
                strSql += "select count(CID) from DT_Arc_Class where CID<>{0} ";
                strSql += " and {1}='{2}'";
                return TypeConvert.ObjectToInt(SqlHelper.ExecuteScalar(CommandType.Text,string.Format(strSql, CID, filedName, filedValue))) > 0;
            }
            else
            {
                strSql += "select count(CID) from DT_Arc_Class where CID={0} ";
                return TypeConvert.ObjectToInt(SqlHelper.ExecuteScalar(CommandType.Text,string.Format(strSql,CID))) > 0;
            }
        }

        /// <summary>
        /// 添加栏目
        /// </summary>
        /// <param name="Entity">栏目实体对象</param>
        /// <returns>返回影响的行数</returns>
        public int Add(Arc_Class model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DT_Arc_Class(");
            strSql.Append("ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content)");
            strSql.Append(" values (");
            strSql.Append("@ParentID,@Attribute,@ClassName,@ClassEName,@ClassType,@ClassDomain,@ClassPath,@IndexTemplet,@ListTemplet,@ArchiveTemplet,@IndexRule,@ListRule,@ArchiveRule,@ClassPage,@Description,@IsHidden,@IsHtml,@CheckLevel,@IsContribute,@IsComment,@Readaccess,@SiteID,@AddDate,@Relation,@OrderID,@ImgUrl,@Keywords,@CrossID,@Content)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = CacheAccess.GetFromCache("ClassAddSqlParameter") as SqlParameter[];
            if (parameters == null)
            {
                parameters = new SqlParameter[]{
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Attribute", SqlDbType.TinyInt,1),
					new SqlParameter("@ClassName", SqlDbType.NVarChar,100),
					new SqlParameter("@ClassEName", SqlDbType.NVarChar,100),
					new SqlParameter("@ClassType", SqlDbType.TinyInt,1),
					new SqlParameter("@ClassDomain", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPath", SqlDbType.NVarChar,200),
					new SqlParameter("@IndexTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ListTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@IndexRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ListRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPage", SqlDbType.TinyInt,1),
					new SqlParameter("@Description", SqlDbType.NVarChar,500),
					new SqlParameter("@IsHidden", SqlDbType.TinyInt,1),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@CheckLevel", SqlDbType.TinyInt,1),
					new SqlParameter("@IsContribute", SqlDbType.TinyInt,1),
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

                CacheAccess.SaveToCache("ClassAddSqlParameter", parameters, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(30));
            }
            parameters[0].Value = model.ParentID;
            parameters[1].Value = model.Attribute;
            parameters[2].Value = model.ClassName;
            parameters[3].Value = model.ClassEName;
            parameters[4].Value = model.ClassType;
            parameters[5].Value = model.ClassDomain;
            parameters[6].Value = model.ClassPath;
            parameters[7].Value = model.IndexTemplet;
            parameters[8].Value = model.ListTemplet;
            parameters[9].Value = model.ArchiveTemplet;
            parameters[10].Value = model.IndexRule;
            parameters[11].Value = model.ListRule;
            parameters[12].Value = model.ArchiveRule;
            parameters[13].Value = model.ClassPage;
            parameters[14].Value = model.Description;
            parameters[15].Value = model.IsHidden;
            parameters[16].Value = model.IsHtml;
            parameters[17].Value = model.CheckLevel;
            parameters[18].Value = model.IsContribute;
            parameters[19].Value = model.IsComment;
            parameters[20].Value = model.Readaccess;
            parameters[21].Value = model.SiteID;
            parameters[22].Value = model.AddDate;
            parameters[23].Value = model.Relation;
            parameters[24].Value = model.OrderID;
            parameters[25].Value = model.ImgUrl;
            parameters[26].Value = model.Keywords;
            parameters[27].Value = model.CrossID;
            parameters[28].Value = model.Content;

            return SqlHelper.ExecuteNonQuery(CommandType.Text,strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新栏目
        /// </summary>
        /// <param name="Entity">栏目实体对象</param>
        /// <returns>返回影响的行数</returns>
        public int Update(Arc_Class model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DT_Arc_Class set ");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("Attribute=@Attribute,");
            strSql.Append("ClassName=@ClassName,");
            strSql.Append("ClassEName=@ClassEName,");
            strSql.Append("ClassType=@ClassType,");
            strSql.Append("ClassDomain=@ClassDomain,");
            strSql.Append("ClassPath=@ClassPath,");
            strSql.Append("IndexTemplet=@IndexTemplet,");
            strSql.Append("ListTemplet=@ListTemplet,");
            strSql.Append("ArchiveTemplet=@ArchiveTemplet,");
            strSql.Append("IndexRule=@IndexRule,");
            strSql.Append("ListRule=@ListRule,");
            strSql.Append("ArchiveRule=@ArchiveRule,");
            strSql.Append("ClassPage=@ClassPage,");
            strSql.Append("Description=@Description,");
            strSql.Append("IsHidden=@IsHidden,");
            strSql.Append("IsHtml=@IsHtml,");
            strSql.Append("CheckLevel=@CheckLevel,");
            strSql.Append("IsContribute=@IsContribute,");
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
            SqlParameter[] parameters = CacheAccess.GetFromCache("ClassUpdateSqlParameter") as SqlParameter[];
            if (parameters == null)
            {
                parameters = new SqlParameter[]{
					new SqlParameter("@CID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Attribute", SqlDbType.TinyInt,1),
					new SqlParameter("@ClassName", SqlDbType.NVarChar,100),
					new SqlParameter("@ClassEName", SqlDbType.NVarChar,100),
					new SqlParameter("@ClassType", SqlDbType.TinyInt,1),
					new SqlParameter("@ClassDomain", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPath", SqlDbType.NVarChar,200),
					new SqlParameter("@IndexTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ListTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveTemplet", SqlDbType.NVarChar,200),
					new SqlParameter("@IndexRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ListRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ArchiveRule", SqlDbType.NVarChar,200),
					new SqlParameter("@ClassPage", SqlDbType.TinyInt,1),
					new SqlParameter("@Description", SqlDbType.NVarChar,500),
					new SqlParameter("@IsHidden", SqlDbType.TinyInt,1),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@CheckLevel", SqlDbType.TinyInt,1),
					new SqlParameter("@IsContribute", SqlDbType.TinyInt,1),
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

                CacheAccess.SaveToCache("ClassUpdateSqlParameter", parameters, Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(30));
            }
            parameters[0].Value = model.CID;
            parameters[1].Value = model.ParentID;
            parameters[2].Value = model.Attribute;
            parameters[3].Value = model.ClassName;
            parameters[4].Value = model.ClassEName;
            parameters[5].Value = model.ClassType;
            parameters[6].Value = model.ClassDomain;
            parameters[7].Value = model.ClassPath;
            parameters[8].Value = model.IndexTemplet;
            parameters[9].Value = model.ListTemplet;
            parameters[10].Value = model.ArchiveTemplet;
            parameters[11].Value = model.IndexRule;
            parameters[12].Value = model.ListRule;
            parameters[13].Value = model.ArchiveRule;
            parameters[14].Value = model.ClassPage;
            parameters[15].Value = model.Description;
            parameters[16].Value = model.IsHidden;
            parameters[17].Value = model.IsHtml;
            parameters[18].Value = model.CheckLevel;
            parameters[19].Value = model.IsContribute;
            parameters[20].Value = model.IsComment;
            parameters[21].Value = model.Readaccess;
            parameters[22].Value = model.SiteID;
            parameters[23].Value = model.AddDate;
            parameters[24].Value = model.Relation;
            parameters[25].Value = model.OrderID;
            parameters[26].Value = model.ImgUrl;
            parameters[27].Value = model.Keywords;
            parameters[28].Value = model.CrossID;
            parameters[29].Value = model.Content;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
		
        }

        /// <summary>
        /// 更新排序
        /// </summary>
        /// <param name="cid">栏目ID</param>
        /// <param name="order">排序编号</param>
        /// <returns></returns>
        public int UpdateOrder(int cid,int order)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DT_Arc_Class set ");
            strSql.Append("OrderID=@OrderID ");
            strSql.Append(" where CID=@CID ");
            SqlParameter[] parameters = {
                new SqlParameter("@OrderID", SqlDbType.SmallInt,2),
                new SqlParameter("@CID", SqlDbType.Int,4)
            };
            parameters[0].Value = order;
            parameters[1].Value = cid;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>返回影响的行数</returns>
        public int Delete(string CID)
        {
            string strSql = string.Format("delete DT_Arc_Class  where CID in ({0})",CID);
            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql);	
        }

        /// <summary>
        /// 获取栏目实体
        /// </summary>
        /// <param name="CID">栏目ID</param>
        /// <returns>栏目实体</returns>
        public Arc_Class GetModel(int CID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content from DT_Arc_Class ");
            strSql.Append(" where CID=@CID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CID", SqlDbType.Int,4)};
            parameters[0].Value = CID;

            DTCMS.Entity.Arc_Class Entity = new DTCMS.Entity.Arc_Class();
            DataSet ds = SqlHelper.FillDataset(CommandType.Text,strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["CID"].ToString() != "")
                {
                    Entity.CID = int.Parse(ds.Tables[0].Rows[0]["CID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    Entity.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Attribute"].ToString() != "")
                {
                    Entity.Attribute = int.Parse(ds.Tables[0].Rows[0]["Attribute"].ToString());
                }
                Entity.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                Entity.ClassEName = ds.Tables[0].Rows[0]["ClassEName"].ToString();
                if (ds.Tables[0].Rows[0]["ClassType"].ToString() != "")
                {
                    Entity.ClassType = int.Parse(ds.Tables[0].Rows[0]["ClassType"].ToString());
                }
                Entity.ClassDomain = ds.Tables[0].Rows[0]["ClassDomain"].ToString();
                Entity.ClassPath = ds.Tables[0].Rows[0]["ClassPath"].ToString();
                Entity.IndexTemplet = ds.Tables[0].Rows[0]["IndexTemplet"].ToString();
                Entity.ListTemplet = ds.Tables[0].Rows[0]["ListTemplet"].ToString();
                Entity.ArchiveTemplet = ds.Tables[0].Rows[0]["ArchiveTemplet"].ToString();
                Entity.IndexRule = ds.Tables[0].Rows[0]["IndexRule"].ToString();
                Entity.ListRule = ds.Tables[0].Rows[0]["ListRule"].ToString();
                Entity.ArchiveRule = ds.Tables[0].Rows[0]["ArchiveRule"].ToString();
                if (ds.Tables[0].Rows[0]["ClassPage"].ToString() != "")
                {
                    Entity.ClassPage = int.Parse(ds.Tables[0].Rows[0]["ClassPage"].ToString());
                }
                Entity.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                if (ds.Tables[0].Rows[0]["IsHidden"].ToString() != "")
                {
                    Entity.IsHidden = int.Parse(ds.Tables[0].Rows[0]["IsHidden"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsHtml"].ToString() != "")
                {
                    Entity.IsHtml = int.Parse(ds.Tables[0].Rows[0]["IsHtml"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CheckLevel"].ToString() != "")
                {
                    Entity.CheckLevel = int.Parse(ds.Tables[0].Rows[0]["CheckLevel"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsContribute"].ToString() != "")
                {
                    Entity.IsContribute = int.Parse(ds.Tables[0].Rows[0]["IsContribute"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsComment"].ToString() != "")
                {
                    Entity.IsComment = int.Parse(ds.Tables[0].Rows[0]["IsComment"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Readaccess"].ToString() != "")
                {
                    Entity.Readaccess = int.Parse(ds.Tables[0].Rows[0]["Readaccess"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SiteID"].ToString() != "")
                {
                    Entity.SiteID = int.Parse(ds.Tables[0].Rows[0]["SiteID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    Entity.AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
                Entity.Relation = ds.Tables[0].Rows[0]["Relation"].ToString();
                if (ds.Tables[0].Rows[0]["OrderID"].ToString() != "")
                {
                    Entity.OrderID = int.Parse(ds.Tables[0].Rows[0]["OrderID"].ToString());
                }
                Entity.ImgUrl = ds.Tables[0].Rows[0]["ImgUrl"].ToString();
                Entity.Keywords = ds.Tables[0].Rows[0]["Keywords"].ToString();
                Entity.CrossID = ds.Tables[0].Rows[0]["CrossID"].ToString();
                Entity.Content = ds.Tables[0].Rows[0]["Content"].ToString();
                return Entity;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取栏目关系
        /// </summary>
        /// <param name="ParentID">父栏目ID</param>
        /// <returns>栏目关系</returns>
        public string GetRelation(int ParentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Relation from DT_ARC_CLASS where CID=@CID");
            SqlParameter[] parameters = {
                new SqlParameter("@CID", SqlDbType.Int,4)
            };
            parameters[0].Value = ParentID;

            object iObj = SqlHelper.ExecuteScalar(CommandType.Text,strSql.ToString(), parameters);

            if (iObj != null)
            {
                return iObj.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 获取栏目名称
        /// </summary>
        /// <param name="ParentID">栏目ID</param>
        /// <returns>栏目名称</returns>
        public string GetClassName(int CID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ClassName from DT_ARC_CLASS where CID=@CID");
            SqlParameter[] parameters = {
                new SqlParameter("@CID", SqlDbType.Int,4)
            };
            parameters[0].Value = CID;
            object iObj = SqlHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), parameters);
            if (iObj != null)
            {
                return iObj.ToString();
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 根据查询字段查询栏目数据
        /// </summary>
        /// <param name="Fileds">要查询的字段</param>
        /// <returns>DataTable数据集合</returns>
        public DataTable GetDataTable(string Fileds)
        {
            return GetDataTable(Fileds, null);

        }
        /// <summary>
        /// 根据查询字段查询栏目数据
        /// </summary>
        /// <param name="Fileds">要查询的字段</param>
        /// <returns>DataTable数据集合</returns>
        public DataTable GetDataTable(string Fileds,string where)
        {
            string strSql = string.Empty;
            if (where != string.Empty)
            {
                strSql = string.Format("select {0} from DT_ARC_CLASS where {1}", Fileds, where);
            }
            else
            {
                strSql = string.Format("SELECT {0} FROM DT_ARC_CLASS ", Fileds);
            }
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

        /// <summary>
        /// 判断当前节点是否存在子节点
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        public bool ExistsChildNode(int CID)
        {
            string strSql = "select count(CID) from DT_Arc_Class where ParentID=@ParentID";
            SqlParameter[] parameter ={
                                          new SqlParameter("@ParentID",SqlDbType.Int,4)
                                     };
            parameter[0].Value = CID;
            return TypeConvert.ObjectToInt(SqlHelper.ExecuteScalar(CommandType.Text, strSql, parameter))>0;
        }

        /// <summary>
        /// 判断栏目是否已经存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool ExistsClassName(int CID,string ClassName)
        {
            string strSql = "select count(CID) from DT_Arc_Class where ClassName=@ClassName and CID<>@CID";
            SqlParameter[] parameter ={
                                          new SqlParameter("@ClassName",SqlDbType.NVarChar,100),
                                          new SqlParameter("@CID",SqlDbType.Int,4)
                                     };
            parameter[0].Value = ClassName;
            parameter[1].Value = CID;

            return TypeConvert.ObjectToInt(SqlHelper.ExecuteScalar(CommandType.Text, strSql,parameter))>0;
        }


        #endregion
    }
}
