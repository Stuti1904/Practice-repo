/*MULTIPLE RESULTS WITH STORED PROCEDURES*/


CREATE PROCEDURE dbo.uspMultipleResults
AS
SELECT TOP(10) BusinessEntityID, Lastname, FirstName FROM Person.Person;
SELECT TOP(10) CustomerID, AccountNumber FROM Sales.Customer;
GO

EXECUTE dbo.uspMultipleResults