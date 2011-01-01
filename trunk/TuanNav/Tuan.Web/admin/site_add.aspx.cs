using System;
using Tuan.Common;
using Tuan.Data.DAO;
using Tuan.Entity;
using Tuan.Web.UI;

namespace Tuan.Web.admin
{
    public partial class site_add : AdminPage
    {
        protected int siteID;
        protected int cityID = 1;
        protected byte apiTypeID = 0;
        protected ModelList cityList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Ajax.RegMethod(AddSite);

            cityList = CityDAO.Instance.GetCityList();
            siteID = Utils.GetQueryInt("ID");
            if (siteID > 0)
            {
                TuanSite tuanSite = TuanSiteDAO.Instance.GetModel(siteID);
                if (tuanSite != null)
                {
                    txt_SiteName.Value = tuanSite.SiteName;
                    txt_SiteUrl.Value = tuanSite.SiteUrl;
                    txt_LogoUrl.Value = tuanSite.LogoUrl;
                    txt_ApiUrl.Value = tuanSite.ApiUrl;
                    txt_QQ.Value = tuanSite.QQ;
                    cityID = tuanSite.CityID;
                    apiTypeID = tuanSite.ApiTypeID;
                    if (tuanSite.SiteType == 0)
                        rdo_SiteType_1.Checked = true;
                    else
                        rdo_SiteType_2.Checked = true;
                }
            }
        }

        private void AddSite()
        {
            TuanSite model = new TuanSite();
            model.SiteID = Utils.GetQueryInt("ID");
            model.UserID = loginUser.UserID;
            model.CityID = Utils.GetFormInt("ddl_City");
            model.SiteName = Utils.GetFormString("txt_SiteName");
            model.SiteUrl = Utils.GetFormString("txt_SiteUrl");
            if (model.SiteUrl.EndsWith("/"))
            {
                model.SiteUrl = model.SiteUrl.TrimEnd('/');
            }
            model.LogoUrl = Utils.GetFormString("txt_LogoUrl");
            model.ApiTypeID = (byte)Utils.GetFormInt("ddl_ApiTypeID");
            model.ApiUrl = Utils.GetFormString("txt_ApiUrl");
            model.QQ = Utils.GetFormString("txt_QQ");
            model.SiteType = 1; //Utils.GetFormString("rdo_SiteType");
            model.Rank = TryConvert.ToByte(Utils.GetFormInt("txt_Rank"));
            model.Trust = TryConvert.ToByte(Utils.GetFormInt("txt_Trust"));

            model.Description = string.Empty;
            model.Master = string.Empty;
            model.ContactPerson = string.Empty;
            model.Phone = string.Empty;
            model.Email = string.Empty;
            model.OpenDate = DateTime.Now;
            model.AddDate = DateTime.Now;
            model.IsVerify = 1;

            int result = 0;
            if (model.SiteID > 0)
                result = TuanSiteDAO.Instance.Update(model);
            else
                result = TuanSiteDAO.Instance.Add(model);
            Ajax.Message(result);
        }
    }
}
