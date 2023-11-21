CREATE PROCEDURE [dbo].[sp_Users_DeleteUser]
  @UserID INT
AS
BEGIN
  DELETE FROM [dbo].[User]
  WHERE UserID = @UserID;
  RETURN @@ROWCOUNT;
END
