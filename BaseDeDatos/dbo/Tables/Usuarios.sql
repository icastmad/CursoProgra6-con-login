CREATE TABLE [dbo].[Usuarios]
(
	 UsuariosId INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Usuarios PRIMARY KEY CLUSTERED(UsuariosId)
	, Usuario VARCHAR(250) NOT NULL
	, Nombre varchar(500) not null
	, Contrasena VARBINARY(max) NOT NULL
	, Estado BIT NOT NULL
)
