CREATE TABLE [dbo].[TeamMembers]
(
	[Id] INT NOT NULL IDENTITY (1,1), 
    [TeamId] INT NULL, 
    [PlayerId] INT NULL, 
    CONSTRAINT [FK_TeamMembers_ToTeams] FOREIGN KEY ([TeamId]) REFERENCES dbo.[Teams](Id), 
    CONSTRAINT [FK_TeamMembers_ToPlayers] FOREIGN KEY ([PlayerId]) REFERENCES dbo.[Players](Id), 
    CONSTRAINT [PK_TeamMembers] PRIMARY KEY (Id)
)
