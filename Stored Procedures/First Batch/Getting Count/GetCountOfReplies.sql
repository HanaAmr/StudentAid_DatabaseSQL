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

CREATE PROCEDURE [dbo].[GetCountOfReplies]
AS
BEGIN
	SELECT (Count(D.Reply_Post_No) + Count(S.Reply_Post_No) + Count(T.Reply_Post_No)) as Sum
    From Doctor_Replies_Community_ToAPost as D, Sponsor_Replies_Community_ToAPost as S, Student_Replies_Community_ToAPost as T
END
