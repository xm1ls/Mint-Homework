IF NOT EXISTS (SELECT * FROM [dbo].[Products])
BEGIN
	SET IDENTITY_INSERT [dbo].[Products] ON;
	INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [ProductBarcode], [ProductPrice], [ProductImage], [ProductCategoryID], [ProductSubcategoryID], [ProductTaxGroup], [Product18Plus], [ProductExciseRequired])
		VALUES (1, N'Youth Bike Model 1', N'123456789012', 299.99, N'path/to/image1.jpg', 1, NULL, N'TaxGroupA', 0, 0)
	INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [ProductBarcode], [ProductPrice], [ProductImage], [ProductCategoryID], [ProductSubcategoryID], [ProductTaxGroup], [Product18Plus], [ProductExciseRequired]) 
		VALUES (2, N'Mountain Bike Model 1', N'987654321098', 899.99, N'path/to/image2.jpg', 6, 2, N'TaxGroupB', 0, 1)
	INSERT INTO [dbo].[Products] ([ProductID], [ProductName], [ProductBarcode], [ProductPrice], [ProductImage], [ProductCategoryID], [ProductSubcategoryID], [ProductTaxGroup], [Product18Plus], [ProductExciseRequired])	
		VALUES (3, N'Road Bike Model 1', N'567890123456', 1299.99, N'path/to/image3.jpg', 7, 3, N'TaxGroupA', 0, 0)
	-- Add more products as needed
	SET IDENTITY_INSERT [dbo].[Products] ON;
END

