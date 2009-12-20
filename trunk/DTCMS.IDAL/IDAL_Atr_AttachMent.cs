using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
    public interface IDAL_Atr_AttachMent
    {
         /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(Atr_AttachMent model);

        #region 基方法
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="tb">表名</param>
        /// <param name="colist">-要查询出的字段列表,*表示全部字段</param>
        /// <param name="top">最多读取记录数 </param>
        /// <param name="pagesize">每页记录数</param>
        /// <param name="page">指定页</param>
        /// <param name="condition">查询条件</param>
        /// <param name="sql_key">用于排序的主键</param>
        /// <param name="col">-用于排序，如：id desc (多个id desc,dt asc)</param>
        /// <param name="orderby">排序,0-顺序,1-倒序</param>
        /// <param name="pagesum">总页数</param>
        /// <returns>数据表</returns>
        DataTable GetDataTable(string tb, string collist, int top, int pagesize, int page
            , string condition, string sql_key, string col, int orderby, out int pagesum);
        #endregion
    }
}
