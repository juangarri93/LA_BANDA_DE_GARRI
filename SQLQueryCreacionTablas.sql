USE [GD2C2015]
GO

--Dropeo las functions
IF (OBJECT_ID('LA_BANDA_DE_GARRI.fn_aeronave_esta_disponible') IS NOT NULL)
  DROP FUNCTION LA_BANDA_DE_GARRI.fn_aeronave_esta_disponible;
  
IF (OBJECT_ID('LA_BANDA_DE_GARRI.fn_servicio_es_valido') IS NOT NULL)
  DROP FUNCTION LA_BANDA_DE_GARRI.fn_servicio_es_valido;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.fn_validar_stock') IS NOT NULL)
  DROP FUNCTION LA_BANDA_DE_GARRI.fn_validar_stock;

--Dropeo las procedures 
IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_rol_funcionalidad ') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_rol_funcionalidad ;
  
  IF (OBJECT_ID('LA_BANDA_DE_GARRI.spMostrar_Funcionalidades ') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spMostrar_Funcionalidades ;

 IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_rol ') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_rol ;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spdardebaja_aerolinea') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spdardebaja_aerolinea;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_fabricante') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_fabricante;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_modelo') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_modelo;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_tipo_servicio') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_tipo_servicio;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_aeronave;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_aeronave;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_baja_ruta_aerea') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_baja_ruta_aerea;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.speditar_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.speditar_aeronave;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_aeronave;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbuscarFabricante_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbuscarFabricante_aeronave;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbuscarNumero_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbuscarNumero_aeronave;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbuscarModelo_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbuscarModelo_aeronave;
   
IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_cancelar_pasajes_encomiendas') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_cancelar_pasajes_encomiendas;
  
IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_comprar_encomienda') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_comprar_encomienda;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_registrar_llegada_destino') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_registrar_llegada_destino;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_comprar_pasaje') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_comprar_pasaje

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_canjear_millas') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_canjear_millas;
  
IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_generar_viaje') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_generar_viaje;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_crear_ruta_aerea') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_crear_ruta_aerea;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_login') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_login;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_agregar_funcionalidad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_agregar_funcionalidad;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_cambiar_estado_rol') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_cambiar_estado_rol;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_consultar_millas') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_consultar_millas;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_eliminar_funcionalidad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_eliminar_funcionalidad;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_listar_roles') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_listar_roles;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_cambiar_nombre_rol') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_cambiar_nombre_rol;

--Dropeo las tablas
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Usuarios]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Usuarios];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Millas]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Millas];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Canje_Millas]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Canje_Millas];
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Rol_Funcionalidad]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Rol_Funcionalidad];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Devoluciones]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Devoluciones];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Butaca]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Butaca];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Tipo_Butaca]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Tipo_Butaca];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Ruta_Aerea]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Ruta_Aerea];
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Pago]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Pago];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Pasaje_Encomienda]', 'U') IS NOT NULL
DROP TABLE [LA_BANDA_DE_GARRI].[Pasaje_Encomienda];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Viajes]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Viajes];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Productos]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Productos];
 
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Clientes]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Clientes];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Funcionalidades]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Funcionalidades];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Roles]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Roles];
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Ciudades]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Ciudades];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Aeronave]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Aeronave];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Modelo]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Modelo];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Fabricante]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Fabricante];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Tipo_Servicio]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Tipo_Servicio];

--Dropeo el schema

DROP SCHEMA [LA_BANDA_DE_GARRI]
GO

CREATE SCHEMA [LA_BANDA_DE_GARRI]
GO

--Empiezo la creacion de tablas

CREATE TABLE [LA_BANDA_DE_GARRI].[Roles] (
[Id] TINYINT IDENTITY (1,1),	
[Rol] NVARCHAR(255) UNIQUE NOT NULL,
[Habilitado] BIT DEFAULT 1 NOT NULL, --0 false 1 true
CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
 )

