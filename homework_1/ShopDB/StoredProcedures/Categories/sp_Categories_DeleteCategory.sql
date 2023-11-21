CREATE PROCEDURE [dbo].[sp_Categories_DeleteCategory]
  @CategoryID INT
AS
BEGIN
  DELETE FROM [dbo].[Categories]
  WHERE CategoryID = @CategoryID;
  RETURN @@ROWCOUNT;
END

