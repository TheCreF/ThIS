CREATE TABLE [dbo].[TicketType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[TypeOfTicket] [nvarchar](255) NULL,
	[ActualPrice] DECIMAL(18, 2) NULL,
	[SeasonID] [int] NOT NULL,
	[GroupID] [int] NULL,
	[Order] [int] NULL,
	[StandardNumberOfItems] [int] NULL
)
