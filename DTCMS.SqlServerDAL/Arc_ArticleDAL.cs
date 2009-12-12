using System;
using System.Collections.Generic;
using System.Text;
using DTCMS.IDAL;
using DTCMS.DBUtility;
using DTCMS.Entity;
using System.Data.SqlClient;
using System.Data;
namespace DTCMS.SqlServerDAL
{

    public class Arc_ArticleDAL :BaseDAL,IDAL_Arc_Article
    {
        #region IDAL_Arc_Article 成员

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
            if (filedName != "")
            {
                strSql += "select count(CID) from DT_Arc_Class where CID<>{0} ";
                strSql += " and {1}='{2}'";
                return Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text,string.Format(strSql, CID, filedName, filedValue))) > 0;
            }
            else
            {
                strSql += "select count(CID) from DT_Arc_Class where CID={0} ";
                return Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text,string.Format(strSql, CID))) > 0;
            }
        }

        /// <summary>
        /// 添加文章
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(Arc_Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DT_Arc_Article(");
            strSql.Append("ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,Content,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID)");
            strSql.Append(" values (");
            strSql.Append("@ClassID,@ViceClassID,@Title,@ShortTitle,@TitleStyle,@TitleFlag,@Tags,@ImgUrl,@Author,@Editor,@PubLisher,@Source,@Templet,@Keywords,@Description,@Content,@Click,@Good,@Bad,@Readaccess,@Money,@Attribute,@IsComment,@IsChecked,@IsRedirect,@IsHtml,@IsPaging,@FilePath,@SimilarArticle,@AddDate,@PubDate,@OrderID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ClassID", SqlDbType.Int,4),
					new SqlParameter("@ViceClassID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@ShortTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@TitleStyle", SqlDbType.NVarChar,100),
					new SqlParameter("@TitleFlag", SqlDbType.Int,4),
					new SqlParameter("@Tags", SqlDbType.NVarChar,100),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Author", SqlDbType.NVarChar,50),
					new SqlParameter("@Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@PubLisher", SqlDbType.NVarChar,50),
					new SqlParameter("@Source", SqlDbType.NVarChar,100),
					new SqlParameter("@Templet", SqlDbType.NVarChar,200),
					new SqlParameter("@Keywords", SqlDbType.NVarChar,200),
					new SqlParameter("@Description", SqlDbType.NVarChar,255),
					new SqlParameter("@Content", SqlDbType.NText),
                    new SqlParameter("@Click", SqlDbType.Int,4),
                    new SqlParameter("@Good", SqlDbType.Int,4),
                    new SqlParameter("@Bad", SqlDbType.Int,4),
					new SqlParameter("@Readaccess", SqlDbType.SmallInt,2),
					new SqlParameter("@Money", SqlDbType.SmallInt,2),
					new SqlParameter("@Attribute", SqlDbType.Char,1),
					new SqlParameter("@IsComment", SqlDbType.TinyInt,1),
					new SqlParameter("@IsChecked", SqlDbType.TinyInt,1),
                    new SqlParameter("@IsRecycle",SqlDbType.TinyInt,1),
					new SqlParameter("@IsRedirect", SqlDbType.Int,4),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@IsPaging", SqlDbType.TinyInt,1),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@SimilarArticle", SqlDbType.NChar,10),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@PubDate", SqlDbType.DateTime),
					new SqlParameter("@OrderID", SqlDbType.TinyInt,1)};

            int n = 0;
            parameters[n++].Value = model.ClassID;
            parameters[n++].Value = model.ViceClassID;
            parameters[n++].Value = model.Title;
            parameters[n++].Value = model.ShortTitle;
            parameters[n++].Value = model.TitleStyle;
            parameters[n++].Value = model.TitleFlag;
            parameters[n++].Value = model.Tags;
            parameters[n++].Value = model.ImgUrl;
            parameters[n++].Value = model.Author;
            parameters[n++].Value = model.Editor;
            parameters[n++].Value = model.PubLisher;
            parameters[n++].Value = model.Source;
            parameters[n++].Value = model.Templet;
            parameters[n++].Value = model.Keywords;
            parameters[n++].Value = model.Description;
            parameters[n++].Value = model.Content;
            parameters[n++].Value = model.Click;
            parameters[n++].Value = model.Good;
            parameters[n++].Value = model.Bad;
            parameters[n++].Value = model.Readaccess;
            parameters[n++].Value = model.Money;
            parameters[n++].Value = model.Attribute;
            parameters[n++].Value = model.IsComment;
            parameters[n++].Value = model.IsChecked;
            parameters[n++].Value = model.IsRecycle;
            parameters[n++].Value = model.IsRedirect;
            parameters[n++].Value = model.IsHtml;
            parameters[n++].Value = model.IsPaging;
            parameters[n++].Value = model.FilePath;
            parameters[n++].Value = model.SimilarArticle;
            parameters[n++].Value = model.AddDate;
            parameters[n++].Value = model.PubDate;
            parameters[n].Value = model.OrderID;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }
        
        /// <summary>
        /// 更新文章
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Update(Arc_Article model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DT_Arc_Article set ");
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
            strSql.Append("Source=@Source,");
            strSql.Append("Templet=@Templet,");
            strSql.Append("Keywords=@Keywords,");
            strSql.Append("Description=@Description,");
            strSql.Append("Content=@Content,");
            strSql.Append("Readaccess=@Readaccess,");
            strSql.Append("Money=@Money,");
            strSql.Append("Attribute=@Attribute,");
            strSql.Append("IsComment=@IsComment,");
            strSql.Append("IsChecked=@IsChecked,");
            strSql.Append("IsRedirect=@IsRedirect,");
            strSql.Append("IsHtml=@IsHtml,");
            strSql.Append("IsPaging=@IsPaging,");
            strSql.Append("FilePath=@FilePath,");
            strSql.Append("SimilarArticle=@SimilarArticle,");
            strSql.Append("PubDate=@PubDate,");
            strSql.Append("OrderID=@OrderID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ClassID", SqlDbType.Int,4),
					new SqlParameter("@ViceClassID", SqlDbType.Int,4),
					new SqlParameter("@Title", SqlDbType.NVarChar,100),
					new SqlParameter("@ShortTitle", SqlDbType.NVarChar,100),
					new SqlParameter("@TitleStyle", SqlDbType.NVarChar,100),
					new SqlParameter("@TitleFlag", SqlDbType.Int,4),
					new SqlParameter("@Tags", SqlDbType.NVarChar,100),
					new SqlParameter("@ImgUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@Author", SqlDbType.NVarChar,50),
					new SqlParameter("@Editor", SqlDbType.NVarChar,50),
					new SqlParameter("@Source", SqlDbType.NVarChar,100),
					new SqlParameter("@Templet", SqlDbType.NVarChar,200),
					new SqlParameter("@Keywords", SqlDbType.NVarChar,200),
					new SqlParameter("@Description", SqlDbType.NVarChar,255),
					new SqlParameter("@Content", SqlDbType.NText),
					new SqlParameter("@Readaccess", SqlDbType.SmallInt,2),
					new SqlParameter("@Money", SqlDbType.SmallInt,2),
					new SqlParameter("@Attribute", SqlDbType.Char,1),
					new SqlParameter("@IsComment", SqlDbType.TinyInt,1),
					new SqlParameter("@IsChecked", SqlDbType.TinyInt,1),
					new SqlParameter("@IsRedirect", SqlDbType.TinyInt,1),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@IsPaging", SqlDbType.TinyInt,1),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@SimilarArticle", SqlDbType.NChar,10),
					new SqlParameter("@PubDate", SqlDbType.DateTime),
					new SqlParameter("@OrderID", SqlDbType.TinyInt,1)};

            int n = 0;
            parameters[n++].Value = model.ID;
            parameters[n++].Value = model.ClassID;
            parameters[n++].Value = model.ViceClassID;
            parameters[n++].Value = model.Title;
            parameters[n++].Value = model.ShortTitle;
            parameters[n++].Value = model.TitleStyle;
            parameters[n++].Value = model.TitleFlag;
            parameters[n++].Value = model.Tags;
            parameters[n++].Value = model.ImgUrl;
            parameters[n++].Value = model.Author;
            parameters[n++].Value = model.Editor;
            parameters[n++].Value = model.Source;
            parameters[n++].Value = model.Templet;
            parameters[n++].Value = model.Keywords;
            parameters[n++].Value = model.Description;
            parameters[n++].Value = model.Content;
            parameters[n++].Value = model.Readaccess;
            parameters[n++].Value = model.Money;
            parameters[n++].Value = model.Attribute;
            parameters[n++].Value = model.IsComment;
            parameters[n++].Value = model.IsChecked;
            parameters[n++].Value = model.IsRedirect;
            parameters[n++].Value = model.IsHtml;
            parameters[n++].Value = model.IsPaging;
            parameters[n++].Value = model.FilePath;
            parameters[n++].Value = model.SimilarArticle;
            parameters[n++].Value = model.PubDate;
            parameters[n].Value = model.OrderID;

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete(string ID)
        {            
            string strSql =string.Format( " delete DT_Arc_Article where ID in({0}) ", ID);
            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString());
        }
        /// <summary>
        /// 得到文章实体
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Arc_Article GetModel(int ID)
        {
           
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,Content,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID from DT_Arc_Article ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = SqlHelper.FillDataset(CommandType.Text,strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Arc_Article model = new Arc_Article();
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ClassID"].ToString() != "")
                {
                    model.ClassID = int.Parse(ds.Tables[0].Rows[0]["ClassID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ViceClassID"].ToString() != "")
                {
                    model.ViceClassID = int.Parse(ds.Tables[0].Rows[0]["ViceClassID"].ToString());
                }
                model.Title = ds.Tables[0].Rows[0]["Title"].ToString();
                model.ShortTitle = ds.Tables[0].Rows[0]["ShortTitle"].ToString();
                model.TitleStyle = ds.Tables[0].Rows[0]["TitleStyle"].ToString();
                if (ds.Tables[0].Rows[0]["TitleFlag"].ToString() != "")
                {
                    model.TitleFlag = int.Parse(ds.Tables[0].Rows[0]["TitleFlag"].ToString());
                }
                model.Tags = ds.Tables[0].Rows[0]["Tags"].ToString();
                model.ImgUrl = ds.Tables[0].Rows[0]["ImgUrl"].ToString();
                model.Author = ds.Tables[0].Rows[0]["Author"].ToString();
                model.Editor = ds.Tables[0].Rows[0]["Editor"].ToString();
                model.PubLisher = ds.Tables[0].Rows[0]["PubLisher"].ToString();
                model.Source = ds.Tables[0].Rows[0]["Source"].ToString();
                model.Templet = ds.Tables[0].Rows[0]["Templet"].ToString();
                model.Keywords = ds.Tables[0].Rows[0]["Keywords"].ToString();
                model.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                model.Content = ds.Tables[0].Rows[0]["Content"].ToString();
                if (ds.Tables[0].Rows[0]["Click"].ToString() != "")
                {
                    model.Click = int.Parse(ds.Tables[0].Rows[0]["Click"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Good"].ToString() != "")
                {
                    model.Good = int.Parse(ds.Tables[0].Rows[0]["Good"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Bad"].ToString() != "")
                {
                    model.Bad = int.Parse(ds.Tables[0].Rows[0]["Bad"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Readaccess"].ToString() != "")
                {
                    model.Readaccess = int.Parse(ds.Tables[0].Rows[0]["Readaccess"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = int.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                model.Attribute = ds.Tables[0].Rows[0]["Attribute"].ToString();
                if (ds.Tables[0].Rows[0]["IsComment"].ToString() != "")
                {
                    model.IsComment = int.Parse(ds.Tables[0].Rows[0]["IsComment"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsChecked"].ToString() != "")
                {
                    model.IsChecked = int.Parse(ds.Tables[0].Rows[0]["IsChecked"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsRecycle"].ToString() != "")
                {
                    model.IsRecycle = int.Parse(ds.Tables[0].Rows[0]["IsRecycle"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsRedirect"].ToString() != "")
                {
                    model.IsRedirect = int.Parse(ds.Tables[0].Rows[0]["IsRedirect"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsHtml"].ToString() != "")
                {
                    model.IsHtml = int.Parse(ds.Tables[0].Rows[0]["IsHtml"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsPaging"].ToString() != "")
                {
                    model.IsPaging = int.Parse(ds.Tables[0].Rows[0]["IsPaging"].ToString());
                }
                model.FilePath = ds.Tables[0].Rows[0]["FilePath"].ToString();
                model.SimilarArticle = ds.Tables[0].Rows[0]["SimilarArticle"].ToString();
                if (ds.Tables[0].Rows[0]["AddDate"].ToString() != "")
                {
                    model.AddDate = DateTime.Parse(ds.Tables[0].Rows[0]["AddDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PubDate"].ToString() != "")
                {
                    model.PubDate = DateTime.Parse(ds.Tables[0].Rows[0]["PubDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderID"].ToString() != "")
                {
                    model.OrderID = int.Parse(ds.Tables[0].Rows[0]["OrderID"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
           
        }

        /// <summary>
        /// 根据栏目id 判断此栏目是否存在文章
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>true存在,false不存在</returns>
        public bool ExistAtricleToClass(int CID)
        {
            string strSql = "select count(ID) from DT_Arc_Article where ClassID=@ClassID";
            SqlParameter[] parameter ={
                                          new SqlParameter("@ClassID",SqlDbType.Int,4)
                                     };
            parameter[0].Value = CID;
            return Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text, strSql, parameter))>0;
        }

        /// <summary>
        /// 判断文章是否已经存在
        /// </summary>
        /// <param name="Title"></param>
        /// <returns>添加ArticleID：-1</returns>
        public bool ExistsArticleName(int ArticleID, string Title)
        {
            string strSql = "select count(ID) from DT_Arc_Article where Title=@Title and ID<>@ID";
            SqlParameter[] parameter ={
                                          new SqlParameter("@Title",SqlDbType.NVarChar,100),
                                          new SqlParameter("@ID",SqlDbType.Int,4)
                                     };
            parameter[0].Value = Title;
            parameter[1].Value = ArticleID;
            return Convert.ToInt32(SqlHelper.ExecuteScalar(CommandType.Text, strSql, parameter))>0;
        }
        #endregion
    }
}
