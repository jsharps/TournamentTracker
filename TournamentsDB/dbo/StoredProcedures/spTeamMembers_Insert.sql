CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
	@teamId int,
	@playerId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TeamMembers (TeamId, PlayerId)
	VALUES (@teamId, @playerId)

	SELECT @id = SCOPE_IDENTITY();
END
