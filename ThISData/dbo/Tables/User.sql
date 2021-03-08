﻿CREATE TABLE [dbo].[User]
(
    [AuthUserId] NVARCHAR(128) PRIMARY KEY NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [Lastname] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(256) NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)