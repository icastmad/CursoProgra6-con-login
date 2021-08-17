CREATE PROCEDURE dbo.Login
@Usuario VARCHAR(250),
@Contrasena VARCHAR(250)
AS 
BEGIN
SET NOCOUNT  ON


DECLARE @ContrasenaSHA1 VARBINARY(MAX)=(SELECT HASHBYTES('SHA1',@Contrasena));

IF NOT EXISTS(SELECT * FROM Usuarios WHERE Usuario=@Usuario) BEGIN
	SELECT -1 AS CodeError, 'El nombre del usuario no existe' AS MsgError

END
ELSE IF EXISTS( SELECT * FROM Usuarios WHERE Usuario=@Usuario AND Estado =0) BEGIN
 
 SELECT -1 AS CodeError, 'El Usuario se encuentra inactivo!' AS MsgError
END
ELSE IF  NOT EXISTS( SELECT * FROM Usuarios WHERE Usuario=@Usuario and Contrasena=@ContrasenaSHA1 AND Estado =1) BEGIN
 
 SELECT -1 AS CodeError, 'La contraseña es incorrecta por favor volver a intentar!' AS MsgError
END
ELSE BEGIN

	SELECT 
	0 AS CodeError,
	UsuariosId,
	Usuario,
	Nombre

	FROM Usuarios 
		WHERE Usuario=@Usuario and Contrasena=@ContrasenaSHA1 

END



	

END