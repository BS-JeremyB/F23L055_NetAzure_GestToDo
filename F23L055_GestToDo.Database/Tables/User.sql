﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY, 
	[Email] VARCHAR (100) NOT NULL,
	[pwd] VARBINARY (64) NOT NULL,
    [Salt] VARCHAR (36)   NOT NULL,
    [Role] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [PK_User] PRIMARY KEY ([Id]),
	UNIQUE NONCLUSTERED ([Email] ASC),
    UNIQUE NONCLUSTERED ([Salt] ASC)
)
