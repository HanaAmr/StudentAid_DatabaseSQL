USE [Final]
GO
/****** Object:  StoredProcedure [dbo].[AddFeedback]    Script Date: 12/21/2019 1:41:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[AddFeedback]
	@Feedback_No	int,
	@Course_No  int, 
	@Rating int,
	@Description varchar(150)
AS
BEGIN
INSERT INTO Feedback(Feedback_No,Course_No,Rating,Description)
Values (@Feedback_No,@Course_No,@Rating,@Description)
END



