using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Tuan.Data;
using Tuan.Common;
using Tuan.Entity;

namespace Tuan.Data.SqlServer
{
    public class CityDAO : Tuan.Data.DAO.CityDAO
    {
        public override ModelList GetCityList()
        {
            string strSql = "SELECT CityID,City FROM TN_City WHERE IsDisplay=1 ORDER BY OrderID";

            ModelList list = SqlHelper.ExecuteList(CommandType.Text, strSql);
            return list;
        }

        public override DataTable GetAllCity()
        {
            DataTable dt = CacheAccess.Get<DataTable>("ALLCITY");
            if (dt == null)
            {
                string strSql = "SELECT CityID,ECity,City FROM TN_City WHERE IsDisplay=1 ORDER BY OrderID";

                DataSet ds = SqlHelper.ExecuteQuery(CommandType.Text, strSql);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    CacheAccess.Set("ALLCITY", dt);
                }
                else
                {
                    return null;
                }
            }
            return dt;
        }
    }
}
