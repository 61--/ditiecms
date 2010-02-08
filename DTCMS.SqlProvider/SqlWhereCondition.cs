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
        private string where = "";

        public SqlWhereCondition() {}
        /// <summary>
        /// 构造组装对象
        /// </summary>
        /// <param name="fieldName">列名称</param>
        /// <param name="parameterName">参数名称</param>
        /// <param name="parameterValue">参数值</param>
        /// <param name="joinSign">操作符</param>
        /// <param name="operateSign">连接符</param>
        public SqlWhereCondition(string fieldName, object fieldValue, EDBType dbtype, string operateSign)
        {
            if (fieldName == string.Empty || fieldName == null) throw new ArgumentNullException("字段名不能为空!");
            if (fieldValue == null) throw new ArgumentNullException("字段值不能为空!");

            switch (dbtype)
            {
                case EDBType.NUMBER:
                case EDBType.INNUMBER:
                case EDBType.LIKE:
                    where = string.Format(fieldName + operateSign, fieldValue.ToString());
                    break;
                case EDBType.INVARCHAR:
                    string[] values = fieldValue.ToString().Split(',');
                    StringBuilder value = new StringBuilder();
                    for (int i = 0, count = values.Length; i < count; i++)
                    {
                        value.Append("'" + values[i] + "',");
                    }
                    where = string.Format(fieldName + operateSign, value.Remove(value.Length - 1, 1).ToString());
                    break;
                case EDBType.DATETIME:
                case EDBType.VARCHAR:
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
            if (s1.where == string.Empty && s2.where != string.Empty)
            {
                s1.where = s2.where.ToLower();
            }
            else if (s1.where != string.Empty && s2.where != string.Empty)
            {
                s1.where = string.Format("{0} AND {1}", s1.where.ToLower(), s2.where.ToLower());
            }

            return s1;
        }

        /// <summary>
        /// Or
        /// </summary>
        public static SqlWhereCondition operator |(SqlWhereCondition s1, SqlWhereCondition s2)
        {
            if (s1.where == string.Empty && s2.where != string.Empty)
            {
                s1.where = s2.where.ToLower();
            }
            else if (s1.where != string.Empty && s2.where != string.Empty)
            {
                s1.where = string.Format("{0} OR {1}", s1.where.ToLower(), s2.where.ToLower());
            }

            return s1;
        }

        public string Where
        {
            set { this.where = value; }
            get { return string.Format(" WHERE {0}", this.where); }
        }

        public override string ToString()
        {
            return string.Format(" WHERE {0}", this.where);
        }
    }
}
