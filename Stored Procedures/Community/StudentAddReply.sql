CREATE PROCEDURE StudentAddReply @Student_ID int ,@PostNo int , @ReplyNo int
AS
BEGIN
Insert into Student_Replies_Community_ToAPost
values(@Student_ID,@PostNo,@ReplyNo)
END
GO