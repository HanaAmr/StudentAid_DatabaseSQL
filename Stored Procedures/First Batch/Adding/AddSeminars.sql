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

CREATE PROCEDURE [dbo].[AddSeminars]
	@Seminar_No	int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Presenter varchar(50)
AS
BEGIN
INSERT INTO Seminars(Seminar_No,Name,Link,Presenter)
Values (@Seminar_No,@Name,@Link,@Presenter)
END