
SELECT * FROM Employees



INSERT INTO Department VALUES(110, 'HouseKeeping')

INSERT INTO Employees VALUES (2, 'GGG', 'HHHHH', 'JJJ', 8303990736, '1980-05-03', 2, 60000, 1000, 8, 110)

ALTER TABLE Employees ALTER COLUMN Comission DECIMAL

UPDATE Employees
SET Email = 'Not available'

UPDATE Employees SET Comission= Comission+Comission*0.10

UPDATE Employees
SET Email = 'Not available'
WHERE DepartmentID=110

UPDATE Employees
SET Comission= Comission+Comission*0.10
WHERE DepartmentID=110


INSERT INTO Department VALUES(80, 'Acounting ')
INSERT INTO Employees VALUES (105, 'ABC', 'DEF', 'GHI', 8160672563, '1980-05-03', 2, 60000, 1000, 8, 80)

UPDATE Employees SET Comission= 0

UPDATE Employees SET Comission= 20 WHERE EmployeeID=1
UPDATE Employees SET Comission= 25 WHERE EmployeeID=2
UPDATE Employees SET Comission= 14 WHERE EmployeeID=105

UPDATE Employees SET Email= 'NOT AVAILABLE!' WHERE DepartmentID=80

UPDATE Employees SET Salary= 8000 WHERE EmployeeID=105 AND Salary<5000

INSERT INTO Department VALUES(40, 'TRAINEES')

INSERT INTO Department VALUES(90, 'NETWORK TEAM')

INSERT INTO Employees VALUES (160, 'JKL', 'MNO', 'TTHHH@gmail.com', 9725017102, '1978-03-07', 3, 16000, 12, 10, 90)

UPDATE Employees SET Salary=6000 WHERE EmployeeID=160

INSERT INTO Employees VALUES (104, 'STU', 'WXY', 'NNNNNNNNN@GMAIL.COM', 9510017101, '2010-09-04', 4, 16000, 12, 4, 40)

UPDATE Employees SET Salary= Salary+ Salary*0.25 WHERE DepartmentID=40

UPDATE Employees SET Salary= Salary+ Salary*0.15 WHERE DepartmentID=90

UPDATE Employees SET Salary= Salary+ Salary*0.10 WHERE DepartmentID=110



