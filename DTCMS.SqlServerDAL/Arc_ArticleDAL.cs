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

    public class Arc_ArticleDAL : IDAL_Arc_Article
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
        /// 添加文章
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
            int n = 0;
            string strSql =string.Format( " delete DT_Arc_ArticleDAL where ID in({0}) ", ID);
            return SqlHelper.ExecuteNonQuery(strSql.ToString());
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

            DataSet ds = SqlHelper.ExecuteDataSet(strSql.ToString(), parameters);
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
        /// 文章列表分页
        /// </summary>
        /// <param name="pageSize">每页显示几条</param>
        /// <param name="currentPage">当前页</param>
        /// <param name="search">查询条件</param>
        /// <returns></returns>
        public DataTable GetDataTable(int pageSize,int currentPage,string search)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(string.Format("SELECT Top {0} A.ID,A.ClassID,A.Title,A.PubLisher,A.AddDate,C.ClassName ",pageSize));
            strSql.Append(" FROM  DT_Arc_Article AS A,DT_Arc_Class AS C ");
            strSql.Append("WHERE A.ClassID=C.CID AND A.ID >=( ");
            strSql.Append("SELECT MAX([ID]) FROM (");
            strSql.Append(string.Format(" SELECT TOP {0} A.ID FROM DT_Arc_Article AS A,DT_Arc_Class AS C ", pageSize * (currentPage - 1) + 1));
            strSql.Append(" WHERE A.ClassID=C.CID  ");
            if(!string.IsNullOrEmpty(search))
            {
                strSql.Append(string.Format(" AND {0} ",search));
            }
            strSql.Append("ORDER BY A.ID DESC ) AS T)");
            if(!string.IsNullOrEmpty(search))
            {
                strSql.Append(string.Format(" AND {0} ",search));
            }
            strSql.Append("ORDER BY A.ID DESC ");

            return SqlHelper.ExecuteDataSet(strSql.ToString()).Tables[0];
          
        }
        #endregion
    }
}
