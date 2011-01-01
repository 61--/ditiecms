using System;
using System.Collections.Generic;
using System.Text;
using Tuan.Data;
using Tuan.Data.Provider;
using Tuan.Data.DAO;

namespace Tuan.Data.SqlServer
{
    public class DataProvider : IDataProvider
    {
        public T GetInstance<T>() where T : BaseDAO<T>
        {
            string instanceName = typeof(T).Name;
            switch (instanceName)
            {
                case "UserDAO":
                    return new UserDAO() as T;
                case "CityDAO":
                    return new CityDAO() as T;
                case "TuanSiteDAO":
                    return new TuanSiteDAO() as T;
                case "TuanGouDAO":
                    return new TuanGouDAO() as T;
                case "CategoryDAO":
                    return new CategoryDAO() as T;
                case "DataBaseDAO":
                    return new DataBaseDAO() as T;
                default:
                    throw new Exception(string.Format("数据访问类\"{0}\"未在DataProvider中注册", instanceName));
            }
        }
    }
}
