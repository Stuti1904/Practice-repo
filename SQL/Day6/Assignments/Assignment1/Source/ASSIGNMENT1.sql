SELECT Salary FROM EMPLOYEE WHERE SALARY>(SELECT SALARY FROM EMPLOYEE WHERE First_Name='ROY')

CREATE VIEW IncentiveInfo AS 
SELECT EMPLOYEE.First_Name, EMPLOYEE.Last_Name, EMPLOYEE.Salary, EMPLOYEE.Joining_Date, INCENTIVE.INCENTIVE_DATE, INCENTIVE.INCENTIVE_AMOUNT FROM EMPLOYEE JOIN INCENTIVE ON EMPLOYEE.Emplpoyee_ID=INCENTIVE.Employee_Ref_ID

SELECT * FROM IncentiveInfo

CREATE VIEW IncentiveGreaterThan AS 
SELECT EMPLOYEE.First_Name, INCENTIVE.INCENTIVE_AMOUNT FROM EMPLOYEE JOIN INCENTIVE ON EMPLOYEE.Emplpoyee_ID= INCENTIVE.Employee_Ref_ID AND INCENTIVE.INCENTIVE_AMOUNT>3000
DROP VIEW IncentiveGreaterThan
SELECT * FROM IncentiveGreaterThan

