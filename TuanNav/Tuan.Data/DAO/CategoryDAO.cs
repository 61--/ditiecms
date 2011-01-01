using System;
using System.Collections.Generic;
using System.Data;
using Tuan.Entity;

namespace Tuan.Data.DAO
{
    /// <summary>
    /// 数据访问抽象类 CategoryDAO
    /// </summary>
    public abstract class CategoryDAO : BaseDAO<CategoryDAO>
    {
        /// <summary>
        /// 获取指定父ID商品类别，-1为获取所有
        /// </summary>
        public abstract IList<Category> GetList(int pid);

        /// <summary>
        /// 获取所有商品类别
        /// </summary>
        public abstract DataTable GetDataList();
    }
}