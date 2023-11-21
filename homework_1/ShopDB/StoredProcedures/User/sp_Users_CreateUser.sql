CREATE PROCEDURE [dbo].[sp_Users_CreateUser]
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
  INSERT INTO [dbo].[User] (UserFirstName, UserLastName, UserMiddleName, UserBirthYear, UserStatus, UserEmail, UserPhone, UserRoleID)
  VALUES (@UserFirstName, @UserLastName, @UserMiddleName, @UserBirthYear, @UserStatus, @UserEmail, @UserPhone, @UserRoleID);
  RETURN @@ROWCOUNT;
END

