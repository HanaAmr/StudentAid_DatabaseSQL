CREATE PROCEDURE GetStudentUsernameFromName @Name varchar(50)
AS
BEGIN
SELECT Username
FROM Student
WHERE Name=@Name
END
GO