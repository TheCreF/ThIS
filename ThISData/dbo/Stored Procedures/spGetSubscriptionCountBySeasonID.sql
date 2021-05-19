CREATE PROCEDURE [dbo].[spGetSubscriptionCountBySeasonID]
	@SeasonID int = 0,
	@ConteggioAbbonati INT OUTPUT
AS
begin
	SET NOCOUNT ON;

	SELECT SUM(A.Conteggio) as Totale, A.SeasonID
FROM (SELECT COUNT(d.Cognome) AS Conteggio, d.Riduzione, (SELECT t.[Order] FROM [dbo].[TicketType] t
                                                       WHERE t.SeasonID = 6 and t.GroupID = 1 and t.TypeOfTicket = d.Riduzione) AS RidOrder, d.SeasonID
FROM (SELECT DISTINCT td.Cognome, td.Riduzione, td.SeasonID
	FROM [dbo].[TicketcornerData] td
	WHERE td.SeasonID = @SeasonID AND td.Riduzione IN (SELECT tt.TypeOfTicket
                                                       FROM [dbo].[TicketType] tt
                                                       WHERE tt.SeasonID = @SeasonID and tt.GroupID = 1) 
    AND td.Numerocliente <> 1 AND td.CP <> 'ITA' AND td.Numerocliente < 200000000) d
	GROUP BY D.Riduzione, d.SeasonID) A
GROUP BY A.SeasonID
End;