CREATE TABLE [LA_BANDA_DE_GARRI].[Funcionalidades] (
[Id] TINYINT IDENTITY (1,1),
[Nombre] NVARCHAR (255) UNIQUE NOT NULL,
CONSTRAINT [PK_Funcionalidades] PRIMARY KEY ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Rol_Funcionalidad] (
[Id_Rol] TINYINT NOT NULL,
[Id_Funcionalidad] TINYINT NOT NULL,
CONSTRAINT [PK_Rol_Funcionalidad] PRIMARY KEY ([Id_Rol], [Id_Funcionalidad]),
CONSTRAINT [FK_Rol] FOREIGN KEY ([Id_Rol]) REFERENCES [LA_BANDA_DE_GARRI].[Roles] ([Id]),
CONSTRAINT [FK_Funcionalidad] FOREIGN KEY ([Id_Funcionalidad]) REFERENCES [LA_BANDA_DE_GARRI].[Funcionalidades] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Usuarios] (
[Id] INT IDENTITY (1,1),
[Username] NVARCHAR (255) UNIQUE NOT NULL,
[Password] NVARCHAR (255),
[ultimo_login] DATETIME,
[intentos_fallidos] TINYINT,
[habilitado] BIT,
[Id_Rol] TINYINT NOT NULL,
CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Rol_Usuario] FOREIGN KEY ([Id_Rol]) REFERENCES [LA_BANDA_DE_GARRI].[Roles] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Ciudades](
[Id] INT IDENTITY (1,1),
[Nombre] NVARCHAR(255),
[Habilitada] BIT DEFAULT 1 NOT NULL,
CONSTRAINT [PK_Ciudades] PRIMARY KEY ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Ruta_Aerea](
[Id] INT IDENTITY (1,1),
[Codigo] NUMERIC(18,0),
[Tipo_Servicio] NVARCHAR(255) NOT NULL,
[Ciudad_Origen] INT,
[Ciudad_Destino] INT,
[Precio_base_pasaje] NUMERIC(18,2),
[Precio_base_kg] NUMERIC(18,2),
[Habilitada] BIT DEFAULT 1 NOT NULL,   
CONSTRAINT [PK_Ruta_Aerea] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Ciudad_Origen] FOREIGN KEY ([Ciudad_Origen]) REFERENCES [LA_BANDA_DE_GARRI].[Ciudades] ([Id]),
CONSTRAINT [FK_Ciudad_Destino] FOREIGN KEY ([Ciudad_Destino]) REFERENCES [LA_BANDA_DE_GARRI].[Ciudades] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Tipo_Servicio](
id int identity,
Tipo_Servicio nvarchar(255),
PRIMARY KEY (id))

CREATE TABLE [LA_BANDA_DE_GARRI].[Fabricante](
[id] int identity,
[Nombre] nvarchar(255),
PRIMARY KEY (id))

