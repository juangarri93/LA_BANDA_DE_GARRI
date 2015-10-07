USE [GD2C2015]
GO

CREATE SCHEMA [LA_BANDA_DE_GARRI] AUTHORIZATION [gd]
GO

CREATE TABLE [Roles] (
[Id] TINYINT IDENTITY (1,1),	
[Rol] NVARCHAR(255) NOT NULL,
[Habilitado] BIT DEFAULT 1 NOT NULL, --0 false 1 true
CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
 )
 
CREATE TABLE [Funcionalidades] (
[Id] TINYINT IDENTITY (1,1),
[Nombre] VARCHAR (255) NOT NULL,
CONSTRAINT [PK_Funcionalidades] PRIMARY KEY ([Id])
)

CREATE TABLE [Rol_Funcionalidad] (
Id_Rol  TINYINT NOT NULL,
Id_Funcionalidad TINYINT NOT NULL,
CONSTRAINT [PK_Rol_Funcionalidad] PRIMARY KEY ([Id_Rol], [Id_Funcionalidad]),
CONSTRAINT [FK_Rol] FOREIGN KEY ([Id_Rol]) REFERENCES [LA_BANDA_DE_GARRI].[Roles] ([Id]),
CONSTRAINT [FK_Funcionalidad] FOREIGN KEY ([Id_Funcionalidad]) REFERENCES [LA_BANDA_DE_GARRI].[Funcionalidades] ([Id])
)

GO
 -- Transaccion para la migracion de datos (acá irian todos los inserts a las tablas)
 begin tran trn_migracion_datos
        
		insert into LA_BANDA_DE_GARRI.Roles(Rol,Habilitado)
            values('Administrador',1)

        insert into LA_BANDA_DE_GARRI.Roles(Rol,Habilitado)
            values('Cliente',1)
		
		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('ABM Rol')	
			
		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Login y Seguridad')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Registro de Usuario')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('ABM Ciudad')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('ABM Ruta Aerea')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('ABM Aeronave')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Generar Viaje')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Registro de Llegada a Destino')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Compra de pasaje/encomienda')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Devolucion/Cancelacion de pasaje y/o encomienda')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Consulta de millas de pasajero frecuente')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Canje de millas')

		insert into LA_BANDA_DE_GARRI.Funcionalidades(Nombre)
            values('Listado Estadístico')			
			

commit tran trn_migracion_datos
 
 
CREATE TABLE LA_BANDA_DE_GARRI.Tipo_servicio(
id int identity,
Tipo_Servicio nvarchar(255),
PRIMARY KEY (id))

CREATE TABLE LA_BANDA_DE_GARRI.Fabricante(
id int identity,
Nombre nvarchar(255),
PRIMARY KEY (id))

CREATE TABLE LA_BANDA_DE_GARRI.Modelo(
id int identity,
Fabricante int NOT NULL REFERENCES [LA_BANDA_DE_GARRI].[Fabricante],
Nombre nvarchar(255),
PRIMARY KEY (id))

CREATE TABLE LA_BANDA_DE_GARRI.Aeronave(
id int identity,
Matricula nvarchar(255),
Modelo int NOT NULL REFERENCES [LA_BANDA_DE_GARRI].[Modelo],
Kg_Disponibles numeric(18,0),
Cantidad_Butacas_Ventana numeric(18,0),
Cantidad_Ventanas_Pasillo numeric(18,0),
Baja_Fuera_Servicio datetime,
Fecha_Reinicio datetime,
Baja_Vida_Util datetime,
Numero_Aeronave numeric(18,0), 
PRIMARY KEY (id))

create table LA_BANDA_DE_GARRI.Butaca_Ventanilla (
id INT IDENTITY, 
Butaca_Nro numeric(18,0), 
Butaca_Tipo nvarchar(255), 
Butaca_Piso numeric(18,0), 
Aeronave int NOT NULL REFERENCES [LA_BANDA_DE_GARRI].[Aeronave])

insert into LA_BANDA_DE_GARRI.Butaca_Ventanilla
SELECT M.Butaca_Nro, M.Butaca_Piso, M.Butaca_Tipo
FROM gd_esquema.Maestra M
