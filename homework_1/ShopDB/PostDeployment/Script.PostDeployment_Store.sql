IF NOT EXISTS (SELECT * FROM [dbo].[Store])
BEGIN
	SET IDENTITY_INSERT [dbo].[Store] ON;
	INSERT INTO [dbo].[Store] ([StoreID], [StoreName], [StoreCity], [StoreAddress], [StoreEmail], [StorePhone], [StorePostalCode], [StoreManagerID]) VALUES (1, N'Store 1', N'City 1', N'Address 1', N'email1@example.com', N'1234567890', N'12345', 1)
	INSERT INTO [dbo].[Store] ([StoreID], [StoreName], [StoreCity], [StoreAddress], [StoreEmail], [StorePhone], [StorePostalCode], [StoreManagerID]) VALUES (2, N'Store 2', N'City 2', N'Address 2', N'email2@example.com', N'9876543210', N'54321', 2)
	-- Add more stores as needed
	SET IDENTITY_INSERT [dbo].[Store] OFF;
END

