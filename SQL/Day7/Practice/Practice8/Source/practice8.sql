use AdventureWorks2019;
WITH Sales_CTE (SalesPersonID, SalesOrderID, SalesYear)
as
(
SELECT SalesPersonID, SalesOrderID, YEAR(OrderDate) AS SALESYEAR
FROM Sales.SalesOrderHeader where SalesPersonID IS NOT NULL
)
   SELECT SalesPersonID, COUNT(SalesOrderID) AS TotalSales, SalesYear  
    FROM Sales_CTE  
    GROUP BY SalesYear, SalesPersonID  
    ORDER BY SalesPersonID, SalesYear;
