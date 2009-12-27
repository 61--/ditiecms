using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTCMS.Entity;
using DTCMS.DBUtility;
namespace DTCMS.SqlServerDAL
{
    public class Sys_PublishDAL
    {
        /// <summary>
        /// 根据栏目编号获取栏目信息
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns></returns>
        public Arc_Class GetClassByID(int CID)
        {
            Arc_Class model = new Arc_Class();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content ");
            strSql.Append(" FROM DT_Arc_Class ");
            strSql.Append(" WHERE ");
            strSql.Append(string.Format(" CID={0} ", CID));

            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {

                object ojb;
                ojb = dataReader["CID"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.CID = (int)ojb;
                }
                ojb = dataReader["ParentID"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.ParentID = (int)ojb;
                }
                ojb = dataReader["Attribute"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.Attribute = (int)ojb;
                }
                model.ClassName = dataReader["ClassName"].ToString();
                model.ClassEName = dataReader["ClassEName"].ToString();
                ojb = dataReader["ClassType"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.ClassType = (int)ojb;
                }
                model.ClassDomain = dataReader["ClassDomain"].ToString();
                model.ClassPath = dataReader["ClassPath"].ToString();
                model.IndexTemplet = dataReader["IndexTemplet"].ToString();
                model.ListTemplet = dataReader["ListTemplet"].ToString();
                model.ArchiveTemplet = dataReader["ArchiveTemplet"].ToString();
                model.IndexRule = dataReader["IndexRule"].ToString();
                model.ListRule = dataReader["ListRule"].ToString();
                model.ArchiveRule = dataReader["ArchiveRule"].ToString();
                ojb = dataReader["ClassPage"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.ClassPage = (int)ojb;
                }
                model.Description = dataReader["Description"].ToString();
                ojb = dataReader["IsHidden"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.IsHidden = (int)ojb;
                }
                ojb = dataReader["IsHtml"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.IsHtml = (int)ojb;
                }
                ojb = dataReader["CheckLevel"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.CheckLevel = (int)ojb;
                }
                ojb = dataReader["IsContribute"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.IsContribute = (int)ojb;
                }
                ojb = dataReader["IsComment"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.IsComment = (int)ojb;
                }
                ojb = dataReader["Readaccess"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.Readaccess = (int)ojb;
                }
                ojb = dataReader["SiteID"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.SiteID = (int)ojb;
                }
                ojb = dataReader["AddDate"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.AddDate = (DateTime)ojb;
                }
                model.Relation = dataReader["Relation"].ToString();
                ojb = dataReader["OrderID"];
                if (ojb != null && ojb != DBNull.Value)
                {
                    model.OrderID = (int)ojb;
                }
                model.ImgUrl = dataReader["ImgUrl"].ToString();
                model.Keywords = dataReader["Keywords"].ToString();
                model.CrossID = dataReader["CrossID"].ToString();
                model.Content = dataReader["Content"].ToString();
                return model;

            }
        }

        /// <summary>
        /// 得到所有的栏目信息
        /// </summary>
        /// <param name="totalCount">共多少条数据</param>
        /// <returns></returns>
        public DataTable GetClassAll(out int totalCount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ");
            strSql.Append("CID,ParentID,Attribute,ClassName,ClassEName,ClassType,ClassDomain,ClassPath,IndexTemplet,ListTemplet,ArchiveTemplet,IndexRule,ListRule,ArchiveRule,ClassPage,Description,IsHidden,IsHtml,CheckLevel,IsContribute,IsComment,Readaccess,SiteID,AddDate,Relation,OrderID,ImgUrl,Keywords,CrossID,Content");
            strSql.Append("FROM DT_Arc_Class ");
            strSql.Append("WHERE isHidden=0 ");

            string sqlCount = "SELECT COUNT(CID) FROM DT_Arc_Class WHERE isHidden=0";
            totalCount =Convert.ToInt32( SqlHelper.ExecuteScalar(CommandType.Text, sqlCount, null));
            return SqlHelper.FillDataset(CommandType.Text, strSql.ToString(), null).Tables[0];

        }

  

        /// <summary>
        /// 按照类别编号发布文章
        /// </summary>
        /// <param name="CID">类别编号</param>
        /// <param name="publishchild">是否发布其子栏目</param>
        /// <param name="orderBy">文章排序</param>
        /// <param name="orderWay">排序方式 desc asc</param>
        /// <param name="totalCount">共有多少条</param>
        /// <returns></returns>
        public DataTable GetArticleByClassID(int CID,string orderBy,string orderWay,out int totalCount)
        {
            StringBuilder strSearch = new StringBuilder();
     
            strSearch.Append(" a.ClassID=b.CID  AND  a.IsChecked=1 AND a.IsRecycle=0 AND a.IsHtml=1 ");
            strSearch.AppendFormat(" AND(  b.relation like'%.{0}.%' OR  b.CID={0} ) ", CID);

            
            StringBuilder strSql=new StringBuilder ();
            strSql.Append(" SELECT ");
            strSql.Append(" a.[ID],a.Title,a.ShortTitle,a.TitleStyle,a.TitleFlag,a.Tags,a.ImgUrl,a.Author,a.Source,a.Templet,a.Keywords,a.Description,a.Content,a.Click,a.Good,a.Bad,a.Readaccess,a.Money,a.IsComment,a.IsRedirect,a.FilePath,a.SimilarArticle,a.PubDate,b.CID,b.ClassName,b.ClassType,");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());

