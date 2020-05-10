CREATE PROCEDURE GetUngradedStudentsInASpecificCourse @CourseName varchar(50)
AS
BEGIN

SELECT S.Name as Student_Name , S.ID as Student_ID , D.Grade as Grade
FROM Courses as C  join Student_Takes_Courses as St on C.Course_No= St.Course_No left outer join  Doctor_Gives_Student_GradesInCourse as D on D.Course_No= St.Course_No and D.Student_ID=St.Student_ID,  Student as S
WHERE C.Name=@CourseName and   St.Student_ID=S.ID

except
select S.Name as Student_Name , S.ID as Student_ID , D.Grade as Grade
from Courses as C join Doctor_Gives_Student_GradesInCourse as D on D.Course_No=C.Course_No , Student as S
where C.Name=@CourseName 


end

