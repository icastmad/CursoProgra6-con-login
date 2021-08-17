CREATE PROCEDURE [dbo].AgenciaLista
	
AS
	BEGIN
	SET NOCOUNT ON


	SELECT
	 AgenciaId,
	 Nombre
	FROM Agencias
	WHERE Estado=1


	END