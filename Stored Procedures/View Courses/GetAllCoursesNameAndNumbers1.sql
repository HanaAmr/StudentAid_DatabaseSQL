USE [W3ouda]
GO
/****** Object:  StoredProcedure [dbo].[GetAllCoursesNameAndNumbers]    Script Date: 12/19/2019 9:40:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[GetAllCoursesNameAndNumbers]
AS
BEGIN
	SELECT Name as Name--,Course_No as CourseNumber
    From Courses
END


