CREATE DATABASE Gestionar_Contactos

GO

USE Gestionar_Contactos

GO


CREATE TABLE Contactos (

IDContacto int primary key identity(1,1) not null,

CodeContacto as ('CC' + right('00' + convert(nvarchar,IDContacto),(2))),

Nombre nvarchar(40) not null,

Apellido nvarchar(50) not null,

Dirrecion nvarchar(50) not null,

Nacimiento nvarchar(30) not null,

Telefono nvarchar(20) not null
)

Go

--Procedimiento de Buscar Contactos

CREATE PROC SP_BuscarContacto
@Buscar nvarchar(30)
as
SELECT * FROM Contactos
WHERE Nombre LIKE @Buscar + '%' 

GO

-- Procedimiento de Insertar Contactos

CREATE PROC SP_InsertarContacto
@Nombre nvarchar(40),
@Apellido nvarchar(50),
@Dirrecion nvarchar(50),
@Nacimiento nvarchar(30),
@Telefono nvarchar(20)
AS
INSERT INTO Contactos VALUES (@Nombre,@Apellido,@Dirrecion,@Nacimiento,@Telefono)

GO


-- Procedimiento de Editar Contactos

CREATE PROC SP_EditarContacto
@CodeContacto nvarchar(20),
@Nombre nvarchar(40),
@Apellido nvarchar(50),
@Dirrecion nvarchar(50),
@Nacimiento nvarchar(30),
@Telefono nvarchar(20)
AS
UPDATE Contactos SET Nombre = @Nombre, Apellido = @Apellido, Dirrecion = @Dirrecion,
Nacimiento = @Nacimiento, Telefono = @Telefono
WHERE CodeContacto = @CodeContacto

GO


--Procedimiento de Eliminar Contactos

CREATE PROC SP_EliminarContacto
@CodeContacto nvarchar(20)
AS
DELETE Contactos
WHERE CodeContacto = @CodeContacto

GO


