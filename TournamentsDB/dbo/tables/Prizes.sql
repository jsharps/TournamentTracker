CREATE TABLE [dbo].[Prizes]
(
	[Id] INT NOT NULL  IDENTITY, 
    [PlaceNumber] INT NOT NULL, 
    [PlaceName] NVARCHAR(50) NOT NULL, 
    [PrizeAmount] MONEY NOT NULL, 
    [PrizePercentage] FLOAT NOT NULL, 
)
