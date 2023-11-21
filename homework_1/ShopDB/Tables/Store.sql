CREATE TABLE [dbo].[Store]
(
  [StoreID] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  [StoreName] NVARCHAR(255) NOT NULL,
  [StoreCity] NVARCHAR(255) NOT NULL,
  [StoreAddress] NVARCHAR(255) NOT NULL,
  [StoreEmail] NVARCHAR(255) NOT NULL,
  [StorePhone] NVARCHAR(20) NOT NULL,
  [StorePostalCode] NVARCHAR(10) NOT NULL,
  [StoreManagerID] INT NOT NULL,
  CONSTRAINT FK_Store_Manager FOREIGN KEY ([StoreManagerID]) REFERENCES [dbo].[User]([UserID])
);