CREATE TABLE [LA_BANDA_DE_GARRI].[Modelo](
[id] int identity,
[Nombre] nvarchar(255),
PRIMARY KEY (id)
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Aeronave](
[Id] int identity,
[Fecha_alta] date,
[Numero] int,
[Matricula] varchar(255),
[Modelo] int,
[Fabricante] int,
[Tipo_Servicio] int,
[Cantidad_Butacas_Ventana] int,
[Cantidad_Ventanas_Pasillo] int,
[Baja_Fuera_Servicio] varchar(50),
[Baja_Vida_Util] varchar(50),
[Fecha_Reinicio] datetime,
[Fecha_Fuera_Servicio] date,
[Fecha_baja_definitiva] date,
[Kg_Disponibles] int
PRIMARY KEY (id),
CONSTRAINT [FK_Modelo] FOREIGN KEY ([Modelo]) REFERENCES [LA_BANDA_DE_GARRI].[Modelo] ([Id]),
CONSTRAINT [FK_Fabricante] FOREIGN KEY (Fabricante) REFERENCES [LA_BANDA_DE_GARRI].Fabricante ([Id]),
CONSTRAINT [FK_TipoServ] FOREIGN KEY ([Tipo_Servicio]) REFERENCES [LA_BANDA_DE_GARRI].[Tipo_Servicio] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Viajes] (
[Id] INT IDENTITY (1,1),
[Fecha_salida] DATETIME,
[Fecha_llegada] DATETIME,
[Fecha_llegada_estimada] DATETIME,
[Id_Aeronave] INT,
[Codigo_Ruta_Aerea] NUMERIC(18,0),
CONSTRAINT [PK_Viajes] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Aeronave] FOREIGN KEY ([Id_Aeronave]) REFERENCES [LA_BANDA_DE_GARRI].[Aeronave] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Clientes] (
[Id] INT IDENTITY (1,1),
[Nombre] NVARCHAR(255) NOT NULL,
[Apellido] NVARCHAR(255) NOT NULL,
[dni] NUMERIC(18,0) UNIQUE NOT NULL,
[direccion] NVARCHAR(255),
[telefono] NUMERIC(18,0), 
[mail] NVARCHAR(255),
[fecha_nacimiento] DATETIME,
CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Pasaje_Encomienda] (
[Id] INT IDENTITY(1,1),
[Id_Cliente] INT,
[Id_Viaje] INT,
[cantidad_butacas] INT,
[KG] NUMERIC(18,0),
CONSTRAINT [PK_Pasaje_Encomienda] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Cliente_PasajeEncomienda] FOREIGN KEY ([Id_Cliente]) REFERENCES [LA_BANDA_DE_GARRI].[Clientes] ([Id]),
CONSTRAINT [FK_Viaje] FOREIGN KEY ([Id_Viaje]) REFERENCES [LA_BANDA_DE_GARRI].[Viajes] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Pago](
[PNR] INT IDENTITY (1,1),
[Id_viaje] INT,
[Id_Cliente] INT,
[Importe] NUMERIC(18,2),
[Fecha_compra] DATETIME,
[Tipo_Pago] CHAR(1),
CONSTRAINT [PK_Pago] PRIMARY KEY ([PNR]),
CONSTRAINT [FK_Cliente_Pago] FOREIGN KEY ([Id_Cliente]) REFERENCES [LA_BANDA_DE_GARRI].[Clientes] ([Id]),
CONSTRAINT [FK_Viaje_Pago] FOREIGN KEY ([Id_Viaje]) REFERENCES [LA_BANDA_DE_GARRI].[Viajes] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Devoluciones] (
[PNR] INT,
[Id_Pasaje_Encomienda] INT,
[Fecha_Devolucion] DATETIME,
[Motivo] NVARCHAR(255),
CONSTRAINT [PK_Devolucion] PRIMARY KEY ([PNR]),
CONSTRAINT [FK_PNR] FOREIGN KEY ([PNR]) REFERENCES [LA_BANDA_DE_GARRI].[Pago] ([PNR]),
CONSTRAINT [FK_Pasaje_Encomienda] FOREIGN KEY ([Id_Pasaje_Encomienda]) REFERENCES [LA_BANDA_DE_GARRI].[Pasaje_Encomienda] ([Id]),
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Millas] (
[Id_cliente] INT,
[Cantidad] INT,
[Validez_Hasta] DATETIME,
CONSTRAINT [PK_Millas] PRIMARY KEY ([Id_Cliente]),
CONSTRAINT [FK_Cliente] FOREIGN KEY ([Id_Cliente]) REFERENCES [LA_BANDA_DE_GARRI].[Clientes] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Productos] (
[Id] INT IDENTITY(1,1),
[Descripcion] NVARCHAR(255),
[Stock] int,
CONSTRAINT [PK_Productos] PRIMARY KEY ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Canje_Millas] (
[Id] INT IDENTITY,
[DNI] NUMERIC(18,0),
[Producto_elegido] INT,
[cantidad] INT,
[Fecha] DATETIME,
CONSTRAINT [PK_Canje_Millas] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Producto] FOREIGN KEY ([Producto_elegido]) REFERENCES [LA_BANDA_DE_GARRI].[Productos] ([Id])
)

create table [LA_BANDA_DE_GARRI].[Tipo_Butaca](
[Id] INT IDENTITY,
[Tipo] nvarchar(255), 
CONSTRAINT [PK_Tipo_Butaca] PRIMARY KEY ([Id])
)

create table [LA_BANDA_DE_GARRI].[Butaca] (
[Id] INT IDENTITY, 
[Nro] numeric(18,0), 
[Tipo] INT, 
[Piso] numeric(18,0), 
[Aeronave_id] int not null,
CONSTRAINT [PK_Butaca] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Aeronave_Butaca] FOREIGN KEY ([Aeronave_id]) REFERENCES [LA_BANDA_DE_GARRI].[Aeronave] ([Id]),
CONSTRAINT [FK_Tipo_Butaca] FOREIGN KEY ([Tipo]) REFERENCES [LA_BANDA_DE_GARRI].[Tipo_Butaca] ([Id])
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

