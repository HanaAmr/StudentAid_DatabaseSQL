CREATE PROCEDURE GetCountReplyPosts_Doctors
AS
BEGIN
SELECT count(*) as CountRepliesDoctors
from Doctor_Replies_Community_ToAPost
END
GO