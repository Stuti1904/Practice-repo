/*CREATING SP FOR PRACTICE EXERCISE*/
/*AUTHOR'S NAME-- STUTI SHAHU*/
/*CREATION DATE-- 29TH JUNE 2022*/

CREATE PROCEDURE PRC_CountCustomers
AS
BEGIN 
SELECT CUSTOMER.CITY, COUNT(*) FROM CUSTOMER JOIN BRANCH ON CUSTOMER.CITY=BRANCH.CITY GROUP BY CUSTOMER.CITY
END

EXECUTE PRC_CountCustomers
SELECT * FROM BRANCH
SELECT * FROM CUSTOMER