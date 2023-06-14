CREATE TABLE [dbo].[TournamentPrizes]
(
	[Id] INT NOT NULL, 
    [TournamentId] INT NULL, 
    [PrizeId] INT NULL, 
    CONSTRAINT [PK_TournamentPrizes] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_TournamentPrizes_ToTournaments] FOREIGN KEY (TournamentId) REFERENCES dbo.[Tournaments](Id
    ), 
    CONSTRAINT [FK_TournamentPrizes_ToPrizes] FOREIGN KEY (PrizeId) REFERENCES dbo.[Prizes]([Id]) 
)
