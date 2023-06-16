CREATE TABLE [dbo].[TournamentEntries]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    CONSTRAINT [FK_TournamentEntries_ToTournament] FOREIGN KEY (TournamentId) REFERENCES dbo.[Tournaments]([Id]), 
    CONSTRAINT [FK_TournamentEntries_ToTeams] FOREIGN KEY (TeamId) REFERENCES dbo.[Teams]([Id]) 
)
