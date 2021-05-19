CREATE PROCEDURE [dbo].[spTicketType_GetAllBySeasonID]
	@SeasonID int = 0
AS
BEGIN
	SELECT tt.[Id]
      ,tt.[TypeOfTicket]
      ,tt.[ActualPrice]
      ,tt.[SeasonID]
      ,tt.[GroupID]
      ,tt.[Order]
      ,tt.[StandardNumberOfItems]
  FROM [dbo].[TicketType] tt
  WHERE tt.SeasonID = @SeasonID 
END;
