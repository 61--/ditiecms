using System;
using System.Data;
using Tuan.Entity;

namespace Tuan.Data.DAO
{
    /// <summary>
    /// 数据访问抽象类 TuanGouDAO
    /// </summary>
    public abstract class TuanGouDAO : BaseDAO<TuanGouDAO>
    {
        /// <summary>
        /// 新增一条数据
        /// </summary>
        public abstract int Add(TuanGou model);

        /// <summary>
        /// 采集团购商品
        /// </summary>
        public abstract int AddOrUpdate(TuanGou model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public abstract int Update(TuanGou model);

        /// <summary>
        /// 更新团购状态
        /// </summary>
        public abstract int UpdateStatu(int tuanID, int statu);
            
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public abstract int Delete(int TuanID);
      
        /// <summary>
        /// 获取一条实体数据
        /// </summary>
        public abstract TuanGou GetModel(int TuanID);

        /// <summary>
        /// 获取城市最新团购信息
        /// </summary>
        public abstract ModelList GetNewTuan(int cityID, int category, int lp, int hp, string order, bool desc);

        /// <summary>
        /// 获取指定城市推荐团购
        /// </summary>
        public abstract ModelList GetRecommend(int cityID);

        /// <summary>
        /// 分页获取团购商品列表
        /// </summary>
        public abstract DataTable GetTuanList(int curPage, int pageSize, string sortValue, bool isDesc, string keyWord, ref int totalRecord);
    }
}