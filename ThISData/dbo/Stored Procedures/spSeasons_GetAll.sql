CREATE PROCEDURE [dbo].[spSeasons_GetAll]
AS
BEGIN
 SET NOCOUNT ON;

 SELECT SeasonName, SeasonShortName, [Order]
 FROM dbo.Season
 ORDER BY [Order]
END
