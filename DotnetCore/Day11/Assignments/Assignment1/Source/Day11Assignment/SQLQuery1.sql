create database Hospital

use hospital

create table Department(
DepartmentID int identity(1,1) PRIMARY KEY,
DepartmentName varchar(50)
)


INSERT INTO Department VALUES('Cancer'),
('ENT'),
('Physiotherapy')

create table Doctors(
DoctorID int identity(1,1) PRIMARY KEY,
DoctorName varchar(200),
Speciality varchar(50),
DepartmentID int FOREIGN KEY REFERENCES Department(DepartmentID)
)
INSERT INTO Doctors VALUES ('ABC', 'Physiotherapy', 3),
('cde', 'asthma', 2)
Create table HealthCareAssistant(
HCID int identity(1,1) PRIMARY KEY,
HCName varchar(100),
DepartmentID int FOREIGN KEY REFERENCES Department(DepartmentID)
)
INSERT INTO HealthCareAssistant VALUES ('XYZ', 1),
('JHK', 1),
('ryoyr', 2),
('feii', 2),
('sfguegf', 3),
('dfuge',3)

Create table Drugs(
DrugID int identity(1,1) PRIMARY KEY,
DrugName varchar(100)
)
INSERT INTO Drugs VALUES('abfuge'), ('suer'), ('dfuegriw'), ('hwe2we')

create table Patients(
PatientID int identity(1,1) PRIMARY KEY,
PatientName varchar(100),
Disease varchar(100),
DoctorID int FOREIGN KEY REFERENCES Doctors(DoctorID),
HCID int FOREIGN KEY REFERENCES HealthCareAssistant(HCID)
)
INSERT INTO Patients VALUES('hhh', 'ear pain', 2, 2),
('hhh', 'physiotherapy', 1, 3)
CREATE TABLE Prescription
(
PrescriptionID int identity(1,1),
PatientID int FOREIGN KEY REFERENCES Patients(PatientID),
DrugID int FOREIGN KEY REFERENCES Drugs(DrugID),
Morning bit,
AfterNoon bit,
Night bit
)

INSERT INTO Prescription VALUES (1, 1, 1,1,1)