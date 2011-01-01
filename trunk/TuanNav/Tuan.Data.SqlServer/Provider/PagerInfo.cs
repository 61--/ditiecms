using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Tuan.Common;

namespace Tuan.Data.SqlServer
{
    public class PagerInfo
    {
        private int _pageSize;

        /// <summary>
        /// 每页显示的记录数
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        private int _pageNumber = 1;

        /// <summary>
        /// 页码
        /// </summary>
        public int PageNumber
        {
            get { return _pageNumber <= 0 ? 1 : _pageNumber; }
            set { _pageNumber = value; }
        }

        private string _tableName;

        /// <summary>
        /// 要查询的表名或视图名
        /// </summary>
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }

        private bool _withNolock = true;

        /// <summary>
        /// 查询时是否加入 WITH (NOLOCK) 语句
        /// </summary>
        public bool WithNolock
        {
            get { return _withNolock; }
            set { _withNolock = value; }
        }

        private string _resultFields = "*";

        /// <summary>
        /// 获取或设置要查询的字段
        /// </summary>
        public string ResultFields
        {
            get { return _resultFields; }
            set { _resultFields = value; }
        }

        private string _primaryKey;

        /// <summary>
        /// 获取或设置分页表的主键
        /// 请注意：仅当SortField属性指定的字段不是唯一的情况下，才一定需要设置本属性
        /// 设置了本属性后，将使用全TOP模式处理分页，可以处理SortField不是唯一字段的分页
        /// </summary>
        public string PrimaryKey
        {
            get { return _primaryKey; }
            set { _primaryKey = value; }
        }

        private string _sortField;

        /// <summary>
        /// 获取或设置分页的排序依据。
        /// 请注意：如果此字段不是唯一的，必须同时指定PrimaryKey（主键）属性，否则将无法得到正确的分页数据
        /// </summary>
        public string SortField
        {
            get { return _sortField; }
            set { _sortField = value; }
        }

        private bool _isDesc = true;

        /// <summary>
        /// 获取或设置分页查询是否倒序。不指定本属性默认为倒序
        /// </summary>
        public bool IsDesc
        {
            get { return _isDesc; }
            set { _isDesc = value; }
        }

        private string _condition;

        /// <summary>
        /// 获取或设置分页查询的条件。不指定本属性默认为取所有数据
        /// </summary>
        public string Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        private int? _totalRecords;

