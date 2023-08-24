CREATE PROCEDURE [dbo].[CSP_UpdateTacheFinalise]
	@Id int,
	@Finalise bit

AS
BEGIN
	UPDATE Tache SET Finalise = @Finalise WHERE Id = @Id
	RETURN 0
END
