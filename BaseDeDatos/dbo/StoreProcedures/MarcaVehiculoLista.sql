CREATE PROCEDURE dbo.MarcaVehiculoLista

AS
	BEGIN
		SET NOCOUNT ON



		SELECT 
		MarcaVehiculoId,
		Descripcion

		FROM	
			dbo.MarcaVehiculo

			WHERE
					Estado=1






	END