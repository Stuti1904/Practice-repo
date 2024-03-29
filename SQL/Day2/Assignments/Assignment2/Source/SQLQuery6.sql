SELECT * FROM Employees /*GET ALL EMPLOYEE DETAILS*/

SELECT FirstName, LastName FROM Employees /*GET FIRST NAME AND LAST NAME OF THE EMPLOYEES*/

SELECT FirstName AS EmployeeName FROM Employees /*GET FIRST NAME USING ALIAS "EmployeeName"*/

UPDATE Employees SET FirstName = 'Steven' WHERE EmployeeID=2

UPDATE Employees SET FirstName = 'Neena' WHERE EmployeeID=104

UPDATE Employees SET FirstName = 'Lex' WHERE EmployeeID=160

SELECT *FROM Employees WHERE FirstName= 'Steven' OR FirstName='Neena' OR FirstName= 'Lex'/*GET EMPLOYEE DETAILS WHERE FIRSTNAME IS EITHER OF THESE THREE*/

SELECT * FROM Employees WHERE NOT FirstName= 'Neena' /*GET THE EMPLOYEE DETAILS WHOSE FIRSTNAME ISNT NEENA*/

SELECT *FROM Employees WHERE Salary>=5000 AND Salary<=8000 /*GET THE EMPLOYEE'S DETAILS WHOSE SALARY IS BETWEEN 5000 AND 8000 */

ALTER TABLE Employees ADD  PF int


ALTER TABLE Employees ALTER COLUMN PF DECIMAL

UPDATE Employees SET PF= Salary*0.12 /*SET THE PF VALUES ACCORDING TO THE GIVEN CONDITION PF=12%OF SALARY*/

SELECT * FROM Employees WHERE FirstName LIKE'N%' /*GET THE EMPLOYEES WHOSE FIRSTNAME BEGINS WITH A 'N'*/

SELECT  DISTINCT DepartmentID  FROM Employees /*GET THE DISTINCT DEPARTMENTID FROM THE EMPLOYEES TABLE*/

SELECT * FROM Employees ORDER BY FirstName DESC /*GET THE EMPLOYEE DETAILS SORTED BY FIRSTNAME IN DESCENDING ORDER*/

SELECT EmployeeID, FirstName, LastName, Salary FROM Employees ORDER BY Salary /*GET THE COLUMNS FIRSTNAME, LASTNAME, EMPLOYEEID AND SALARY WHICH ARE SORTED IN ASCENDING ORDER*/

SELECT TOP 2 SALARY FROM EMPLOYEES

