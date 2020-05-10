

create PROCEDURE GetAllInfoOfInternshipByName
@Name varchar(50)
AS
BEGIN
	SELECT Internship_ID as Internship_ID , I.Name as Internship_Name , Link as Link, Start as [Start_date], EndDate as [End_Date],S.Name as Sponsor_Name
    From Internships as I  join Sponsors as S on Sponsor_ID=ID 
	where I.Name=@Name
END


