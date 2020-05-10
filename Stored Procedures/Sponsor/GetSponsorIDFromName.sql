CREATE PROCEDURE GetSponsorIDFromName @Name varchar(50)
AS
BEGIN
SELECT ID
FROM Sponsors
WHERE Name=@Name
END
GO