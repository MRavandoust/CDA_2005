CREATE TABLE [Vegetables](
   [Id] INT,
   [Name] VARCHAR(50) NOT NULL,
   [Variety] VARCHAR(50) NOT NULL,
   [PrimaryColor] VARCHAR(20) NOT NULL,
   [LifeTime] INT NOT NULL,
   [Fresh] INT NOT NULL DEFAULT 0,
   PRIMARY KEY(Id)
);

CREATE TABLE [Sales](
   [SaleId] INT,
   [SaleDate] DATE NOT NULL,
   [SaleWeight] INT NOT NULL,
   [SaleUnitPrice] DECIMAL(5,2) NOT NULL,
   [SaleActive] INT NOT NULL DEFAULT 1,
   [VegetableId] INT NOT NULL,
   PRIMARY KEY(SaleId),
   FOREIGN KEY(VegetableId) REFERENCES Vegetables(Id)
);
