CREATE TABLE Department(
DepartmentID int PRIMARY KEY,
DepartmentName varchar(50),
)

INSERT INTO Department VALUES(1, 'HR')

INSERT INTO Department VALUES(2, 'Developers')

CREATE TABLE Employees(
Employee_Id int PRIMARY KEY,
FirstName varchar(50),
LastName varchar(50),
Email varchar(100),
PhoneNumber int,
HireDate date,
JobID int FOREIGN KEY REFERENCES Jobs(JobID),
Salary int,
Comission int,
ManagerID int,
DepartmentID int FOREIGN KEY REFERENCES Department(DepartmentID)
)

INSERT INTO Employees VALUES (1, 'stuti', 'shahu', 'stutishahu19@gmail.com', 9106754761,'2001-04-19', 2, 90000, 3000, 7, 1)