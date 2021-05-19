CREATE PROCEDURE [dbo].[spSeasons_GetAll]
AS
BEGIN
 SET NOCOUNT ON;

 SELECT Id, SeasonName, SeasonShortName, [Order], IsCurrent
 FROM dbo.Season
 ORDER BY [Order] DESC
END
