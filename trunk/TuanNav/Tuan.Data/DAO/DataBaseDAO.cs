using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tuan.Entity;
using Tuan.Entity.Global;

namespace Tuan.Data.DAO
{
    public abstract class DataBaseDAO : BaseDAO<DataBaseDAO>
    {
        /// <summary>
        /// 获取数据库基本信息
        /// </summary>
        public abstract DataBaseInfo GetDataBaseInfo();

        /// <summary>
        /// 获取网站基本统计信息
        /// </summary>
        public abstract ModelList GetBaseStats();
    }
}
