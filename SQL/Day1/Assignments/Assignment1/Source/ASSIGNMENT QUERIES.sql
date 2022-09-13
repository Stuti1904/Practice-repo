CREATE DATABASE CarBusiness

CREATE TABLE Employees(
EmployeeID int PRIMARY KEY,
EmployeeName varchar(100),
JoiningDate date,
NumberOfSales int,
Experience int,
Commission int
)

CREATE TABLE Inventory(
CarID int PRIMARY KEY,
CarCompanyName varchar(50),
CarModel varchar(50),
CarColor varchar(50),
Stock int,
FuelType varchar(10),
Price int,
)
CREATE TABLE Sales(
SaleID int PRIMARY KEY,
DateOfSale date,
SoldThrough int FOREIGN KEY REFERENCES  Employees(EmployeeID),
ModelSold int FOREIGN KEY REFERENCES Inventory(CarID)
)