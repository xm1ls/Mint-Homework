IF NOT EXISTS (SELECT * FROM [dbo].[Subcategories])
BEGIN
	SET IDENTITY_INSERT [dbo].[Subcategories] ON;
	INSERT INTO [dbo].[Subcategories] ([SubcategoryID], [SubcategoryName], [SubcategoryCategoryID]) VALUES (1, N'Youth Bikes', 1)
	INSERT INTO [dbo].[Subcategories] ([SubcategoryID], [SubcategoryName], [SubcategoryCategoryID]) VALUES (2, N'Mountain Bikes', 6)
	INSERT INTO [dbo].[Subcategories] ([SubcategoryID], [SubcategoryName], [SubcategoryCategoryID]) VALUES (3, N'Road Bikes', 7)
	SET IDENTITY_INSERT [dbo].[Subcategories] OFF;
END