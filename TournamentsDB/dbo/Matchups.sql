CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL , 
    [WinnerTeamId] NCHAR(10) NULL, 
    [MatchupRound] NCHAR(10) NULL, 
    CONSTRAINT [PK_Matchups] PRIMARY KEY (Id)
)
