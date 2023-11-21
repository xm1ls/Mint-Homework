CREATE PROCEDURE [dbo].[sp_Products_CreateProduct]
  @ProductName NVARCHAR(255),
  @ProductBarcode NVARCHAR(50),
  @ProductPrice DECIMAL(10, 2),
  @ProductImage NVARCHAR(MAX),
  @ProductCategoryID INT,
  @ProductSubcategoryID INT,
  @ProductTaxGroup NVARCHAR(50),
  @Product18Plus BIT,
  @ProductExciseRequired BIT
AS
BEGIN
  INSERT INTO [dbo].[Products] (ProductName, ProductBarcode, ProductPrice, ProductImage, ProductCategoryID, ProductSubcategoryID, ProductTaxGroup, Product18Plus, ProductExciseRequired)
  VALUES (@ProductName, @ProductBarcode, @ProductPrice, @ProductImage, @ProductCategoryID, @ProductSubcategoryID, @ProductTaxGroup, @Product18Plus, @ProductExciseRequired);
  RETURN @@ROWCOUNT;
END

