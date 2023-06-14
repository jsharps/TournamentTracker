CREATE TABLE [dbo].[Tournaments]
(
	[Id] INT NOT NULL , 
    [TournamentName] NVARCHAR(50) NULL, 
    [TeamId] INT NULL, 
    CONSTRAINT [FK_Tournaments_ToTeams] FOREIGN KEY (TeamId) REFERENCES [Teams]([Id]), 
    CONSTRAINT [PK_Tournaments] PRIMARY KEY ([Id])
	
)
