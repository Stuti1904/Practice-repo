alter TRIGGER ondelete
ON Doctors
INSTEAD OF DELETE
AS
BEGIN
UPDATE Patients 
SET DoctorID=NULL
WHERE DoctorID  IN (SELECT DoctorID FROM deleted)
DELETE FROM Doctors
WHERE DoctorID IN (SELECT DoctorID FROM deleted)
END

DELETE FROM Doctors WHERE DoctorID=3