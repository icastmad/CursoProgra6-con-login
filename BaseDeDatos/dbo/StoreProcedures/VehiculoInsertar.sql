CREATE PROCEDURE dbo.VehiculoInsertar
    @MarcaVehiculoId INT,
	@Matricula varchar(250)	,
	@Color varchar(250)	,
	@Modelo varchar(250),
	@Estado BIT,
	@FechaModelo DATE,
	@TieneDefectos BIT ,
	@Defectos VARCHAR(1000)= NULL
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Vehiculo 
		(
	     MarcaVehiculoId
	    , Matricula 
	    , Color
	    , Modelo 
	    , Estado 
		, FechaModelo
		, TieneDefectos
		, Defectos
		)
		VALUES
		(
		 @MarcaVehiculoId
	    , @Matricula 
	    , @Color
	    , @Modelo 
	    , @Estado 
		, @FechaModelo
		, @TieneDefectos
		, @Defectos
		)


		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END