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

CREATE PROCEDURE [dbo].[GetContestsNameJoinedByASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
		SELECT F.Name as ContestName
		From Contests as F
		where F.Contest_No IN
							  (SELECT Contest_No 
							  FROM (Student_Goes_Contests as E join Student as K on E.Student_ID=ID)  
							  where Contest_No in (SELECT Contest_No FROM Contests) and Username=@Username)
END
