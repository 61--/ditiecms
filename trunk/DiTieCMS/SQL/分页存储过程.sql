-- 字符串缓存实现的通用分页存储过程
CREATE PROC [dbo].[UP_GetRecordByPage]  
@tbname     nvarchar(1000)='',               --要分页显示的表名，可以使用表联合  
@FieldKey   nvarchar(1000)='',               --用于定位记录的主键(惟一键)字段,只能是单个字段  
@PageCurrent int=1,                 --要显示的页码  
@PageSize   int=10,                --每页的大小(记录数)  
@FieldShow  nvarchar(1000)='',      --以逗号分隔的要显示的字段列表,如果不指定,则显示所有字段  
@FieldOrder  nvarchar(1000)='',     --以逗号分隔的排序字段列表,可以指定在字段后面指定DESC/ASC  
                                    -- 用于指定排序顺序  
@Where     nvarchar(1000)='',      --查询条件  
@PageCount  int OUTPUT            --总页数  
AS  
DECLARE @sql nvarchar(4000)  
SET NOCOUNT ON  

--分页字段检查  
IF ISNULL(@FieldKey,N'')=''  
BEGIN  
    RAISERROR(N'分页处理需要主键（或者惟一键）',1,16)  
    RETURN  
END  
--其他参数检查及规范  
IF ISNULL(@PageCurrent,0)<1 SET @PageCurrent=1  
IF ISNULL(@PageSize,0)<1 SET @PageSize=10  
IF ISNULL(@FieldShow,N'')=N'' SET @FieldShow=N'*'  
IF ISNULL(@FieldOrder,N'')=N''  
    SET @FieldOrder=N''  
ELSE  IF CHARINDEX('ORDER BY',@FieldOrder)!=0
	SET @FieldOrder=LTRIM(@FieldOrder)
ELSE
    SET @FieldOrder=N'ORDER BY '+LTRIM(@FieldOrder)  
IF ISNULL(@Where,N'')=N''  
    SET @Where=N''  
ELSE  
    SET @Where=N'WHERE ('+@Where+N')'  
--如果@PageCount为NULL值,则计算总页数(这样设计可以只在第一次计算总页数,以后调用时,把总页数传回给存储过程,避免再次计算总页数,对于不想计算总页数的处理而言,可以给@PageCount赋值)  
IF @PageCount IS NULL  
BEGIN  
    SET @sql=N'SELECT @PageCount=COUNT(*)'  
        +N' FROM '+@tbname  
        +N' '+@Where  
    EXEC sp_executesql @sql,N'@PageCount int OUTPUT',@PageCount OUTPUT  
    --SET @PageCount=(@PageCount+@PageSize-1)/@PageSize  
END  

--@PageCount总记录数为0退出
IF @PageCount = 0
BEGIN
return 
END

--计算分页显示的TOPN值  
DECLARE @TopN varchar(20),@TopN1 varchar(20)  
SELECT @TopN=@PageSize,  
    @TopN1=@PageCurrent*@PageSize      
--第一页直接显示  
IF @PageCurrent=1  
    EXEC(N'SELECT TOP '+@TopN  
        +N' '+@FieldShow  
        +N' FROM '+@tbname  
        +N' '+@Where  
        +N' '+@FieldOrder)  
ELSE  
BEGIN  
    SELECT @PageCurrent=@TopN1,  
        @sql=N'SELECT @n=@n-1,@s=CASE WHEN @n<'+@TopN  
            +N' THEN @s+N'',''+QUOTENAME(RTRIM(CAST('+@FieldKey  
            +N' as varchar(8000))),N'''''''') ELSE N'''' END FROM '+@tbname  
            +N' '+@Where  
            +N' '+@FieldOrder  
    SET ROWCOUNT @PageCurrent  
    EXEC sp_executesql @sql,  
        N'@n int,@s nvarchar(4000) OUTPUT',  
        @PageCurrent,@sql OUTPUT  
    SET ROWCOUNT 0  
    IF @sql=N''  
        EXEC(N'SELECT TOP 0'  
            +N' '+@FieldShow  
            +N' FROM '+@tbname)  
    ELSE  
    BEGIN  
        SET @sql=STUFF(@sql,1,1,N'')          
        --执行查询  
        EXEC (N'SELECT TOP '+@TopN  
            +N' '+@FieldShow  
            +N' FROM '+@tbname  
            +N' WHERE '+@FieldKey  
            +N' IN('+@sql  
            +N') '+@FieldOrder ) 
	END
END