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

CREATE PROCEDURE [dbo].[AddRPapers]
	@RPaper_No	int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Publisher varchar(50)
AS
BEGIN
INSERT INTO RPapers(RPaper_No,Name,Link,Publisher)
Values (@RPaper_No,@Name,@Link,@Publisher)
END
