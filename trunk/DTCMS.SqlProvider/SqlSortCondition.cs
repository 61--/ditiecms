//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-02-06 23:35:36
// 功能描述: 排序对象条件
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    /// <summary>
    /// 排序对象
    /// </summary>
    public class SqlSortCondition
    {
        private string sort="";

        public SqlSortCondition() { }
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="fieldName">需要排序的列名</param>
        /// <param name="sign">排序标识</param>
        public SqlSortCondition(string fieldName, ESortSign sortSign)
        {
            if (fieldName != string.Empty && fieldName != null)
            {
                this.sort = string.Format("{0} {1}", fieldName, sortSign.ToString());
            }
        }

        public static SqlSortCondition operator &(SqlSortCondition s1, SqlSortCondition s2)
        {
            if (s1.sort == string.Empty && s2.sort != string.Empty)
            {
                s1.sort = s2.sort.ToLower();
            }
            else if (s1.sort != string.Empty && s2.sort != string.Empty)
            {
                s1.sort = string.Format("{0},{1}", s1.sort.ToLower(), s2.sort.ToLower());
            }
            return s1;
        }

        /// <summary>
        /// 需要排序的列名
        /// </summary>
        public string Sort
        {
            get { return string.Format(" ORDER BY {0}",this.sort);}
        }

        /// <summary>
        /// 返回排序字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(" ORDER BY {0}", this.sort); ;
        }
    }
}
