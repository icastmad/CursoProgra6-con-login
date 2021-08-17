CREATE PROCEDURE [dbo].[CatalogoCantonLista]
@IdCatalogoProvincia INT=null
AS
	BEGIN
		SET NOCOUNT ON
		SELECT 
		IdCatalogoCanton,
		NombreCatalogoCanton

		FROM	
			CatalogoCanton

	    WHERE
		    IdCatalogoProvincia=@IdCatalogoProvincia


	END