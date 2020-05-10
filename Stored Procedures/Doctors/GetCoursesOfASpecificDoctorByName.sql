CREATE PROCEDURE GetCoursesOfASpecificDoctorByName @Name varchar(50)
AS
BEGIN
SELECT *
FROM Courses as C
WHERE C.Course_No in (select Course_No
from Doctors as D join Course_OfferedBy_Doctors as G on G.Doctor_ID=D.ID
where D.Name=@Name)
END
GO