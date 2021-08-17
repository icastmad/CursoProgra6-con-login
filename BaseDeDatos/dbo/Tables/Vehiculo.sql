CREATE TABLE [dbo].[Vehiculo]
(
 VehiculoId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Vehiculo PRIMARY KEY CLUSTERED(VehiculoId)
,MarcaVehiculoId INT NOT NULL
     CONSTRAINT FK_Vehiculo_MarcaVehiculo FOREIGN KEY(MarcaVehiculoId) REFERENCES dbo.MarcaVehiculo(MarcaVehiculoId)
, Matricula VARCHAR(250) NOT NULL
, Color VARCHAR(250) NOT NULL
, Modelo VARCHAR(250) NOT NULL
, FechaModelo DATE NOT NULL CONSTRAINT DF_Vehiculo_FechaModelo default('2020-01-01')
,TieneDefectos BIT NOT NULL CONSTRAINT DF_Vehiculo_TieneDefectos default(0)
,Defectos VARCHAR(1000) NULL
, Estado BIT NOT NULL
)
WITH (DATA_COMPRESSION=PAGE)
GO

CREATE UNIQUE NONCLUSTERED INDEX IDX_Vehiculo_Matricula
ON dbo.Vehiculo(Matricula)
WITH (DATA_COMPRESSION=PAGE)
GO

