using System;
using System.Data;
using Tuan.Common;
using Tuan.Controls;
using Tuan.Data.DAO;
using Tuan.Entity;
using Tuan.Web.UI;

namespace Tuan.Web.admin
{
    public partial class tuan_add : AdminPage
    {
        protected int tuanID;
        protected int cityID = 1;
        protected int categoryID;
        protected ModelList cityList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Ajax.RegMethod(AddTuanGou);

            cityList = CityDAO.Instance.GetCityList();
            DataTable category = CategoryDAO.Instance.GetDataList();
            DropDownTree.BindToDropDownList(ddl_Category, category, "0");

            tuanID = Utils.GetQueryInt("ID");
            if (tuanID > 0)
            {
                TuanGou tuanGou = TuanGouDAO.Instance.GetModel(tuanID);
                if (tuanGou != null)
                {
                    txt_Title.Value = tuanGou.Title;
                    cityID = tuanGou.CityID;
                    hid_SiteID.Value = tuanGou.SiteID.ToString();
                    ddl_Category.Value = tuanGou.CategoryID.ToString();
                    txt_Description.Value = tuanGou.Description;
                    txt_MarketPrice.Value = tuanGou.MarketPrice.ToString();
                    txt_TuanPrice.Value = tuanGou.TuanPrice.ToString();
                    txt_Rebate.Value = tuanGou.Rebate.ToString();
                    txt_TotalCount.Value = tuanGou.TotalCount.ToString();
                    txt_BuyCount.Value = tuanGou.BuyCount.ToString();
                    txt_ClickCount.Value = tuanGou.ClickCount.ToString();
                    txt_CommentCount.Value = tuanGou.CommentCount.ToString();
                    txt_PointCount.Value = tuanGou.PointCount.ToString();
                    txt_BeginTime.Value = tuanGou.BeginTime.ToString();
                    txt_EndTime.Value = tuanGou.EndTime.ToString();
                    txt_TuanUrl.Value = tuanGou.TuanUrl;
                    txt_ImageThumbUrl.Value = tuanGou.ImageThumbUrl;
                    txt_ImageUrl.Value = tuanGou.ImageUrl;
                    txt_MerchantName.Value = tuanGou.MerchantName;
                    txt_MerchantAddress.Value = tuanGou.MerchantAddress;
                    txt_MerchantPhone.Value = tuanGou.MerchantPhone;
                    txt_Longitude.Value = tuanGou.Longitude.ToString();
                    txt_Latitude.Value = tuanGou.Latitude.ToString();
                    txt_Rank.Value = tuanGou.Rank.ToString();
                    hid_Statu.Value = tuanGou.Statu.ToString();
                    txt_OrderID.Value = tuanGou.OrderID.ToString();
                }
            }
        }

        private void AddTuanGou()
        {
            TuanGou tuanGou = new TuanGou();

            tuanGou.Title = Utils.GetFormString("txt_Title");
            tuanGou.CityID = Utils.GetFormInt("ddl_City");
            tuanGou.SiteID = Utils.GetFormInt("hid_SiteID");
            tuanGou.CategoryID = Utils.GetFormInt("ddl_Category");
            tuanGou.Description = Utils.GetFormString("txt_Description");   //如果有包含html标记需要htmldecode
            tuanGou.MarketPrice = TryConvert.ToDecimal(Request.Form["txt_MarketPrice"]);
            tuanGou.TuanPrice = TryConvert.ToDecimal(Request.Form["txt_TuanPrice"]);
            tuanGou.Rebate = TryConvert.ToSingle(Request.Form["txt_Rebate"]);
            tuanGou.TotalCount = Utils.GetFormInt("txt_TotalCount");
            tuanGou.BuyCount = Utils.GetFormInt("txt_BuyCount");
            tuanGou.ClickCount = Utils.GetFormInt("txt_ClickCount");
            tuanGou.CommentCount = Utils.GetFormInt("txt_CommentCount");
            tuanGou.PointCount = Utils.GetFormInt("txt_PointCount");
            tuanGou.BeginTime = Convert.ToDateTime(Request.Form["txt_BeginTime"]);
            tuanGou.EndTime = Convert.ToDateTime(Request.Form["txt_EndTime"]);
            tuanGou.TuanUrl = Utils.GetFormString("txt_TuanUrl");
            tuanGou.ImageThumbUrl = Utils.GetFormString("txt_ImageThumbUrl");
            tuanGou.ImageUrl = Utils.GetFormString("txt_ImageUrl");
            tuanGou.MerchantName = Utils.GetFormString("txt_MerchantName");
            tuanGou.MerchantPhone = Utils.GetFormString("txt_MerchantPhone");
            tuanGou.MerchantAddress = Utils.GetFormString("txt_MerchantAddress");
            tuanGou.Longitude = TryConvert.ToDouble(Request.Form["txt_Longitude"]);
            tuanGou.Latitude = TryConvert.ToDouble(Request.Form["txt_Latitude"]);
            tuanGou.Rank = TryConvert.ToByte(Request.Form["txt_Rank"]);
            tuanGou.OrderID = Utils.GetFormInt("txt_OrderID");
            tuanGou.Statu = TryConvert.ToByte(Request.Form["rdo_Statu"]);
            tuanGou.AddDate = DateTime.Now;

            int result;
            tuanID = Utils.GetQueryInt("ID");
            if (tuanID < 1)
            {
                tuanGou.UserID = loginUser.UserID;
                result = TuanGouDAO.Instance.Add(tuanGou);
            }
            else
            {
                tuanGou.TuanID = tuanID;
                result = TuanGouDAO.Instance.Update(tuanGou);
            }

            Ajax.Message(result);
        }
    }
}
