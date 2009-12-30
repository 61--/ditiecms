using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DTCMS.Entity;

namespace DTCMS.IDAL
{
    public interface IDAL_Sys_Publish
    {
        
         /// <summary>
        /// 得到所有的栏目信息
        /// </summary>
        /// <param name="totalCount">共多少条数据</param>
        /// <returns></returns>
        DataTable GetClassByClassID(int CID, out int totalCount);

         /// <summary>
        /// 根据栏目编号获取栏目信息
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns></returns>
        Arc_Class GetClassByID(int CID);

           /// <summary>
        /// 按照类别编号发布文章
        /// </summary>
        /// <param name="CID">类别编号</param>
        /// <param name="publishchild">是否发布其子栏目</param>
        /// <param name="orderBy">文章排序</param>
        /// <param name="orderWay">排序方式 desc asc</param>
        /// <param name="totalCount">共有多少条</param>
        /// <returns></returns>
        DataTable GetArticleByClassID(int CID, string orderBy, string orderWay, out int totalCount);

        /// <summary>
        /// 按照日期发布文章
        /// </summary>
        /// <param name="CID">类别编号</param>
        /// <param name="publishchild">是否发布其子栏目</param>
        /// <param name="orderBy">文章排序</param>
        /// <param name="totalCount">共有多少条</param>
        /// <returns></returns>
        DataTable GetArticleByTime(DateTime startTime, DateTime endTime, out int totalCount);

        /// <summary>
        /// 根据文章编号范围发布 
        /// </summary>
        /// <param name="minId">开始编号</param>
        /// <param name="maxId">结束编号</param>
        /// <param name="totalCount">共有几条数据</param>
        /// <returns></returns>
        DataTable GetArticleByID(int minId, int maxId, out int totalCount);

        /// <summary>
        /// 根据组合条件获取前多少条数据
        /// </summary>
        /// <param name="topnum">前多少条数据</param>
        /// <param name="orderBy">排序字段</param>
        /// <param name="orderWay">排序方式 desc asc</param>
        /// <param name="search">组合条件</param>
        /// <returns></returns>
        DataTable GetTopArticleBySearch(int topnum, string orderBy, string orderWay, string search);

        /// <summary>
        /// 获取当前类别的父类别集合
        /// </summary>
        /// <param name="CID">栏目编号</param>
        /// <returns>栏目集合</returns>
        List<Arc_Class> GetParentClassList(int CID);
    }
}
