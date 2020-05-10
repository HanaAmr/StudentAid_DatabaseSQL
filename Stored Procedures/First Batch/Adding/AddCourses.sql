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

CREATE PROCEDURE [dbo].[AddCourses]
	@Course_No		int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Level int 
AS
BEGIN
INSERT INTO Courses(Course_No,Name,Link,Level)
Values (@Course_No,@Name,@Link,@Level)
END
