CREATE TABLE [dbo].[CatalogoDistrito](
	IdCatalogoDistrito INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Distrito PRIMARY KEY CLUSTERED(IdCatalogoDistrito),
	NombreCatalogoDistrito varchar(50) NULL,
    IdCatalogoCanton int NOT NULL
	  CONSTRAINT FK_Distrito_Canton FOREIGN KEY(IdCatalogoCanton) REFERENCES dbo.CatalogoCanton(IdCatalogoCanton)
)WITH (DATA_COMPRESSION = PAGE)
GO