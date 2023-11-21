CREATE PROCEDURE [dbo].[sp_Roles_DeleteRole]
  @RoleID INT
AS
BEGIN
  DELETE FROM [dbo].[Roles]
  WHERE RoleID = @RoleID;
  RETURN @@ROWCOUNT;
END

