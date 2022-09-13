CREATE TABLE employeeMod9(
Banking varchar(50),
Insurance varchar(50),
Services varchar(50)
)
SELECT Banking AS 'Bank_DEPT' FROM employeeMod9
SELECT Insurance AS 'Insurance_Dept'FROM employeeMod9
SELECT Services AS 'Services_Dept' FROM employeeMod9


DECLARE @StudentData NVARCHAR(MAX)
SET @StudentData = N'[
{"Student_name":"Parth","Address":"Anand","City":"Anand","DOB":"2000-01-09","Standard":"8th"},
{"Student_name":"Krutik","Address":"Anand","City":"Anand","DOB":"2000-04-06","Standard":"8th"},
{"Student_name":"Stuti","Address":"Ahmedabad","City":"Ahmedababd","DOB":"2000-19-04","Standard":"8th"},
{"Student_name":"Keyuri","Address":"Porbandar","City":"Ahmedababd","DOB":"1999-27-12","Standard":"8th"},
{"Student_name":"Chaitanya","Address":"Jamnanager","City":"Ahmedababd","DOB":"2000-15-09","Standard":"8th"}
]';
SELECT Student_Name,Address,City,DOB,Standard FROM OPENJSON(@StudentData)
WITH (
Student_name varchar(50) '$.Student_name',
Address Nvarchar(50) '$.Address',
City varchar(50) '$.City',
DOB NVarchar(50) '$.DOB',
Standard NVARCHAR(50) '$.Standard'
);