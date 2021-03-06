USE [updated2]
GO
/****** Object:  StoredProcedure [dbo].[GetPendingInternshipsOfAStudentByUsername]    Script Date: 12/23/2019 3:18:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetPendingInternshipsOfAStudentByUsername] @Username varchar(50)
AS
BEGIN
SELECT I.Name as Internship_Name , I.Start as [Start_Date] , I.EndDate as End_Date, I.Link as Internship_Link
FROM Student_Request_Internship as SRI , Student as S , Internships as I
WHERE S.ID= SRI.Student_ID and SRI.Internship_ID = I.Internship_ID and S.Username= @Username
except
 select I.Name as Internship_Name , I.Start as [Start_Date] , I.EndDate as End_Date, I.Link as Internship_Link
from Sponsor_Accepts_Students_internships as SAI , Student as S, Internships as I
where SAI.Student_ID = S.ID and Username=@Username and SAI.Internship_ID= I.Internship_ID

END





