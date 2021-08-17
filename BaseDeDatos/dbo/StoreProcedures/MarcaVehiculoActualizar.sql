CREATE PROCEDURE [dbo].[MarcaVehiculoActualizar]
@MarcaVehiculoId INT,
@Descripcion VARCHAR(250), 
@Estado BIT
AS
  BEGIN
  SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
		UPDATE MarcaVehiculo
		SET
		Descripcion=@Descripcion,
		Estado=@Estado
		WHERE 
			MarcaVehiculoId=@MarcaVehiculoId

	   COMMIT TRANSACTION TRASA

	   SELECT 0 AS CodError , '' AS MsgError

   END TRY

   BEGIN CATCH
		SELECT
			ERROR_NUMBER() AS CodError,
			ERROR_MESSAGE() AS MsgError
		ROLLBACK TRANSACTION TRASA

   END CATCH

  END
