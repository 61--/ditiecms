//------------------------------------------------------------------------------
// 创建标识: Copyright (C) 2010 91aspx.com 版权所有
// 创建描述: DTCMS V1.0 创建于 2010-02-06 23:35:36
// 功能描述: 数据组装对象
// 修改标识: 
// 修改描述: 
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    /// <summary>
    /// 数据组装对象
    /// </summary>
    public class SqlWhereCondition
    {
        private string where;
        public static SqlWhereCondition Default = new SqlWhereCondition();

        public SqlWhereCondition(){}
        /// <summary>
        /// 构造组装对象
        /// </summary>
        /// <param name="fieldName">字段名</param>
        /// <param name="fieldValue">字段值</param>
        /// <param name="dbtype">字段类型，默认字符串</param>
        /// <param name="operateSign">操作符</param>
        public SqlWhereCondition(string fieldName,object fieldValue, DBType dbtype, string operateSign)
        {
            switch (dbtype)
            {
                case DBType.NUMBER:
                    where = string.Format(fieldName + operateSign, fieldValue);
                    break;
                default:
                    where = string.Format(fieldName + operateSign, "'" + fieldValue + "'");
                    break;
            }
        }

        /// <summary>
        /// And
        /// </summary>
        public static SqlWhereCondition operator &(SqlWhereCondition s1, SqlWhereCondition s2)
        {
            if (s1.Where == string.Empty && s2.Where != string.Empty)
            {
                s1.Where = s2.Where;
            }
            else if (s1.Where != string.Empty && s2.Where != string.Empty)
            {
                s1.where = string.Format(" {0} AND {1}", s1.where,s2.where);
            }

            return s1;
        }

        /// <summary>
        /// Or
        /// </summary>
        public static SqlWhereCondition operator |(SqlWhereCondition s1, SqlWhereCondition s2)
        {
            if (s1.Where == string.Empty && s2.Where != string.Empty)
            {
                s1.where = s2.where;
            }
            else if (s1.Where != string.Empty && s2.Where != string.Empty)
            {
                s1.where = string.Format(" {0} OR {1}",s1.where,s2.where);
            }

            return s1;
        }

        private string Where
        {
            set { this.where = value; }
            get { return this.where; }
        }

       /// <summary>
       /// 返回where语句
       /// </summary>
       /// <returns></returns>
        public override string ToString()
        {
            return string.Format(" WHERE {0}", this.where);
        }
    }
}
