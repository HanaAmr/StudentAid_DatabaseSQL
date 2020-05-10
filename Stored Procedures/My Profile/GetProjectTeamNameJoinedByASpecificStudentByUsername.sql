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

CREATE PROCEDURE [dbo].[GetProjectTeamNameJoinedByASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
	SELECT F.Name as TeamName
    From Project_Team as F
	where F.Team_No IN
						(SELECT Team_No 
						 FROM (Student_Joins_ProjectTeam as E join Student as K on E.Student_ID=ID)  
						 where team_no in ( SELECT Team_No FROM Project_Team) and Username=@Username)
END