-- el hash de w23e --> e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7
		insert into LA_BANDA_DE_GARRI.Usuarios(Username, Password, Id_Rol)
            values('gonza', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1)					

		insert into LA_BANDA_DE_GARRI.Usuarios(Username, Password, Id_Rol)
            values('garri', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1)

		insert into LA_BANDA_DE_GARRI.Usuarios(Username, Password, Id_Rol)
            values('lucas', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1)

		insert into LA_BANDA_DE_GARRI.Usuarios(Username, Password, Id_Rol)
            values('nico', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 1)

			
		insert into LA_BANDA_DE_GARRI.Ciudades(Nombre)
			select distinct master.Ruta_Ciudad_Origen
                from gd_esquema.Maestra master
			where master.Ruta_Ciudad_Origen is not null
			UNION
			select distinct master.Ruta_Ciudad_Destino
                from gd_esquema.Maestra master
				where master.Ruta_Ciudad_Destino is not null
				
		insert into LA_BANDA_DE_GARRI.Tipo_Butaca(Tipo)
			select distinct gd_esquema.Maestra.Butaca_Tipo from gd_esquema.Maestra
			where gd_esquema.Maestra.Butaca_Tipo !='0';
				
		insert into LA_BANDA_DE_GARRI.Tipo_Servicio(Tipo_Servicio)
			select distinct gd_esquema.Maestra.Tipo_Servicio from gd_esquema.Maestra;

		insert into LA_BANDA_DE_GARRI.Fabricante(Nombre)
			select distinct gd_esquema.Maestra.Aeronave_Fabricante from gd_esquema.Maestra;

		insert into LA_BANDA_DE_GARRI.Modelo(Nombre)
			select distinct gd_esquema.Maestra.Aeronave_Modelo from gd_esquema.Maestra;

		insert into LA_BANDA_DE_GARRI.Aeronave(Matricula, Modelo, Fabricante, Tipo_Servicio, Kg_Disponibles)
			select distinct gd_esquema.Maestra.Aeronave_Matricula, 
			(Select LA_BANDA_DE_GARRI.Modelo.id from LA_BANDA_DE_GARRI.Modelo
			where LA_BANDA_DE_GARRI.Modelo.Nombre = gd_esquema.Maestra.Aeronave_Modelo),
			(select LA_BANDA_DE_GARRI.Fabricante.id from LA_BANDA_DE_GARRI.Fabricante 
			where LA_BANDA_DE_GARRI.Fabricante.Nombre = gd_esquema.Maestra.Aeronave_Fabricante), 
			(Select LA_BANDA_DE_GARRI.Tipo_Servicio.id from LA_BANDA_DE_GARRI.Tipo_Servicio
			where LA_BANDA_DE_GARRI.Tipo_Servicio.Tipo_Servicio = gd_esquema.Maestra.Tipo_Servicio), 
			gd_esquema.Maestra.Aeronave_KG_Disponibles
			from gd_esquema.Maestra;

		insert into LA_BANDA_DE_GARRI.Butaca(Nro,Tipo,Piso,Aeronave_id)
			select distinct gd_esquema.Maestra.Butaca_Nro, 
			(Select LA_BANDA_DE_GARRI.Tipo_Butaca.Id from LA_BANDA_DE_GARRI.Tipo_Butaca
			where LA_BANDA_DE_GARRI.Tipo_Butaca.Tipo = gd_esquema.Maestra.Butaca_Tipo), 
			gd_esquema.Maestra.Butaca_Piso,
			(Select LA_BANDA_DE_GARRI.Aeronave.Id from LA_BANDA_DE_GARRI.Aeronave
			where LA_BANDA_DE_GARRI.Aeronave.Matricula = gd_esquema.Maestra.Aeronave_Matricula)
			 from gd_esquema.Maestra;

		insert into LA_BANDA_DE_GARRI.Clientes(Nombre, Apellido, dni, direccion, telefono, mail, fecha_nacimiento)
			select distinct m.Cli_Nombre, m.Cli_Apellido, m.Cli_Dni, m.Cli_Dir, m.Cli_Telefono, m.Cli_Mail, m.Cli_Fecha_Nac
                from gd_esquema.Maestra m				

commit tran trn_migracion_datos

GO

--STORED PROCEDURES
--ABM ROL
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_listar_roles AS
BEGIN
	select Rol
	from LA_BANDA_DE_GARRI.Roles
