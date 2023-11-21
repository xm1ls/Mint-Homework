CREATE PROCEDURE [dbo].[sp_Roles_CreateRole]
  @RoleName NVARCHAR(50)
AS
BEGIN
  INSERT INTO [dbo].[Roles] (RoleName)
  VALUES (@RoleName);
  RETURN @@ROWCOUNT;
END

