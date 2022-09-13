CREATE TABLE Jobs(
JobID int PRIMARY KEY not null,
JobTitle varchar(50) not null,
MinSalary int not null DEFAULT 8000,
MaxSalary int
)
INSERT INTO Jobs (JobID) VALUES( 1)

INSERT INTO Jobs (JObID, JobTitle, MinSalary) VALUES(2, 'HR', 15000)