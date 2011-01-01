using System;
using System.Data;
using System.Collections.Generic;
using Tuan.Common;
using Tuan.Controls;
using Tuan.Data.DAO;
using Tuan.Entity;
using Tuan.Web.UI;
using Tuan.Api;

namespace Tuan.Web
{
    public partial class get : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int siteID = Utils.GetFormInt("siteID");
            int apiTypeID = Utils.GetFormInt("apiTypeID");
            string apiUrl = Utils.GetFormString("apiUrl");
            int rank = Utils.GetFormInt("rank");

            if (siteID == -1)
                Ajax.Message(-1, "不存在网站信息。");
            if (apiTypeID == 0)
                Ajax.Message(-1, "未指定API地址类型。");
            if (apiUrl.Length == 0)
                Ajax.Message(-1, "API地址为空。");

            int getCount = 0;
            try
            {
                IList<TuanGou> tuanGouList = ApiProvider.GetTuanGouList(apiTypeID, apiUrl);
                if (tuanGouList != null && tuanGouList.Count > 0)
                {
                    for (int i = 0; i < tuanGouList.Count; i++)
                    {
                        tuanGouList[i].SiteID = siteID;
                        tuanGouList[i].Rank = (byte)rank;
                        getCount += TuanGouDAO.Instance.AddOrUpdate(tuanGouList[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Ajax.Message(-1, ex.Message.Replace("\\", "\\\\").Replace("'", "\\'"));
            }
            Ajax.Message(1, getCount.ToString());
        }
    }
}
