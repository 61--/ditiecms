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
        public List<ArcList> GetArcList(int firstRecort, int lastRecort, string classType, string strWhere, string strOrder)
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
            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix, classType), null))
            {
                List<ArcList> lst = new List<ArcList>();

                int count = 0;

                while (dr.Read())
                {
                    count++;
                    if (count >= firstRecort && count <= lastRecort)
                    {
                        ArcList model = new ArcList();
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
        /// 获取分页文档泛型数据列表
        /// </summary>
        public List<ArcList> GetPageList(int classID, string classType, int pageSize, int pageIndex)
        {
            string strSql = "SELECT ID,ClassID,C.ClassName,C.ClassPath,Title,ShortTitle,TitleStyle,TitleFlag,A.ImgUrl,Author,Click,Good,Bad,FilePath,A.PubDate FROM {0}{1} A LEFT JOIN {0}Arc_Class C ON A.ClassID=C.CID AND A.ClassID=" + classID + " WHERE IsHidden=0";

            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix, classType), null))
            {
                List<ArcList> lst = new List<ArcList>();

                int firstRecort = GetFirstIndex(pageSize, pageIndex);
                int lastRecort = GetLastIndex(pageSize, pageIndex);
                int count = 0;
                while (dr.Read())
                {
                    count++;
                    if (count >= firstRecort && count <= lastRecort)
                    {
                        ArcList model = new ArcList();
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
        /// 获取栏目泛型数据列表
        /// </summary>
        public List<ArcClass> GetArcClass(int row, string strWhere)
        {
            string strSql = "SELECT CID,ClassName,ClassEname,ClassDomain,ClassPath,Description,SiteID,ImgURL,Keywords FROM {0}Arc_Class";

            if (strWhere.Length != 0)
            {
                strSql += " WHERE 1=1" + strWhere;
            }

            using (SqlDataReader dr = dbHelper.ExecuteReader(CommandType.Text, string.Format(strSql, tablePrefix), null))
            {
                List<ArcClass> lst = new List<ArcClass>();

                int count = 0;

                while (dr.Read())
                {
                    count++;
                    if (count <= row)
                    {
                        ArcClass model = new ArcClass();
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
        public int GetArcCount(int classID, string classType)
        {
            string strSql = "SELECT COUNT(*) FROM {0}{1} WHERE AND ClassID=@ClassID IsRecycle=0 AND IsVerify=1";
            SqlParameter[] cmdParms ={
                 AddInParameter("@ClassID",SqlDbType.Int,4,classID)};

            return dbHelper.GetInt(dbHelper.ExecuteScalar(CommandType.Text, string.Format(strSql, tablePrefix, classType), null));
        }
    }
}
