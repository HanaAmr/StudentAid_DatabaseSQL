CREATE PROCEDURE SponsorAddReply @Sponsor_ID int ,@PostNo int , @ReplyNo int
AS
BEGIN
Insert into Sponsor_Replies_Community_ToAPost
values(@Sponsor_ID,@PostNo,@ReplyNo)
END
GO