CREATE PROCEDURE GetCountReplyPosts_Sponsor
AS
BEGIN
SELECT count(*) as CountRepliesSponsors
from Sponsor_Replies_Community_ToAPost
END
GO