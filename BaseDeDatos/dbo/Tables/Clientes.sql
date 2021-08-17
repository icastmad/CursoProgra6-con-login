CREATE TABLE dbo.Clientes
(
	   ClientesId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Clientes PRIMARY KEY CLUSTERED(ClientesId)
	 , NombreCompleto VARCHAR(250) NOT NULL
	 , Direccion VARCHAR(500) NOT NULL
	 , Telefono VARCHAR(500) NOT NULL
	 , AgenciaId INT NOT NULL 
		CONSTRAINT FK_Clientes_Agencias FOREIGN KEY(AgenciaId) REFERENCES dbo.Agencias(AgenciaId)  
	 , Estado BIT
)
WITH (DATA_COMPRESSION = PAGE)
GO