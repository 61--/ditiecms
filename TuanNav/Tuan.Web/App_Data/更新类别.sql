DECLARE @count INT
DROP TABLE #temp_get
CREATE TABLE #temp_get(
	ID int IDENTITY(1,1), CID int,GetUrl varchar(255), IsPost tinyint
)
INSERT INTO #temp_get(CID,GetUrl,IsPost) SELECT * FROM Tn_Get WHERE Ispost=0 AND CID=29
SELECT @count=MAX(ID) FROM #temp_get
WHILE @count>0
BEGIN
	UPDATE TN_TuanGou SET CategoryID = 4 WHERE TuanUrl=(SELECT GetUrl FROM #temp_get WHERE ID=@count)
	SET @count=@count-1
END
