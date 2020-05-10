CREATE PROCEDURE AddProjectTeamrequirements @TeamNo int , @Requirements varchar(50)
AS
BEGIN
Insert into Project_Team_Requirements(Team_No,Requirement)
values (@TeamNo,@Requirements)
END
GO