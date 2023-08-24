CREATE TABLE [dbo].[Tache]
(
	[Id] INT NOT NULL IDENTITY,
	[Titre] NVARCHAR(128) NOT NULL,
	[Finalise] BIT NOT NULL DEFAULT (0),
	[Responsable] INT NOT NULL

	
    CONSTRAINT [PK_Todo] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Tache_User] FOREIGN KEY ([Responsable]) REFERENCES [User]([Id]) 
)
