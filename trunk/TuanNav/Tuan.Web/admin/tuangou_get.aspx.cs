using System;
using System.Data;
using Tuan.Common;
using Tuan.Controls;
using Tuan.Data.DAO;
using Tuan.Entity;

namespace Tuan.Web
{
    public partial class tuangou_get : Tuan.Web.UI.AdminPage
    {
        protected ModelList citys = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Ajax.RegMethod(GetSiteByCityID);

            citys = CityDAO.Instance.GetCityList();
            //DataTable category = CategoryDAO.Instance.GetDataList();


        }

        /// <summary>
        /// 获取要采集的团购网站列表
        /// </summary>
        private void GetSiteByCityID()
        {
            int cityID = Utils.GetQueryInt("cityID");
            DataTable site = TuanSiteDAO.Instance.GetSiteByCityID(cityID);

            Ajax.Write(Utils.DataTableToJson(site, site.Rows.Count).ToString(), DataType.Json);
        }
    }
}
