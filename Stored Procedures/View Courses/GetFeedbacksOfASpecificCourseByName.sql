



CREATE PROCEDURE GetFeedbacksOfASpecificCourseByName @Name  varchar(50) 
AS
BEGIN
	SELECT Description,Rating
    From Courses as E join Feedback as F on E.Course_No=F.Course_No
	where E.Name=@Name
END
GO