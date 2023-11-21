IF NOT EXISTS (SELECT * FROM [dbo].[Categories])
BEGIN
	SET IDENTITY_INSERT [dbo].[Categories] ON;
	INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Children Bicycles')
	INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Comfort Bicycles')
	INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Cruisers Bicycles')
	INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Cyclocross Bicycles')
	INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Electric Bikes')
	INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Mountain Bikes')
	INSERT INTO [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Road Bikes')
	SET IDENTITY_INSERT [dbo].[Categories] OFF;
END
