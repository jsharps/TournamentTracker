CREATE PROCEDURE [dbo].[spTeams_Insert]
	@teamName nvarchar(100)
,	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Teams (TeamName)
	VALUES (@teamName);

	SELECT @id = SCOPE_IDENTITY();
END
