CREATE PROCEDURE StudentAddPost @Student_ID int , @PostNo int
AS
BEGIN
Insert into Student_Posts_Community 
values (@Student_ID,@PostNo)
END
GO