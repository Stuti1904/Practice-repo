/*AGGREGATE FUNCTIONS*/

SELECT SUM(SALARY) FROM Employees

SELECT AVG(SALARY) FROM Employees

/*GROUP BY*/

SELECT JOBTITLE FROM HumanResources.Employee GROUP BY JobTitle

SELECT JOBTITLE, GENDER FROM HumanResources.Employee GROUP BY  ROLLUP(JOBTITLE, Gender)

SELECT SalesOrderID, SUM(LineTotal) AS SubTotal FROM Sales.SalesOrderDetail GROUP BY SalesOrderID HAVING SUM(LineTotal)>100000 order by SalesOrderID

SELECT  DENSE_RANK() OVER(ORDER BY VACATIONHOURS) FROM HumanResources.Employee

SELECT  RANK() OVER(ORDER BY VACATIONHOURS) FROM HumanResources.Employee

