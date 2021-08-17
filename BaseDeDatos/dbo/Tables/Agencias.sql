CREATE TABLE dbo.Agencias
(
	   AgenciaId INT NOT NULL IDENTITY(1,1) CONSTRAINT Agencia PRIMARY KEY CLUSTERED(AgenciaId)
	 , Nombre VARCHAR(250) NOT NULL
	 , IdCatalogoProvincia INT NOT NULL
	      CONSTRAINT FK_Agencia_Provincia FOREIGN KEY(IdCatalogoProvincia) REFERENCES dbo.CatalogoProvincia(IdCatalogoProvincia)
	 , IdCatalogoCanton INT NOT NULL 
	       CONSTRAINT Fk_Agencia_Canton FOREIGN KEY(IdCatalogoCanton) REFERENCES dbo.CatalogoCanton(IdCatalogoCanton)
	 , IdCatalogoDistrito INT NOT NULL
	       CONSTRAINT Fk_Agencia_Distrito FOREIGN KEY(IdCatalogoDistrito) REFERENCES dbo.CatalogoDistrito(IdCatalogoDistrito)
	 , Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION = PAGE)
GO
