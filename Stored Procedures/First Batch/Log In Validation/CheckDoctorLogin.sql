USE [SAid]
GO
/****** Object:  StoredProcedure [dbo].[CheckDoctorLogIn]    Script Date: 12/14/2019 2:42:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[CheckDoctorLogIn]
@Username	varchar(50),
@Password	varchar(50)

AS
BEGIN
   set nocount off;
	SELECT count(*)
    From Doctors
	where Username=@Username and Password=@Password
END