            if (string.IsNullOrEmpty(orderWay))
                orderWay = "DESC";
            if (string.IsNullOrEmpty(orderBy))
                strSql.AppendFormat(" ORDER BY a.[ID] {0} ",orderWay);
            else
                strSql.AppendFormat("ORDER BY a.[{0}] {1} ",orderBy,orderWay);
          
            string sqlCount=string.Format(" SELECT Count(a.ID) FROM DT_Arc_Article as a,DT_Arc_Class as b  WHERE {0}",strSearch.ToString());

            totalCount=Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text,sqlCount.ToString()));
                
            return SqlHelper.FillDataset(CommandType.Text,strSql.ToString(),null).Tables[0];
        }

        /// <summary>
        /// 按照日期发布文章
        /// </summary>
        /// <param name="CID">类别编号</param>
        /// <param name="publishchild">是否发布其子栏目</param>
        /// <param name="orderBy">文章排序</param>
        /// <param name="totalCount">共有多少条</param>
        /// <returns></returns>
        public DataTable GetArticleByTime(DateTime startTime,DateTime endTime, out int totalCount)
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.Append(" a.ClassID=b.CID AND IsChecked=1 AND IsRecycle=1 AND IsHtml=1 ");
            strSearch.AppendFormat(" AND AddDate Between '{0}' AND '{1}' ",startTime,endTime);
            
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" a.[ID],a.Title,a.ShortTitle,a.TitleStyle,a.TitleFlag,a.Tags,a.ImgUrl,a.Author,a.Source,a.Templet,a.Keywords,a.Description,a.Content,a.Click,a.Good,a.Bad,a.Readaccess,a.Money,a.IsComment,a.IsRedirect,a.FilePath,a.SimilarArticle,a.PubDate,b.ClassID,b.ClassName,b.ClassType");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());
            strSql.Append(" Order BY a.[ID] DESC");

            string sqlCount = string.Format(" SELECT Count(a.ClassID) FROM DT_Arc_Article as a,DT_Arc_Class as b  WHERE {0}", strSearch.ToString());

            totalCount = Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text, sqlCount.ToString(),null));

            return SqlHelper.FillDataset(CommandType.Text, strSql.ToString(), null).Tables[0];
        }

        /// <summary>
        /// 根据文章编号范围发布 
        /// </summary>
        /// <param name="minId">开始编号</param>
        /// <param name="maxId">结束编号</param>
        /// <param name="totalCount">共有几条数据</param>
        /// <returns></returns>
        public DataTable GetArticleByID(int minId,int maxId,out int totalCount )
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.Append(" a.ClassID=b.CID AND IsChecked=1 AND IsRecycle=1 AND IsHtml=1 ");
            strSearch.AppendFormat(" AND a.[ID] Between {0} AND {1} ", minId, maxId);

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ");
            strSql.Append(" a.[ID],a.Title,a.ShortTitle,a.TitleStyle,a.TitleFlag,a.Tags,a.ImgUrl,a.Author,a.Source,a.Templet,a.Keywords,a.Description,a.Content,a.Click,a.Good,a.Bad,a.Readaccess,a.Money,a.IsComment,a.IsRedirect,a.FilePath,a.SimilarArticle,a.PubDate,b.ClassID,b.ClassName,b.ClassType");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());
            strSql.Append(" Order BY a.[ID] DESC");

            string sqlCount = string.Format(" SELECT Count(a.ClassID) FROM DT_Arc_Article as a,DT_Arc_Class as b  WHERE {0}", strSearch.ToString());

            totalCount = Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text,sqlCount.ToString(),null));

            return SqlHelper.FillDataset(CommandType.Text, strSql.ToString(), null).Tables[0];
        }

        /// <summary>
        /// 根据组合条件获取前多少条数据
        /// </summary>
        /// <param name="topnum">前多少条数据</param>
        /// <param name="orderBy">排序字段</param>
        /// <param name="orderWay">排序方式 desc asc</param>
        /// <param name="search">组合条件</param>
        /// <returns></returns>
        public DataTable GetTopArticleBySearch(int topnum,string orderBy,string orderWay,string search)
        {
            StringBuilder strSearch = new StringBuilder();
            strSearch.Append(" a.ClassID=b.CID AND a.isChecked=1 AND a.IsRecycle=0 AND a.IsHtml=1 ");
            if (!string.IsNullOrEmpty(search))
                strSearch.AppendFormat(" AND {0} ",search);
            StringBuilder strSql = new StringBuilder();
            strSql.AppendFormat(" SELECT TOP {0} ",topnum);
            strSql.Append(" a.[ID],a.Title,a.ShortTitle,a.TitleStyle,a.TitleFlag,a.Tags,a.ImgUrl,a.Author,a.Source,a.Templet,a.Keywords,a.Description,a.Content,a.Click,a.Good,a.Bad,a.Readaccess,a.Money,a.IsComment,a.IsRedirect,a.FilePath,a.SimilarArticle,a.PubDate,b.CID,b.ClassName,b.ClassType,");
            strSql.Append(" FROM DT_Arc_Article as a,DT_Arc_Class as b  ");
            strSql.Append(" WHERE ");
            strSql.Append(strSearch.ToString());

            if (string.IsNullOrEmpty(orderWay))
                orderWay = "DESC";
            if (string.IsNullOrEmpty(orderBy))
                strSql.AppendFormat("ORDER BY a.[ID] {0} ", orderWay);
            else
                strSql.AppendFormat("ORDER BY a.[{0}] {1} ", orderBy, orderWay);

            return SqlHelper.FillDataset(CommandType.Text, strSql.ToString(), null).Tables[0];
        }


    }
}
