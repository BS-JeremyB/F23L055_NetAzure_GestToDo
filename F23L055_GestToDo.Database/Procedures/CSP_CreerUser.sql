CREATE PROCEDURE [dbo].[CSP_CreerUser]
    @Email NVARCHAR(100),
    @Password NVARCHAR(50)
AS
BEGIN
    DECLARE @salt VARCHAR(36)
    DECLARE @Pepper NVARCHAR(128) = '%0Pepper0%'

    SET @salt = CONVERT(VARCHAR(36), NEWID())

    DECLARE @hashedPasswd VARBINARY(64)
    SET @hashedPasswd = HASHBYTES('SHA2_512', @salt + @Password + @Pepper)

    INSERT INTO [User] (Email, pwd, Salt)
    VALUES (@Email, @hashedPasswd, @salt)

    RETURN 0
END