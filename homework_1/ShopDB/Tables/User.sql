CREATE TABLE [dbo].[User]
(
  [UserID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  [UserFirstName] NVARCHAR(50) NOT NULL,
  [UserLastName] NVARCHAR(50) NOT NULL,
  [UserMiddleName] NVARCHAR(50),
  [UserBirthYear] INT NOT NULL,
  [UserEmploymentDate] DATETIME NOT NULL DEFAULT GETUTCDATE(),
  [UserStatus] NVARCHAR(20) NOT NULL,
  [UserEmail] NVARCHAR(255) NOT NULL,
  [UserPhone] NVARCHAR(20) NOT NULL,
  [UserRoleID] INT NOT NULL,
  CONSTRAINT FK_User_Role FOREIGN KEY ([UserRoleID]) REFERENCES [dbo].[Roles]([RoleID])
);

