USE [W3ouda]
GO
/****** Object:  StoredProcedure [dbo].[GetInfoOfAProjectTeamByNumber]    Script Date: 12/20/2019 9:23:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

ALTER PROCEDURE [dbo].[GetInfoOfAProjectTeamByNumber]
@Team_No  int
AS
BEGIN
	SELECT Team_No, T.Name as Project_Team_Name , T.[Description] as Description , S.Name as Team_Leader_Name
    From Project_Team as T join Student as S on T.TeamLeader_ID=S.ID
	where Team_No=@Team_No
END


