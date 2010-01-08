//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-1-8 11:52:52
// 功能描述: 
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
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
		public int Add(Arc_Article model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("INSERT INTO Arc_Article(");
            strSql.Append("ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,ArticleContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID)");
			strSql.Append(" VALUES (");
            strSql.Append("@ClassID,@ViceClassID,@Title,@ShortTitle,@TitleStyle,@TitleFlag,@Tags,@ImgUrl,@Author,@Editor,@PubLisher,@Source,@Templet,@Keywords,@Description,@ArticleContent,@Click,@Good,@Bad,@Readaccess,@Money,@Attribute,@IsComment,@IsChecked,@IsRecycle,@IsRedirect,@IsHtml,@IsPaging,@FilePath,@SimilarArticle,@AddDate,@PubDate,@OrderID)");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ClassID", DbType.Int32, model.ClassID),
				dbHelper.CreateInDbParameter("@ViceClassID", DbType.Int32, model.ViceClassID),
				dbHelper.CreateInDbParameter("@Title", DbType.String, model.Title),
				dbHelper.CreateInDbParameter("@ShortTitle", DbType.String, model.ShortTitle),
				dbHelper.CreateInDbParameter("@TitleStyle", DbType.AnsiString, model.TitleStyle),
				dbHelper.CreateInDbParameter("@TitleFlag", DbType.Byte, model.TitleFlag),
				dbHelper.CreateInDbParameter("@Tags", DbType.String, model.Tags),
				dbHelper.CreateInDbParameter("@ImgUrl", DbType.AnsiString, model.ImgUrl),
				dbHelper.CreateInDbParameter("@Author", DbType.String, model.Author),
				dbHelper.CreateInDbParameter("@Editor", DbType.String, model.Editor),
				dbHelper.CreateInDbParameter("@PubLisher", DbType.String, model.PubLisher),
				dbHelper.CreateInDbParameter("@Source", DbType.String, model.Source),
				dbHelper.CreateInDbParameter("@Templet", DbType.AnsiString, model.Templet),
				dbHelper.CreateInDbParameter("@Keywords", DbType.String, model.Keywords),
				dbHelper.CreateInDbParameter("@Description", DbType.String, model.Description),
				dbHelper.CreateInDbParameter("@ArticleContent", DbType.String, model.ArticleContent),
				dbHelper.CreateInDbParameter("@Click", DbType.Int32, model.Click),
				dbHelper.CreateInDbParameter("@Good", DbType.Int32, model.Good),
				dbHelper.CreateInDbParameter("@Bad", DbType.Int32, model.Bad),
				dbHelper.CreateInDbParameter("@Readaccess", DbType.Int16, model.Readaccess),
				dbHelper.CreateInDbParameter("@Money", DbType.Int16, model.Money),
				dbHelper.CreateInDbParameter("@Attribute", DbType.Int16, model.Attribute),
				dbHelper.CreateInDbParameter("@IsComment", DbType.Byte, model.IsComment),
				dbHelper.CreateInDbParameter("@IsChecked", DbType.Byte, model.IsChecked),
				dbHelper.CreateInDbParameter("@IsRecycle", DbType.Byte, model.IsRecycle),
				dbHelper.CreateInDbParameter("@IsRedirect", DbType.Byte, model.IsRedirect),
				dbHelper.CreateInDbParameter("@IsHtml", DbType.Byte, model.IsHtml),
				dbHelper.CreateInDbParameter("@IsPaging", DbType.Byte, model.IsPaging),
				dbHelper.CreateInDbParameter("@FilePath", DbType.AnsiString, model.FilePath),
				dbHelper.CreateInDbParameter("@SimilarArticle", DbType.AnsiString, model.SimilarArticle),
				dbHelper.CreateInDbParameter("@AddDate", DbType.String, model.AddDate),
				dbHelper.CreateInDbParameter("@PubDate", DbType.String, model.PubDate),
				dbHelper.CreateInDbParameter("@OrderID", DbType.Int32, model.OrderID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Arc_Article model)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("UPDATE Arc_Article SET ");
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
			strSql.Append("ArticleContent=@ArticleContent,");
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
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ClassID", DbType.Int32, model.ClassID),
				dbHelper.CreateInDbParameter("@ViceClassID", DbType.Int32, model.ViceClassID),
				dbHelper.CreateInDbParameter("@Title", DbType.String, model.Title),
				dbHelper.CreateInDbParameter("@ShortTitle", DbType.String, model.ShortTitle),
				dbHelper.CreateInDbParameter("@TitleStyle", DbType.AnsiString, model.TitleStyle),
				dbHelper.CreateInDbParameter("@TitleFlag", DbType.Byte, model.TitleFlag),
				dbHelper.CreateInDbParameter("@Tags", DbType.String, model.Tags),
				dbHelper.CreateInDbParameter("@ImgUrl", DbType.AnsiString, model.ImgUrl),
				dbHelper.CreateInDbParameter("@Author", DbType.String, model.Author),
				dbHelper.CreateInDbParameter("@Editor", DbType.String, model.Editor),
				dbHelper.CreateInDbParameter("@PubLisher", DbType.String, model.PubLisher),
				dbHelper.CreateInDbParameter("@Source", DbType.String, model.Source),
				dbHelper.CreateInDbParameter("@Templet", DbType.AnsiString, model.Templet),
				dbHelper.CreateInDbParameter("@Keywords", DbType.String, model.Keywords),
				dbHelper.CreateInDbParameter("@Description", DbType.String, model.Description),
				dbHelper.CreateInDbParameter("@ArticleContent", DbType.String, model.ArticleContent),
				dbHelper.CreateInDbParameter("@Click", DbType.Int32, model.Click),
				dbHelper.CreateInDbParameter("@Good", DbType.Int32, model.Good),
				dbHelper.CreateInDbParameter("@Bad", DbType.Int32, model.Bad),
				dbHelper.CreateInDbParameter("@Readaccess", DbType.Int16, model.Readaccess),
				dbHelper.CreateInDbParameter("@Money", DbType.Int16, model.Money),
				dbHelper.CreateInDbParameter("@Attribute", DbType.Int16, model.Attribute),
				dbHelper.CreateInDbParameter("@IsComment", DbType.Byte, model.IsComment),
				dbHelper.CreateInDbParameter("@IsChecked", DbType.Byte, model.IsChecked),
				dbHelper.CreateInDbParameter("@IsRecycle", DbType.Byte, model.IsRecycle),
				dbHelper.CreateInDbParameter("@IsRedirect", DbType.Byte, model.IsRedirect),
				dbHelper.CreateInDbParameter("@IsHtml", DbType.Byte, model.IsHtml),
				dbHelper.CreateInDbParameter("@IsPaging", DbType.Byte, model.IsPaging),
				dbHelper.CreateInDbParameter("@FilePath", DbType.AnsiString, model.FilePath),
				dbHelper.CreateInDbParameter("@SimilarArticle", DbType.AnsiString, model.SimilarArticle),
				dbHelper.CreateInDbParameter("@AddDate", DbType.String, model.AddDate),
				dbHelper.CreateInDbParameter("@PubDate", DbType.String, model.PubDate),
				dbHelper.CreateInDbParameter("@OrderID", DbType.Int32, model.OrderID),
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, model.ID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("DELETE FROM Arc_Article ");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT COUNT(1) FROM Arc_Article");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
			return dbHelper.GetInt(obj) > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Arc_Article GetModel(int ID)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,ArticleContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID FROM Arc_Article");
			strSql.Append(" WHERE ID=@ID");
			DbParameter[] cmdParms = {
				dbHelper.CreateInDbParameter("@ID", DbType.Int32, ID)};

			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
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
		public List<Arc_Article> GetList(out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,ArticleContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID FROM Arc_Article");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Article> lst = GetList(dr, out count);
				return lst;
			}
		}

		/// <summary>
		/// 分页获取泛型数据列表
		/// </summary>
		public List<Arc_Article> GetPageList(int pageSize, int pageIndex, out long count)
		{
			StringBuilder strSql = new StringBuilder();
			strSql.Append("SELECT ID,ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,ArticleContent,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID FROM Arc_Article");
			using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
			{
				List<Arc_Article> lst = GetPageList(dr, pageSize, pageIndex, out count);
				return lst;
			}
		}

		#region -------- 私有方法，通常情况下无需修改 --------
		/// <summary>
		/// 由一行数据得到一个实体
		/// </summary>
		private Arc_Article GetModel(DbDataReader dr)
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
			model.ArticleContent = dbHelper.GetString(dr["ArticleContent"]);
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
		/// 由DbDataReader得到泛型数据列表
		/// </summary>
		private List<Arc_Article> GetList(DbDataReader dr, out long count)
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
		/// 由DbDataReader得到分页泛型数据列表
		/// </summary>
		private List<Arc_Article> GetPageList(DbDataReader dr, int pageSize, int pageIndex, out long count)
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
