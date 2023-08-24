CREATE PROCEDURE [dbo].[CSP_GetTacheUnique]
	@Id int
AS
BEGIN
	SELECT Id, Titre, Finalise FROM Tache WHERE Id = @Id
	RETURN 0
END
