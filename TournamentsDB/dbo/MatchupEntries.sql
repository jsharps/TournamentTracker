CREATE TABLE [dbo].[MatchupEntries]
(
	[Id] INT NOT NULL , 
    [MatchupId] INT NULL, 
    [ParentMatchupId] INT NULL, 
    [CompetingTeamId] INT NULL, 
    [Score] INT NULL, 
    CONSTRAINT [PK_MatchupEntries] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_MatchupEntries_ToMatchups1] FOREIGN KEY ([MatchupId]) REFERENCES dbo.Matchups(Id),
    CONSTRAINT [FK_MatchupEntries_ToMatchups2] FOREIGN KEY ([ParentMatchupId]) REFERENCES dbo.Matchups(Id)
)
