CREATE PROCEDURE GetCourseNumberFromCourseName @Name varchar(50)
AS
BEGIN
SELECT Course_No
FROM Courses
WHERE Name=@Name
END
GO