CREATE PROCEDURE AcceptStudentBusinessIdeas @Sponsor_ID int, @IdeaNo int
AS
BEGIN
update Business_Idea
set Sponsor_ID=@Sponsor_ID
where Idea_No=@IdeaNo
END
GO