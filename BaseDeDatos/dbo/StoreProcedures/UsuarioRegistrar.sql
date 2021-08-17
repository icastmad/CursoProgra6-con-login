CREATE PROCEDURE dbo.UsuarioRegistrar
@Usuario varchar(250),
@Nombre varchar(500),
@Contrasena VARCHAR(250)
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
DECLARE @ContrasenaSHA1 VARBINARY(MAX)=(SELECT HASHBYTES('SHA1',@Contrasena));

	IF NOT EXISTS( SELECT * FROM dbo.Usuarios WHERE @Usuario=Usuario) BEGIN

				INSERT INTO dbo.Usuarios
					(Usuario,Nombre,Contrasena,Estado)
					VALUES
					(@Usuario,@Nombre,@ContrasenaSHA1,1)

		
		
		SELECT 0 AS CodeError, '' AS MsgError

		END
		ELSE BEGIN 
		
			SELECT -1 AS CodeError, 'Este Usuario se encuetra en uso por favor ingresar otro usuario!' AS MsgError


		END


		COMMIT TRANSACTION TRASA


	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END