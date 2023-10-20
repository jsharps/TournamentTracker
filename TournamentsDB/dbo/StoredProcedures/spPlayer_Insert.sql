CREATE PROCEDURE [dbo].[spPlayer_Insert]
	@firstName NVARCHAR(100),
	@lastName NVARCHAR(100),
	@emailAddress NVARCHAR(100),
	@cellphoneNumber NVARCHAR(100),
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Players 
	(
		FirstName,
		LastName,
		EmailAdress,
		CellphoneNumber
	)
	VALUES
	(
		@firstName,
		@lastName,
		@emailAddress,
		@cellphoneNumber
	)

	SELECT @id=SCOPE_IDENTITY();
END
GO
