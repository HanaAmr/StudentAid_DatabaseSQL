

create PROCEDURE GetAllProjectTeamsNameAndNumbers
AS
BEGIN
	SELECT Name as Name,Team_No as TeamNumber , [Description] as Project_Description
    From Project_Team
END


