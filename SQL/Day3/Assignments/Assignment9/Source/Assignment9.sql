DECLARE @dateone datetime
DECLARE @datetwo datetime

SET @dateone= '1960-01-01'
SET @datetwo= '1980-01-01'


SELECT FIRSTNAME, HIREDATE FROM Employees WHERE HIREDATE between @dateone AND @datetwo