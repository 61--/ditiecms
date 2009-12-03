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
    public class Arc_ArticleDAL:IDAL_Arc_Article
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
            string strSql = "select count(CID) from DT_Arc_Class where CID<>{0} ";
            if (filedName != "")
            {
                strSql += " and {1}='{2}'";
                return SqlHelper.ExecuteNonQuery(string.Format(strSql, CID, filedName, filedValue)) > 0;
            }
            else
            {
                return SqlHelper.ExecuteNonQuery(string.Format(strSql, CID)) > 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Add(Arc_Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DT_Arc_Article(");
            strSql.Append("ClassID,ViceClassID,Title,ShortTitle,TitleStyle,TitleFlag,Tags,ImgUrl,Author,Editor,PubLisher,Source,Templet,Keywords,Description,Content,Click,Good,Bad,Readaccess,Money,Attribute,IsComment,IsChecked,IsRecycle,IsRedirect,IsHtml,IsPaging,FilePath,SimilarArticle,AddDate,PubDate,OrderID)");
            strSql.Append(" values (");
            strSql.Append("@ClassID,@ViceClassID,@Title,@ShortTitle,@TitleStyle,@TitleFlag,@Tags,@ImgUrl,@Author,@Editor,@PubLisher,@Source,@Templet,@Keywords,@Description,@Content,@Click,@Good,@Bad,@Readaccess,@Money,@Attribute,@IsComment,@IsChecked,@IsRecycle,@IsRedirect,@IsHtml,@IsPaging,@FilePath,@SimilarArticle,@AddDate,@PubDate,@OrderID)");
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
					new SqlParameter("@IsRecycle", SqlDbType.TinyInt,1),
					new SqlParameter("@IsRedirect", SqlDbType.TinyInt,1),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@IsPaging", SqlDbType.TinyInt,1),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@SimilarArticle", SqlDbType.NChar,10),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@PubDate", SqlDbType.DateTime),
					new SqlParameter("@OrderID", SqlDbType.TinyInt,1)};
            parameters[0].Value = model.ClassID;
            parameters[1].Value = model.ViceClassID;
            parameters[2].Value = model.Title;
            parameters[3].Value = model.ShortTitle;
            parameters[4].Value = model.TitleStyle;
            parameters[5].Value = model.TitleFlag;
            parameters[6].Value = model.Tags;
            parameters[7].Value = model.ImgUrl;
            parameters[8].Value = model.Author;
            parameters[9].Value = model.Editor;
            parameters[10].Value = model.PubLisher;
            parameters[11].Value = model.Source;
            parameters[12].Value = model.Templet;
            parameters[13].Value = model.Keywords;
            parameters[14].Value = model.Description;
            parameters[15].Value = model.Content;
            parameters[16].Value = model.Click;
            parameters[17].Value = model.Good;
            parameters[18].Value = model.Bad;
            parameters[19].Value = model.Readaccess;
            parameters[20].Value = model.Money;
            parameters[21].Value = model.Attribute;
            parameters[22].Value = model.IsComment;
            parameters[23].Value = model.IsChecked;
            parameters[24].Value = model.IsRecycle;
            parameters[25].Value = model.IsRedirect;
            parameters[26].Value = model.IsHtml;
            parameters[27].Value = model.IsPaging;
            parameters[28].Value = model.FilePath;
            parameters[29].Value = model.SimilarArticle;
            parameters[30].Value = model.AddDate;
            parameters[31].Value = model.PubDate;
            parameters[32].Value = model.OrderID;

            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

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
            strSql.Append("PubLisher=@PubLisher,");
            strSql.Append("Source=@Source,");
            strSql.Append("Templet=@Templet,");
            strSql.Append("Keywords=@Keywords,");
            strSql.Append("Description=@Description,");
            strSql.Append("Content=@Content,");
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
					new SqlParameter("@IsRecycle", SqlDbType.TinyInt,1),
					new SqlParameter("@IsRedirect", SqlDbType.TinyInt,1),
					new SqlParameter("@IsHtml", SqlDbType.TinyInt,1),
					new SqlParameter("@IsPaging", SqlDbType.TinyInt,1),
					new SqlParameter("@FilePath", SqlDbType.NVarChar,200),
					new SqlParameter("@SimilarArticle", SqlDbType.NChar,10),
					new SqlParameter("@AddDate", SqlDbType.DateTime),
					new SqlParameter("@PubDate", SqlDbType.DateTime),
					new SqlParameter("@OrderID", SqlDbType.TinyInt,1)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.ClassID;
            parameters[2].Value = model.ViceClassID;
            parameters[3].Value = model.Title;
            parameters[4].Value = model.ShortTitle;
            parameters[5].Value = model.TitleStyle;
            parameters[6].Value = model.TitleFlag;
            parameters[7].Value = model.Tags;
            parameters[8].Value = model.ImgUrl;
            parameters[9].Value = model.Author;
            parameters[10].Value = model.Editor;
            parameters[11].Value = model.PubLisher;
            parameters[12].Value = model.Source;
            parameters[13].Value = model.Templet;
            parameters[14].Value = model.Keywords;
            parameters[15].Value = model.Description;
            parameters[16].Value = model.Content;
            parameters[17].Value = model.Click;
            parameters[18].Value = model.Good;
            parameters[19].Value = model.Bad;
            parameters[20].Value = model.Readaccess;
            parameters[21].Value = model.Money;
            parameters[22].Value = model.Attribute;
            parameters[23].Value = model.IsComment;
            parameters[24].Value = model.IsChecked;
            parameters[25].Value = model.IsRecycle;
            parameters[26].Value = model.IsRedirect;
            parameters[27].Value = model.IsHtml;
            parameters[28].Value = model.IsPaging;
            parameters[29].Value = model.FilePath;
            parameters[30].Value = model.SimilarArticle;
            parameters[31].Value = model.AddDate;
            parameters[32].Value = model.PubDate;
            parameters[33].Value = model.OrderID;
            return SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 批量删除文章
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete(string ID)
        {
            int n= 0;
            string[] arrId = ID.Split(',');
            string sql = "DELETE DT_Arc_Class WHERE CID={0}";
            SqlConnection con = new SqlConnection(SqlHelper.ConnString);
            SqlTransaction tran = con.BeginTransaction();
            try
            {
                
                foreach (string cid in arrId)
                {
                    SqlParameter[] parameters = {new SqlParameter("@CID", SqlDbType.Int,4)};
                    parameters[0].Value = CID;
                    n=n+SqlHelper.ExecuteNonQueryTran(string.Format(sql, cid),parameters,tran);
                }
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
            }
            finally
            {
                tran.Dispose();
                con.Close();
            }
            return n;
        }

        public Arc_Article GetModel(int ID)
        {
            Arc_Article model =new Arc_Article ();
            return model; //throw new NotImplementedException();
        }

        #endregion
    }
}