        /// <summary>
        /// 预先设置分页查询的结果的总记录数。此属性并不是必须的，因为大部分情况并不知道结果的总记录数。
        /// 提供此属性是为了以下情况提高性能：
        /// 查询某一页的数据的时候，得到了总记录数，此时把总记录数缓存起来，
        /// 下次再查询任意一页，因为缓存中已经存在，那只需要直接将缓存中的值赋值到这个属性即可，可以极大提高性能
        /// 注意：不能与TotalRecordsVariable一起使用
        /// </summary>
        public int? TotalRecords
        {
            private get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        private string _totalRecordsVariable;
        /// <summary>
        /// 预先设置分页查询的结果的总记录数由此变量提供。此属性并不是必须的，因为大部分情况并不知道结果的总记录数。
        /// 提供此属性是为了以下情况提高性能：
        /// 已经有另外的表专门记录了记录条数，在BeforeExecute里面已经从这个表查询到了正确的总结果数并保存在一个临时变量中，
        /// 那只需要直接将这个临时变量名赋值到这个属性即可，可以极大提高性能
        /// 注意：不能与TotalRecords一起使用
        /// </summary>
        public string TotalRecordsVariable
        {
            private get { return _totalRecordsVariable; }
            set { _totalRecordsVariable = value; }
        }

        private DeclareVariableCollection m_BeforeExecuteDealcre;

        public DeclareVariableCollection BeforeExecuteDealcre
        {
            get
            {
                DeclareVariableCollection declare = m_BeforeExecuteDealcre;
                if (declare == null)
                {
                    declare = new DeclareVariableCollection();
                    m_BeforeExecuteDealcre = declare;
                }
                return declare;
            }
            set { m_BeforeExecuteDealcre = value; }
        }

        private string _beforeExecute;

        /// <summary>
        /// 在分页查询执行之前需要执行的sql
        /// </summary>
        public string BeforeExecute
        {
            get { return _beforeExecute; }
            set { _beforeExecute = value; }
        }

        private string _afterExecute;

        /// <summary>
        /// 在分页查询执行之后需要执行的sql
        /// </summary>
        public string AfterExecute
        {
            get { return _afterExecute; }
            set { _afterExecute = value; }
        }

        private bool _selectCount;

        /// <summary>
        /// 获取或设置是否在返回数据结果集之后，再返回一个单行、单列的结果集标识总记录数。如果已经指定了TotalRecords属性，那么返回的总记录数将直接使用TotalRecords，而不会重新到数据库查询
        /// </summary>
        public bool SelectCount
        {
            get { return _selectCount; }
            set { _selectCount = value; }
        }

        private int _offset = 0;

        /// <summary>
        /// 偏移量
        /// </summary>
        public int Offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        internal string CreateCommandText(SqlParameterCollection parameters)
        {
            StringBuilder sb = new StringBuilder();

            if (BeforeExecuteDealcre != null)
            {
                BeforeExecuteDealcre.BuildDeclareVariableSql(sb);
            }

            sb.AppendLine(BeforeExecute);

            sb.AppendLine(CreatePagedSelect(ResultFields, TableName, WithNolock, PrimaryKey, Condition, parameters, BeforeExecuteDealcre, SortField, IsDesc, PageNumber, PageSize, Offset, SelectCount, TotalRecords));

            sb.AppendLine(AfterExecute);

            return sb.ToString();
        }

        internal CommandType GetCommandType()
        {
            return CommandType.Text;
        }

        internal string CreatePagedSelect(string selectFields, string tableName, bool withNolock, string primaryKey, string condition, SqlParameterCollection parameters, DeclareVariableCollection beforeExecuteDeclare, string sortField, bool isDesc, int pageNumber, int pageSize, int offset, bool returnTotalRecords, int? totalRecords)
        {
            if (string.IsNullOrEmpty(selectFields))
                throw new ArgumentNullException("selectFields");

            if (string.IsNullOrEmpty(tableName))
                throw new ArgumentNullException("tableName");

            if (pageSize < 1)
                throw new ArgumentException("每页显示的记录数不能为0", "pageSize");

            string tableNameWithNolock;

            if (string.IsNullOrEmpty(sortField))
            {
                if (string.IsNullOrEmpty(primaryKey))
                    throw new ArgumentNullException("必须指定sortField和primaryKey其中的一个", "sortField");
                else
                    sortField = primaryKey;
            }

            if (primaryKey != string.Empty && string.Compare(primaryKey, sortField, true) == 0)
                primaryKey = string.Empty;

            if (withNolock)
                tableNameWithNolock = tableName + " WITH (NOLOCK)";
            else
                tableNameWithNolock = tableName;

            string desc = isDesc ? " DESC" : " ASC";
            string primaryKeyDesc;

            if (string.IsNullOrEmpty(primaryKey))
                primaryKeyDesc = string.Empty;
            else
                primaryKeyDesc = isDesc ? string.Concat(",", primaryKey, " DESC") : string.Concat(",", primaryKey, " ASC");

            if (pageNumber < 1)
                pageNumber = 1;

            //是否知道总记录数
            bool knowTotalRecords = (totalRecords != null && totalRecords.Value > -1);

            bool hasWhere = string.IsNullOrEmpty(condition) == false;
            string whereString = hasWhere ? " WHERE " + condition : " ";

            //是否在sql中已经声明了TotalRecords变量
            bool declareTotalRecords = false;

            StringBuffer sqlBuilder = new StringBuffer();

            //在已知总记录数的情况下，以下情况直接返回0条数据  --  passed
            if (
                (
                    knowTotalRecords
                    &&
                    (
                //已知没有数据
                        totalRecords.Value == 0
                        ||
                //页码已经超过最后一页
                        (
                        pageNumber > 1
                        &&
                        (pageSize * (pageNumber - 1)) >= (totalRecords.Value + offset)
                        )
                    )
                )
                ||
                //Offset已经大到本页面已经不需要取任何数据
                (
                    offset > 0
                    &&
                    (pageSize * pageNumber) <= offset
                )
               )
            {
                sqlBuilder += string.Concat(@"SELECT TOP 0 ", selectFields, " FROM ", tableName, " WITH (NOLOCK);");
            }

            //取第一页，使用最简单高效的方式：top查询  --  passed
            else if (offset / pageSize == pageNumber - 1)
            {
                #region TOP方式取第一页数据

                //sql server 2005 及更高版本，top参数化
                if (SqlHelper.SqlVersion > 8)
                {
                    sqlBuilder += string.Concat("SELECT TOP (@_Top) ", selectFields, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, desc, primaryKeyDesc, ";");

                    SqlParameter topParam = new SqlParameter("@_Top", SqlDbType.Int);
                    topParam.Value = pageSize - offset % pageSize;
                    parameters.Add(topParam);

                }
                //sql server 2000 ，top没有优化
                else
                {
                    sqlBuilder += string.Concat("SELECT TOP ", (pageSize - offset % pageSize).ToString(), " ", selectFields, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, desc, primaryKeyDesc, ";");
                }

                #endregion
            }


            //最后一页，直接top查询，并颠倒结果  --  passed
            else if (
                knowTotalRecords
                &&
                (pageSize * pageNumber) >= (totalRecords.Value + offset)
                )
            {
                #region TOP方式取最后一页数据

                string tempDesc = isDesc ? " ASC" : " DESC";
                string tempPrimaryKeyDesc;

                if (string.IsNullOrEmpty(primaryKey))
                    tempPrimaryKeyDesc = string.Empty;
                else
                    tempPrimaryKeyDesc = isDesc ? string.Concat(",", primaryKey, " ASC") : string.Concat(",", primaryKey, " DESC");

                int top = (totalRecords.Value + offset) % pageSize;
                if (top == 0)
                    top = pageSize - offset % pageSize;

                //sql server 2005 及更高版本，top参数化
                if (SqlHelper.SqlVersion > 8)
                {

                    sqlBuilder += string.Concat(@"
SELECT * FROM (
    SELECT TOP (@_Top) ", selectFields, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, tempDesc, tempPrimaryKeyDesc, @"
) AS t1 ORDER BY ", sortField, desc, primaryKeyDesc, ";");

                    SqlParameter topParam = new SqlParameter("@_Top", SqlDbType.Int);
                    topParam.Value = top;
                    parameters.Add(topParam);

                }
                //sql server 2000 ，top没有优化
                else
                {
                    sqlBuilder += string.Concat(@"
SELECT * FROM (
    SELECT TOP ", top.ToString(), " ", selectFields, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, tempDesc, tempPrimaryKeyDesc, @"
) AS t1 ORDER BY ", sortField, desc, primaryKeyDesc, ";");

                }

                #endregion
            }

            //没有指定主键，使用MAX/MIN方式来分页，SortField必须是唯一字段  --  doing
            else if (string.IsNullOrEmpty(primaryKey))
            {

                #region MIN/MAX分页模式

                //如果是sql server 2005及更高版本，可以使用 top @参数 来优化查询，提高查询计划的复用程度，改善性能和内存占用
                if (SqlHelper.SqlVersion > 8)
                {

                    #region sql server 2005以上版本的处理

                    //如果已知总记录数，则可以马上推算出到底是否需要逆向查询以提高性能
                    //(逆向查询指：如果要查询的页数超过总页数的一般，则倒过来查询数据。例如：最后一页的数据应该使用 top 直接查询)
                    if (totalRecords != null && totalRecords.Value > -1)
                    {
                        #region 复杂逻辑...

                        string minOrMax, tempDesc, op;
                        int topMax = pageSize * (pageNumber - 1);

                        if (topMax - offset > totalRecords.Value / 2)
                        {
                            minOrMax = isDesc ? "MAX" : "MIN";
                            op = isDesc ? "<=" : ">=";
                            tempDesc = isDesc ? " ASC" : " DESC";
                            topMax = totalRecords.Value - topMax + offset;
                        }
                        else
                        {
                            minOrMax = isDesc ? "MIN" : "MAX";
                            op = isDesc ? "<" : ">";
                            tempDesc = isDesc ? " DESC" : " ASC";
                            topMax -= offset;
                        }

                        sqlBuilder += string.Concat(@"
SELECT TOP (@_Size) ", selectFields, @" FROM ", tableNameWithNolock, whereString, (hasWhere ? " AND " : " WHERE "), sortField, op, @"
    (SELECT ", minOrMax, "(", sortField, @") FROM (SELECT TOP (@_TopMax) ", sortField, @" FROM ", tableNameWithNolock, whereString, @" ORDER BY ", sortField, tempDesc, @") AS t1)
ORDER BY ", sortField, desc, @"
");

                        SqlParameter pageSizeParam = new SqlParameter("@_Size", SqlDbType.Int);
                        pageSizeParam.Value = pageSize;
                        parameters.Add(pageSizeParam);

                        SqlParameter topMaxParam = new SqlParameter("@_TopMax", SqlDbType.Int);
                        topMaxParam.Value = topMax;
                        parameters.Add(topMaxParam);

                        #endregion
                    }

                    //不知道总记录数，则需要在sql内部计算到底是否需要逆向查询来提高性能
                    else
                    {
                        #region 更复杂逻辑...

                        declareTotalRecords = true;

                        string tempDesc = isDesc ? " ASC" : " DESC";

                        sqlBuilder += @"
DECLARE @_Total int;
DECLARE @_TopMax int;
";

                        if (string.IsNullOrEmpty(TotalRecordsVariable) == false)
                        {
                            sqlBuilder += "SELECT @_Total = ";
                            sqlBuilder += TotalRecordsVariable;
                            sqlBuilder += ";";
                        }
                        else
                        {
                            sqlBuilder += "SELECT @_Total = COUNT(*) FROM ";
                            sqlBuilder += tableName;
                            if (WithNolock)
                                sqlBuilder += " WITH (NOLOCK) ";
                            sqlBuilder += whereString;
                            sqlBuilder += ";";
                        }

                        sqlBuilder += string.Concat(@"
SET @_TopMax = @_Size * (@_Number - 1);

--out page
IF (
    (@_Total = 0)
    OR
    (@_Number > 1 AND @_TopMax >= (@_Total + @_Offset))
    )
    SELECT TOP 0 ", selectFields, " FROM ", tableName, @" WITH (NOLOCK);

--last page
ELSE IF (@_Size * @_Number) >= (@_Total + @_Offset) BEGIN
    SET @_TopMax = (@_Total + @_Offset) % @_Size;
    IF @_TopMax = 0
        SET @_TopMax = @_Size - (@_Offset % @_Size);

    SELECT * FROM (
        SELECT TOP (@_TopMax) ", selectFields, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, tempDesc, @"
    ) AS t1 ORDER BY ", sortField, desc, @";
END
");

                        //查询页数超过10页的时候才自动优化，否则提高不了太多性能，却反而使sql语句变得更长
                        if (pageNumber - (offset / pageSize) > 10)
                        {
                            sqlBuilder += string.Concat(@"
ELSE IF (@_TopMax - @_Offset) > (@_Total / 2) BEGIN
    SET @_TopMax = @_Total - @_TopMax + @_Offset;

    SELECT TOP (@_Size) ", selectFields, " FROM ", tableNameWithNolock, whereString, (hasWhere ? " AND " : " WHERE "), sortField, (isDesc ? "<" : ">"), @"=
        (SELECT ", (isDesc ? "MAX" : "MIN"), "(", sortField, ") FROM (SELECT TOP (@_TopMax) ", sortField, @" FROM ", tableNameWithNolock, whereString, @" ORDER BY ", sortField, tempDesc, @") AS t1)
    ORDER BY ", sortField, desc, @";
END
");
                        }

                        sqlBuilder += string.Concat(@"
ELSE BEGIN
    SET @_TopMax = @_TopMax - @_Offset;

    SELECT TOP (@_Size) ", selectFields, " FROM ", tableNameWithNolock, whereString, (hasWhere ? " AND " : " WHERE "), sortField, (isDesc ? "<" : ">"), @"
        (SELECT ", (isDesc ? "MIN" : "MAX"), "(", sortField, ") FROM (SELECT TOP (@_TopMax) ", sortField, @" FROM ", tableNameWithNolock, whereString, @" ORDER BY ", sortField, desc, @") AS t1)
    ORDER BY ", sortField, desc, @";

END
");

                        SqlParameter pageSizeParam = new SqlParameter("@_Size", SqlDbType.Int);
                        pageSizeParam.Value = pageSize;
                        parameters.Add(pageSizeParam);

                        SqlParameter pageNumberParam = new SqlParameter("@_Number", SqlDbType.Int);
                        pageNumberParam.Value = pageNumber;
                        parameters.Add(pageNumberParam);

                        SqlParameter offsetParam = new SqlParameter("@_Offset", SqlDbType.Int);
                        offsetParam.Value = offset;
                        parameters.Add(offsetParam);

                        #endregion
                    }

                    #endregion

                }
                else
                {
                    #region sql server 2000版本的处理

                    //如果已知总记录数，则可以马上推算出到底是否需要逆向查询以提高性能
                    //(逆向查询指：如果要查询的页数超过总页数的一般，则倒过来查询数据。例如：最后一页的数据应该使用 top 直接查询)
                    if (totalRecords != null && totalRecords.Value > -1)
                    {

                        #region 复杂逻辑...

                        string minOrMax, tempDesc, op;
                        int topMax = pageSize * (pageNumber - 1);

                        if (topMax - offset > totalRecords.Value / 2)
                        {
                            minOrMax = isDesc ? "MAX" : "MIN";
                            op = isDesc ? "<=" : ">=";
                            tempDesc = isDesc ? " ASC" : " DESC";
                            topMax = totalRecords.Value - topMax + offset;
                        }
                        else
                        {
                            minOrMax = isDesc ? "MIN" : "MAX";
                            op = isDesc ? "<" : ">";
                            tempDesc = isDesc ? " DESC" : " ASC";
                            topMax -= offset;
                        }

                        sqlBuilder += string.Concat(@"
SELECT TOP ", pageSize.ToString(), " ", selectFields, @" FROM ", tableNameWithNolock, whereString, (hasWhere ? " AND " : " WHERE "), sortField, op, @"
    (SELECT ", minOrMax, "(", sortField, @") FROM (SELECT TOP ", topMax.ToString(), " ", sortField, @" FROM ", tableNameWithNolock, whereString, @" ORDER BY ", sortField, tempDesc, @") AS t1)
ORDER BY ", sortField, desc, @"
");

                        #endregion

                    }

                    //不知道总记录数，则需要在sql内部计算到底是否需要逆向查询来提高性能
                    else
                    {

                        #region 更复杂逻辑...

                        int topMax = pageSize * (pageNumber - 1);

                        declareTotalRecords = true;

                        string tempDesc = isDesc ? " ASC" : " DESC";

                        string paramString = buildParamStringForExecuteSql(beforeExecuteDeclare, condition, parameters);

                        sqlBuilder += @"
DECLARE @_Total int;
DECLARE @_TopMax int;
DECLARE @_Sql nvarchar(4000);
";

                        if (string.IsNullOrEmpty(TotalRecordsVariable) == false)
                        {
                            sqlBuilder += "SELECT @_Total = ";
                            sqlBuilder += TotalRecordsVariable;
                            sqlBuilder += ";";
                        }
                        else
                        {
                            sqlBuilder += "SELECT @_Total = COUNT(*) FROM ";
                            sqlBuilder += tableName;
                            if (WithNolock)
                                sqlBuilder += " WITH (NOLOCK) ";
                            sqlBuilder += whereString;
                            sqlBuilder += ";";
                        }

                        sqlBuilder += string.Concat(@"
SET @_TopMax = @_Size * (@_Number - 1);

--out page
IF (
    (@_Total = 0)
    OR
    (@_Number > 1 AND @_TopMax >= (@_Total + @_Offset))
    )
    SELECT TOP 0 ", selectFields, " FROM ", tableName, @" WITH (NOLOCK);

--last page
ELSE IF (@_Size * @_Number) >= (@_Total + @_Offset) BEGIN
    SET @_TopMax = (@_Total + @_Offset) % @_Size;
    IF @_TopMax = 0
        SET @_TopMax = @_Size - (@_Offset % @_Size);

    SET @_Sql = N'SELECT * FROM (
        SELECT TOP ' + CAST(@_TopMax AS varchar(9)) + N' ", selectFields, " FROM ", tableNameWithNolock, whereString.Replace("'", "''"), " ORDER BY ", sortField, tempDesc, @"
    ) AS t1 ORDER BY ", sortField, desc, @"';

    EXEC sp_executesql @_Sql", paramString, @";
END
");

                        //查询页数超过10页的时候才自动优化，否则提高不了太多性能，却反而使sql语句变得更长
                        if (pageNumber - (offset / pageSize) > 10)
                        {
                            sqlBuilder += string.Concat(@"
ELSE IF (@_TopMax - @_Offset) > (@_Total / 2) BEGIN
    SET @_TopMax = @_Total - @_TopMax + @_Offset;

    SET @_Sql = N'SELECT TOP ", pageSize.ToString(), " ", selectFields, " FROM ", tableNameWithNolock, whereString.Replace("'", "''"), (hasWhere ? " AND " : " WHERE "), sortField, (isDesc ? "<" : ">"), @"=
        (SELECT ", (isDesc ? "MAX" : "MIN"), "(", sortField, ") FROM (SELECT TOP ' + CAST(@_TopMax AS varchar(9)) + N' ", sortField, @" FROM ", tableNameWithNolock, whereString.Replace("'", "''"), @" ORDER BY ", sortField, tempDesc, @") AS t1)
    ORDER BY ", sortField, desc, @"';

    EXEC sp_executesql @_Sql", paramString, @";
END
");
                        }

                        sqlBuilder += string.Concat(@"
ELSE BEGIN
    --SET @_TopMax = @_TopMax - @_Offset;

    SELECT TOP ", pageSize.ToString(), " ", selectFields, " FROM ", tableNameWithNolock, whereString, (hasWhere ? " AND " : " WHERE "), sortField, (isDesc ? "<" : ">"), @"
        (SELECT ", (isDesc ? "MIN" : "MAX"), "(", sortField, ") FROM (SELECT TOP ", (topMax - offset).ToString(), " ", sortField, @" FROM ", tableNameWithNolock, whereString, @" ORDER BY ", sortField, desc, @") AS t1)
    ORDER BY ", sortField, desc, @";

END
");

                        SqlParameter pageSizeParam = new SqlParameter("@_Size", SqlDbType.Int);
                        pageSizeParam.Value = pageSize;
                        parameters.Add(pageSizeParam);

                        SqlParameter pageNumberParam = new SqlParameter("@_Number", SqlDbType.Int);
                        pageNumberParam.Value = pageNumber;
                        parameters.Add(pageNumberParam);

                        SqlParameter offsetParam = new SqlParameter("@_Offset", SqlDbType.Int);
                        offsetParam.Value = offset;
                        parameters.Add(offsetParam);

                        #endregion

                    }

                    #endregion
                }

                #endregion

            }
            //指定了主键，使用全TOP方式来分页，并且可以处理SortField并不是唯一字段的情况
            else
            {

                //if (offset != 0)
                //    throw new NotSupportedException("指定了主键的分页方式不支持偏移分页(Offset必需为0)");

                #region TOP分页模式

                //如果是sql server 2005及更高版本，可以使用 top @参数 来优化查询，提高查询计划的复用程度，改善性能和内存占用
                if (SqlHelper.SqlVersion > 8)
                {
                    #region sql server 2005以上版本的处理


                    //如果已知总记录数，则可以马上推算出到底是否需要逆向查询以提高性能
                    //(逆向查询指：如果要查询的页数超过总页数的一般，则倒过来查询数据。例如：最后一页的数据应该使用 top 直接查询)
                    if (totalRecords != null && totalRecords.Value > -1)
                    {

                        #region 复杂逻辑...

                        string tempDesc1, tempDesc2;
                        int topMax = pageSize * pageNumber;

                        if (topMax - offset > totalRecords.Value / 2)
                        {
                            tempDesc1 = isDesc ? " ASC" : " DESC";
                            tempDesc2 = isDesc ? " DESC" : " ASC";
                            topMax = totalRecords.Value - topMax + pageSize + offset;
                        }
                        else
                        {
                            tempDesc1 = isDesc ? " DESC" : " ASC";
                            tempDesc2 = isDesc ? " ASC" : " DESC";
                            topMax -= offset;
                        }

                        sqlBuilder += string.Concat(@"

SELECT ", selectFields, " FROM ", tableNameWithNolock, " WHERE ", primaryKey, @" IN (
    SELECT TOP (@_Size) ", primaryKey, @" FROM (
        SELECT TOP (@_TopMax) ", primaryKey, ",", sortField, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, tempDesc1, ",", primaryKey, tempDesc1, @"
    ) AS t1 ORDER BY ", sortField, tempDesc2, ",", primaryKey, tempDesc2, @"
) ORDER BY ", sortField, desc, ",", primaryKey, desc, @";
");

                        SqlParameter pageSizeParam = new SqlParameter("@_Size", SqlDbType.Int);
                        pageSizeParam.Value = pageSize;
                        parameters.Add(pageSizeParam);

                        SqlParameter topMaxParam = new SqlParameter("@_TopMax", SqlDbType.Int);
                        topMaxParam.Value = topMax;
                        parameters.Add(topMaxParam);


                        #endregion

                    }

                    //不知道总记录数，则需要在sql内部计算到底是否需要逆向查询来提高性能
                    else
                    {

                        #region 更复杂逻辑...

                        declareTotalRecords = true;

                        string tempDesc = isDesc ? " ASC" : " DESC";

                        sqlBuilder += @"
DECLARE @_Total int;
DECLARE @_TopMax int;
";

                        if (string.IsNullOrEmpty(TotalRecordsVariable) == false)
                        {
                            sqlBuilder += "SELECT @_Total = ";
                            sqlBuilder += TotalRecordsVariable;
                            sqlBuilder += ";";
                        }
                        else
                        {
                            sqlBuilder += "SELECT @_Total = COUNT(*) FROM ";
                            sqlBuilder += tableName;
                            if (WithNolock)
                                sqlBuilder += " WITH (NOLOCK) ";
                            sqlBuilder += whereString;
                            sqlBuilder += ";";
                        }

                        sqlBuilder += string.Concat(@"
SET @_TopMax = @_Size * @_Number;

--out page
IF (
    (@_Total = 0)
    OR
    (@_Number > 1 AND (@_Size * (@_Number - 1)) >= (@_Total + @_Offset))
    )
    SELECT TOP 0 ", selectFields, " FROM ", tableName, @" WITH (NOLOCK);

--last page
ELSE IF @_TopMax >= (@_Total + @_Offset) BEGIN
    SET @_TopMax = (@_Total + @_Offset) % @_Size;
    IF @_TopMax = 0
        SET @_TopMax = @_Size - (@_Offset % @_Size);

    SELECT * FROM (
        SELECT TOP (@_TopMax) ", selectFields, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, tempDesc, ",", primaryKey, tempDesc, @"
    ) AS t1 ORDER BY ", sortField, desc, ",", primaryKey, desc, @";
END
");

                        //查询页数超过10页的时候才自动优化，否则提高不了太多性能，却反而使sql语句变得更长
                        if (pageNumber - (offset / pageSize) > 10)
                        {
                            sqlBuilder += string.Concat(@"
ELSE IF (@_TopMax - @_Offset) > (@_Total / 2) BEGIN
    SET @_TopMax = @_Total - @_TopMax + @_Size + @_Offset;

    SELECT ", selectFields, " FROM ", tableNameWithNolock, " WHERE ", primaryKey, @" IN (
	    SELECT TOP (@_Size) ", primaryKey, @" FROM (
		    SELECT TOP (@_TopMax) ", primaryKey, ",", sortField, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, tempDesc, ",", primaryKey, tempDesc, @"
	    ) AS t1 ORDER BY ", sortField, desc, ",", primaryKey, desc, @"
    ) ORDER BY ", sortField, desc, ",", primaryKey, desc, @";
END
");
                        }

                        sqlBuilder += string.Concat(@"
ELSE BEGIN
    SET @_TopMax = @_TopMax - @_Offset;

    SELECT ", selectFields, " FROM ", tableNameWithNolock, " WHERE ", primaryKey, @" IN (
	    SELECT TOP (@_Size) ", primaryKey, @" FROM (
		    SELECT TOP (@_TopMax) ", primaryKey, ",", sortField, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, desc, ",", primaryKey, desc, @"
	    ) AS t1 ORDER BY ", sortField, tempDesc, ",", primaryKey, tempDesc, @"
    ) ORDER BY ", sortField, desc, ",", primaryKey, desc, @";
END
");

                        SqlParameter pageSizeParam = new SqlParameter("@_Size", SqlDbType.Int);
                        pageSizeParam.Value = pageSize;
                        parameters.Add(pageSizeParam);

                        SqlParameter pageNumberParam = new SqlParameter("@_Number", SqlDbType.Int);
                        pageNumberParam.Value = pageNumber;
                        parameters.Add(pageNumberParam);

                        SqlParameter offsetParam = new SqlParameter("@_Offset", SqlDbType.Int);
                        offsetParam.Value = offset;
                        parameters.Add(offsetParam);

                        #endregion

                    }

                    #endregion
                }
                else
                {
                    #region sql server 2000的处理

                    //如果已知总记录数，则可以马上推算出到底是否需要逆向查询以提高性能
                    //(逆向查询指：如果要查询的页数超过总页数的一般，则倒过来查询数据。例如：最后一页的数据应该使用 top 直接查询)
                    if (totalRecords != null && totalRecords.Value > -1)
                    {
                        #region 复杂逻辑...

                        string tempDesc1, tempDesc2;
                        int topMax = pageSize * pageNumber;

                        if (topMax - offset > totalRecords.Value / 2)
                        {
                            tempDesc1 = isDesc ? " ASC" : " DESC";
                            tempDesc2 = isDesc ? " DESC" : " ASC";
                            topMax = totalRecords.Value - topMax + pageSize + offset;
                        }
                        else
                        {
                            tempDesc1 = isDesc ? " DESC" : " ASC";
                            tempDesc2 = isDesc ? " ASC" : " DESC";
                            topMax -= offset;
                        }

                        sqlBuilder += string.Concat(@"

SELECT ", selectFields, " FROM ", tableNameWithNolock, " WHERE ", primaryKey, @" IN (
    SELECT TOP ", pageSize.ToString(), " ", primaryKey, @" FROM (
        SELECT TOP ", topMax.ToString(), " ", primaryKey, ",", sortField, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, tempDesc1, ",", primaryKey, tempDesc1, @"
    ) AS t1 ORDER BY ", sortField, tempDesc2, ",", primaryKey, tempDesc2, @"
) ORDER BY ", sortField, desc, ",", primaryKey, desc, @";
");

                        #endregion
                    }
                    //不知道总记录数，则需要在sql内部计算到底是否需要逆向查询来提高性能
                    else
                    {
                        #region 更复杂逻辑...

                        declareTotalRecords = true;

                        int topMax = pageSize * pageNumber;
                        string tempDesc = isDesc ? " ASC" : " DESC";

                        string paramString = buildParamStringForExecuteSql(beforeExecuteDeclare, condition, parameters);

                        sqlBuilder += @"
DECLARE @_Total int;
DECLARE @_TopMax int;
DECLARE @_Sql nvarchar(4000);
";

                        if (string.IsNullOrEmpty(TotalRecordsVariable) == false)
                        {
                            sqlBuilder += "SELECT @_Total = ";
                            sqlBuilder += TotalRecordsVariable;
                            sqlBuilder += ";";
                        }
                        else
                        {
                            sqlBuilder += "SELECT @_Total = COUNT(*) FROM ";
                            sqlBuilder += tableName;
                            if (WithNolock)
                                sqlBuilder += " WITH (NOLOCK) ";
                            sqlBuilder += whereString;
                            sqlBuilder += ";";
                        }

                        sqlBuilder += string.Concat(@"
SET @_TopMax = @_Size * @_Number;

--out page
IF (
    (@_Total = 0)
    OR
    (@_Number > 1 AND (@_Size * (@_Number - 1)) >= (@_Total + @_Offset))
    )
    SELECT TOP 0 ", selectFields, " FROM ", tableName, @" WITH (NOLOCK);

--last page
ELSE IF @_TopMax >= (@_Total + @_Offset) BEGIN
    SET @_TopMax = (@_Total + @_Offset) % @_Size;
    IF @_TopMax = 0
        SET @_TopMax = @_Size - (@_Offset % @_Size);

    SET @_Sql = N'SELECT * FROM (
        SELECT TOP ' + CAST(@_TopMax AS varchar(9)) + N' ", selectFields, " FROM ", tableNameWithNolock, whereString.Replace("'", "''"), " ORDER BY ", sortField, tempDesc, ",", primaryKey, tempDesc, @"
    ) AS t1 ORDER BY ", sortField, desc, ",", primaryKey, desc, @"';

    EXEC sp_executesql @_Sql", paramString, @";
END
");
                        //查询页数超过10页的时候才自动优化，否则提高不了太多性能，却反而使sql语句变得更长
                        if (pageNumber - (offset / pageSize) > 10)
                        {
                            sqlBuilder += string.Concat(@"
ELSE IF (@_TopMax - @_Offset) > (@_Total / 2) BEGIN
    SET @_TopMax = @_Total - @_TopMax + @_Size + @_Offset;

    SET @_Sql = N'SELECT ", selectFields, " FROM ", tableNameWithNolock, " WHERE ", primaryKey, @" IN (
	    SELECT TOP ", pageSize.ToString(), " ", primaryKey, @" FROM (
		    SELECT TOP ' + CAST(@_TopMax AS varchar(9)) + N' ", primaryKey, ",", sortField, " FROM ", tableNameWithNolock, whereString.Replace("'", "''"), " ORDER BY ", sortField, tempDesc, ",", primaryKey, tempDesc, @"
	    ) AS t1 ORDER BY ", sortField, desc, ",", primaryKey, desc, @"
    ) ORDER BY ", sortField, desc, ",", primaryKey, desc, @"';

    EXEC sp_executesql @_Sql", paramString, @";
END
");
                        }

                        sqlBuilder += string.Concat(@"
ELSE BEGIN
    --SET @_TopMax = @_TopMax - @_Offset;

    SELECT ", selectFields, " FROM ", tableNameWithNolock, " WHERE ", primaryKey, @" IN (
	    SELECT TOP ", pageSize.ToString(), " ", primaryKey, @" FROM (
		    SELECT TOP ", (topMax - offset).ToString(), " ", primaryKey, ",", sortField, " FROM ", tableNameWithNolock, whereString, " ORDER BY ", sortField, desc, ",", primaryKey, desc, @"
	    ) AS t1 ORDER BY ", sortField, tempDesc, ",", primaryKey, tempDesc, @"
    ) ORDER BY ", sortField, desc, ",", primaryKey, desc, @";
END
");

                        SqlParameter pageSizeParam = new SqlParameter("@_Size", SqlDbType.Int);
                        pageSizeParam.Value = pageSize;
                        parameters.Add(pageSizeParam);

                        SqlParameter pageNumberParam = new SqlParameter("@_Number", SqlDbType.Int);
                        pageNumberParam.Value = pageNumber;
                        parameters.Add(pageNumberParam);

                        SqlParameter offsetParam = new SqlParameter("@_Offset", SqlDbType.Int);
                        offsetParam.Value = offset;
                        parameters.Add(offsetParam);

                        #endregion
                    }

                    #endregion
                }

                #endregion

            }

            //如果需要返回总记录数，返回。如果已经知道总记录数，此处无需再取
            if (returnTotalRecords)
            {
                if (string.IsNullOrEmpty(this.TotalRecordsVariable) == false)
                {
                    sqlBuilder += "\r\nSELECT ";
                    sqlBuilder += this.TotalRecordsVariable;
                    sqlBuilder += ";";
                }

                else if (knowTotalRecords || declareTotalRecords)
                {
                    sqlBuilder += "\r\nSELECT @_Total;";

                    if (knowTotalRecords)
                    {
                        SqlParameter totalRecordsParam = new SqlParameter("@_Total", SqlDbType.Int);
                        totalRecordsParam.Value = totalRecords.Value;
                        parameters.Add(totalRecordsParam);
                    }
                }

                else
                {
                    sqlBuilder += "SELECT COUNT(*) FROM ";
                    sqlBuilder += tableName;
                    if (WithNolock)
                        sqlBuilder += " WITH (NOLOCK) ";
                    sqlBuilder += whereString;
                    sqlBuilder += ";";
                }
            }


            return sqlBuilder.ToString();
        }

        /// <summary>
        /// 生成sp_executesql专用的参数字符串
        /// </summary>
        /// <param name="beforeExecuteDeclare"></param>
        /// <param name="condition"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private string buildParamStringForExecuteSql(DeclareVariableCollection beforeExecuteDeclare, string condition, SqlParameterCollection parameters)
        {
            if (string.IsNullOrEmpty(condition))// || parameters == null || parameters.Count == 0)
                return string.Empty;

            if (
                (beforeExecuteDeclare == null || beforeExecuteDeclare.Count == 0)
                &&
                (parameters == null || parameters.Count == 0)
                )
            {
                return string.Empty;
            }

            StringBuilder paramDeclare = new StringBuilder();
            StringBuilder paramValues = new StringBuilder();

            if (parameters != null && parameters.Count > 0)
            {
                #region 根据参数列表生成sp_executesql专用的参数字符串

                foreach (SqlParameter param in parameters)
                {
                    if (condition.IndexOf(param.ParameterName) == -1)
                        continue;

                    paramDeclare.Append(",");

                    DeclareVariable.BuildDeclareVariableSql(paramDeclare, param.ParameterName, param.SqlDbType, param.Size);

                    paramValues.Append(",");
                    paramValues.Append(param.ParameterName);
                    paramValues.Append("=");
                    paramValues.Append(param.ParameterName);
                }

                #endregion
            }

            if (beforeExecuteDeclare != null && beforeExecuteDeclare.Count > 0)
            {
                #region 根据BeforeExecute的变量声明列表生成sp_executesql专用的参数字符串

                foreach (DeclareVariable declare in beforeExecuteDeclare)
                {
                    if (condition.IndexOf(declare.Name) == -1)
                        continue;

                    paramDeclare.Append(",");

                    declare.BuildDeclareVariableSql(paramDeclare);

                    paramValues.Append(",");
                    paramValues.Append(declare.Name);
                    paramValues.Append("=");
                    paramValues.Append(declare.Name);
                }

                #endregion
            }

            if (paramDeclare.Length > 0)
            {
                paramDeclare.Insert(1, "N'");
                paramDeclare.Append("'");
                paramDeclare.Append(paramValues.ToString());
            }

            return paramDeclare.ToString();
        }
    }
}
