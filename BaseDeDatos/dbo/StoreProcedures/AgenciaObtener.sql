CREATE PROCEDURE [dbo].AgenciaObtener
@AgenciaId INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			A.AgenciaId
		,   A.Nombre
		,   A.Estado

		,   CP.IdCatalogoProvincia
		,	CP.NombreCatalogoProvincia

		, CC.IdCatalogoCanton
		,	CC.NombreCatalogoCanton

		,   CD.IdCatalogoDistrito
		,	CD.NombreCatalogoDistrito
	
				

	FROM Agencias A
	 INNER JOIN dbo.CatalogoProvincia CP
         ON A.IdCatalogoProvincia = CP.IdCatalogoProvincia
     INNER JOIN dbo.CatalogoCanton CC
         ON A.IdCatalogoCanton = CC.IdCatalogoCanton
	 INNER JOIN dbo.CatalogoDistrito CD
         ON A.IdCatalogoDistrito = CD.IdCatalogoDistrito
	WHERE
	     (@AgenciaId IS NULL OR AgenciaId=@AgenciaId)

END