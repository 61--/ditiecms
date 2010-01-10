//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-10 19:36:36
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using DTCMS.Entity;
using DTCMS.IDAL;

namespace DTCMS.SqlServerDAL
{
    /// <summary>
    /// 数据访问类 Arc_Article
    /// </summary>
    public class Arc_ArticleDAL : BaseDAL, IDAL_Arc_Article
    {
        public Arc_ArticleDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Add(Arc_Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO " + tablePrefix + "Arc_Article(");
            strSql.Append("ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,AContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID)");
            strSql.Append(" VALUES (");
            strSql.Append("@ClassID,@ViceClassID,@Title,@ShortTitle,@TitleStyle,@TitleFlag,@Tags,@ImgUrl,@Author,@Editor,@PubLisher,@Source,@Templet,@Keywords,@Description,@AContent,@Click,@Good,@Bad,@Readaccess,@Money,@Attribute,@IsComment,@IsChecked,@IsRecycle,@IsRedirect,@IsHtml,@IsPaging,@FilePath,@SimilarArticle,@AddDate,@PubDate,@OrderID)");
            SqlParameter[] cmdParms = {
				AddInParameter("@ClassID", SqlDbType.Int, 4, model.ClassID),
				AddInParameter("@ViceClassID", SqlDbType.Int, 4, model.ViceClassID),
				AddInParameter("@Title", SqlDbType.NVarChar, 100, model.Title),
				AddInParameter("@ShortTitle", SqlDbType.NVarChar, 100, model.ShortTitle),
				AddInParameter("@TitleStyle", SqlDbType.VarChar, 100, model.TitleStyle),
				AddInParameter("@TitleFlag", SqlDbType.TinyInt, 1, model.TitleFlag),
				AddInParameter("@Tags", SqlDbType.NVarChar, 100, model.Tags),
				AddInParameter("@ImgUrl", SqlDbType.VarChar, 255, model.ImgUrl),
				AddInParameter("@Author", SqlDbType.NVarChar, 50, model.Author),
				AddInParameter("@Editor", SqlDbType.NVarChar, 50, model.Editor),
				AddInParameter("@PubLisher", SqlDbType.NVarChar, 50, model.PubLisher),
				AddInParameter("@Source", SqlDbType.NVarChar, 100, model.Source),
				AddInParameter("@Templet", SqlDbType.VarChar, 255, model.Templet),
				AddInParameter("@Keywords", SqlDbType.NVarChar, 200, model.Keywords),
				AddInParameter("@Description", SqlDbType.NVarChar, 500, model.Description),
				AddInParameter("@AContent", SqlDbType.NVarChar, 8, model.AContent),
				AddInParameter("@Click", SqlDbType.Int, 4, model.Click),
				AddInParameter("@Good", SqlDbType.Int, 4, model.Good),
				AddInParameter("@Bad", SqlDbType.Int, 4, model.Bad),
				AddInParameter("@Readaccess", SqlDbType.SmallInt, 2, model.Readaccess),
				AddInParameter("@Money", SqlDbType.SmallInt, 2, model.Money),
				AddInParameter("@Attribute", SqlDbType.SmallInt, 2, model.Attribute),
				AddInParameter("@IsComment", SqlDbType.TinyInt, 1, model.IsComment),
				AddInParameter("@IsChecked", SqlDbType.TinyInt, 1, model.IsChecked),
				AddInParameter("@IsRecycle", SqlDbType.TinyInt, 1, model.IsRecycle),
				AddInParameter("@IsRedirect", SqlDbType.TinyInt, 1, model.IsRedirect),
				AddInParameter("@IsHtml", SqlDbType.TinyInt, 1, model.IsHtml),
				AddInParameter("@IsPaging", SqlDbType.TinyInt, 1, model.IsPaging),
				AddInParameter("@FilePath", SqlDbType.VarChar, 255, model.FilePath),
				AddInParameter("@SimilarArticle", SqlDbType.VarChar, 200, model.SimilarArticle),
				AddInParameter("@AddDate", SqlDbType.DateTime, 8, model.AddDate),
				AddInParameter("@PubDate", SqlDbType.DateTime, 8, model.PubDate),
				AddInParameter("@OrderID", SqlDbType.Int, 4, model.OrderID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">实体对象</param>
        /// <returns>返回影响行数</returns>
        public int Update(Arc_Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE " + tablePrefix + "Arc_Article SET ");
            strSql.Append("ClassID=@ClassID,");
            strSql.Append("ViceClassID=@ViceClassID,");
            strSql.Append("Title=@Title,");
            strSql.Append("ShortTitle=@ShortTitle,");
            strSql.Append("TitleStyle=@TitleStyle,");
            strSql.Append("TitleFlag=@TitleFlag,");
            strSql.Append("Tags=@Tags,");
            strSql.Append("ImgUrl=@ImgUrl,");
            strSql.Append("Author=@Author,");
            strSql.Append("Editor=@Editor,");
            strSql.Append("PubLisher=@PubLisher,");
            strSql.Append("Source=@Source,");
            strSql.Append("Templet=@Templet,");
            strSql.Append("Keywords=@Keywords,");
            strSql.Append("Description=@Description,");
            strSql.Append("AContent=@AContent,");
            strSql.Append("Click=@Click,");
            strSql.Append("Good=@Good,");
            strSql.Append("Bad=@Bad,");
            strSql.Append("Readaccess=@Readaccess,");
            strSql.Append("Money=@Money,");
            strSql.Append("Attribute=@Attribute,");
            strSql.Append("IsComment=@IsComment,");
            strSql.Append("IsChecked=@IsChecked,");
            strSql.Append("IsRecycle=@IsRecycle,");
            strSql.Append("IsRedirect=@IsRedirect,");
            strSql.Append("IsHtml=@IsHtml,");
            strSql.Append("IsPaging=@IsPaging,");
            strSql.Append("FilePath=@FilePath,");
            strSql.Append("SimilarArticle=@SimilarArticle,");
            strSql.Append("AddDate=@AddDate,");
            strSql.Append("PubDate=@PubDate,");
            strSql.Append("OrderID=@OrderID");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@ClassID", SqlDbType.Int, 4, model.ClassID),
				AddInParameter("@ViceClassID", SqlDbType.Int, 4, model.ViceClassID),
				AddInParameter("@Title", SqlDbType.NVarChar, 100, model.Title),
				AddInParameter("@ShortTitle", SqlDbType.NVarChar, 100, model.ShortTitle),
				AddInParameter("@TitleStyle", SqlDbType.VarChar, 100, model.TitleStyle),
				AddInParameter("@TitleFlag", SqlDbType.TinyInt, 1, model.TitleFlag),
				AddInParameter("@Tags", SqlDbType.NVarChar, 100, model.Tags),
				AddInParameter("@ImgUrl", SqlDbType.VarChar, 255, model.ImgUrl),
				AddInParameter("@Author", SqlDbType.NVarChar, 50, model.Author),
				AddInParameter("@Editor", SqlDbType.NVarChar, 50, model.Editor),
				AddInParameter("@PubLisher", SqlDbType.NVarChar, 50, model.PubLisher),
				AddInParameter("@Source", SqlDbType.NVarChar, 100, model.Source),
				AddInParameter("@Templet", SqlDbType.VarChar, 255, model.Templet),
				AddInParameter("@Keywords", SqlDbType.NVarChar, 200, model.Keywords),
				AddInParameter("@Description", SqlDbType.NVarChar, 500, model.Description),
				AddInParameter("@AContent", SqlDbType.NVarChar, 8, model.AContent),
				AddInParameter("@Click", SqlDbType.Int, 4, model.Click),
				AddInParameter("@Good", SqlDbType.Int, 4, model.Good),
				AddInParameter("@Bad", SqlDbType.Int, 4, model.Bad),
				AddInParameter("@Readaccess", SqlDbType.SmallInt, 2, model.Readaccess),
				AddInParameter("@Money", SqlDbType.SmallInt, 2, model.Money),
				AddInParameter("@Attribute", SqlDbType.SmallInt, 2, model.Attribute),
				AddInParameter("@IsComment", SqlDbType.TinyInt, 1, model.IsComment),
				AddInParameter("@IsChecked", SqlDbType.TinyInt, 1, model.IsChecked),
				AddInParameter("@IsRecycle", SqlDbType.TinyInt, 1, model.IsRecycle),
				AddInParameter("@IsRedirect", SqlDbType.TinyInt, 1, model.IsRedirect),
				AddInParameter("@IsHtml", SqlDbType.TinyInt, 1, model.IsHtml),
				AddInParameter("@IsPaging", SqlDbType.TinyInt, 1, model.IsPaging),
				AddInParameter("@FilePath", SqlDbType.VarChar, 255, model.FilePath),
				AddInParameter("@SimilarArticle", SqlDbType.VarChar, 200, model.SimilarArticle),
				AddInParameter("@AddDate", SqlDbType.DateTime, 8, model.AddDate),
				AddInParameter("@PubDate", SqlDbType.DateTime, 8, model.PubDate),
				AddInParameter("@OrderID", SqlDbType.Int, 4, model.OrderID),
				AddInParameter("@ID", SqlDbType.Int, 4, model.ID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
		/// 根据ID和值更新一条数据
		/// </summary>
		/// <param name="ID">编号ID</param>
		/// <param name="value">更新值（fieldName=fieldValue）</param>
		/// <returns>返回影响行数</returns>
		public int Update(int ID, string value)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE " + tablePrefix + "Arc_Article SET ");
			strSql.Append(value);
			strSql.Append(" WHERE ID=");
			strSql.Append(ID);
			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
		}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <returns>返回影响行数</returns>
        public int Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM " + tablePrefix + "Arc_Article");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@ID", SqlDbType.Int, 4, ID)};

            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        /// <param name="ID">文章ID，多个ID用,号隔开</param>
        /// <returns>返回影响行数</returns>
        public int Delete(string ID)
        {
            string strSql = string.Format("DELETE FROM " + tablePrefix + "Arc_Article WHERE ID in({0}) ", ID);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <param name="filedName">字段名称</param>
        /// <param name="filedValue">字段值</param>
        /// <returns>存在返回true，不存在返回false</returns>
        public bool Exists(int ID, string filedName, string filedValue)
        {
            StringBuilder strSql = new StringBuilder();
            if (filedName != "")
            {
                strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Arc_Article");
                strSql.Append(" WHERE ID<>{0} AND {1}={2}");
                return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), ID, filedName, filedValue))) > 0;
            }
            else
            {
                strSql.Append("SELECT COUNT(1) FROM " + tablePrefix + "Arc_Article");
                strSql.Append(" WHERE ID={0}");
                return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql.ToString(), ID))) > 0;
            }
        }

        /// <summary>
        /// 根据栏目ID判断此栏目是否存在文章
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>true存在,false不存在</returns>
        public bool ExistAtricleToClass(int CID)
        {
            string strSql = "SELECT count(1) FROM " + tablePrefix + "Arc_Article WHERE ClassID=@ClassID";
            SqlParameter[] cmdParms ={
                                          AddInParameter("@ID", SqlDbType.Int, 4, CID)
                                     };

            return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, strSql, cmdParms)) > 0;
        }

        /// <summary>
        /// 判断文章是否已经存在
        /// </summary>
        /// <param name="Title"></param>
        /// <returns>添加ArticleID：-1</returns>
        public bool ExistsArticleName(int ArticleID, string Title)
        {
            string strSql = "select count(ID) from DT_Arc_Article where Title=@Title and ID<>@ID";
            SqlParameter[] cmdParms ={
                                          AddInParameter("@Title",SqlDbType.NVarChar,100,Title),
                                          AddInParameter("@ID", SqlDbType.Int, 4, ArticleID)
                                     };

            return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, strSql, cmdParms)) > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        /// <param name="ID">编号ID</param>
        /// <returns>实体对象</returns>
        public Arc_Article GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,AContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID FROM " + tablePrefix + "Arc_Article");
            strSql.Append(" WHERE ID=@ID");
            SqlParameter[] cmdParms = {
				AddInParameter("@ID", SqlDbType.Int, 4, ID)};

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
        /// 获取泛型数据列表
        /// </summary>
        /// <param name="count">返回记录总数</param>
        /// <returns>对象泛型集合</returns>
        public List<Arc_Article> GetList(out long count)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,AContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID FROM " + tablePrefix + "Arc_Article");
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<Arc_Article> lst = GetList(dr, out count);
                return lst;
            }
        }

        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="count">返回记录数</param>
        /// <returns>分页对象泛型集合</returns>
        public List<Arc_Article> GetPageList(int pageSize, int pageIndex, out long count)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID,ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,AContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID FROM " + tablePrefix + "Arc_Article");
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<Arc_Article> lst = GetPageList(dr, pageSize, pageIndex, out count);
                return lst;
            }
        }

        #region 私有方法，通常情况下无需修改
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <returns>实体对象</returns>
        private Arc_Article GetModel(SqlDataReader dr)
        {
            Arc_Article model = new Arc_Article();
            model.ID = dbHelper.GetInt(dr["ID"]);
            model.ClassID = dbHelper.GetInt(dr["ClassID"]);
            model.ViceClassID = dbHelper.GetInt(dr["ViceClassID"]);
            model.Title = dbHelper.GetString(dr["Title"]);
            model.ShortTitle = dbHelper.GetString(dr["ShortTitle"]);
            model.TitleStyle = dbHelper.GetString(dr["TitleStyle"]);
            model.TitleFlag = dbHelper.GetByte(dr["TitleFlag"]);
            model.Tags = dbHelper.GetString(dr["Tags"]);
            model.ImgUrl = dbHelper.GetString(dr["ImgUrl"]);
            model.Author = dbHelper.GetString(dr["Author"]);
            model.Editor = dbHelper.GetString(dr["Editor"]);
            model.PubLisher = dbHelper.GetString(dr["PubLisher"]);
            model.Source = dbHelper.GetString(dr["Source"]);
            model.Templet = dbHelper.GetString(dr["Templet"]);
            model.Keywords = dbHelper.GetString(dr["Keywords"]);
            model.Description = dbHelper.GetString(dr["Description"]);
            model.AContent = dbHelper.GetString(dr["AContent"]);
            model.Click = dbHelper.GetInt(dr["Click"]);
            model.Good = dbHelper.GetInt(dr["Good"]);
            model.Bad = dbHelper.GetInt(dr["Bad"]);
            model.Readaccess = dbHelper.GetInt16(dr["Readaccess"]);
            model.Money = dbHelper.GetInt16(dr["Money"]);
            model.Attribute = dbHelper.GetInt16(dr["Attribute"]);
            model.IsComment = dbHelper.GetByte(dr["IsComment"]);
            model.IsChecked = dbHelper.GetByte(dr["IsChecked"]);
            model.IsRecycle = dbHelper.GetByte(dr["IsRecycle"]);
            model.IsRedirect = dbHelper.GetByte(dr["IsRedirect"]);
            model.IsHtml = dbHelper.GetByte(dr["IsHtml"]);
            model.IsPaging = dbHelper.GetByte(dr["IsPaging"]);
            model.FilePath = dbHelper.GetString(dr["FilePath"]);
            model.SimilarArticle = dbHelper.GetString(dr["SimilarArticle"]);
            model.AddDate = dbHelper.GetDateTime(dr["AddDate"]);
            model.PubDate = dbHelper.GetDateTime(dr["PubDate"]);
            model.OrderID = dbHelper.GetInt(dr["OrderID"]);
            return model;
        }

        /// <summary>
        /// 由SqlDataReader得到泛型数据列表
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <param name="count">返回记录数</param>
        /// <returns>对象泛型集合</returns>
        private List<Arc_Article> GetList(SqlDataReader dr, out long count)
        {
            count = 0;
            List<Arc_Article> lst = new List<Arc_Article>();
            while (dr.Read())
            {
                count++;
                lst.Add(GetModel(dr));
            }
            return lst;
        }

        /// <summary>
        /// 由SqlDataReader得到分页泛型数据列表
        /// </summary>
        /// <param name="dr">SqlDataReader对象</param>
        /// <param name="pageSize">分页大小</param>
        /// <param name="pageIndex">当前页数</param>
        /// <param name="count">返回记录总数</param>
        /// <returns>分页对象泛型集合</returns>
        private List<Arc_Article> GetPageList(SqlDataReader dr, int pageSize, int pageIndex, out long count)
        {
            long first = GetFirstIndex(pageSize, pageIndex);
            long last = GetLastIndex(pageSize, pageIndex);

            count = 0;

            List<Arc_Article> lst = new List<Arc_Article>();
            while (dr.Read())
            {
                count++;
                if (count >= first && count <= last)
                    lst.Add(GetModel(dr));
            }
            return lst;
        }
        #endregion
    }
}
