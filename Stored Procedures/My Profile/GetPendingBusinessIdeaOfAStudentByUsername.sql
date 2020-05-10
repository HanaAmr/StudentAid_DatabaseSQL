
CREATE PROCEDURE GetPendingBusinessIdeaOfAStudentByUsername @Username varchar(50)
AS
BEGIN
SELECT B.Idea_No as Business_Idea_No , B.[Description] as Business_Idea_Description 
FROM Business_Idea as B  join Student as S on B.Student_ID= S.ID
WHERE S.Username= @Username 
 except 
  
SELECT B.Idea_No as Business_Idea_No , B.[Description] as Business_Idea_Description 
FROM Business_Idea as B join Student as S on B.Student_ID=S.ID join Sponsors as Sp on B.Sponsor_ID=Sp.ID 
WHERE S.Username=@Username
end