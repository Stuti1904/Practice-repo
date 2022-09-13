CREATE PROCEDURE PRCDemoProcedure @empid int =NULL
AS
BEGIN
IF(@empid IS NULL)
BEGIN
SELECT Department.NAME FROM HumanResources.Department JOIN HumanResources.EmployeeDepartmentHistory ON Department.DepartmentID=EmployeeDepartmentHistory.DepartmentID
END
ELSE
BEGIN
SELECT Department.NAME FROM HumanResources.Department JOIN HumanResources.EmployeeDepartmentHistory ON Department.DepartmentID=EmployeeDepartmentHistory.DepartmentID WHERE @empid=EmployeeDepartmentHistory.BusinessEntityID
END
END

EXECUTE PRCDemoProcedure 35