END
GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_cambiar_nombre_rol(@rol NVARCHAR(255), @nuevo_nombre NVARCHAR(255)) AS
BEGIN
	update LA_BANDA_DE_GARRI.Roles
	set Rol = @nuevo_nombre
	where Rol = @rol
END

GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_agregar_funcionalidad(@rol nvarchar(255), @func nvarchar(255)) AS
BEGIN
		INSERT INTO LA_BANDA_DE_GARRI.Rol_Funcionalidad(Id_Rol, Id_Funcionalidad)
		VALUES ((SELECT Id FROM LA_BANDA_DE_GARRI.Roles WHERE Rol = @rol),
		        (SELECT Id FROM LA_BANDA_DE_GARRI.Funcionalidades WHERE Nombre = @func))
END

GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_eliminar_funcionalidad(@rol nvarchar(255), @func nvarchar(255)) AS
BEGIN
		delete from LA_BANDA_DE_GARRI.Rol_Funcionalidad
		where Id_Rol = (SELECT Id FROM LA_BANDA_DE_GARRI.Roles WHERE Rol = @rol) 
		and Id_Funcionalidad = (SELECT Id FROM LA_BANDA_DE_GARRI.Funcionalidades WHERE Nombre = @func)
END

GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_cambiar_estado_rol(@rol NVARCHAR(255), @nuevo_nombre NVARCHAR(255), @estado BIT) AS
BEGIN
	update LA_BANDA_DE_GARRI.Roles
	set Habilitado = @estado
	where Rol = @rol
END

GO

--LOGIN
create procedure LA_BANDA_DE_GARRI.sp_login (@username_enviado NVARCHAR(255) , @password NVARCHAR(255), @result NVARCHAR(25) output) AS
begin

	if @username_enviado is null
		begin
			set @result = 'LOGIN_ERROR'
			return 1
		end

	declare @check_password nvarchar(255)
	declare @check_habilitado bit
	declare @check_fallidos tinyint

	if (exists(select password from LA_BANDA_DE_GARRI.Usuarios where username = @username_enviado))

		begin
			-- Seleccionamos el hash
			set @check_password = (select password from LA_BANDA_DE_GARRI.Usuarios where username = @username_enviado)

			-- Seleccionamos si está habilitado
			set @check_habilitado = (select habilitado from LA_BANDA_DE_GARRI.Usuarios where username = @username_enviado)
			if (@check_habilitado = 0)

				begin
					set @result = 'LOGIN_OFF'
					return 1
				end


			-- Si intentos_fallidos = 3, deshabilitar usuario
			set @check_fallidos = (select intentos_fallidos from LA_BANDA_DE_GARRI.Usuarios where username = @username_enviado)
			if (@check_fallidos >= 3)
				begin
						update LA_BANDA_DE_GARRI.Login
							set habilitado = 0
							where username = @username_enviado

						set @result = 'LOGIN_MAS_TRES_VECES'
						return 1
				end    

			-- Usuario correcto pero contraseña incorrecta
			if (@check_password <> @password)
				
				begin
						update LA_BANDA_DE_GARRI.Usuarios
							set intentos_fallidos = intentos_fallidos + 1
							where username = @username_enviado

						set @result = 'LOGIN_ERROR_PASSWORD'
						return 1
				end              

			-- Login Correcto deberia entrar aca
			if (@check_habilitado = 1 and @check_password = @password)
				begin
					update LA_BANDA_DE_GARRI.Usuarios
						set intentos_fallidos = 0
						where username = @username_enviado

					set @result = 'LOGIN_OK'
					return 0
				end
		end
	
	-- Si no se cumple ninguna de las condiciones anteriores, (usuario inexistente, otro error, etc) retornar error
	set @result = 'LOGIN_ERROR'
	return 1
	
end

GO

--ABM DE USUARIO NO ES NECESARIO HACERLO
--ABM CIUDADES NO ES NECESARIO HACERLO

--ABM RUTA AEREA
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_crear_ruta_aerea (@codigo numeric(18,0), 
														@tipo NVARCHAR(255), 
														@origen int, 
														@destino int, 
														@precio_pasaje numeric(18,2),
														@precio_kg numeric(18,2)) AS
