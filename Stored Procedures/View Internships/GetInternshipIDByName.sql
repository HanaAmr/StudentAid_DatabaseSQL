CREATE PROCEDURE GetInternshipIDByName @Name varchar(50)
AS
BEGIN
SELECT Internship_ID
FROM Internships
WHERE Name=@Name
END
GO