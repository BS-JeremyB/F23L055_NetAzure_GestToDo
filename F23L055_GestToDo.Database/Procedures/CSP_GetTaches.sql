CREATE PROCEDURE [dbo].[CSP_GetTaches]
AS
BEGIN
	SELECT Id, Titre, Finalise, Responsable	
	FROM Tache
	RETURN 0
END