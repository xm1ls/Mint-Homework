CREATE PROCEDURE [dbo].[sp_Subcategories_DeleteSubcategory]
  @SubcategoryID INT
AS
BEGIN
  DELETE FROM [dbo].[Subcategories]
  WHERE SubcategoryID = @SubcategoryID;
  RETURN @@ROWCOUNT;
END

