
create PROCEDURE GetAllQuestions
AS
BEGIN
	SELECT F.Post_No as Post_No,  Text as Questions 
    From Student_Posts_Community as E join Post_Community as F on E.Post_No=F.Post_No
END






