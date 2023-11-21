CREATE PROCEDURE [dbo].[sp_Products_DeleteProduct]
  @ProductID INT
AS
BEGIN
  DELETE FROM [dbo].[Products]
  WHERE ProductID = @ProductID;
  RETURN @@ROWCOUNT;
END
