/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [JobID]
      ,[JobTitle]
      ,[MinSalary]
      ,[MaxSalary]
  FROM [DbWithGui].[dbo].[JOBS]

  INSERT INTO Jobs VALUES(3, 'trainee', 3000, 8000)
  INSERT INTO Jobs VALUES(4, 'NETWORK EXECUTIVE', 10000, 20000)