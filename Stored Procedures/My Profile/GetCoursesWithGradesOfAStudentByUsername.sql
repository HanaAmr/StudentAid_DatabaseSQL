CREATE PROCEDURE GetCoursesWithGradesOfAStudentByUsername @Username varchar(50)
AS
BEGIN
SELECT C.Course_No as Course_No , C.Name as Course_Name, D.Grade
FROM Student_Takes_Courses as St , Student as S , Courses as C,Doctor_Gives_Student_GradesInCourse as D
WHERE S.Username=@Username and S.ID= st.Student_ID and st.Course_No=C.Course_No

intersect

select C.Course_No as Course_No , C.Name as Course_Name, D.Grade as Course_Grade
from Doctor_Gives_Student_GradesInCourse as D join Student_Takes_Courses as st on (D.Student_ID=St.Student_ID and D.Course_No=st.Course_No),student as S, Courses as C
where S.Username=@Username and S.ID=D.Student_ID and D.Course_No=C.Course_No
END
GO