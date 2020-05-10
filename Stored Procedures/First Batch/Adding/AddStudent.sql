-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddStudent]
	@ID		int,
	@Name  varchar(50), 
	@Username varchar(50),
	@Password varchar(50), 
	@Email varchar(50)
AS
BEGIN
INSERT INTO Student(ID,Name,Username,Password,Email)
Values (@ID,@Name,@Username,@Password,@Email)
END