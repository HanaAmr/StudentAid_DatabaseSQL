CREATE PROCEDURE AddgradeToAStudentInACourse 
@DocID int ,
@StudID int,
@CourseNo int,
@Grade varchar(1)
AS
BEGIN
Insert into Doctor_Gives_Student_GradesInCourse
values (@DocID,@StudID,@CourseNo,@Grade)
END
GO