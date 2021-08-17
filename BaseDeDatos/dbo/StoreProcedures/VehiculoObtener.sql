CREATE PROCEDURE [dbo].VehiculoObtener
@VehiculoId INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			V.VehiculoId
		,   V.Matricula
		,   V.Color
		,   V.Modelo
		,   V.Estado
		,   V.FechaModelo
		,	V.TieneDefectos
		,   V.Defectos
		,   MV.MarcaVehiculoId
		,	MV.Descripcion
	
				

	FROM dbo.Vehiculo V
	 INNER JOIN dbo.MarcaVehiculo MV
         ON V.MarcaVehiculoId = MV.MarcaVehiculoId
	WHERE
	     (@VehiculoId IS NULL OR VehiculoId=@VehiculoId)

END