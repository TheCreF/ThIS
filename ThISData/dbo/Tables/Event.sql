CREATE TABLE [dbo].[Event]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TicketcornerId] INT NOT NULL, 
    [EventDate] DATETIME2 NOT NULL, 
    [EventName] NVARCHAR(256) NOT NULL, 
    [SeasonId] INT NOT NULL, 
    [EventTypeId] INT NULL
)
