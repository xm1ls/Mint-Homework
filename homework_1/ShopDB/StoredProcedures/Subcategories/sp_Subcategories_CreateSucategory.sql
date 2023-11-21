CREATE PROCEDURE [dbo].[sp_Subcategories_CreateSubcategory]
  @SubcategoryName NVARCHAR(50),
  @SubcategoryCategoryID INT
AS
BEGIN
  INSERT INTO [dbo].[Subcategories] (SubcategoryName, SubcategoryCategoryID)
  VALUES (@SubcategoryName, @SubcategoryCategoryID);
  RETURN @@ROWCOUNT;
END

