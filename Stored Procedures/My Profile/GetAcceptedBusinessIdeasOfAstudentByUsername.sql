USE [W3ouda]
GO
/****** Object:  StoredProcedure [dbo].[GetAcceptedBusinessIdeasOfAstudentByUsername]    Script Date: 12/19/2019 5:20:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetAcceptedBusinessIdeasOfAstudentByUsername] @Username varchar(50)
AS
BEGIN
SELECT B.Idea_No as Business_Idea_No , B.[Description] as Business_Idea_Description , Sp.Name as Sponsor_Name
FROM Business_Idea as B join Sponsors as Sp on B.Sponsor_ID=Sp.ID join Student as S on B.Student_ID=S.ID
WHERE S.Username=@Username
end
go


