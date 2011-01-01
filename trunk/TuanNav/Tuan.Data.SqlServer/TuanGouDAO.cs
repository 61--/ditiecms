using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tuan.Entity;
using Tuan.Common;

namespace Tuan.Data.SqlServer
{
    /// <summary>
    /// 数据访问类 TuanGouDAO
    /// </summary>
    public class TuanGouDAO : Tuan.Data.DAO.TuanGouDAO
    {
        /// <summary>
        /// 新增一条数据
        /// </summary>
        public override int Add(TuanGou model)
        {
            string strSql = @"INSERT INTO TN_TuanGou(TuanID,CategoryID,CityID,UserID,SiteID,Title,Description,TuanDetail,TuanUrl,ImageThumbUrl,ImageUrl,MarketPrice,TuanPrice,Rebate,MerchantName,MerchantPhone,MerchantAddress,Longitude,Latitude,TotalCount,BuyCount,ClickCount,CommentCount,PointCount,BeginTime,EndTime,Statu,Rank,AddDate,OrderID)
                VALUES(@TuanID,@CategoryID,@CityID,@UserID,@SiteID,@Title,@Description,@TuanDetail,@TuanUrl,@ImageThumbUrl,@ImageUrl,@MarketPrice,@TuanPrice,@Rebate,@MerchantName,@MerchantPhone,@MerchantAddress,@Longitude,@Latitude,@TotalCount,@BuyCount,@ClickCount,@CommentCount,@PointCount,@BeginTime,@EndTime,@Statu,@Rank,@AddDate,@OrderID)";

            SqlParameter[] parms = {
                SqlHelper.CreateParameter<int>("@CategoryID", model.CategoryID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CityID", model.CityID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@UserID", model.UserID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@SiteID", model.SiteID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<string>("@Title", model.Title, SqlDbType.VarChar, 200),
                SqlHelper.CreateParameter<string>("@Description", model.Description, SqlDbType.VarChar, 500),
                SqlHelper.CreateParameter<string>("@TuanDetail", model.TuanDetail, SqlDbType.Text, 5000),
                SqlHelper.CreateParameter<string>("@TuanUrl", model.TuanUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@ImageUrl", model.ImageUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@ImageThumbUrl", model.ImageThumbUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<decimal>("@MarketPrice", model.MarketPrice, SqlDbType.Money, 8),
                SqlHelper.CreateParameter<decimal>("@TuanPrice", model.TuanPrice, SqlDbType.Money, 8),
                SqlHelper.CreateParameter<float>("@Rebate", model.Rebate, SqlDbType.Float, 8),
                SqlHelper.CreateParameter<string>("@MerchantName", model.MerchantName, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@MerchantPhone", model.MerchantPhone, SqlDbType.VarChar, 20),
                SqlHelper.CreateParameter<string>("@MerchantAddress", model.MerchantAddress, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<double>("@Longitude", model.Longitude, SqlDbType.Float, 8),
                SqlHelper.CreateParameter<double>("@Latitude", model.Latitude, SqlDbType.Float, 8),
                SqlHelper.CreateParameter<int>("@TotalCount", model.TotalCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@BuyCount", model.BuyCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@ClickCount", model.ClickCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CommentCount", model.CommentCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@PointCount", model.PointCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<DateTime>("@BeginTime", model.BeginTime, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<DateTime>("@EndTime", model.EndTime, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<byte>("@Statu", model.Statu, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@Rank", model.Rank, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<DateTime>("@AddDate", model.AddDate, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<int>("@OrderID", model.OrderID, SqlDbType.Int, 4)};

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql, parms);
        }

        /// <summary>
        /// 采集团购商品
        /// </summary>
        public override int AddOrUpdate(TuanGou model)
        {
            SqlParameter[] parms = {
                SqlHelper.CreateParameter<int>("@CategoryID", model.CategoryID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CityID", model.CityID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@SiteID", model.SiteID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<string>("@Title", model.Title, SqlDbType.VarChar, 200),
                SqlHelper.CreateParameter<string>("@Description", model.Description, SqlDbType.VarChar, 500),
                SqlHelper.CreateParameter<string>("@TuanDetail", model.TuanDetail, SqlDbType.Text, 5000),
                SqlHelper.CreateParameter<string>("@TuanUrl", model.TuanUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@ImageUrl", model.ImageUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@ImageThumbUrl", model.ImageThumbUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<decimal>("@MarketPrice", model.MarketPrice, SqlDbType.Money, 8),
                SqlHelper.CreateParameter<decimal>("@TuanPrice", model.TuanPrice, SqlDbType.Money, 8),
                SqlHelper.CreateParameter<float>("@Rebate", model.Rebate, SqlDbType.Float, 8),
                SqlHelper.CreateParameter<string>("@MerchantName", model.MerchantName, SqlDbType.VarChar, 50),
                SqlHelper.CreateParameter<string>("@MerchantPhone", model.MerchantPhone, SqlDbType.VarChar, 20),
                SqlHelper.CreateParameter<string>("@MerchantAddress", model.MerchantAddress, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<double>("@Longitude", model.Longitude, SqlDbType.Float, 8),
                SqlHelper.CreateParameter<double>("@Latitude", model.Latitude, SqlDbType.Float, 8),
                SqlHelper.CreateParameter<int>("@TotalCount", model.TotalCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@BuyCount", model.BuyCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<DateTime>("@BeginTime", model.BeginTime, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<DateTime>("@EndTime", model.EndTime, SqlDbType.DateTime, 8)};

            return SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "Proc_TuanGou_AddOrUpdate", parms);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public override int Update(TuanGou model)
        {
            string strSql = @"UPDATE TN_TuanGou SET CategoryID=@CategoryID,CityID=@CityID,UserID=@UserID,SiteID=@SiteID,Title=@Title,Description=@Description,TuanDetail=@TuanDetail,TuanUrl=@TuanUrl,ImageThumbUrl=@ImageThumbUrl,ImageUrl=@ImageUrl,MarketPrice=@MarketPrice,TuanPrice=@TuanPrice,Rebate=@Rebate,MerchantName=@MerchantName,MerchantPhone=@MerchantPhone,MerchantAddress=@MerchantAddress,Longitude=@Longitude,Latitude=@Latitude,TotalCount=@TotalCount,BuyCount=@BuyCount,ClickCount=@ClickCount,CommentCount=@CommentCount,PointCount=@PointCount,BeginTime=@BeginTime,EndTime=@EndTime,Statu=@Statu,Rank=@Rank,AddDate=@AddDate,OrderID=@OrderID
                  WHERE TuanID=@TuanID";

            SqlParameter[] parms = {
                SqlHelper.CreateParameter<int>("@TuanID", model.TuanID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CategoryID", model.CategoryID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CityID", model.CityID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@UserID", model.UserID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@SiteID", model.SiteID, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<string>("@Title", model.Title, SqlDbType.VarChar, 400),
                SqlHelper.CreateParameter<string>("@Description", model.Description, SqlDbType.VarChar, 1000),
                SqlHelper.CreateParameter<string>("@TuanDetail", model.TuanDetail, SqlDbType.Text, 5000),
                SqlHelper.CreateParameter<string>("@TuanUrl", model.TuanUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<string>("@ImageThumbUrl",model.ImageThumbUrl,SqlDbType.VarChar,255),
                SqlHelper.CreateParameter<string>("@ImageUrl", model.ImageUrl, SqlDbType.VarChar, 255),
                SqlHelper.CreateParameter<decimal>("@MarketPrice", model.MarketPrice, SqlDbType.VarChar, 8),
                SqlHelper.CreateParameter<decimal>("@TuanPrice", model.TuanPrice, SqlDbType.VarChar, 8),
                SqlHelper.CreateParameter<float>("@Rebate", model.Rebate, SqlDbType.Float, 8),
                SqlHelper.CreateParameter<string>("@MerchantName", model.MerchantName, SqlDbType.VarChar, 100),
                SqlHelper.CreateParameter<string>("@MerchantPhone", model.MerchantPhone, SqlDbType.VarChar, 20),
                SqlHelper.CreateParameter<string>("@MerchantAddress", model.MerchantAddress, SqlDbType.VarChar, 510),
                SqlHelper.CreateParameter<double>("@Longitude", model.Longitude, SqlDbType.Decimal, 8),
                SqlHelper.CreateParameter<double>("@Latitude", model.Latitude, SqlDbType.Decimal, 8),
                SqlHelper.CreateParameter<int>("@TotalCount", model.TotalCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@BuyCount", model.BuyCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@ClickCount", model.ClickCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@CommentCount", model.CommentCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<int>("@PointCount", model.PointCount, SqlDbType.Int, 4),
                SqlHelper.CreateParameter<DateTime>("@BeginTime", model.BeginTime, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<DateTime>("@EndTime", model.EndTime, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<byte>("@Statu", model.Statu, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<byte>("@Rank", model.Rank, SqlDbType.TinyInt, 1),
                SqlHelper.CreateParameter<DateTime>("@AddDate", model.AddDate, SqlDbType.DateTime, 8),
                SqlHelper.CreateParameter<int>("@OrderID", model.OrderID, SqlDbType.Int, 4)};

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql, parms);
        }

        /// <summary>
        /// 更新团购状态
        /// </summary>
        public override int UpdateStatu(int tuanID, int statu)
        {
            string strSql = string.Format("UPDATE TN_TuanGou SET Statu={0} WHERE TuanID={1}", statu, tuanID);

            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public override int Delete(int tuanID)
        {
            string strSql = "DELETE FROM TN_TuanGou WHERE TuanID=@TuanID";

            SqlParameter[] parms = {
                SqlHelper.CreateParameter<int>("@TuanID", tuanID, SqlDbType.Int, 4)};
            return SqlHelper.ExecuteNonQuery(CommandType.Text, strSql, parms);
        }

        /// <summary>
        /// 获取一条实体数据
        /// </summary>
        public override TuanGou GetModel(int tuanID)
        {
            string strSql = "SELECT TuanID,CategoryID,CityID,UserID,SiteID,Title,Description,TuanDetail,TuanUrl,ImageThumbUrl,ImageUrl,MarketPrice,TuanPrice,Rebate,MerchantName,MerchantPhone,MerchantAddress,Longitude,Latitude,TotalCount,BuyCount,ClickCount,CommentCount,PointCount,BeginTime,EndTime,Statu,Rank,AddDate,OrderID FROM TN_TuanGou WHERE TuanID=@TuanID";

            SqlParameter[] parms = {
                SqlHelper.CreateParameter<int>("@TuanID", tuanID, SqlDbType.Int, 4)};

            using (SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, strSql, parms))
            {
                if (dr.Read())
                {
                    TuanGou model = new TuanGou();
                    model.TuanID = SqlHelper.GetInt(dr["TuanID"]);
                    model.CategoryID = SqlHelper.GetInt(dr["CategoryID"]);
                    model.CityID = SqlHelper.GetInt(dr["CityID"]);
                    model.UserID = SqlHelper.GetInt(dr["UserID"]);
                    model.SiteID = SqlHelper.GetInt(dr["SiteID"]);
                    model.Title = SqlHelper.GetString(dr["Title"]);
                    model.Description = SqlHelper.GetString(dr["Description"]);
                    model.TuanDetail = SqlHelper.GetString(dr["TuanDetail"]);
                    model.TuanUrl = SqlHelper.GetString(dr["TuanUrl"]);
                    model.ImageThumbUrl = SqlHelper.GetString(dr["ImageThumbUrl"]);
                    model.ImageUrl = SqlHelper.GetString(dr["ImageUrl"]);
                    model.MarketPrice = SqlHelper.GetDecimal(dr["MarketPrice"]);
                    model.TuanPrice = SqlHelper.GetDecimal(dr["TuanPrice"]);
                    model.Rebate = SqlHelper.GetFloat(dr["Rebate"]);
                    model.MerchantName = SqlHelper.GetString(dr["MerchantName"]);
                    model.MerchantPhone = SqlHelper.GetString(dr["MerchantPhone"]);
                    model.MerchantAddress = SqlHelper.GetString(dr["MerchantAddress"]);
                    model.Longitude = SqlHelper.GetDouble(dr["Longitude"]);
                    model.Latitude = SqlHelper.GetDouble(dr["Latitude"]);
                    model.TotalCount = SqlHelper.GetInt(dr["TotalCount"]);
                    model.BuyCount = SqlHelper.GetInt(dr["BuyCount"]);
                    model.ClickCount = SqlHelper.GetInt(dr["ClickCount"]);
                    model.CommentCount = SqlHelper.GetInt(dr["CommentCount"]);
                    model.PointCount = SqlHelper.GetInt(dr["PointCount"]);
                    model.BeginTime = SqlHelper.GetDateTime(dr["BeginTime"]);
                    model.EndTime = SqlHelper.GetDateTime(dr["EndTime"]);
                    model.Statu = SqlHelper.GetByte(dr["Statu"]);
                    model.Rank = SqlHelper.GetByte(dr["Rank"]);
                    model.AddDate = SqlHelper.GetDateTime(dr["AddDate"]);
                    model.OrderID = SqlHelper.GetInt(dr["OrderID"]);
                    return model;
                }
                return null;
            }
        }

        /// <summary>
        /// 获取指定城市推荐团购
        /// </summary>
        public override ModelList GetRecommend(int cityID)
        {
            string strSql = string.Format(@"SELECT TuanID,TG.SiteID,TS.SiteName,TS.SiteUrl,Title,TuanUrl,ImageUrl,ImageThumbUrl,MarketPrice,TuanPrice,Rebate,BuyCount,TG.Description,TG.CommentCount,PointCount,BeginTime,EndTime FROM
                (SELECT TOP 3 TuanID,SiteID,Title,TuanUrl,ImageUrl,ImageThumbUrl,CONVERT(DECIMAL(18,2),MarketPrice) MarketPrice,CONVERT(DECIMAL(18,2),TuanPrice) TuanPrice,CONVERT(DECIMAL(18,2),Rebate) Rebate,BuyCount,CommentCount,PointCount,BeginTime,EndTime,Description FROM TN_TuanGou WHERE CityID={0} ORDER BY Rank DESC) TG LEFT JOIN TN_TuanSite TS ON TG.SiteID=TS.SiteID", cityID);

            ModelList tuanList = SqlHelper.ExecuteList(CommandType.Text, strSql.ToString());
            return tuanList;
        }

        /// <summary>
        /// 获取城市最新团购信息
        /// </summary>
        public override ModelList GetNewTuan(int cityID, int category, int lp, int hp, string order, bool desc)
        {
            StringBuffer strSql = new StringBuffer();
            strSql += "SELECT TuanID,TG.SiteID,TS.SiteName,TS.SiteUrl,Title,TuanUrl,ImageUrl,ImageThumbUrl,MarketPrice,TuanPrice,Rebate,BuyCount,TG.CommentCount,PointCount,BeginTime,EndTime FROM(SELECT TOP 30 TuanID,SiteID,Title,TuanUrl,ImageUrl,ImageThumbUrl,CONVERT(DECIMAL(18,2),MarketPrice) MarketPrice,CONVERT(DECIMAL(18,2),TuanPrice) TuanPrice,CONVERT(DECIMAL(18,2),Rebate) Rebate,BuyCount,CommentCount,PointCount,BeginTime,EndTime";
            strSql += " FROM TN_TuanGou WHERE CityID=" + cityID;

            if (category > 0)
                strSql += " AND CategoryID=" + category;
            if (hp > lp && lp >= 0)
                strSql += string.Format(" AND TuanPrice>{0} AND TuanPrice<{1}", lp, hp);
            else if (lp > 0 && hp == 0)
                strSql += " AND TuanPrice>" + lp;

            strSql += " AND Statu=1 ORDER BY";
            if (string.IsNullOrEmpty(order))
            {
                switch (order)
                {
                    case "date":
                        strSql += " BeginTime";
                        break;
                    case "price":
                        strSql += " TuanPrice";
                        break;
                    case "hot":
                        strSql += " BuyCount";
                        break;
                    case "rebate":
                        strSql += " Rebate";
                        break;
                    case "default":
                    default:
                        strSql += " BeginTime";
                        break;
                }
                if (desc)
                    strSql += " DESC";
                else
                    strSql += " ASC";
            }
            else
            {
                strSql += " BeginTime DESC";
            }
            strSql += ") TG LEFT JOIN TN_TuanSite TS ON TG.SiteID=TS.SiteID";

            ModelList tuanList = SqlHelper.ExecuteList(CommandType.Text, strSql.ToString());
            return tuanList;
        }

        /// <summary>
        /// 分页获取团购商品列表
        /// </summary>
        public override DataTable GetTuanList(int curPage, int pageSize, string sortValue, bool isDesc, string keyWord, ref int totalRecord)
        {
            PagerInfo pager = new PagerInfo();
            pager.TableName = "TN_TuanGou TG LEFT JOIN TN_Category TC ON TG.CategoryID=TC.CategoryID LEFT JOIN TN_City TI ON TG.CityID=TI.CityID";
            pager.PrimaryKey = "TuanID";
            pager.PageNumber = curPage;
            pager.PageSize = pageSize;
            pager.ResultFields = "TuanID,CName,City,Title,ImageUrl,Statu,Rank,AddDate";
            pager.SortField = sortValue;
            pager.IsDesc = isDesc;
            pager.Condition = keyWord;
            pager.SelectCount = true;
            pager.WithNolock = false;
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
    }
}