using System;
using System.Data;
using Tuan.Common;
using Tuan.Data.DAO;
using Tuan.Web.UI;

namespace Tuan.Web.admin
{
    public partial class tuan_list : AdminPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ajax.RegMethod(GetTuanGouList);
            Ajax.RegMethod(EditStatu);
            Ajax.RegMethod(DeleteTuanGou);
        }

        private void GetTuanGouList()
        {
            int curPage = Utils.GetQueryInt("curPage");
            int pageSize = Utils.GetQueryInt("pageSize");
            int totalRecord = Utils.GetQueryInt("totalRecord");
            string sortValue = Utils.GetQueryString("sortValue");
            bool isDesc = Boolean.Parse(Utils.GetQueryString("isDesc"));
            string keyWord = Utils.GetQueryString("keyWord");
            if (keyWord.Length > 0)
            {
                keyWord = string.Format("Title LIKE '%{0}%'", keyWord);
            }

            string jsonData = string.Empty;
            DataTable dt = TuanGouDAO.Instance.GetTuanList(curPage, pageSize, sortValue, isDesc, keyWord, ref totalRecord);

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

        private void EditStatu()
        {
            int tuanID = Utils.GetQueryInt("ID");
            int statu = Utils.GetQueryInt("statu");

            int result = TuanGouDAO.Instance.UpdateStatu(tuanID, statu);
            Ajax.Message(result);
        }

        private void DeleteTuanGou()
        {
            int tuanID = Utils.GetQueryInt("ID");

            int result = TuanGouDAO.Instance.Delete(tuanID);
            Ajax.Message(result);
        }
    }
}
