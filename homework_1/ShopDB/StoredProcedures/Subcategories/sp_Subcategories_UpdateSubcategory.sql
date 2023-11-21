CREATE PROCEDURE [dbo].[sp_Subcategories_UpdateSubcategory]
  @SubcategoryID INT,
  @SubcategoryName NVARCHAR(50),
  @SubcategoryCategoryID INT
AS
BEGIN
  UPDATE [dbo].[Subcategories]
  SET SubcategoryName = @SubcategoryName,
      SubcategoryCategoryID = @SubcategoryCategoryID
  WHERE SubcategoryID = @SubcategoryID;
  RETURN @@ROWCOUNT;
END

