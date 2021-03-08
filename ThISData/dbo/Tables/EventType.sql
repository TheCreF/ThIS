CREATE TABLE [dbo].[EventType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TypeOfEvent] NVARCHAR(256) NOT NULL, 
    [ShortDescription] NVARCHAR(MAX) NOT NULL, 
    [IsPublic] BIT NOT NULL
)
