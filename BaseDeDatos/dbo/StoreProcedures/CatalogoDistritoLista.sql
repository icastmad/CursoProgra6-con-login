CREATE PROCEDURE [dbo].CatalogoDistritoLista
@IdCatalogoCanton INT=null
AS
	BEGIN
		SET NOCOUNT ON
		SELECT 
		IdCatalogoDistrito,
		NombreCatalogoDistrito

		FROM	
			CatalogoDistrito

	    WHERE
		    IdCatalogoCanton=@IdCatalogoCanton


	END
