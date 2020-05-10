CREATE PROCEDURE DoctorChangePassword @Username varchar(50), @Newpass varchar(50)
As
BEGIN
Update  Doctors 
set Password=@Newpass
where Username=@Username
END
GO