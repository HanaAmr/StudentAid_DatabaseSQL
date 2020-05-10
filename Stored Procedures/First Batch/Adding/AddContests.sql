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

CREATE PROCEDURE [dbo].[AddContests]
	@Contest_No	int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Location varchar(50),
	@Time  varchar(50),
	@Prize  varchar(50),
	@Theme  varchar(50),
	@Sponsor_ID int
AS
BEGIN
INSERT INTO Contests(Contest_No,Name,Link,Location,Time,Prize,Theme,Sponsor_ID)
Values (@Contest_No,@Name,@Link,@Location,@Time,@Prize,@Theme,@Sponsor_ID)
END
