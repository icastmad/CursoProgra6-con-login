CREATE TABLE [dbo].[CatalogoCanton]
(
    IdCatalogoCanton INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Canton PRIMARY KEY CLUSTERED(IdCatalogoCanton),
	NombreCatalogoCanton varchar(50) NULL,
	IdCatalogoProvincia int NOT NULL
	   CONSTRAINT FK_Canton_Provincia FOREIGN KEY(IdCatalogoProvincia) REFERENCES dbo.CatalogoProvincia(IdCatalogoProvincia)

)WITH (DATA_COMPRESSION = PAGE)
GO