BEGIN
	insert into LA_BANDA_DE_GARRI.Ruta_Aerea(Codigo, Tipo_Servicio, Ciudad_Origen, Ciudad_Destino, Precio_base_pasaje, Precio_base_kg)
	values(@codigo, @tipo, @origen, @destino, @precio_pasaje, @precio_kg)
END

GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_baja_ruta_aerea(@codigo numeric(18,0)) AS
BEGIN
	update LA_BANDA_DE_GARRI.Ruta_Aerea
	set Habilitada = 0
	where Codigo = @codigo
	
	--EXEC LA_BANDA_DE_GARRI.sp_cancelar_pasajes_encomiendas @codigo = @codigo --falta codificar este sp
END

GO

--ABM AERONAVES

create function LA_BANDA_DE_GARRI.fn_servicio_es_valido(@ruta_aerea NUMERIC(18,0),@aeronave NVARCHAR(255))RETURNS INT as
begin
	
	DECLARE @tipo_servicio_ruta NVARCHAR(255);
	DECLARE @tipo_servicio_aeronave NVARCHAR(255);
	
	select @tipo_servicio_ruta = tipo_servicio 
	from LA_BANDA_DE_GARRI.Ruta_aerea
	where Codigo = @ruta_aerea
	
	select @tipo_servicio_aeronave = tipo_servicio
	from LA_BANDA_DE_GARRI.Aeronave
	where matricula = @aeronave
	
	if(@tipo_servicio_ruta <> @tipo_servicio_aeronave)
		begin
			return 0;
		end;
	return 1;
end

GO


create function LA_BANDA_DE_GARRI.fn_aeronave_esta_disponible(@aeronave NVARCHAR(255), @fecha_salida DATETIME) RETURNS INT as
BEGIN
	DECLARE @cantidad INT;
	
	select @cantidad = count(*) 
	from LA_BANDA_DE_GARRI.Viajes
	where Id_Aeronave = @aeronave
	and Fecha_salida = @fecha_salida
	
		if(@cantidad <> 0)
		begin
			return 0;
		end;
	return 1;

END

GO


--GENERAR VIAJE
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_generar_viaje(@ruta_aerea numeric(18,0), 
													@aeronave NVARCHAR(255), 
													@fecha_salida DATETIME, 
													@fecha_llegada DATETIME,
													@resultado varchar(100) output) AS
BEGIN
		
	if(LA_BANDA_DE_GARRI.fn_servicio_es_valido(@ruta_aerea, @aeronave) = 0)
		begin
			set @resultado = 'EL SERVICIO DE LA RUTA AEREA NO COINCIDE CON EL DE LA AERONAVE'
			return	
		end
	
	if(LA_BANDA_DE_GARRI.fn_aeronave_esta_disponible(@aeronave, @fecha_salida) = 0)
		begin
			set @resultado = 'LA AERONAVE NO SE ENCUENTRA DISPONIBLE EN ESA FECHA'
			return	
		end
		
	insert into LA_BANDA_DE_GARRI.Viajes(Fecha_salida, Fecha_llegada_estimada, Id_Aeronave, Codigo_Ruta_Aerea)
	values(@fecha_salida, @fecha_llegada, @aeronave, @ruta_aerea)
	
END
go

--REGISTRO LLEGADA A DESTINO
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_registrar_llegada_destino(@fecha_llegada DATETIME, @aeronave NVARCHAR(255), @origen int, @destino int) AS
BEGIN
return 1;
--insert a una tabla nueva de registro de llegadas?

END

GO


--COMPRA PASAJE-ENCOMIENDA
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_comprar_pasaje(@fecha datetime, @origen int, @destino int) AS
BEGIN
return 1;
END

GO


CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_comprar_encomienda AS
BEGIN

	return 1;
END

GO

--CANCELACION/DEVOLUCION PASAJE-ENCOMIENDA
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_cancelar_pasajes_encomiendas (@codigo NUMERIC (18,0)) AS
BEGIN
	return 1;
END

GO

--CONSULTAR MILLAS
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_consultar_millas(@dni numeric(18,0)) AS
BEGIN
	select *
	from LA_BANDA_DE_GARRI.Millas m
	join LA_BANDA_DE_GARRI.Clientes c on m.Id_Cliente = c.Id
	where c.dni = @dni
	
END

GO

--CANJE DE MILLAS

