//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-02-06 23:35:36
// 功能描述: 数据参数集合
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    /// <summary>
    /// 数据参数集合
    /// </summary>
    public class SqlLoading
    {
        //private IList<SqlWhereCondition> wList = new List<SqlWhereCondition>();
        //private IList<SqlSortCondition> sList = new List<SqlSortCondition>();

        //#region 组装条件对象
        ///// <summary>
        ///// 组装条件对象
        ///// </summary>
        ///// <param name="fieldName">列名称</param>
        ///// <param name="fieldValue">列值</param>
        ///// <param name="joinSign">操作符 如果为空 Add</param>
        ///// <param name="operateSign">连接符 如果为空 Equal</param>
        //public void AddSqlWhere(string fieldName, object fieldValue, JoinSign joinSign, OperateSign operateSign)
        //{
        //    if (fieldName.Trim().Length == 0)
        //    {
        //        throw new ArgumentNullException("列名称不能为空!");
        //    }

        //    wList.Add(new SqlWhereCondition(fieldName, fieldValue, joinSign, operateSign));
        //}

        ///// <summary>
        ///// 组装条件对象
        ///// </summary>
        ///// <param name="fieldName">列名称</param>
        ///// <param name="fieldValue">列值</param>
        ///// <param name="joinSign">操作符 如果为空 Add</param>
        ///// <param name="operateSign">连接符 如果为空 Equal</param>
        //public void AddSqlWhere(string fieldName, object fieldValue, OperateSign operateSign)
        //{
        //    AddSqlWhere(fieldName, fieldValue, JoinSign.None, operateSign);
        //}

        ///// <summary>
        ///// 组装条件对象
        ///// </summary>
        ///// <param name="fieldName">列名称</param>
        ///// <param name="fieldValue">列值</param>
        ///// <param name="joinSign">操作符 如果为空 Add</param>
        ///// <param name="operateSign">连接符 如果为空 Equal</param>
        //public void AddSqlWhere(string fieldName, object fieldValue, JoinSign joinSign)
        //{
        //    AddSqlWhere(fieldName, fieldValue, joinSign, OperateSign.Equal);
        //}

        ///// <summary>
        ///// 组装条件对象
        ///// </summary>
        ///// <param name="fieldName">列名称</param>
        ///// <param name="fieldValue">参数值</param>
        //public void AddSqlWhere(string fieldName, object fieldValue)
        //{
        //    AddSqlWhere(fieldName, fieldValue, JoinSign.None, OperateSign.Equal);
        //}
        //#endregion

        //#region 组装排序对象

        ///// <summary>
        ///// 装载排序
        ///// </summary>
        ///// <param name="fieldName">列名称</param>
        ///// <param name="sign">排序标示</param>
        //public void AddSqlSort(string fieldName, SortSign sign)
        //{
        //    if (fieldName.Trim().Length == 0)
        //        throw new ArgumentNullException("需要排序的列名称不能为空!");

        //    sList.Add(new SqlSortCondition(fieldName, sign));
        //}
        //#endregion

        ///// <summary>
        ///// 获得where和order语句
        ///// </summary>
        ///// <returns>where和order语句</returns>
        //public string GetSqlString()
        //{
        //    string sqlWhere = InternalSqlWhereString();
        //    string sqlOrder = InternalSqlOrderString();
        //    return string.Concat(sqlWhere, sqlOrder);
        //}

        ///// <summary>
        ///// 获得where语句
        ///// </summary>
        ///// <returns>where语句</returns>
        //public string GetSqlWhereString()
        //{
        //    return InternalSqlWhereString();
        //}

        ///// <summary>
        ///// 获得order语句
        ///// </summary>
        ///// <returns>order语句</returns>
        //public string GetSqlOrderString()
        //{
        //    return InternalSqlOrderString();
        //}

        ///// <summary>
        ///// 内部装载where语句
        ///// </summary>
        //private string InternalSqlWhereString()
        //{
        //    int count = wList.Count;
        //    if (count == 0)
        //        return string.Empty;

        //    StringBuilder sqlWhere = new StringBuilder();
        //    sqlWhere.Append(" WHERE ");

        //    foreach (SqlWhereCondition item in this.wList)
        //    {
        //        sqlWhere.Append(item.JoinSign.Sign).Append(item.FieldName);
        //        sqlWhere.AppendFormat(item.OperateSign.Sign, item.FieldValue);
        //    }
        //    return sqlWhere.ToString();
        //}

        ///// <summary>
        ///// 内部装载order by语句
        ///// </summary>
        //private string InternalSqlOrderString()
        //{
        //    int count = this.sList.Count;
        //    if (count == 0)
        //        return string.Empty;

        //    StringBuilder sqlOrder = new StringBuilder();
        //    sqlOrder.Append(" ORDER BY ");
        //    SqlSortCondition item;
        //    for (int i = 0; i < count; i++)
        //    {
        //        item = this.sList[i];
        //        sqlOrder.Append(item.FieldName).Append(item.SortSign.Sign);

        //        if (i != count - 1)
        //            sqlOrder.Append(" , ");
        //    }
        //    return sqlOrder.ToString();
        //}
    }
}
