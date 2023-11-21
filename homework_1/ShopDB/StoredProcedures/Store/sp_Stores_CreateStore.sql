CREATE PROCEDURE [dbo].[sp_Stores_CreateStore]
  @StoreName NVARCHAR(255),
  @StoreCity NVARCHAR(255),
  @StoreAddress NVARCHAR(255),
  @StoreEmail NVARCHAR(255),
  @StorePhone NVARCHAR(20),
  @StorePostalCode NVARCHAR(10),
  @StoreManagerID INT
AS
BEGIN
  INSERT INTO [dbo].[Store] (StoreName, StoreCity, StoreAddress, StoreEmail, StorePhone, StorePostalCode, StoreManagerID)
  VALUES (@StoreName, @StoreCity, @StoreAddress, @StoreEmail, @StorePhone, @StorePostalCode, @StoreManagerID);
  RETURN @@ROWCOUNT;
END

