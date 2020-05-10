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

CREATE PROCEDURE [dbo].[AddInterships]
	@Internship_ID		int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Start varchar(50), 
	@End varchar(50),
	@Sponsor_ID int
AS
BEGIN
INSERT INTO Internships(Internship_ID,Name,Link,Start,EndDate,Sponsor_ID)
Values (@Internship_ID,@Name,@Link,@Start,@End,@Sponsor_ID)
END