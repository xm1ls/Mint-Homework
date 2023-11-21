CREATE PROCEDURE [dbo].[sp_Users_UpdateUser]
  @UserID INT,
  @UserFirstName NVARCHAR(50),
  @UserLastName NVARCHAR(50),
  @UserMiddleName NVARCHAR(50),
  @UserBirthYear INT,
  @UserStatus NVARCHAR(20),
  @UserEmail NVARCHAR(255),
  @UserPhone NVARCHAR(20),
  @UserRoleID INT
AS
BEGIN
  UPDATE [dbo].[User]
  SET UserFirstName = @UserFirstName,
      UserLastName = @UserLastName,
      UserMiddleName = @UserMiddleName,
      UserBirthYear = @UserBirthYear,
      UserStatus = @UserStatus,
      UserEmail = @UserEmail,
      UserPhone = @UserPhone,
      UserRoleID = @UserRoleID
  WHERE UserID = @UserID;
  RETURN @@ROWCOUNT;
END
