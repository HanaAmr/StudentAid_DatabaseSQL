
CREATE PROCEDURE GetCountReplyPosts_Student
AS
BEGIN
SELECT count(*) as countofRepliesStudent
 from Student_Replies_Community_ToAPost
END
GO