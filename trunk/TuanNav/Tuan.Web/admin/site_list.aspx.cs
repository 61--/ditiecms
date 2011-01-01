using System;
using System.Data;
using Tuan.Common;
using Tuan.Data.DAO;
using Tuan.Web.UI;

namespace Tuan.Web.admin
{
    public partial class site_list : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ajax.RegMethod(GetTuanSiteList);
            Ajax.RegMethod(DeleteTuanSite);
        }

        public void GetTuanSiteList()
        {
            int curPage = Utils.GetQueryInt("curPage");
            int pageSize = Utils.GetQueryInt("pageSize");
            int totalRecord = Utils.GetQueryInt("totalRecord");
            string sortValue = Utils.GetQueryString("sortValue");
            bool isDesc = Boolean.Parse(Utils.GetQueryString("isDesc"));
            string keyWord = Utils.GetQueryString("keyWord");
            if (keyWord.Length > 0)
            {
                keyWord = string.Format("SiteName LIKE '%{0}%' OR SiteUrl LIKE '%{0}%'", keyWord);
            }

            string jsonData = string.Empty;
            DataTable dt = TuanSiteDAO.Instance.GetSiteList(curPage, pageSize, sortValue, isDesc, keyWord, ref totalRecord);

            if (dt != null)
            {
                jsonData = Utils.DataTableToJson(dt, totalRecord).ToString();
            }
            else
            {
                jsonData = "{'error':1,'totalRecord':0,'dataTable':[]}";
            }
            Ajax.Write(jsonData, DataType.Json);
        }


        /// <summary>
        /// 删除团购网站
        /// </summary>
        public void DeleteTuanSite()
        {
            int result = TuanSiteDAO.Instance.Delete(Utils.GetQueryInt("ID"));
            Ajax.Message(result);
        }
    }
}
