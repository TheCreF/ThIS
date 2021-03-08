﻿CREATE TABLE [dbo].[Season]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SeasonName] NVARCHAR(50) NOT NULL, 
    [SeasonShortName] NVARCHAR(20) NOT NULL, 
    [Order] SMALLINT NOT NULL
)
