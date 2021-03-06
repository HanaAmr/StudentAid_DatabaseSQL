USE [SAid]
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesAndGradeOfASpecificStudentByUsername]    Script Date: 12/15/2019 4:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[GetCoursesAndGradeOfASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
	SELECT E.Name as Course_Name, Grade as Course_Grade
    From Courses as E, Doctor_Gives_Student_GradesInCourse as F, Student as K
	where E.Course_No=F.Course_No and F.Student_ID=K.ID and Username=@Username
END

