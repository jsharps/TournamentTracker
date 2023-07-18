CREATE PROCEDURE [dbo].[spPrizes_Insert]
	@placeNumber int = 0,
	@placeName nvarchar(50),
	@prizeAmount money,
	@prizePercentage float,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	VALUES (@placeNumber, @placeName, @prizeAmount, @prizePercentage);

	SELECT @id = SCOPE_IDENTITY();
END
GO
