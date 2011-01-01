using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tuan.Data;
using Tuan.Entity;

namespace Tuan.Data.SqlServer
{
    public class TuanSiteDAO : Tuan.Data.DAO.TuanSiteDAO
    {
        /// <summary>
        /// 添加团购网站
        /// </summary>
        public override int Add(TuanSite model)
        {
            string strSql = @"insert into TN_TuanSite(UserID,CityID,SiteUrl,LogoUrl,ApiUrl,SiteName,Description,OpenDate,CategoryID,TuanCount,CommentCount,ClickCount,Master,ContactPerson,Phone,Email,QQ,ApiTypeID,SiteType,Rank,Trust,IsVerify,AddDate,OrderID)
                values (@UserID,@CityID,@SiteUrl,@LogoUrl,@ApiUrl,@SiteName,@Description,@OpenDate,@CategoryID,@TuanCount,@CommentCount,@ClickCount,@Master,@ContactPerson,@Phone,@Email,@QQ,@ApiTypeID,@SiteType,@Rank,@Trust,@IsVerify,@AddDate,@OrderID)";

            SqlParameter[] parms = {
                SqlHelper.CreateParameter<int>("@UserID", model.UserID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CityID", model.CityID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<string>("@SiteUrl", model.SiteUrl, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@LogoUrl", model.LogoUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@ApiUrl", model.ApiUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@SiteName", model.SiteName, SqlDbType.VarChar, 100),
                SqlHelper.CreateParameter<string>("@Description", model.Description, SqlDbType.VarChar, 1000),
                SqlHelper.CreateParameter<DateTime>("@OpenDate", model.OpenDate, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<int>("@CategoryID", model.CategoryID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@TuanCount", model.TuanCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CommentCount", model.CommentCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@ClickCount", model.ClickCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<string>("@Master", model.Master, SqlDbType.VarChar, 40),
                SqlHelper.CreateParameter<string>("@ContactPerson", model.ContactPerson, SqlDbType.VarChar, 40),
                SqlHelper.CreateParameter<string>("@Phone", model.Phone, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@Email", model.Email, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@QQ", model.QQ, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<byte>("@ApiTypeID", model.ApiTypeID, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@SiteType", model.SiteType, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@Rank", model.Rank, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@Trust", model.Trust, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@IsVerify", model.IsVerify, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<DateTime>("@AddDate", model.AddDate, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<int>("@OrderID", model.OrderID, SqlDbType.Int, 4)};

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql, parms);
        }

        /// <summary>
        /// 更新团购网站
        /// </summary>
        public override int Update(TuanSite model)
        {
            string strSql = "update TN_TuanSite set UserID=@UserID,CityID=@CityID,SiteUrl=@SiteUrl,LogoUrl=@LogoUrl,ApiUrl=@ApiUrl,SiteName=@SiteName,Description=@Description,OpenDate=@OpenDate,CategoryID=@CategoryID,TuanCount=@TuanCount,CommentCount=@CommentCount,ClickCount=@ClickCount,Master=@Master,ContactPerson=@ContactPerson,Phone=@Phone,Email=@Email,QQ=@QQ,ApiTypeID=@ApiTypeID,SiteType=@SiteType,Rank=@Rank,Trust=@Trust,IsVerify=@IsVerify,OrderID=@OrderID where SiteID=@SiteID";

            SqlParameter[] parms = {
                SqlHelper.CreateParameter<int>("@SiteID",model.SiteID,SqlDbType.Int,4),
	            SqlHelper.CreateParameter<int>("@UserID", model.UserID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CityID", model.CityID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<string>("@SiteUrl", model.SiteUrl, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@LogoUrl", model.LogoUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@ApiUrl", model.ApiUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@SiteName", model.SiteName, SqlDbType.VarChar, 100),
                SqlHelper.CreateParameter<string>("@Description", model.Description, SqlDbType.VarChar, 1000),
                SqlHelper.CreateParameter<DateTime>("@OpenDate", model.OpenDate, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<int>("@CategoryID", model.CategoryID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@TuanCount", model.TuanCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CommentCount", model.CommentCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@ClickCount", model.ClickCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<string>("@Master", model.Master, SqlDbType.VarChar, 40),
                SqlHelper.CreateParameter<string>("@ContactPerson", model.ContactPerson, SqlDbType.VarChar, 40),
                SqlHelper.CreateParameter<string>("@Phone", model.Phone, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@Email", model.Email, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@QQ", model.QQ, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<byte>("@ApiTypeID", model.ApiTypeID, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@SiteType", model.SiteType, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@Rank", model.Rank, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@Trust", model.Trust, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@IsVerify", model.IsVerify, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<DateTime>("@AddDate", model.AddDate, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<int>("@OrderID", model.OrderID, SqlDbType.Int, 4)};

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql, parms);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public override int Delete(int siteID)
        {

            string strSql = "delete from TN_TuanSite where SiteID=@SiteID";
            SqlParameter[] parms = {
				SqlHelper.CreateParameter<int>("@SiteID",siteID,SqlDbType.Int,4)};

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql, parms);
        }

        /// <summary>
        /// 返回团购网站实体
        /// </summary>
        public override TuanSite GetModel(int siteID)
        {
            string strSql = "select top 1 SiteID,CityID,SiteUrl,LogoUrl,ApiUrl,SiteName,Description,OpenDate,CategoryID,TuanCount,CommentCount,ClickCount,Master,ContactPerson,Phone,Email,QQ,ApiTypeID,SiteType,Rank,Trust,IsVerify,AddDate from TN_TuanSite where SiteID=@SiteID";

            SqlParameter[] parms = {
				SqlHelper.CreateParameter<int>("@SiteID",siteID,SqlDbType.Int,4)};

            using (SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strSql, parms))
            {
                if (dr.Read())
                {
                    TuanSite tuanSite = new TuanSite();
                    tuanSite.SiteID = SqlHelper.GetInt(dr["SiteID"]);
                    tuanSite.CityID = SqlHelper.GetInt(dr["CityID"]);
                    tuanSite.SiteUrl = SqlHelper.GetString(dr["SiteUrl"]);
                    tuanSite.LogoUrl = SqlHelper.GetString(dr["LogoUrl"]);
                    tuanSite.ApiUrl = SqlHelper.GetString(dr["ApiUrl"]);
                    tuanSite.SiteName = SqlHelper.GetString(dr["SiteName"]);
                    tuanSite.Description = SqlHelper.GetString(dr["Description"]);
                    tuanSite.OpenDate = SqlHelper.GetDateTime(dr["OpenDate"]);
                    tuanSite.CategoryID = SqlHelper.GetInt(dr["CategoryID"]);
                    tuanSite.TuanCount = SqlHelper.GetInt(dr["TuanCount"]);
                    tuanSite.CommentCount = SqlHelper.GetInt(dr["CommentCount"]);
                    tuanSite.ClickCount = SqlHelper.GetInt(dr["ClickCount"]);
                    tuanSite.Master = SqlHelper.GetString(dr["Master"]);
                    tuanSite.ContactPerson = SqlHelper.GetString(dr["ContactPerson"]);
                    tuanSite.Phone = SqlHelper.GetString(dr["Phone"]);
                    tuanSite.Email = SqlHelper.GetString(dr["Email"]);
                    tuanSite.QQ = SqlHelper.GetString(dr["QQ"]);
                    tuanSite.ApiTypeID = SqlHelper.GetByte(dr["ApiTypeID"]);
                    tuanSite.SiteType = SqlHelper.GetByte(dr["SiteType"]);
                    tuanSite.Rank = SqlHelper.GetByte(dr["Rank"]);
                    tuanSite.Trust = SqlHelper.GetByte(dr["Trust"]);
                    tuanSite.IsVerify = SqlHelper.GetByte(dr["IsVerify"]);
                    tuanSite.AddDate = SqlHelper.GetDateTime(dr["AddDate"]);

                    return tuanSite;
                }
                return null;
            }
        }

        /// <summary>
        /// 获取团购网站API信息
        /// </summary>
        public override TuanSite GetApiInfo(int siteID)
        {
            string strSql = "SELECT TOP 1 SiteUrl,ApiUrl,ApiTypeID FROM TN_TuanSite WHERE SiteID=" + siteID;

            using (SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strSql))
            {
                if (dr.Read())
                {
                    TuanSite tuanSite = new TuanSite();
                    tuanSite.SiteUrl = SqlHelper.GetString(dr["SiteUrl"]);
                    tuanSite.ApiUrl = SqlHelper.GetString(dr["ApiUrl"]);
                    tuanSite.ApiTypeID = SqlHelper.GetByte(dr["ApiTypeID"]);

                    return tuanSite;
                }
                return null;
            }
        }

        /// <summary>
        /// 分页获取团购网站列表
        /// </summary>
        public override DataTable GetSiteList(int curPage, int pageSize, string sortValue, bool isDesc, string keyWord, ref int totalRecord)
        {
            PagerInfo pager = new PagerInfo();
            pager.TableName = "TN_TuanSite";
            pager.PrimaryKey = "SiteID";
            pager.PageNumber = curPage;
            pager.PageSize = pageSize;
            pager.ResultFields = "SiteID,CityID,SiteName,SiteUrl,LogoUrl,ApiUrl,QQ,AddDate";
            pager.SortField = sortValue;
            pager.IsDesc = isDesc;
            pager.Condition = keyWord;
            pager.SelectCount = true;
            pager.TotalRecords = totalRecord;

            DataSet ds = SqlHelper.ExecutePageList(pager, null);
            if (ds != null && ds.Tables.Count > 0)
            {
                totalRecord = int.Parse(ds.Tables[1].Rows[0][0].ToString());
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据城市区号获取所有团购网站列表
        /// 当城市ID为0时获取所有团购团购网站
        /// </summary>
        public override DataTable GetSiteByCityID(int cityID)
        {
            string strSql = "SELECT SiteID,CityID,SiteName,ApiTypeID,ApiUrl,Rank FROM TN_TuanSite";
            if (cityID > 0)
                strSql += " WHERE CityID=" + cityID;

            DataSet ds = SqlHelper.ExecuteQuery(CommandType.Text, strSql);
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            else
                return null;
        }

        /// <summary>
        /// 根据城市区号获取该城市团购网站总数
        /// </summary>
        public override int GetSiteCountByCityID(int cityID)
        {
            string strSql = "SELECT COUNT(*) FROM TN_TuanSite";
            if (cityID > 0)
                strSql += " WHERE CityID=" + cityID;

            int count = int.Parse(SqlHelper.ExecuteScalar(CommandType.Text, strSql).ToString());
            return count;
        }
    }
}
