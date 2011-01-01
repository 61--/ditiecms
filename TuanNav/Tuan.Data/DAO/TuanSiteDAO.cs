using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Tuan.Entity;

namespace Tuan.Data.DAO
{
    public abstract class TuanSiteDAO : BaseDAO<TuanSiteDAO>
    {
        /// <summary>
        /// 添加团购网站
        /// </summary>
        public abstract int Add(TuanSite model);

        /// <summary>
        /// 更新团购网站
        /// </summary>
        public abstract int Update(TuanSite model);

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public abstract int Delete(int siteID);

        /// <summary>
        /// 返回团购网站实体
        /// </summary>
        public abstract TuanSite GetModel(int siteID);

        /// <summary>
        /// 获取团购网站API信息
        /// </summary>
        public abstract TuanSite GetApiInfo(int siteID);

        /// <summary>
        /// 分页获取团购网站列表
        /// </summary>
        public abstract DataTable GetSiteList(int curPage, int pageSize, string sortValue, bool isDesc, string keyWord, ref int totalRecord);

        /// <summary>
        /// 根据城市区号获取所有团购网站列表
        /// </summary>
        public abstract DataTable GetSiteByCityID(int cityID);

        /// <summary>
        /// 根据城市区号获取该城市团购网站总数
        /// </summary>
        public abstract int GetSiteCountByCityID(int cityID);
    }
}
