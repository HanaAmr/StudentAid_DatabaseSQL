USE [W3ouda]
GO
/****** Object:  StoredProcedure [dbo].[AddBusinessIdeaa]    Script Date: 12/21/2019 11:51:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[AddBusinessIdeaa]
	@Idea_No	int,
	@Description  varchar(150), 
	@Student_ID int
	
AS
BEGIN
INSERT INTO Business_Idea(Idea_No,Description,Student_ID)
Values (@Idea_No,@Description,@Student_ID)
END

