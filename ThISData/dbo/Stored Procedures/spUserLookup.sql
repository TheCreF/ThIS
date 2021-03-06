CREATE PROCEDURE [dbo].[spUserLookup]
	@Id NVARCHAR(128)
AS
BEGIN
	set nocount on;
	
	SELECT Id, FirstName, Lastname, UserAcr, EmailAddress, CreatedDate
	from [dbo].[User]
	where Id = @Id;
END
