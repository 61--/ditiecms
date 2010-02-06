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
        private string fieldName;
        private SortSign sign;

        /// <summary>
        /// 需要排序的列名
        /// </summary>
        public string FieldName
        {
            get { return this.fieldName; }
        }
        /// <summary>
        /// 排序标识
        /// </summary>
        public SortSign SortSign
        {
            get { return this.sign; }
        }

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="fieldName">需要排序的列名</param>
        /// <param name="sign">排序标识</param>
        public SqlSortCondition(string fieldName, SortSign sign) 
        {
            this.fieldName = fieldName;
            this.sign = sign;
        }
    }
}
