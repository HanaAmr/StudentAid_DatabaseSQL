CREATE PROCEDURE DoctorAddReply @Doctor_ID int ,@PostNo int , @ReplyNo int
AS
BEGIN
Insert into Doctor_Replies_Community_ToAPost
values(@Doctor_ID,@PostNo,@ReplyNo)
END
GO