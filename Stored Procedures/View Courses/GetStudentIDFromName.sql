CREATE PROCEDURE GetStudentIDFromName @Name varchar(50)
AS
BEGIN
SELECT ID
FROM Student
WHERE Name=@Name
END
GO