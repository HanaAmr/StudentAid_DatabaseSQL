CREATE PROCEDURE SponsorChangePassword @Username varchar(50), @Newpass varchar(50)
As
BEGIN
Update  Sponsors 
set Password=@Newpass
where Username=@Username
END
GO