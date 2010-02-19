//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-01-8 11:52:52
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTCMS.Entity;
using DTCMS.DBUtility;
using DTCMS.IDAL;

namespace DTCMS.SqlServerDAL
{
    public class Sys_PublishDAL : BaseDAL, IDAL_Sys_Publish
    {
        public Sys_PublishDAL()
		{ }

        /// <summary>
        /// 根据栏目编号获取栏目信息
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns></returns>
        public Arc_Class GetClassByID(int CID)
        {
            StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,ClassContent FROM Arc_Class");
			strSql.Append(" WHERE CID=@CID");
			SqlParameter[] cmdParms = {
				AddInParameter("@CID", SqlDbType.Int, CID)};

			using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
			{
				if (dr.Read())
				{
					return GetModel(dr);
				}
				return null;
            }
        }

        /// <summary>
        /// 得到所有的栏目信息
        /// </summary>
        /// <param name="totalCount">共多少条数据</param>
        /// <returns></returns>
        public DataTable GetClassByClassID(int CID, out int totalCount)
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.AppendFormat(" isHidden=0  AND(  relation like'%.{0}.%' OR CID={0} ) ", CID);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ");
            strSql.Append("CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content");
            strSql.Append("FROM DT_Arc_Class ");
            strSql.Append("WHERE ");
            strSql.Append(strSearch.ToString());
            string sqlCount = string.Format(" SELECT COUNT(CID) FROM DT_Arc_Class WHERE {0} ", strSearch.ToString());
            totalCount = Convert.ToInt32(dbHelper.ExecuteScalar(CommandType.Text, sqlCount, null));
            return dbHelper.ExecuteQuery(CommandType.Text, strSql.ToString(), null).Tables[0];

        }



