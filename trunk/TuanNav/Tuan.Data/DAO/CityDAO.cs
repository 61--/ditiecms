using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tuan.Entity;

namespace Tuan.Data.DAO
{
    public abstract class CityDAO : BaseDAO<CityDAO>
    {
        /// <summary>
        /// 获取所有城市列表
        /// </summary>
        public abstract ModelList GetCityList();

        /// <summary>
        /// 按指定排序获取城市列表
        /// </summary>
        /// <returns></returns>
        public abstract DataTable GetAllCity();
    }
}
