CREATE PROCEDURE [dbo].[sp_Products_UpdateProduct]
  @ProductID INT,
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
  UPDATE [dbo].[Products]
  SET ProductName = @ProductName,
      ProductBarcode = @ProductBarcode,
      ProductPrice = @ProductPrice,
      ProductImage = @ProductImage,
      ProductCategoryID = @ProductCategoryID,
      ProductSubcategoryID = @ProductSubcategoryID,
      ProductTaxGroup = @ProductTaxGroup,
      Product18Plus = @Product18Plus,
      ProductExciseRequired = @ProductExciseRequired
  WHERE ProductID = @ProductID;
  RETURN @@ROWCOUNT;
END

