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

CREATE PROCEDURE [dbo].[GetTextbookNameLoadedByASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
	SELECT F.Name as TextbookName
    From Textbook as F
	where F.Textbook_No IN
						(SELECT Textbook_No 
						 FROM (Student_Loads_Textbook as E join Student as K on E.Student_ID=ID)  
						 where textbook_no in ( SELECT Textbook_No FROM Textbook) and Username=@Username)
END
