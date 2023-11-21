IF NOT EXISTS (SELECT * FROM [dbo].[User])
BEGIN
	SET IDENTITY_INSERT [dbo].[User] ON;
	INSERT INTO [dbo].[User] ([UserID], [UserFirstName], [UserLastName], [UserMiddleName], [UserBirthYear], [UserEmploymentDate], [UserStatus], [UserEmail], [UserPhone], [UserRoleID]) VALUES (1, N'John', N'Doe', N'Middle', 1990, GETUTCDATE(), N'Active', N'john.doe@example.com', N'1234567890', 1)
	INSERT INTO [dbo].[User] ([UserID], [UserFirstName], [UserLastName], [UserMiddleName], [UserBirthYear], [UserEmploymentDate], [UserStatus], [UserEmail], [UserPhone], [UserRoleID]) VALUES (2, N'Jane', N'Smith', N'', 1985, GETUTCDATE(), N'Active', N'jane.smith@example.com', N'9876543210', 2)
	-- Add more users as needed
	SET IDENTITY_INSERT [dbo].[User] OFF;
END