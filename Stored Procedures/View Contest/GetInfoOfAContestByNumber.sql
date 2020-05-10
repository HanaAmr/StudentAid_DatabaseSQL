USE [W3ouda]
GO
/****** Object:  StoredProcedure [dbo].[GetInfoOfAContestByNumber]    Script Date: 12/20/2019 9:18:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[GetInfoOfAContestByNumber]
@Contest_No  int
AS
BEGIN
	SELECT Contest_No ,C.Name as Contest_Name , Link as Contest_Link , Location, [Time],Theme,Prize, S.Name as Sponsor_Name
    From Contests as C join Sponsors as S on C.Sponsor_ID= S.ID 
	where Contest_No=@Contest_No
END



