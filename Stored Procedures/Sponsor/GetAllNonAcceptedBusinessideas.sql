CREATE PROCEDURE GetAllNonAcceptedBusinessideas 
AS
BEGIN
SELECT B.Idea_No as Idea_No , B.[Description] as Idea_Description ,S.Name as Student_Name
FROM Business_Idea as B , Student as S
where Sponsor_ID is null and b.Student_ID=s.ID




END
GO