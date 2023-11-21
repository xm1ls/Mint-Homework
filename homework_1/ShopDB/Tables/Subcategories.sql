CREATE TABLE [dbo].[Subcategories]
(
  [SubcategoryID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  [SubcategoryName] NVARCHAR(50) NOT NULL,
  [SubcategoryCategoryID] INT NOT NULL,
  
  CONSTRAINT FK_Subcategory_Category 
	FOREIGN KEY ([SubcategoryCategoryID]) 
  REFERENCES [dbo].[Categories]([CategoryID])
);

