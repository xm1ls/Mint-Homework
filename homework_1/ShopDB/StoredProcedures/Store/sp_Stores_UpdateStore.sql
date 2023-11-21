CREATE PROCEDURE [dbo].[sp_Stores_UpdateStore]
  @StoreID INT,
  @StoreName NVARCHAR(255),
  @StoreCity NVARCHAR(255),
  @StoreAddress NVARCHAR(255),
  @StoreEmail NVARCHAR(255),
  @StorePhone NVARCHAR(20),
  @StorePostalCode NVARCHAR(10),
  @StoreManagerID INT
AS
BEGIN
  UPDATE [dbo].[Store]
  SET StoreName = @StoreName,
      StoreCity = @StoreCity,
      StoreAddress = @StoreAddress,
      StoreEmail = @StoreEmail,
      StorePhone = @StorePhone,
      StorePostalCode = @StorePostalCode,
      StoreManagerID = @StoreManagerID
  WHERE StoreID = @StoreID;
  RETURN @@ROWCOUNT;
END

