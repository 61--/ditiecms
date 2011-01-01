//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-04-16 20:54:55
// 功能描述: 
// 修改标识:
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections.Generic;
using DTCMS.Entity.TemplateEngine;
using DTCMS.IDAL.TemplateEngine;

namespace DTCMS.SqlServerDAL.TemplateEngine
{
    /// <summary>
    /// 数据访问类 ArcListDAL
    /// </summary>
    public class ArcListDAL : BaseDAL, IDAL_ArcList
    {
        /// <summary>
        /// 获取文档泛型数据列表
        /// </summary>
        public List<Archive_List> GetArcList(int firstRecort, int lastRecort, string channelType, string strWhere, string strOrder)
        {
            string strSql = "SELECT ID,ClassID,C.ClassName,C.ClassPath,Title,ShortTitle,TitleStyle,TitleFlag,A.ImgUrl,Author,Click,Good,Bad,FilePath,A.PubDate FROM {0}{1} A LEFT JOIN {0}Arc_Class C ON A.ClassID=C.CID WHERE IsHidden=0";
            if (strWhere.Length != 0)
            {
                strSql += strWhere;
            }
            if (strOrder.Length != 0)
            {
                strSql += strOrder;
            }
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix, channelType), null))
            {
                List<Archive_List> lst = new List<Archive_List>();

                int count = 0;

                while (dr.Read())
                {
                    count++;
                    if (count >= firstRecort && count <= lastRecort)
                    {
                        Archive_List model = new Archive_List();
                        model.ID = dbHelper.GetInt(dr["ID"]);
                        model.ClassID = dbHelper.GetInt(dr["ClassID"]);
                        model.ClassName = dbHelper.GetString(dr["ClassName"]);
                        model.ClassUrl = dbHelper.GetString(dr["ClassPath"]);
                        model.Title = dbHelper.GetString(dr["Title"]);
                        model.ShortTitle = dbHelper.GetString(dr["ShortTitle"]);
                        model.TitleStyle = dbHelper.GetString(dr["TitleStyle"]);
                        model.TitleFlag = dbHelper.GetByte(dr["TitleFlag"]);
                        model.ImgUrl = dbHelper.GetString(dr["ImgUrl"]);
                        model.Author = dbHelper.GetString(dr["Author"]);
                        model.Click = dbHelper.GetInt(dr["Click"]);
                        model.Good = dbHelper.GetInt(dr["Good"]);
                        model.Bad = dbHelper.GetInt(dr["Bad"]);
                        model.Url = dbHelper.GetString(dr["FilePath"]);
                        model.PubDate = dbHelper.GetDateTime(dr["PubDate"]);

                        lst.Add(model);
                    }
                }
                return lst;
            }
        }

        /// <summary>
        /// 获取文章分页泛型数据列表
        /// </summary>
        public List<Archive> GetPageList(int channelID, string channelType, int pageSize, int pageIndex)
        {
            string strSql = "SELECT ID,ClassID,C.ClassName,C.ClassPath,Title,ShortTitle,TitleStyle,TitleFlag,A.ImgUrl,Author,Editor,Source,Click,Good,Bad,FilePath,A.PubDate FROM {0}{1} A LEFT JOIN {0}Arc_Class C ON A.ClassID=C.CID AND A.ClassID=" + channelID + " WHERE IsHidden=0 ORDER BY PubDate DESC";

            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix, channelType), null))
            {
                List<Archive> lst = new List<Archive>();

                int firstRecort = GetFirstIndex(pageSize, pageIndex);
                int lastRecort = GetLastIndex(pageSize, pageIndex);
                int count = 0;
                while (dr.Read())
                {
                    count++;
                    if (count >= firstRecort && count <= lastRecort)
                    {
                        Article_List model = new Article_List();
                        model.ID = dbHelper.GetInt(dr["ID"]);
                        model.ClassID = dbHelper.GetInt(dr["ClassID"]);
                        model.ClassName = dbHelper.GetString(dr["ClassName"]);
                        model.ClassUrl = dbHelper.GetString(dr["ClassPath"]);
                        model.Title = dbHelper.GetString(dr["Title"]);
                        model.ShortTitle = dbHelper.GetString(dr["ShortTitle"]);
                        model.TitleStyle = dbHelper.GetString(dr["TitleStyle"]);
                        model.TitleFlag = dbHelper.GetByte(dr["TitleFlag"]);
                        model.ImgUrl = dbHelper.GetString(dr["ImgUrl"]);
                        model.Author = dbHelper.GetString(dr["Author"]);
                        model.Editor = dbHelper.GetString(dr["Editor"]);
                        model.Source = dbHelper.GetString(dr["Source"]);
                        model.Click = dbHelper.GetInt(dr["Click"]);
                        model.Good = dbHelper.GetInt(dr["Good"]);
                        model.Bad = dbHelper.GetInt(dr["Bad"]);
                        model.Url = dbHelper.GetString(dr["FilePath"]);
                        model.PubDate = dbHelper.GetDateTime(dr["PubDate"]);

                        lst.Add(model);
                    }
                }
                return lst;
            }
        }

        /// <summary>
        /// 获取指定ID文章实体
        /// </summary>
        /// <param name="ID">文档ID</param>
        public List<Archive> GetArticleInfo(int ID)
        {
            string strSql = "SELECT ID,ClassID,C.ClassName,TitleFlag,Title,ShortTitle,TitleStyle,A.ImgUrl,Author,A.Description,Click,Good,Bad,PubDate,Tags,Editor,Source,Templet,A.Keywords,Acontent,A.Readaccess,Money,A.IsComment,IsPaging,FilePath,SimilarArticle FROM {0}Arc_Article A LEFT JOIN {0}Arc_Class C ON classID=C.CID WHERE A.ID={1} AND IsHidden=0 ORDER BY PubDate DESC";
            List<Archive> lst = new List<Archive>();
            int _classID = 0;

            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix, ID), null))
            {
                if (dr.Read())
                {
                    Article_Info model = new Article_Info();
                    model.ID = dbHelper.GetInt(dr["ID"]);
                    model.ClassID = _classID = dbHelper.GetInt(dr["ClassID"]);
                    model.ClassName = dbHelper.GetString(dr["ClassName"]);
                    //model.ClassUrl = dbHelper.GetString(dr["ClassPath"]);
                    model.Title = dbHelper.GetString(dr["Title"]);
                    model.ShortTitle = dbHelper.GetString(dr["ShortTitle"]);
                    model.TitleStyle = dbHelper.GetString(dr["TitleStyle"]);
                    model.TitleFlag = dbHelper.GetByte(dr["TitleFlag"]);
                    model.Tags = dbHelper.GetString(dr["Tags"]);
                    model.Keywords = dbHelper.GetString(dr["Keywords"]);
                    model.Description = dbHelper.GetString(dr["Description"]);
                    model.Content = dbHelper.GetString(dr["Acontent"]);
                    model.ImgUrl = dbHelper.GetString(dr["ImgUrl"]);
                    model.Author = dbHelper.GetString(dr["Author"]);
                    model.Editor = dbHelper.GetString(dr["Editor"]);
                    model.Source = dbHelper.GetString(dr["Source"]);
                    model.Click = dbHelper.GetInt(dr["Click"]);
                    model.Good = dbHelper.GetInt(dr["Good"]);
                    model.Bad = dbHelper.GetInt(dr["Bad"]);
                    model.Url = dbHelper.GetString(dr["FilePath"]);
                    model.Readaccess = dbHelper.GetInt16(dr["Readaccess"]);
                    model.Money = dbHelper.GetInt16(dr["Money"]);
                    model.IsComment = dbHelper.GetByte(dr["IsComment"]);
                    model.IsPaging = dbHelper.GetByte(dr["IsPaging"]);
                    model.Templet = dbHelper.GetString(dr["Templet"]);
                    model.SimilarArticle = dbHelper.GetString(dr["SimilarArticle"]);
                    model.PubDate = dbHelper.GetDateTime(dr["PubDate"]);

                    lst.Add(model);
                }
            }

            //获取上一篇、下一篇
            strSql = "SELECT TOP 1 ID,Title,FilePath FROM {0}Arc_Article WHERE ClassID={1} AND ID<{2} ORDER BY ID DESC";
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix, _classID, ID), null))
            {
                if (dr.Read())
                {
                    Article_Info model = new Article_Info();
                    model.ID = dbHelper.GetInt(dr["ID"]);
                    model.Title = dbHelper.GetString(dr["Title"]);
                    model.Url = dbHelper.GetString(dr["FilePath"]);

                    lst.Add(model);
                }
            }

            strSql = "SELECT TOP 1 ID,Title,FilePath FROM {0}Arc_Article WHERE ClassID={1} AND ID>{2} ORDER BY ID ASC";
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix, _classID, ID), null))
            {
                if (dr.Read())
                {
                    Article_Info model = new Article_Info();
                    model.ID = dbHelper.GetInt(dr["ID"]);
                    model.Title = dbHelper.GetString(dr["Title"]);
                    model.Url = dbHelper.GetString(dr["FilePath"]);

                    lst.Add(model);
                }
            }

            return lst;
        }

        /// <summary>
        /// 获取栏目泛型数据列表
        /// </summary>
        public List<Channel> GetChannelList(int row, string strWhere)
        {
            string strSql = "SELECT CID,ClassName,ClassEname,ClassDomain,ClassPath,Description,SiteID,ImgURL,Keywords FROM {0}Arc_Class";

            if (strWhere.Length != 0)
            {
                strSql += " WHERE 1=1" + strWhere;
            }

            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix), null))
            {
                List<Channel> lst = new List<Channel>();

                int count = 0;

                while (dr.Read())
                {
                    count++;
                    if (count <= row)
                    {
                        Channel model = new Channel();
                        model.ID = dbHelper.GetInt(dr["CID"]);
                        model.SiteID = dbHelper.GetByte(dr["SiteID"]);
                        model.Name = dbHelper.GetString(dr["ClassName"]);
                        model.EName = dbHelper.GetString(dr["ClassEName"]);
                        model.Domain = dbHelper.GetString(dr["ClassDomain"]);
                        model.Path = dbHelper.GetString(dr["ClassPath"]);
                        model.ImgUrl = dbHelper.GetString(dr["ImgURL"]);
                        model.Keywords = dbHelper.GetString(dr["Keywords"]);
                        model.Description = dbHelper.GetString(dr["Description"]);

                        lst.Add(model);
                    }
                }
                return lst;
            }
        }

        ///<summary>
        /// 获取指定栏目下的文档总数（不包含未审核和回收站中的文档）
        /// </summary>
        public int GetArcCount(int channelID, string channelType)
        {
            string strSql = "SELECT COUNT(*) FROM {0}{1} WHERE ClassID=@ClassID AND IsRecycle=0 AND IsVerify=1";
            SqlParameter[] cmdParms ={
                 AddInParameter("@ClassID",SqlDbType.Int,4,channelID)};

            return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql, tablePrefix, channelType), cmdParms));
        }

        /// <summary>
        /// 获取指定栏目的类型
        /// </summary>
        public int GetChannelType(int channelID)
        {
            string strSql = "SELECT ClassType FROM {0}Arc_Class WHERE CID=@ClassID";
            SqlParameter[] cmdParms ={
                 AddInParameter("@ClassID",SqlDbType.Int,4,channelID)};

            return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql, tablePrefix), cmdParms));
        }
    }
}
