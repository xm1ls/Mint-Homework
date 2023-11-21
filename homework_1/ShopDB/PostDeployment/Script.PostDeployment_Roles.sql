IF NOT EXISTS (SELECT * FROM [dbo].[Roles])
BEGIN
	SET IDENTITY_INSERT [dbo].[Roles] ON;
	INSERT INTO [dbo].[Roles] ([RoleID], [RoleName]) VALUES (1, N'Manager')
	INSERT INTO [dbo].[Roles] ([RoleID], [RoleName]) VALUES (2, N'Clerk')
	-- Add more roles as needed
	SET IDENTITY_INSERT [dbo].[Roles] OFF;
END