create function LA_BANDA_DE_GARRI.fn_validar_stock(@producto int, @cantidad int) RETURNS INT as
BEGIN
	DECLARE @stock INT;
	
	select @stock = Stock 
	from LA_BANDA_DE_GARRI.Productos
	where Id = @producto
	--and Fecha_salida = @fecha_salida	PARA QUE ESTO?
		
		if(@stock < @cantidad)
		begin
			return 0;
		end;
	return 1;
END
GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_canjear_millas(@dni numeric(18,0), @producto int, @cant int, @fecha_canje datetime, @resultado nvarchar(255) output) AS
BEGIN

	if(LA_BANDA_DE_GARRI.fn_validar_stock(@producto, @cant) = 0)
	begin
		set @resultado = 'NO HAY STOCK DISPONIBLE DE ESE PRODUCTO'
		return	
	end

	insert into LA_BANDA_DE_GARRI.Canje_Millas(DNI, Producto_elegido, cantidad, Fecha)
	values(@dni, @producto, @cant, @fecha_canje)

END
GO

create proc LA_BANDA_DE_GARRI.spmostrar_aeronave
as
select * from LA_BANDA_DE_GARRI.Aeronave
order by Aeronave.Id
GO

--create proc [LA_BANDA_DE_GARRI].[spinsertar_aeronave]
--(@Id int output, 
--@numeroAeronave int)
--as
--insert into LA_BANDA_DE_GARRI.Aeronave([Numero] )
--values(@numeroAeronave)
--go

create proc LA_BANDA_DE_GARRI.spinsertar_aeronave
(@Id int output, 
@fechaAlta  date,
@numeroAeronave int,  
@modelo int,
@matricula varchar(255),
@fabricante int,
@tipoDeServicio int,
@CantidadButacasVentana int,
@CantidadButacasPasillo int, 
@bajaPorFueraDeServicio varchar(50),
@bajaPorVidaUtil varchar(50),
@FechaDeFueraDeServicio date,
@FechaDeReinicioDeServicio date,
@FechaBajaDefinitiva date,
@kgDisponible int)
as
--BEGIN
insert into LA_BANDA_DE_GARRI.Aeronave([Fecha_alta],
[Numero],[Matricula],[Modelo],[Fabricante],
[Tipo_Servicio],[Cantidad_Butacas_Ventana],[Cantidad_Ventanas_Pasillo],[Baja_Fuera_Servicio],
[Baja_Vida_Util],[Fecha_Reinicio],[Fecha_Fuera_Servicio],
[Fecha_baja_definitiva],[Kg_Disponibles])
values(null,@numeroAeronave,@matricula,@modelo,@fabricante,
@tipoDeServicio,@CantidadButacasVentana,@CantidadButacasPasillo,null,
null,null,null,null, @kgDisponible)

--declare @idAeronave int
--set @idAeronave = (SELECT @@identity AS id)

--declare @aux int
--declare @tipo int
--set @aux = 1
--set @tipo = (select id from LA_BANDA_DE_GARRI.Tipo_Butaca where Tipo = 'Ventana')

--while @aux <= @CantidadButacasVentana
--begin
--insert into LA_BANDA_DE_GARRI.Butaca(Nro,Tipo,Piso,Aeronave_id)
--values(@aux*2,@tipo,1,@idAeronave)
--set @aux = @aux + 1
--end
--set @aux = 0

--set @tipo = (select id from LA_BANDA_DE_GARRI.Tipo_Butaca where Tipo = 'Pasillo')
--while @aux < @CantidadButacasPasillo
--begin
--insert into LA_BANDA_DE_GARRI.Butaca(Nro,Tipo,Piso,Aeronave_id)
--values(@aux*2+1,@tipo,1,@idAeronave)
--set @aux = @aux + 1
--end
--END
go 

--PROCEDIMIENTO BUSCAR NUMERO--
create proc LA_BANDA_DE_GARRI.spbuscarNumero_aeronave
@numeroABuscar int
as
select * from LA_BANDA_DE_GARRI.Aeronave
where Numero like '%' + @numeroABuscar + '%'
go

--PROCEDIMIENTO BUSCAR FABRICANTE--
create proc LA_BANDA_DE_GARRI.spbuscarFabricante_aeronave
@textoBuscar varchar(50)
as
select * from LA_BANDA_DE_GARRI.Aeronave
where Fabricante like '%' + @textoBuscar + '%'
go

