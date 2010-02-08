using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    public class SqlColumnCondition
    {
        private string fieldName;

        public SqlColumnCondition(string fieldName)
        {
            this.fieldName = fieldName;
        }

        #region 运算符重写 条件
        public static SqlWhereCondition operator >(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(s1.fieldName,fieldValue,EDBType.NUMBER,OperateSign.GreatThan);
            return s;
        }
        public static SqlWhereCondition operator <(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(s1.fieldName, fieldValue, EDBType.NUMBER, OperateSign.SmallThan);
            return s;
        }
        public static SqlWhereCondition operator >=(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(s1.fieldName, fieldValue, EDBType.NUMBER, OperateSign.GreatThanEqual);
            return s;
        }
        public static SqlWhereCondition operator <=(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(s1.fieldName, fieldValue, EDBType.NUMBER, OperateSign.SmallThanEqual);
            return s;
        }
        public static SqlWhereCondition operator ==(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(s1.fieldName, fieldValue, EDBType.NUMBER, OperateSign.Equal);
            return s;
        }
        public static SqlWhereCondition operator !=(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(s1.fieldName, fieldValue, EDBType.NUMBER, OperateSign.NotEqual);
            return s;
        }

        public SqlWhereCondition Like(string fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(this.fieldName, fieldValue, EDBType.VARCHAR, OperateSign.Like);
            return s;
        }
        public SqlWhereCondition LeftLike(string fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(this.fieldName, fieldValue, EDBType.VARCHAR, OperateSign.LeftLike);
            return s;
        }
        public SqlWhereCondition RightLike(string fieldValue)
        {
            SqlWhereCondition s = new SqlWhereCondition(this.fieldName, fieldValue, EDBType.VARCHAR, OperateSign.RightLike);
            return s;
        }

        public SqlWhereCondition In(object fieldValue,EDBType dbtype)
        {
            SqlWhereCondition s = new SqlWhereCondition(this.fieldName, fieldValue, dbtype, OperateSign.In);
            return s;
        }
        #endregion 运算符重写 条件

        #region 运算符重写 排序
        public SqlSortCondition DESC
        {
            get
            {
                return new SqlSortCondition(this.fieldName, ESortSign.DESC);
            }
        }
        public SqlSortCondition ASC
        {
            get
            {
                return new SqlSortCondition(this.fieldName, ESortSign.ASC);
            }
        }
        #endregion 运算符重写 排序

        #region 方法重写
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion 方法重写
    }
}
