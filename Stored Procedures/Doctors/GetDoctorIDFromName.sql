CREATE PROCEDURE GetDoctorIDFromName @Name varchar(50)
AS
BEGIN
SELECT ID
FROM Doctors
WHERE Name=@Name
END
GO