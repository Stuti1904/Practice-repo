WITH cust AS(SELECT emp.Emplpoyee_ID,emp.First_name,emp.Last_name,emp.Joining_date,inc.Incentive_date FROM Employee as emp INNER JOIN incentive as inc on emp.Emplpoyee_ID = inc.Employee_Ref_ID)
SELECT First_name,Last_name,DATEDIFF(yy,Joining_date,Incentive_date) as Total_DIff from cust


WITH cust AS(SELECT * FROM employee as emp INNER JOIN incentive as inc on emp.Emplpoyee_ID = inc.Employee_Ref_ID)
SELECT First_name,Incentive_amount FROM cust WHERE INCENTIVE_AMOUNT> 3000


WITH cust AS(SELECT * FROM employee as emp LEFT OUTER JOIN incentive as inc on emp.Emplpoyee_ID = inc.Employee_Ref_ID)
SELECT * FROM CUST


WITH cust AS(SELECT emp.First_name,emp.Manager_Id from employee as emp)
SELECT * FROM cust


WITH cust AS(SELECT * FROM employee as emp full OUTER JOIN incentive as inc on emp.Emplpoyee_ID = inc.Employee_Ref_ID)
SELECT Emplpoyee_ID,First_name,isnull(Incentive_amount,0) as incentive_amount from cust where Incentive_amount is NULL