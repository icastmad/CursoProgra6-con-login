CREATE PROCEDURE [dbo].ClientesObtener
	@ClientesId INT= null
AS
	begin
	SET NOCOUNT ON


	 SELECT
	 C.ClientesId,
	 C.NombreCompleto,
	 C.Direccion,
	 C.Telefono,
	 C.Estado,
	 A.AgenciaId,
	 A.Nombre
	 FROM dbo.Clientes C
	 INNER JOIN dbo.Agencias A
			ON (C.AgenciaId=A.AgenciaId)
	 WHERE

	 (@ClientesId IS NULL OR ClientesId=@ClientesId)



	end