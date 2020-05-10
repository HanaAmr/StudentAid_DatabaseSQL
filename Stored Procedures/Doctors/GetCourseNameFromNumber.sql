CREATE PROCEDURE GetCourseNameFromNumber @No int
AS
BEGIN
SELECT Name
FROM Courses
WHERE Course_No=@No
END
GO