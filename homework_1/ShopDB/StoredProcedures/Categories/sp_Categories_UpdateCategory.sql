CREATE PROCEDURE [dbo].[sp_Categories_UpdateCategory]
  @CategoryID INT,
  @CategoryName NVARCHAR(50)
AS
BEGIN
  UPDATE [dbo].[Categories]
  SET CategoryName = @CategoryName
  WHERE CategoryID = @CategoryID;
  RETURN @@ROWCOUNT;
END
