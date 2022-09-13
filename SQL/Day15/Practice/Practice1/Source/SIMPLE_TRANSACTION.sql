/*TRANSACTION EXAMPLE*/

BEGIN TRANSACTION TR1
BEGIN TRY
UPDATE Person.EmailAddress
SET EmailAddress= 'JOLYN@YAHOO.COM'
WHERE BusinessEntityID=101
UPDATE Person.BusinessEntityAddress
SET AddressID=328
WHERE BusinessEntityID=1
COMMIT TRANSACTION TR1
SELECT 'TRANSACTION EXECUTED'
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION TR1
SELECT 'TRANSACTION ROLLBACK'
END CATCH