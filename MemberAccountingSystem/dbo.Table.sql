﻿CREATE TABLE [dbo].[Member]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [fName] NVARCHAR(50) NOT NULL, 
    [Location] NVARCHAR(50) NOT NULL, 
    [actType] NVARCHAR(50) NOT NULL
)
