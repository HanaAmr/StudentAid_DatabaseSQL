CREATE PROCEDURE AcceptStudentIntern @Sponsor_ID int , @Student_ID int , @IntID int
AS
BEGIN
Insert into Sponsor_Accepts_Students_internships
values(@Sponsor_ID,@Student_ID,@IntID)
END
GO