--PROCEDIMIENTO BUSCAR MODELO--
create proc LA_BANDA_DE_GARRI.spbuscarModelo_aeronave
@textoBuscar varchar(50)
as
select * from Aeronave
where Modelo like '%' + @textoBuscar + '%'
go

--Modificado por Nico 03/11/2015
--PROCEDIMIENTO EDITAR AERONAVE--
create proc LA_BANDA_DE_GARRI.speditar_aeronave
(@codigo int, 
@fechaAlta  date,
@numeroAeronave int, 
@matricula varchar(50),
@modelo int, 
@fabricante int,
@tipoDeServicio int,
@CantidadButacasVentana int,
@CantidadButacasPasillo int, 
@bajaPorFueraDeServicio varchar(50),
@FechaDeFueraDeServicio date,
@FechaDeReinicioDeServicio date,
@kgDisponible int)
as
update Aeronave set Fecha_alta = @fechaAlta,
Numero = @numeroAeronave,
Modelo = @modelo,
Matricula = @matricula,
Fabricante = @fabricante,
Tipo_Servicio = @tipoDeServicio,
Cantidad_Butacas_Ventana = @CantidadButacasVentana,
Cantidad_Ventanas_Pasillo = @CantidadButacasPasillo,
Baja_Fuera_Servicio = @bajaPorFueraDeServicio,
Fecha_Fuera_Servicio = @FechaDeFueraDeServicio,
Fecha_Reinicio = @FechaDeReinicioDeServicio,
Kg_Disponibles = @kgDisponible
where Id = @codigo
go

-- AGREGADOR POR NICO -- FECHA : 01/11/2015 --
create proc LA_BANDA_DE_GARRI.spmostrar_fabricante
as
select * from LA_BANDA_DE_GARRI.Fabricante
go

-------------------------------------------------
-- AGREGADOR POR NICO -- FECHA : 01/11/2015 --
create proc LA_BANDA_DE_GARRI.spmostrar_modelo
as
select * from LA_BANDA_DE_GARRI.Modelo
go

-------------------------------------------------
-- AGREGADOR POR NICO -- FECHA : 01/11/2015 --
create proc LA_BANDA_DE_GARRI.spmostrar_tipo_servicio
as
select * from LA_BANDA_DE_GARRI.Tipo_Servicio
go

--------------------------------------------------

-- Agregado Nico 03/11/2015--
--PROCEDIMIENTO spdardebaja_aerolinea --
create proc LA_BANDA_DE_GARRI.spdardebaja_aerolinea
@CodigoAeronave int
as
update LA_BANDA_DE_GARRI.Aeronave Set Baja_Vida_Util = 'Deshabilitado',Fecha_baja_definitiva = getdate()
where @CodigoAeronave = Id
go

-----------------------------------------------------------

--PROCEDIMIENTO MOSTRAR TABLA FUNCIONALIDAD --> spMostrar_Funcionalidades --
CREATE PROC LA_BANDA_DE_GARRI.spMostrar_Funcionalidades
as
select * from LA_BANDA_DE_GARRI.Funcionalidades
order by Id
go

------------------------------------------------------------

----------------------------------------------------------------------------------

--PROCEDIMIENTO INSERTAR ROL --> spinsertar_rol --
CREATE PROC LA_BANDA_DE_GARRI.spinsertar_rol
 (@id_rol int output,
@rol varchar(100),
@habilitado binary
)
as

begin

insert into LA_BANDA_DE_GARRI.Roles(Rol,Habilitado)
values(@rol,@habilitado)

declare @id_aux int
select @id_aux = Id from LA_BANDA_DE_GARRI.Roles where @rol = Rol 

return(@id_aux)

end
go

----------------------------------------------------------------------------------------

--Crear insertar rol-funcionalidad en tabla rol_funcionalidad--
CREATE PROC LA_BANDA_DE_GARRI.spinsertar_rol_funcionalidad 
(@id_rol int,
@id_funcionalidad int
)

as

insert into LA_BANDA_DE_GARRI.Rol_Funcionalidad(Id_Rol,Id_Funcionalidad)
values(@id_rol,@id_funcionalidad)

go

-------------------------------------------------------------------------------------------