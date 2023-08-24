CREATE PROCEDURE [dbo].[CSP_Connexion]
    @Email NVARCHAR(100),
    @Password NVARCHAR(50)
AS
BEGIN
    DECLARE @Pepper NVARCHAR(128) = '%0Pepper0%'

    SELECT Id, Email, [Role]
    FROM [User]
    WHERE Email = @Email AND pwd = HASHBYTES('SHA2_512', Salt + @Password + @Pepper);
    RETURN 0
END