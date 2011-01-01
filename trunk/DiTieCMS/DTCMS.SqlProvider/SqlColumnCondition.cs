using System;
using System.Collections.Generic;
using System.Text;

namespace DTCMS.SqlProvider
{
    public class SqlColumnCondition
    {
        private string fieldName="";
        private EDBType dbtype;

        public SqlColumnCondition(string fieldName,EDBType dbtype)
        {
            if (fieldName == string.Empty || fieldName == null) throw new ArgumentNullException("字段名不能为空！");

            this.fieldName = fieldName;
            this.dbtype = dbtype;
        }

        /// <summary>
        /// 字段名
        /// </summary>
        public string FieldName
        {
            get { return this.fieldName; }
        }

        #region 运算符重写 条件
        public static SqlWhereCondition operator >(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(s1.fieldName, fieldValue,s1.dbtype, OperateSign.GreatThan);
            return where;
        }
        public static SqlWhereCondition operator <(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(s1.fieldName, fieldValue, s1.dbtype, OperateSign.SmallThan);
            return where;
        }
        public static SqlWhereCondition operator >=(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(s1.fieldName, fieldValue, s1.dbtype, OperateSign.GreatThanEqual);
            return where;
        }
        public static SqlWhereCondition operator <=(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(s1.fieldName, fieldValue, s1.dbtype, OperateSign.SmallThanEqual);
            return where;
        }
        public static SqlWhereCondition operator ==(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(s1.fieldName, fieldValue, s1.dbtype, OperateSign.Equal);
            return where;
        }
        public static SqlWhereCondition operator !=(SqlColumnCondition s1, object fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(s1.fieldName, fieldValue, s1.dbtype, OperateSign.NotEqual);
            return where;
        }

        public SqlWhereCondition Like(string fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(this.fieldName, fieldValue, dbtype, OperateSign.Like);
            return where;
        }
        public SqlWhereCondition LeftLike(string fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(this.fieldName, fieldValue, dbtype, OperateSign.LeftLike);
            return where;
        }
        public SqlWhereCondition RightLike(string fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(this.fieldName, fieldValue, dbtype, OperateSign.RightLike);
            return where;
        }

        public SqlWhereCondition In(object fieldValue)
        {
            SqlWhereCondition where = new SqlWhereCondition(this.fieldName, fieldValue, dbtype, OperateSign.In);
            return where;
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
