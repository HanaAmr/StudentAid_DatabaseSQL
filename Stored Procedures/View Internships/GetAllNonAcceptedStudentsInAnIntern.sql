CREATE PROCEDURE GetAllNonAcceptedStudentsInAnIntern @InternID int
AS
BEGIN
SELECT W.ID as Student_ID, W.Name as Student_Name  
FROM Student_Request_Internship as S , Student as W
where S.Internship_ID=@InternID and W.ID=S.Student_ID and S.Student_ID not in (
select Sp.Student_ID
from Sponsor_Accepts_Students_internships as Sp
where Sp.Internship_ID=@InternID)
END
GO