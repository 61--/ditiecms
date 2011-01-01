-- �ַ�������ʵ�ֵ�ͨ�÷�ҳ�洢����
CREATE PROC [dbo].[UP_GetRecordByPage]  
@tbname     nvarchar(1000)='',               --Ҫ��ҳ��ʾ�ı���������ʹ�ñ�����  
@FieldKey   nvarchar(1000)='',               --���ڶ�λ��¼������(Ωһ��)�ֶ�,ֻ���ǵ����ֶ�  
@PageCurrent int=1,                 --Ҫ��ʾ��ҳ��  
@PageSize   int=10,                --ÿҳ�Ĵ�С(��¼��)  
@FieldShow  nvarchar(1000)='',      --�Զ��ŷָ���Ҫ��ʾ���ֶ��б�,�����ָ��,����ʾ�����ֶ�  
@FieldOrder  nvarchar(1000)='',     --�Զ��ŷָ��������ֶ��б�,����ָ�����ֶκ���ָ��DESC/ASC  
                                    -- ����ָ������˳��  
@Where     nvarchar(1000)='',      --��ѯ����  
@PageCount  int OUTPUT            --��ҳ��  
AS  
DECLARE @sql nvarchar(4000)  
SET NOCOUNT ON  

--��ҳ�ֶμ��  
IF ISNULL(@FieldKey,N'')=''  
BEGIN  
    RAISERROR(N'��ҳ������Ҫ����������Ωһ����',1,16)  
    RETURN  
END  
--����������鼰�淶  
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
--���@PageCountΪNULLֵ,�������ҳ��(������ƿ���ֻ�ڵ�һ�μ�����ҳ��,�Ժ����ʱ,����ҳ�����ظ��洢����,�����ٴμ�����ҳ��,���ڲ��������ҳ���Ĵ������,���Ը�@PageCount��ֵ)  
IF @PageCount IS NULL  
BEGIN  
    SET @sql=N'SELECT @PageCount=COUNT(*)'  
        +N' FROM '+@tbname  
        +N' '+@Where  
    EXEC sp_executesql @sql,N'@PageCount int OUTPUT',@PageCount OUTPUT  
    --SET @PageCount=(@PageCount+@PageSize-1)/@PageSize  
END  

--@PageCount�ܼ�¼��Ϊ0�˳�
IF @PageCount = 0
BEGIN
return 
END

--�����ҳ��ʾ��TOPNֵ  
DECLARE @TopN varchar(20),@TopN1 varchar(20)  
SELECT @TopN=@PageSize,  
    @TopN1=@PageCurrent*@PageSize      
--��һҳֱ����ʾ  
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
        --ִ�в�ѯ  
        EXEC (N'SELECT TOP '+@TopN  
            +N' '+@FieldShow  
            +N' FROM '+@tbname  
            +N' WHERE '+@FieldKey  
            +N' IN('+@sql  
            +N') '+@FieldOrder ) 
	END
END