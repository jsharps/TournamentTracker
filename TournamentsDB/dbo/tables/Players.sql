CREATE TABLE [dbo].[Players]
(
	[Id] INT NOT NULL IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [EmailAdress] NVARCHAR(50) NULL, 
    [CellphoneNumber] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Players] PRIMARY KEY (Id) 
)
