using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections.ObjectModel;

namespace Tuan.Data.SqlServer
{
    public class DeclareVariable
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = "@" + value;
            }
        }

        public SqlDbType DbType { get; set; }

        public int Size { get; set; }

        public void BuildDeclareVariableSql(StringBuilder builder)
        {
            BuildDeclareVariableSql(builder, this.Name, this.DbType, this.Size);
        }

        /// <summary>
        /// 生成类似 "@ParamName varchar(50)" 这样的声明字符串
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name"></param>
        /// <param name="dbType"></param>
        /// <param name="size"></param>
        public static void BuildDeclareVariableSql(StringBuilder builder, string name, SqlDbType dbType, int size)
        {
            builder.Append(name);
            builder.Append(" ");
            builder.Append(dbType.ToString().ToLower());

            switch (dbType)
            {
                case SqlDbType.Char:
                case SqlDbType.NChar:
                case SqlDbType.VarChar:
                case SqlDbType.NVarChar:
                case SqlDbType.VarBinary:
                    builder.Append("(");
                    builder.Append(size);
                    builder.Append(")");
                    break;
            }
        }
    }

    public class DeclareVariableCollection : Collection<DeclareVariable>
    {
        public void Add(string name, SqlDbType dbType, int size)
        {
            DeclareVariable variable = new DeclareVariable();
            variable.Name = name;
            variable.DbType = dbType;
            variable.Size = size;
            this.Add(variable);
        }

        public void Add(string name, SqlDbType dbType)
        {
            DeclareVariable variable = new DeclareVariable();
            variable.Name = name;
            variable.DbType = dbType;
            variable.Size = 0;
            this.Add(variable);
        }

        public void AddRange(IEnumerable<DeclareVariable> list)
        {
            foreach (DeclareVariable item in list)
            {
                this.Add(item);
            }
        }

        /// <summary>
        /// 生成类似
        /// DECLARE @ParamName varchar(50);
        /// DECLARE @ParamName2 int;
        /// 这样的声明字符串
        /// </summary>
        /// <returns></returns>
        public string GetDeclareVariableSql()
        {
            StringBuilder builder = new StringBuilder();
            BuildDeclareVariableSql(builder);
            return builder.ToString();
        }

        public void BuildDeclareVariableSql(StringBuilder builder)
        {
            if (this.Count > 0)
            {
                foreach (DeclareVariable variable in this)
                {
                    builder.Append("DECLARE ");
                    variable.BuildDeclareVariableSql(builder);
                    builder.AppendLine(";");
                }
            }
        }
    }
}
