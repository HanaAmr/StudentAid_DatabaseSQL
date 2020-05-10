CREATE PROCEDURE GetAllAcceptedStudentsInASpecificInternship @Intern_ID int
AS
BEGIN
SELECT S.Name as Student_Name , S.ID as Student_ID
FROM Student as S join Sponsor_Accepts_Students_internships as Sp on S.ID=Sp.Student_ID join Internships as I on I.Internship_ID=Sp.Internship_ID
WHERE I.Internship_ID=@Intern_ID
END
GO