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
        public static SqlSortCondition Default = new SqlSortCondition();

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
                this.fieldName = string.Format("Order by {0} {1}", fieldName, sortSign.ToString());
            }
        }        

        /// <summary>
        /// 添加排序
        /// </summary>
        /// <param name="filedName"></param>
        /// <param name="sortSign"></param>
        public void Append(string filedName, ESortSign sortSign)
        {
            if (filedName == string.Empty || filedName==null) throw new ArgumentNullException("需要排序的列名称不能为空!");;

            if (this.fieldName == string.Empty || this.fieldName==null)
            {
                this.fieldName = string.Format("Order by {0} {1}",filedName,sortSign.ToString());
            }
            else
            {
                this.fieldName += string.Format(", {0} {1}",filedName,sortSign.ToString());
            }
        }

        /// <summary>
        /// 需要排序的列名
        /// </summary>
        public string FieldName
        {
            get { return this.fieldName; }
        }

        /// <summary>
        /// 返回排序字符串
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.fieldName;
        }
    }
}
