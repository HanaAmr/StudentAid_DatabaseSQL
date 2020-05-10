CREATE PROCEDURE GetInternshipsOfASpecificSponsorUsingName @Name varchar(50)
AS
BEGIN
SELECT I.Internship_ID ,I.Name as Internship_Name , Link, Start as [Start_Date], EndDate as End_Date
FROM Internships as I join Sponsors as S on I.Sponsor_ID=S.ID
WHERE S.Name=@Name
END
GO