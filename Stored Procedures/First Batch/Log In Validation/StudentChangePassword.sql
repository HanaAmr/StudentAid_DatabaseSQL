CREATE PROCEDURE StudentChangePassword @Username varchar(50), @Newpass varchar(50)
As
BEGIN
Update  Student 
set Password=@Newpass
where Username=@Username
END
GO