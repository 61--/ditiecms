using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    public class SqlLoading
    {
        public static string Select<T>(SqlWhereCondition where, SqlSortCondition sort)
        {
            return Select<T>(null, where, sort);
        }

        public static string Select<T>(string fieldName,SqlWhereCondition where,SqlSortCondition sort)
        {
            string strSql="";
            if (fieldName == string.Empty || fieldName == null)
            {
                strSql = string.Format("select {0} from {1}{2}{3}", fieldName, typeof(T).Name, where.ToString(), sort.ToString());
            }
            else
            {
                strSql = string.Format("select * from {0}{1}{2}",typeof(T).Name, where.ToString(), sort.ToString());
            }
            //执行SQL语句，返回数据集
            return strSql;
        }
    }
}
