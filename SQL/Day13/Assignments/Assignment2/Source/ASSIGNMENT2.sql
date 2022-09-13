CREATE FUNCTION PT(@MONTHLY INT)
RETURNS FLOAT
AS
BEGIN 
DECLARE @PT int
SELECT @PT =
CASE
WHEN @Monthly < 6000 THEN 0
WHEN @Monthly between 6000 and 9000 THEN 80
WHEN @Monthly between 9000 and 12000 THEN 150
WHEN @Monthly >= 12000 THEN  200
ELSE 0
END
RETURN @PT
END


DECLARE @ANS INT
 SET @ANS= dbo.PT(1000)
 PRINT @ANS