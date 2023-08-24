CREATE PROCEDURE [dbo].[CSP_CreerTache]
	@Titre NVARCHAR(128),
	@Responsable INT
AS
BEGIN
	--TEST

	INSERT INTO Tache (Titre, Responsable) VALUES (@Titre, @Responsable);
	RETURN 0
END