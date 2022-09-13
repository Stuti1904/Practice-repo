CREATE TABLE JobHistory(
EmployeeId int PRIMARY KEY,
 StartDate char(10) CHECK (StartDate LIKE '[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9]') , 
 End_Eate char(10) CHECK (EndDate LIKE '[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9]'), 
 Job_Id int,
 Department_Id int
 )