        /// <summary>
        /// 获取栏目列表文章
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <param name="publishchild">是否发布其子栏目</param>
        /// <param name="orderBy">文章排序</param>
        /// <returns></returns>
        public DataTable GetArticleListByClassID(int CID, string orderBy)
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.Append(" a.ClassID=b.CID  AND  a.IsVerify=1 AND a.IsRecycle=0 AND a.IsHtml=1 ");
            strSearch.AppendFormat(" AND(  b.relation like'%.{0}.%' OR  b.CID={0} ) ", CID);

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" a.[ID],a.Title,a.ImgUrl,a.Author,a.Source,a.Description,a.Content,a.Click,a.Good,a.Bad,a.IsRedirect,a.FilePath,a.PubDate,b.CID,b.ClassName,b.ClassType");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());

            if (string.IsNullOrEmpty(orderBy))
                strSql.AppendFormat(" ORDER BY a.[ID] DESC ");
            else
                strSql.AppendFormat(" ORDER BY {0} ", orderBy);

            return dbHelper.ExecuteQuery(CommandType.Text, strSql.ToString(), null).Tables[0];
        }

        /// <summary>
        /// 按照日期发布文章
        /// </summary>
        /// <param name="CID">类别编号</param>
        /// <param name="publishchild">是否发布其子栏目</param>
        /// <param name="orderBy">文章排序</param>
        /// <param name="totalCount">共有多少条</param>
        /// <returns></returns>
        public DataTable GetArticleByTime(DateTime startTime, DateTime endTime)
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.Append(" a.ClassID=b.CID AND IsVerify=1 AND IsRecycle=1 AND IsHtml=1 ");
            strSearch.AppendFormat(" AND AddDate Between '{0}' AND '{1}' ", startTime, endTime);

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" a.[ID],a.Title,a.ShortTitle,a.TitleStyle,a.TitleFlag,a.Tags,a.ImgUrl,a.Author,a.Source,a.Templet,a.Keywords,a.Description,a.Content,a.Click,a.Good,a.Bad,a.Readaccess,a.Money,a.IsComment,a.IsRedirect,a.FilePath,a.SimilarArticle,a.PubDate,b.ClassID,b.ClassName,b.ClassType");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());
            strSql.Append(" Order BY a.[ID] DESC");

            string sqlCount = string.Format(" SELECT Count(a.ClassID) FROM DT_Arc_Article as a,DT_Arc_Class as b  WHERE {0}", strSearch.ToString());

            totalCount = Convert.ToInt32(dbHelper.ExecuteScalar(CommandType.Text, sqlCount.ToString(), null));

            return dbHelper.ExecuteQuery(CommandType.Text, strSql.ToString(), null).Tables[0];
        }

        /// <summary>
        /// 根据文章编号范围发布 
        /// </summary>
        /// <param name="minId">开始编号</param>
        /// <param name="maxId">结束编号</param>
        /// <param name="totalCount">共有几条数据</param>
        /// <returns></returns>
        public DataTable GetArticleByID(int minId, int maxId, out int totalCount)
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.Append(" a.ClassID=b.CID AND IsVerify=1 AND IsRecycle=1 AND IsHtml=1 ");
            strSearch.AppendFormat(" AND a.[ID] Between {0} AND {1} ", minId, maxId);

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" a.[ID],a.Title,a.TitleFlag,a.ImgUrl,a.Author,a.Source,a.Templet,a.Keywords,a.Description,a.Content,a.Click,a.Good,a.Bad,a.Readaccess,a.Money,a.IsComment,a.IsRedirect,a.FilePath,a.SimilarArticle,a.PubDate,b.ClassID,b.ClassName,b.ClassType");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());
            strSql.Append(" Order BY a.[ID] DESC");

            string sqlCount = string.Format(" SELECT Count(a.ClassID) FROM DT_Arc_Article as a,DT_Arc_Class as b  WHERE {0}", strSearch.ToString());

            totalCount = Convert.ToInt32(dbHelper.ExecuteScalar(CommandType.Text, sqlCount.ToString(), null));

            return dbHelper.ExecuteQuery(CommandType.Text, strSql.ToString(), null).Tables[0];
        }

        /// <summary>
        /// 根据组合条件获取前多少条数据
        /// </summary>
        /// <param name="topnum">前多少条数据</param>
        /// <param name="orderBy">排序字段</param>
        /// <param name="orderWay">排序方式 desc asc</param>
        /// <param name="search">组合条件</param>
        /// <returns></returns>
        public DataTable GetTopArticleBySearch(int topnum, string orderBy, string orderWay, string search)
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.Append(" a.ClassID=b.CID AND a.IsVerify=1 AND a.IsRecycle=0 AND a.IsHtml=1 ");
            if (!string.IsNullOrEmpty(search))
                strSearch.AppendFormat(" AND {0} ", search);
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(" SELECT TOP {0} ", topnum);
            strSql.Append(" a.[ID],a.Title,a.TitleFlag,a.ImgUrl,a.Author,a.Source,a.Description,a.Content,a.Click,a.Good,a.Bad,a.IsRedirect,a.FilePath,a.PubDate,b.CID,b.ClassName,b.ClassType,");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());

            if (string.IsNullOrEmpty(orderWay))
                orderWay = "DESC";
            if (string.IsNullOrEmpty(orderBy))
                strSql.AppendFormat("ORDER BY a.[ID] {0} ", orderWay);
            else
                strSql.AppendFormat("ORDER BY a.[{0}] {1} ", orderBy, orderWay);

            return dbHelper.ExecuteQuery(CommandType.Text, strSql.ToString(), null).Tables[0];
        }

        /// <summary>
        /// 获取当前类别的父类别集合
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>栏目集合</returns>
        public List<Arc_Class> GetParentClassList(int CID)
        {
            string sql = "SELECT CID,ClassName,Relation,ParentID From DT_Arc_Class WHERE CID=@CID ";
            SqlParameter[] cmdParms = {
				AddInParameter("@CID", SqlDbType.Int, CID)};

            Arc_Class model = new Arc_Class();
            using (SqlDataReader reader = dbHelper.ExecuteReader(CommandType.Text, sql, cmdParms))
            {
                if (reader.HasRows)
                {
                    model = DataReaderToModel<Arc_Class>(reader);
                }
            }
            if (!string.IsNullOrEmpty(model.Relation))
            {
                List<Arc_Class> list = new List<Arc_Class>();
                if (model.ParentID > 0)
                {
                    model.Relation = model.Relation.Replace(".0.", "");
                    if (model.Relation.IndexOf(".") != -1)
                    {
                        model.Relation = model.Relation.Trim().Substring(0, model.Relation.Trim().Length - 1);
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append(" SELECT CID,ClassName,ClassDomain,ClassPath From DT_Arc_Class ");
                        strSql.Append(" WHERE ");
                        strSql.AppendFormat(" CID IN ({0}) ", model.Relation);
                        strSql.Append(" ORDER BY LEN(Relation) ASC ");

                        using (SqlDataReader readerList = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
                        {
                            while (readerList.Read())
                            {
                                list.Add(DataReaderToModel<Arc_Class>(readerList));
                            }
                        }

                    }
                }
                else
                {
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

    }
}
