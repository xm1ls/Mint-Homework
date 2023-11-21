CREATE PROCEDURE [dbo].[sp_Roles_UpdateRole]
  @RoleID INT,
  @RoleName NVARCHAR(50)
AS
BEGIN
  UPDATE [dbo].[Roles]
  SET RoleName = @RoleName
  WHERE RoleID = @RoleID;
  RETURN @@ROWCOUNT;
END

