
SELECT HireDate FROM Employees
WHERE DATENAME(dw, HireDate) = 'Monday'