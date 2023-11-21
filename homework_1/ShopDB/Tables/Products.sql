CREATE TABLE [dbo].[Products]
(
  [ProductID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  [ProductName] NVARCHAR(255) NOT NULL,
  [ProductBarcode] NVARCHAR(50) NOT NULL,
  [ProductPrice] DECIMAL(10,2) NOT NULL,
  [ProductImage] NVARCHAR(MAX) NOT NULL,
  [ProductCategoryID] INT NOT NULL,
  [ProductSubcategoryID] INT,
  [ProductTaxGroup] NVARCHAR(50) NOT NULL,
  [Product18Plus] BIT NOT NULL,
  [ProductExciseRequired] BIT NOT NULL,
  
  CONSTRAINT FK_Product_Category 
	FOREIGN KEY ([ProductCategoryID]) 
  REFERENCES [dbo].[Categories]([CategoryID]),	

  CONSTRAINT FK_Product_Subcategory 
	FOREIGN KEY ([ProductSubcategoryID]) 
  REFERENCES [dbo].[Subcategories]([SubcategoryID])
);

