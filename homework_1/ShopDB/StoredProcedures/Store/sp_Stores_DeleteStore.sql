CREATE PROCEDURE [dbo].[sp_Stores_DeleteStore]
  @StoreID INT
AS
BEGIN
  DELETE FROM [dbo].[Store]
  WHERE StoreID = @StoreID;
  RETURN @@ROWCOUNT;
END
