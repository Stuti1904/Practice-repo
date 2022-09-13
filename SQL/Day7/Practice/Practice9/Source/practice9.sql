WITH SALES_CTE (SalesPersonID, SalesOrderID, SalesYear)
AS
(
SELECT SalesPersonID, SalesOrderID, YEAR(OrderDate)
FROM Sales.SalesOrderHeader
WHERE SalesPersonID IS NOT NULL
)
SELECT SalesPersonID, COUNT(SalesOrderID) AS TotalSales, SalesYear
FROM SALES_CTE GROUP BY SalesYear, SalesPersonID
ORDER BY SalesPersonID, SalesYear