USE [updated2]
GO
/****** Object:  StoredProcedure [dbo].[GetAcceptedInternshipsOfAStudentByUsername]    Script Date: 12/23/2019 3:15:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetAcceptedInternshipsOfAStudentByUsername] @Username varchar(50)
AS
BEGIN
SELECT I.Name as Internship_Name , Sp.Name as Sponsor_Name , I.Start as [Start_Date], I.EndDate as End_Date
FROM Sponsor_Accepts_Students_internships as SAI , Student as S, Internships as I, Sponsors as Sp
WHERE SAI.Student_ID=S.ID and  S.Username= @Username and SAI.Internship_ID = I.Internship_ID and I.Sponsor_ID= Sp.ID
END





