USE [GD2C2015]
GO

--Dropeo las functions

IF (OBJECT_ID('LA_BANDA_DE_GARRI.fn_validar_stock') IS NOT NULL)
  DROP FUNCTION LA_BANDA_DE_GARRI.fn_validar_stock;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.fncEstaOcupada') IS NOT NULL)
  DROP FUNCTION LA_BANDA_DE_GARRI.fncEstaOcupada;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.fn_en_semestre') IS NOT NULL)
  DROP FUNCTION LA_BANDA_DE_GARRI.fn_en_semestre;  
  
--Dropeo las procedures
IF (OBJECT_ID('LA_BANDA_DE_GARRI.spMostrar_butacas_pasaje_compra') IS NOT NULL)
  DROP PROCEDURE   LA_BANDA_DE_GARRI.spMostrar_butacas_pasaje_compra ;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_estadistico_aeronave_mas_vacia') IS NOT NULL)
  DROP PROCEDURE   LA_BANDA_DE_GARRI.sp_estadistico_aeronave_mas_vacia ;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spcargar_butacasEnTablaViaje_Butaca') IS NOT NULL)
  DROP PROCEDURE   LA_BANDA_DE_GARRI.spcargar_butacasEnTablaViaje_Butaca;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_RolHabilitados') IS NOT NULL)
  DROP PROCEDURE  LA_BANDA_DE_GARRI.spmostrar_RolHabilitados;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.speditar_Ruta') IS NOT NULL)
  DROP PROCEDURE  LA_BANDA_DE_GARRI.speditar_Ruta;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sptraerCiudad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sptraerCiudad;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_Ruta') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_Ruta;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spMostrar_Ciudad_sin_baja_util') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spMostrar_Ciudad_sin_baja_util;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbuscar_ciudad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbuscar_ciudad;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbaja_ciudad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbaja_ciudad;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.speditar_ciudad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.speditar_ciudad;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_compra') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_compra;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sprestar_premio') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI. sprestar_premio;

 IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbaja_premio') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbaja_premio;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_premios_nombre') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_premios_nombre;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_premios') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_premios;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_premio') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_premio;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spcalcular_millas') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spcalcular_millas;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sprestar_millas') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sprestar_millas;

 IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbaja_millas') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbaja_millas;

 IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbuscarMillas_cliente') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbuscarMillas_cliente;

 IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_millas') IS NOT NULL)
  DROP PROCEDURE  LA_BANDA_DE_GARRI.spmostrar_millas;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_millas') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_millas;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sptraerRol_Funcionalidad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sptraerRol_Funcionalidad;
  
IF (OBJECT_ID('LA_BANDA_DE_GARRI.sptraer_Rol') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sptraer_Rol;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_butacas_libres') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_butacas_libres;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.speliminar_funcionalidades_para_rol') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.speliminar_funcionalidades_para_rol;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_modificar_nombre_rol') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_modificar_nombre_rol;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_ciudad') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_ciudad;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_Rol') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_Rol ;

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

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbuscarMatricula_aeronave') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spbuscarMatricula_aeronave;
  
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
  
IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_ciudades') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_ciudades;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_Ruta_Aerea') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_Ruta_Aerea;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_viajes') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_viajes;

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_estadistico_destinos_mas_pasajes_comprados') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_estadistico_destinos_mas_pasajes_comprados;  

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_estadistico_destinos_mas_pasajes_cancelados') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_estadistico_destinos_mas_pasajes_cancelados;   

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_estadistico_aeronave_fuera_servicio') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_estadistico_aeronave_fuera_servicio;    

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_estadistico_clientes_mas_puntos_acumulados') IS NOT NULL)
  DROP PROCEDURE LA_BANDA_DE_GARRI.sp_estadistico_clientes_mas_puntos_acumulados; 

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spbuscar_fechaOrigenDestino') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.spbuscar_fechaOrigenDestino; 

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_cliente') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_cliente; 

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_clientes_pordni') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_clientes_pordni; 

IF (OBJECT_ID('LA_BANDA_DE_GARRI.spmostrar_clientes') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.spmostrar_clientes; 


IF (OBJECT_ID('LA_BANDA_DE_GARRI.spinsertar_pago') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.spinsertar_pago; 
 
 IF (OBJECT_ID('LA_BANDA_DE_GARRI.spMostrar_viaje_esp') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.spMostrar_viaje_esp; 

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_Kg_disponibles') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.sp_Kg_disponibles; 

IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_checkViaje') IS NOT NULL)
DROP PROCEDURE LA_BANDA_DE_GARRI.sp_checkViaje; 

 IF (OBJECT_ID('LA_BANDA_DE_GARRI.sp_actualizar_cantidad_tipo_butacas') IS NOT NULL)
  DROP PROCEDURE  LA_BANDA_DE_GARRI.sp_actualizar_cantidad_tipo_butacas;
  
--Dropeo las tablas
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Usuario]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Usuario];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Millas]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Millas];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Canje_Millas]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Canje_Millas];
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Rol_Funcionalidad]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Rol_Funcionalidad];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Devolucion]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Devolucion];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Viaje_Butaca]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Viaje_Butaca];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Pasaje_Encomienda]', 'U') IS NOT NULL
DROP TABLE [LA_BANDA_DE_GARRI].[Pasaje_Encomienda];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Butaca]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Butaca];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Tipo_Butaca]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Tipo_Butaca];
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Pago]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Pago];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Viaje]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Viaje];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Ruta_Aerea]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Ruta_Aerea];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Producto]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Producto];
 
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Cliente]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Cliente];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Funcionalidad]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Funcionalidad];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Rol]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Rol];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Aeronave_Baja_Temporaria]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Aeronave_Baja_Temporaria];
   
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Aeronave]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Aeronave];
  
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Modelo]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Modelo];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Fabricante]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Fabricante];

IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Tipo_Servicio]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Tipo_Servicio];
 
IF OBJECT_ID('[LA_BANDA_DE_GARRI].[Ciudad]', 'U') IS NOT NULL
  DROP TABLE [LA_BANDA_DE_GARRI].[Ciudad];
go



--Dropeo el schema

IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'LA_BANDA_DE_GARRI')
	BEGIN
		DROP SCHEMA [LA_BANDA_DE_GARRI]
END
go

CREATE SCHEMA [LA_BANDA_DE_GARRI]
GO

--Empiezo la creacion de tablas

CREATE TABLE [LA_BANDA_DE_GARRI].[Rol] (
[Id] TINYINT IDENTITY (1,1),	
[Rol] NVARCHAR(255) UNIQUE NOT NULL,
[Habilitado] BIT DEFAULT 1 NOT NULL, --0 false 1 true
CONSTRAINT [PK_Rol] PRIMARY KEY ([Id])
 )

CREATE TABLE [LA_BANDA_DE_GARRI].[Funcionalidad] (
[Id] TINYINT IDENTITY (1,1),
[Nombre] NVARCHAR (255) UNIQUE NOT NULL,
CONSTRAINT [PK_Funcionalidad] PRIMARY KEY ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Rol_Funcionalidad] (
[Id_Rol] TINYINT NOT NULL,
[Id_Funcionalidad] TINYINT NOT NULL,
CONSTRAINT [PK_Rol_Funcionalidad] PRIMARY KEY ([Id_Rol], [Id_Funcionalidad]),
CONSTRAINT [FK_Rol] FOREIGN KEY ([Id_Rol]) REFERENCES [LA_BANDA_DE_GARRI].[Rol] ([Id]),
CONSTRAINT [FK_Funcionalidad] FOREIGN KEY ([Id_Funcionalidad]) REFERENCES [LA_BANDA_DE_GARRI].[Funcionalidad] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Usuario] (
[Id] INT IDENTITY (1,1),
[Username] NVARCHAR (255) UNIQUE NOT NULL,
[Password] NVARCHAR (255),
[ultimo_login] DATETIME,
[intentos_fallidos] TINYINT,
[habilitado] BIT,
[Id_Rol] TINYINT NOT NULL,
CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Rol_Usuario] FOREIGN KEY ([Id_Rol]) REFERENCES [LA_BANDA_DE_GARRI].[Rol] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Ciudad](
[Id] INT IDENTITY (1,1),
[Nombre] NVARCHAR(255),
[Habilitada] BIT DEFAULT 1 NOT NULL,
CONSTRAINT [PK_Ciudad] PRIMARY KEY ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Tipo_Servicio](
id int identity,
Tipo_Servicio nvarchar(255),
PRIMARY KEY (id))

CREATE TABLE [LA_BANDA_DE_GARRI].[Ruta_Aerea](
[Id] INT IDENTITY (1,1),
[Codigo] NUMERIC(18,0),
[Id_Tipo_Servicio] INT,
[Ciudad_Origen] INT,
[Ciudad_Destino] INT,
[Precio_base_pasaje] NUMERIC(18,2),
[Precio_base_kg] NUMERIC(18,2),
[Habilitada] BIT DEFAULT 1 NOT NULL,   
CONSTRAINT [PK_Ruta_Aerea] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Tipo_Servicio] FOREIGN KEY ([Id_Tipo_Servicio]) REFERENCES [LA_BANDA_DE_GARRI].[Tipo_Servicio] ([id]),
CONSTRAINT [FK_Ciudad_Origen] FOREIGN KEY ([Ciudad_Origen]) REFERENCES [LA_BANDA_DE_GARRI].[Ciudad] ([Id]),
CONSTRAINT [FK_Ciudad_Destino] FOREIGN KEY ([Ciudad_Destino]) REFERENCES [LA_BANDA_DE_GARRI].[Ciudad] ([Id])
)

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
[Id_Tipo_Servicio] int,
[Cantidad_Butacas_Ventana] int,
[Cantidad_Ventanas_Pasillo] int,
[Baja_Vida_Util] varchar(50),
[Fecha_baja_definitiva] date,
[Kg_Disponibles] int
PRIMARY KEY (id),
CONSTRAINT [FK_Modelo] FOREIGN KEY ([Modelo]) REFERENCES [LA_BANDA_DE_GARRI].[Modelo] ([Id]),
CONSTRAINT [FK_Fabricante] FOREIGN KEY (Fabricante) REFERENCES [LA_BANDA_DE_GARRI].Fabricante ([Id]),
CONSTRAINT [FK_TipoServ] FOREIGN KEY ([Id_Tipo_Servicio]) REFERENCES [LA_BANDA_DE_GARRI].[Tipo_Servicio] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Aeronave_Baja_Temporaria](
[id_Aeronave] int,
[Baja_Fuera_Servicio] varchar(50),
[Fecha_Fuera_Servicio] datetime,
[Fecha_Reinicio] datetime,
PRIMARY KEY (id_Aeronave),
CONSTRAINT [FK_Aeronave_Baja_Temporaria] FOREIGN KEY ([id_Aeronave]) REFERENCES [LA_BANDA_DE_GARRI].[Aeronave] ([Id]),
)


CREATE TABLE [LA_BANDA_DE_GARRI].[Viaje] (
[Id] INT IDENTITY (1,1),
[Fecha_salida] DATETIME,
[Fecha_llegada] DATETIME,
[Fecha_llegada_estimada] DATETIME,
[Id_Aeronave] INT,
[Codigo_Ruta_Aerea] int,
CONSTRAINT [PK_Viaje] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Aeronave] FOREIGN KEY ([Id_Aeronave]) REFERENCES [LA_BANDA_DE_GARRI].[Aeronave] ([Id]),
CONSTRAINT [FK_CODIGORUTA] FOREIGN KEY ([Codigo_Ruta_Aerea]) REFERENCES [LA_BANDA_DE_GARRI].Ruta_Aerea ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Cliente] (
[Id] INT IDENTITY (1,1),
[Nombre] NVARCHAR(255) NOT NULL,
[Apellido] NVARCHAR(255) NOT NULL,
[dni] NUMERIC(18,0) NOT NULL,
[direccion] NVARCHAR(255),
[telefono] NUMERIC(18,0), 
[mail] NVARCHAR(255),
[fecha_nacimiento] DATE,
CONSTRAINT [PK_Cliente] PRIMARY KEY ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Pago](
[PNR] INT IDENTITY (1,1),
[Id_viaje] INT,
[Id_Cliente] INT,
[Importe] NUMERIC(18,2),
[Fecha_compra] DATETIME,
[Tipo_Pago] CHAR(1),
CONSTRAINT [PK_Pago] PRIMARY KEY ([PNR]),
CONSTRAINT [FK_Cliente_Pago] FOREIGN KEY ([Id_Cliente]) REFERENCES [LA_BANDA_DE_GARRI].[Cliente] ([Id]),
CONSTRAINT [FK_Viaje_Pago] FOREIGN KEY ([Id_Viaje]) REFERENCES [LA_BANDA_DE_GARRI].[Viaje] ([Id])
)


CREATE TABLE [LA_BANDA_DE_GARRI].[Millas] (
[Id_cliente] INT,
[Cantidad] INT,
[Validez_Hasta] DATETIME,
CONSTRAINT [PK_Millas] PRIMARY KEY ([Id_Cliente]),
CONSTRAINT [FK_Cliente] FOREIGN KEY ([Id_Cliente]) REFERENCES [LA_BANDA_DE_GARRI].[Cliente] ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Producto] (
[Id] INT IDENTITY(1,1),
[Descripcion] NVARCHAR(255),
[Stock] int,
CONSTRAINT [PK_Producto] PRIMARY KEY ([Id]),
[Cantidad_Millas] int
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Canje_Millas] (
[Id] INT IDENTITY,
[DNI] NUMERIC(18,0),
[Producto_elegido] INT,
[cantidad] INT,
[Fecha] DATETIME,
CONSTRAINT [PK_Canje_Millas] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Producto] FOREIGN KEY ([Producto_elegido]) REFERENCES [LA_BANDA_DE_GARRI].[Producto] ([Id])
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

CREATE TABLE [LA_BANDA_DE_GARRI].[Pasaje_Encomienda] (
[Id] INT IDENTITY(1,1),
[Id_Cliente] INT,
[Id_Viaje] INT,
[Id_Butaca] INT,
[Id_Pago] INT DEFAULT NULL,
[KG] NUMERIC(18,0)
CONSTRAINT [PK_Pasaje_Encomienda] PRIMARY KEY ([Id]),
CONSTRAINT [FK_Cliente_PasajeEncomienda] FOREIGN KEY ([Id_Cliente]) REFERENCES [LA_BANDA_DE_GARRI].[Cliente] ([Id]),
CONSTRAINT [FK_Viaje] FOREIGN KEY ([Id_Viaje]) REFERENCES [LA_BANDA_DE_GARRI].[Viaje] ([Id]),
CONSTRAINT [FK_Pago] FOREIGN KEY ([Id_Pago]) REFERENCES [LA_BANDA_DE_GARRI].Pago ([PNR]),
CONSTRAINT [FK_Butaca_Pasaje] FOREIGN KEY ([Id_Butaca]) REFERENCES [LA_BANDA_DE_GARRI].Butaca ([Id])
)

CREATE TABLE [LA_BANDA_DE_GARRI].[Devolucion] (
[PNR] INT,
[Id_Pasaje_Encomienda] INT,
[Fecha_Devolucion] DATETIME,
[Motivo] NVARCHAR(255),
CONSTRAINT [PK_Devolucion] PRIMARY KEY ([PNR]),
CONSTRAINT [FK_PNR] FOREIGN KEY ([PNR]) REFERENCES [LA_BANDA_DE_GARRI].[Pago] ([PNR]),
CONSTRAINT [FK_Pasaje_Encomienda] FOREIGN KEY ([Id_Pasaje_Encomienda]) REFERENCES [LA_BANDA_DE_GARRI].[Pasaje_Encomienda] ([Id]),
)

create table [LA_BANDA_DE_GARRI].[Viaje_Butaca] (
[Id] INT IDENTITY, 
[id_Viaje] INT, 
[id_Butaca] INT,
libre bit DEFAULT 1 NOT NULL,
CONSTRAINT [PK_Viaje_Butaca] PRIMARY KEY ([Id]),
CONSTRAINT [FK_ViajeIntermedio] FOREIGN KEY ([id_Viaje]) REFERENCES [LA_BANDA_DE_GARRI].[Viaje] ([Id]),
CONSTRAINT [FK_ButacaIntermedio] FOREIGN KEY ([id_Butaca]) REFERENCES [LA_BANDA_DE_GARRI].[Butaca] ([Id])
)
GO

 -- Transaccion para la migracion de datos (acá irian todos los inserts a las tablas)
 begin tran trn_migracion_datos
        
		insert into LA_BANDA_DE_GARRI.Rol(Rol,Habilitado)
            values('Administrador General',1)		

		insert into LA_BANDA_DE_GARRI.Rol(Rol,Habilitado)
            values('Administrador',1)

        insert into LA_BANDA_DE_GARRI.Rol(Rol,Habilitado)
            values('Cliente',1)
		
		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('ABM Rol')	
			
		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Login y Seguridad')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Registro de Usuario')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('ABM Ciudad')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('ABM Ruta Aerea')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('ABM Aeronave')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Generar Viaje')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Registro de Llegada a Destino')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Compra de pasaje/encomienda')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Devolucion/Cancelacion de pasaje y/o encomienda')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Consulta de millas de pasajero frecuente')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Canje de millas')

		insert into LA_BANDA_DE_GARRI.Funcionalidad(Nombre)
            values('Listado Estadístico')
		
-- el hash de w23e --> e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7
		insert into LA_BANDA_DE_GARRI.Usuario(Username, Password, intentos_fallidos, habilitado, Id_Rol)
            values('admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 1, 1)		

		insert into LA_BANDA_DE_GARRI.Usuario(Username, Password, intentos_fallidos, habilitado, Id_Rol)
            values('gonza', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 1, 2)					

		insert into LA_BANDA_DE_GARRI.Usuario(Username, Password, intentos_fallidos, habilitado, Id_Rol)
            values('garri', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 1, 2)

		insert into LA_BANDA_DE_GARRI.Usuario(Username, Password, intentos_fallidos, habilitado, Id_Rol)
            values('lucas', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 1, 2)

		insert into LA_BANDA_DE_GARRI.Usuario(Username, Password, intentos_fallidos, habilitado, Id_Rol)
            values('nico', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 1, 2)
			
		insert into LA_BANDA_DE_GARRI.Ciudad(Nombre)
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

		insert into LA_BANDA_DE_GARRI.Aeronave(Matricula, Modelo, Fabricante, Id_Tipo_Servicio, Kg_Disponibles)
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
			 from gd_esquema.Maestra where gd_esquema.Maestra.Butaca_Tipo != '0';

		insert into LA_BANDA_DE_GARRI.Cliente(Nombre, Apellido, dni, direccion, telefono, mail, fecha_nacimiento)
			select distinct m.Cli_Nombre, m.Cli_Apellido, m.Cli_Dni, m.Cli_Dir, m.Cli_Telefono, m.Cli_Mail, m.Cli_Fecha_Nac
                from gd_esquema.Maestra m				
		
		insert into LA_BANDA_DE_GARRI.[Ruta_Aerea]([Codigo],
		[Id_Tipo_Servicio],[Ciudad_Origen],[Ciudad_Destino] ,[Precio_base_pasaje],
		[Precio_base_kg])
			select distinct m.Ruta_Codigo,
			(Select LA_BANDA_DE_GARRI.Tipo_Servicio.id from LA_BANDA_DE_GARRI.Tipo_Servicio
			where LA_BANDA_DE_GARRI.Tipo_Servicio.Tipo_Servicio = m.Tipo_Servicio), 
			(Select C.Id from LA_BANDA_DE_GARRI.Ciudad C
			where C.Nombre = m.Ruta_Ciudad_Origen), 
			(Select C.Id from LA_BANDA_DE_GARRI.Ciudad C
			where C.Nombre = m.Ruta_Ciudad_Destino),
			(SELECT TOP 1 m2.Ruta_Precio_BasePasaje from gd_esquema.Maestra m2
		    where m2.Ruta_Codigo = m.Ruta_Codigo 
			AND m2.Ruta_Ciudad_Origen = m.Ruta_Ciudad_Origen
			AND m2.Ruta_Ciudad_Destino = m.Ruta_Ciudad_Destino
			AND m2.Ruta_Precio_BasePasaje !=0),
			(SELECT TOP 1 m2.Ruta_Precio_BaseKG from gd_esquema.Maestra m2
			where m2.Ruta_Codigo = m.Ruta_Codigo 
			AND m2.Ruta_Ciudad_Origen = m.Ruta_Ciudad_Origen
			AND m2.Ruta_Ciudad_Destino = m.Ruta_Ciudad_Destino
			AND m2.Ruta_Precio_BaseKG !=0)
             from gd_esquema.Maestra m				

		insert into LA_BANDA_DE_GARRI.Viaje(Fecha_salida, Fecha_llegada, Fecha_llegada_estimada, Id_Aeronave, Codigo_Ruta_Aerea)
			select distinct
			m.FechaSalida,
			m.FechaLLegada,
			m.Fecha_LLegada_Estimada,
			(Select LA_BANDA_DE_GARRI.Aeronave.Id from LA_BANDA_DE_GARRI.Aeronave
			where LA_BANDA_DE_GARRI.Aeronave.Matricula = m.Aeronave_Matricula),
			(Select R.Id from LA_BANDA_DE_GARRI.Ruta_Aerea R
			where R.Codigo = m.Ruta_Codigo and r.Ciudad_Origen=(select c.Id from LA_BANDA_DE_GARRI.Ciudad C where c.Nombre=m.Ruta_Ciudad_Origen))			
			from gd_esquema.Maestra m				
	
		insert into [LA_BANDA_DE_GARRI].[Pasaje_Encomienda](Id_Cliente,Id_Viaje,Id_Butaca,KG)
			select  (select C.Id from LA_BANDA_DE_GARRI.Cliente c 
			where c.dni=m.Cli_Dni and c.fecha_nacimiento=m.Cli_Fecha_Nac and c.Apellido=m.Cli_Apellido),
			(select V.Id from LA_BANDA_DE_GARRI.Viaje V where V.Fecha_salida=m.FechaSalida and v.Fecha_llegada=m.FechaLLegada
			and A.Id=V.Id_Aeronave AND V.Codigo_Ruta_Aerea = 
			(SELECT Ruta_Aerea.Id from LA_BANDA_DE_GARRI.Ruta_Aerea
			where (select T.Tipo_Servicio from LA_BANDA_DE_GARRI.Tipo_Servicio T where T.Id=Ruta_Aerea.[Id_Tipo_Servicio])= m.Tipo_Servicio 
			and (select c.nombre from LA_BANDA_DE_GARRI.Ciudad C where c.Id=Ruta_Aerea.Ciudad_Origen)= m.Ruta_Ciudad_Origen 
			and  (select c.nombre from LA_BANDA_DE_GARRI.Ciudad C where c.Id=Ruta_Aerea.Ciudad_Destino)=m.Ruta_Ciudad_Destino)),
			(Select B.Id from LA_BANDA_DE_GARRI.Butaca B
			where B.nro = m.Butaca_Nro and b.aeronave_id=a.Id),			
			m.Paquete_KG
			from gd_esquema.Maestra m JOIN LA_BANDA_DE_GARRI.Aeronave A ON	a.Matricula = m.Aeronave_Matricula		


		insert into LA_BANDA_DE_GARRI.[Viaje_Butaca](id_Butaca ,id_Viaje, libre) 
			select B.Id,
			V.Id,
			case 
			 when (select top 1 0 from [LA_BANDA_DE_GARRI].[Pasaje_Encomienda] P where P.Id_Viaje=V.Id and P.Id_Butaca=B.Id) = 0 then 0
			 else 1 
			END
			from LA_BANDA_DE_GARRI.Viaje V
			join LA_BANDA_DE_GARRI.Butaca B on b.Aeronave_id=V.Id_Aeronave

commit tran trn_migracion_datos
GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_agregar_funcionalidad(@rol nvarchar(255), @func nvarchar(255)) AS
BEGIN
		INSERT INTO LA_BANDA_DE_GARRI.Rol_Funcionalidad(Id_Rol, Id_Funcionalidad)
		VALUES ((SELECT Id FROM LA_BANDA_DE_GARRI.Rol WHERE Rol = @rol),
		        (SELECT Id FROM LA_BANDA_DE_GARRI.Funcionalidad WHERE Nombre = @func))
END
GO

--transaccion para insertar funcionalidad en los roles
begin tran insertar_funcionalidades
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'ABM Rol'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Listado Estadístico'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Canje de millas'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Consulta de millas de pasajero frecuente'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Devolucion/Cancelacion de pasaje y/o encomienda'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Compra de pasaje/encomienda'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Registro de Llegada a Destino'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Generar Viaje'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'ABM Aeronave'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'ABM Ruta Aerea'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador General',@func = 'Registro de Usuario'
	
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'ABM Rol'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Listado Estadístico'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Canje de millas'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Consulta de millas de pasajero frecuente'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Devolucion/Cancelacion de pasaje y/o encomienda'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Compra de pasaje/encomienda'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Registro de Llegada a Destino'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Generar Viaje'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'ABM Aeronave'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'ABM Ruta Aerea'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Administrador',@func = 'Registro de Usuario'
	
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Cliente',@func = 'Canje de millas'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Cliente',@func = 'Consulta de millas de pasajero frecuente'
	exec LA_BANDA_DE_GARRI.sp_agregar_funcionalidad @rol = 'Cliente',@func = 'Compra de pasaje/encomienda'
commit tran insertar_funcionalidades

go
--STORED PROCEDURES
--ABM ROL

create proc LA_BANDA_DE_GARRI.spmostrar_Ruta_Aerea
as
select * from LA_BANDA_DE_GARRI.[Ruta_Aerea]
go

create proc LA_BANDA_DE_GARRI.spmostrar_Viajes
as
select * from LA_BANDA_DE_GARRI.Viaje
go

create procedure LA_BANDA_DE_GARRI.sp_butacas_libres(@id_Viaje int)
as
begin
	
	SELECT * FROM LA_BANDA_DE_GARRI.Butaca B 
	Where (Select V.Id_Aeronave from LA_BANDA_DE_GARRI.Viaje V where V.Id=@id_Viaje)=B.Aeronave_id 
	and NOT EXISTS(SELECT 1 from LA_BANDA_DE_GARRI.Pasaje_Encomienda P where P.Id_Butaca=B.Id and P.Id_Viaje=@id_Viaje)
	and Exists(Select 1 from LA_BANDA_DE_GARRI.Viaje_Butaca T where T.id_Butaca = B.Id and T.libre = 0)
	
END
GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_listar_roles AS
BEGIN
	select Rol
	from LA_BANDA_DE_GARRI.Rol
END
GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_cambiar_nombre_rol(@rol NVARCHAR(255), @nuevo_nombre NVARCHAR(255)) AS
BEGIN
	update LA_BANDA_DE_GARRI.Rol
	set Rol = @nuevo_nombre
	where Rol = @rol
END

GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_eliminar_funcionalidad(@rol nvarchar(255), @func nvarchar(255)) AS
BEGIN
		delete from LA_BANDA_DE_GARRI.Rol_Funcionalidad
		where Id_Rol = (SELECT Id FROM LA_BANDA_DE_GARRI.Rol WHERE Rol = @rol) 
		and Id_Funcionalidad = (SELECT Id FROM LA_BANDA_DE_GARRI.Funcionalidad WHERE Nombre = @func)
END

GO

CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_cambiar_estado_rol(@rol int, @estado BIT) AS
BEGIN
	update LA_BANDA_DE_GARRI.Rol
	set Habilitado = @estado
	where Id = @rol
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

	if (exists(select password from LA_BANDA_DE_GARRI.Usuario where username = @username_enviado))

		begin
			-- Seleccionamos el hash
			set @check_password = (select password from LA_BANDA_DE_GARRI.Usuario where username = @username_enviado)

			-- Seleccionamos si está habilitado
			set @check_habilitado = (select habilitado from LA_BANDA_DE_GARRI.Usuario where username = @username_enviado)
			if (@check_habilitado = 0)

				begin
					set @result = 'LOGIN_OFF'
					return 1
				end


			-- Si intentos_fallidos = 3, deshabilitar usuario
			set @check_fallidos = (select intentos_fallidos from LA_BANDA_DE_GARRI.Usuario where username = @username_enviado)
			if (@check_fallidos >= 3)
				begin
						update LA_BANDA_DE_GARRI.Usuario
							set habilitado = 0
							where username = @username_enviado

						set @result = 'LOGIN_MAS_TRES_VECES'
						return 1
				end    

			-- Usuario correcto pero contraseña incorrecta
			if (@check_password <> @password)
				
				begin
						update LA_BANDA_DE_GARRI.Usuario
							set intentos_fallidos = intentos_fallidos + 1
							where username = @username_enviado

						set @result = 'LOGIN_ERROR_PASSWORD'
						return 1
				end              

			-- Login Correcto deberia entrar aca
			if (@check_habilitado = 1 and @check_password = @password)
				begin
					update LA_BANDA_DE_GARRI.Usuario
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
--ABM Ciudad NO ES NECESARIO HACERLO

--ABM RUTA AEREA
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_crear_ruta_aerea (@codigo numeric(18,0), 
														@tipo NVARCHAR(255), 
														@origen int, 
														@destino int, 
														@precio_pasaje numeric(18,2),
														@precio_kg numeric(18,2)) AS
BEGIN
	insert into LA_BANDA_DE_GARRI.Ruta_Aerea(Codigo, Id_Tipo_Servicio, Ciudad_Origen, Ciudad_Destino, Precio_base_pasaje, Precio_base_kg,Habilitada)
	values(@codigo, @tipo, @origen, @destino, @precio_pasaje, @precio_kg,'true')
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


--GENERAR VIAJE --actualizado 15/11
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_generar_viaje(@id_viaje int output,
													@ruta_aerea numeric(18,0), 
													@aeronave VARCHAR(255), 
													@fecha_salida DATETIME, 
													@fecha_llegada DATETIME,
													@fecha_llegada_estimada DATETIME)
													 AS

BEGIN
	DECLARE @id_aeronave INT;

	 select @id_aeronave = Id from LA_BANDA_DE_GARRI.Aeronave where Matricula = @aeronave
	
	DECLARE @id_ruta INT;
	select  @id_ruta = Id from LA_BANDA_DE_GARRI.Ruta_Aerea where Codigo = @ruta_aerea
	
	DECLARE @tipo_servicio_ruta int
	DECLARE @tipo_servicio_aeronave int;
	
	select @tipo_servicio_ruta =  Id_Tipo_Servicio from LA_BANDA_DE_GARRI.Ruta_aerea
	where Codigo = @ruta_aerea 
	
	select @tipo_servicio_aeronave = Id_Tipo_Servicio
	from LA_BANDA_DE_GARRI.Aeronave
	where Matricula = @aeronave 
	
	if(@tipo_servicio_ruta <> @tipo_servicio_aeronave)
		begin
			return(0)--'EL SERVICIO DE LA RUTA AEREA NO COINCIDE CON EL DE LA AERONAVE'
			 
		end
	
		DECLARE @cantidad INT;
	
		select @cantidad = count(*) 
		from LA_BANDA_DE_GARRI.Viaje
		where Id_Aeronave = (select Id from LA_BANDA_DE_GARRI.Aeronave where Matricula = @aeronave)
		and Fecha_salida = @fecha_salida 
	
		if(@cantidad != 0)
			begin
				return(1) --'LA AERONAVE NO SE ENCUENTRA DISPONIBLE EN ESA FECHA'
			
			end
		
	declare @existe_id int
	 select @existe_id = Id from LA_BANDA_DE_GARRI.Viaje where
	 Fecha_salida = @fecha_salida and Fecha_llegada = @fecha_llegada and Fecha_llegada_estimada = @fecha_llegada_estimada and Id_Aeronave = @id_aeronave and Codigo_Ruta_Aerea = @id_ruta

	 if(@existe_id is null)
	 begin
	 insert into LA_BANDA_DE_GARRI.Viaje(Fecha_salida, Fecha_llegada, Fecha_llegada_estimada, Id_Aeronave, Codigo_Ruta_Aerea)
	values(@fecha_salida, @fecha_llegada, @fecha_llegada_estimada, @id_aeronave, @id_ruta)

	declare @idViaje int
	set @id_viaje = (select max(Id) from LA_BANDA_DE_GARRI.Viaje)

	insert into LA_BANDA_DE_GARRI.Viaje_Butaca(id_Viaje,id_Butaca,libre)
	select @id_viaje,b.Id,1 from LA_BANDA_DE_GARRI.Butaca b where b.Aeronave_id = @id_aeronave

	return(2)
	end
		else
	begin
	return(3)
	end
	 
END
go


--REGISTRO LLEGADA A DESTINO
CREATE PROCEDURE LA_BANDA_DE_GARRI.sp_registrar_llegada_destino(@matricula VARCHAR(255), @origen int, @destino int, @fecha_llegada DATETIME ) AS
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
	join LA_BANDA_DE_GARRI.Cliente c on m.Id_Cliente = c.Id
	where c.dni = @dni
	
END

GO

--CANJE DE MILLAS

create function LA_BANDA_DE_GARRI.fn_validar_stock(@producto int, @cantidad int) RETURNS INT as
BEGIN
	DECLARE @stock INT;
	
	select @stock = Stock 
	from LA_BANDA_DE_GARRI.Producto
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



create proc LA_BANDA_DE_GARRI.spbuscar_fechaOrigenDestino(
@FechaSalida datetime,
@CiudadOrigen int,
@CiudadDestino int
)
as
begin 
 
declare @idCodigo int
select @idCodigo = Id from LA_BANDA_DE_GARRI.Ruta_Aerea where Ciudad_Origen = @CiudadOrigen and Ciudad_Destino = @CiudadDestino and Ruta_Aerea.Habilitada = 'true'
select * from LA_BANDA_DE_GARRI.Viaje 
where Codigo_Ruta_Aerea = @idCodigo
and YEAR(LA_BANDA_DE_GARRI.Viaje.Fecha_salida) = YEAR(@FechaSalida)
		and MONTH(LA_BANDA_DE_GARRI.Viaje.Fecha_salida) = MONTH(@FechaSalida)
		and DAY(LA_BANDA_DE_GARRI.Viaje.Fecha_salida) = DAY(@FechaSalida)
order by LA_BANDA_DE_GARRI.Viaje.Id
end
go


create proc LA_BANDA_DE_GARRI.spmostrar_aeronave
as
select * from LA_BANDA_DE_GARRI.Aeronave
order by Aeronave.Id
GO

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
@bajaPorVidaUtil varchar(50),
@FechaBajaDefinitiva date,
@kgDisponible int)
as
BEGIN

declare @AuxMaxAnt int
set @AuxMaxAnt = (SELECT MAX(id) FROM LA_BANDA_DE_GARRI.Aeronave)

insert into LA_BANDA_DE_GARRI.Aeronave([Fecha_alta],
[Numero],[Matricula],[Modelo],[Fabricante],
[Id_Tipo_Servicio],[Cantidad_Butacas_Ventana],[Cantidad_Ventanas_Pasillo],
[Baja_Vida_Util], 
[Fecha_baja_definitiva],[Kg_Disponibles])
values(null,@numeroAeronave,@matricula,@modelo,@fabricante,
@tipoDeServicio,@CantidadButacasVentana,@CantidadButacasPasillo,null,
null, @kgDisponible)


print('el id es:' + '@Id')
declare @idAeronave int
set @idAeronave = (SELECT MAX(id) FROM LA_BANDA_DE_GARRI.Aeronave)

if(@idAeronave != @AuxMaxAnt)
BEGIN
declare @aux int
declare @tipo int
declare @aux2  int

set @aux = 1
set @aux2 = 0
set @tipo = (select id from LA_BANDA_DE_GARRI.Tipo_Butaca where Tipo = 'Ventanilla')

 while (@aux <= @CantidadButacasVentana)

 begin
  set @aux2 = @aux*2
  insert into LA_BANDA_DE_GARRI.Butaca(Nro,Tipo,Piso,Aeronave_id)
  values(@aux2,@tipo,1,@idAeronave)
  set @aux = @aux + 1
 end

set @aux = 0
set @aux2 = 0

set @tipo = (select id from LA_BANDA_DE_GARRI.Tipo_Butaca where Tipo = 'Pasillo')

 while (@aux < @CantidadButacasPasillo)
 begin
  set @aux2 = @aux*2+1
  insert into LA_BANDA_DE_GARRI.Butaca(Nro,Tipo,Piso,Aeronave_id)
  values(@aux2,@tipo,1,@idAeronave)
  set @aux = @aux + 1
 end
 END --FIN IF
END
go 

--PROCEDIMIENTO BUSCAR NUMERO--
create proc LA_BANDA_DE_GARRI.spbuscarNumero_aeronave
@numeroABuscar int
as
select * from LA_BANDA_DE_GARRI.Aeronave
where Numero like '%' + @numeroABuscar + '%'
go

/*
--PROCEDIMIENTO BUSCAR MATRICULA--
create proc LA_BANDA_DE_GARRI.spbuscarMatricula_aeronave
@matricula varchar(255)
as
select * from LA_BANDA_DE_GARRI.Aeronave
where Matricula like '%' + @matricula + '%'
go
*/

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
@kgDisponible int,
@bajaFueraDeServicio varchar(50),
@fechaFueraDeServicio date,
@fechaFueraReinicio date,
@habilitadoFueraDeServicio int)
as
update Aeronave set Fecha_alta = @fechaAlta,
Numero = @numeroAeronave,
Modelo = @modelo,
Matricula = @matricula,
Fabricante = @fabricante,
Id_Tipo_Servicio = @tipoDeServicio,
Cantidad_Butacas_Ventana = @CantidadButacasVentana,
Cantidad_Ventanas_Pasillo = @CantidadButacasPasillo,
Kg_Disponibles = @kgDisponible
where Id = @codigo

	if @habilitadoFueraDeServicio = 1
		begin

		insert into Aeronave_Baja_Temporaria(id_Aeronave,Baja_Fuera_Servicio,Fecha_Fuera_Servicio,Fecha_Reinicio)
			values(@codigo,@bajaFueraDeServicio,@fechaFueraDeServicio,@fechaFueraReinicio)
		end
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
select * from LA_BANDA_DE_GARRI.Funcionalidad
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

insert into LA_BANDA_DE_GARRI.Rol(Rol,Habilitado)
values(@rol,@habilitado)

declare @id_aux int
select @id_aux = Id from LA_BANDA_DE_GARRI.Rol where @rol = Rol 

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

--Agregado Nico 03/11/2015--

create proc LA_BANDA_DE_GARRI.spmostrar_Rol
as
select * from LA_BANDA_DE_GARRI.Rol
order by Rol.Id
GO

-----------------------------------------------------

--Agregado Nico 04/11/2015--

--PROCEDIMIENTO INSERTAR ciudad EN TABLA Ciudad--
create proc  LA_BANDA_DE_GARRI.spinsertar_ciudad
 (  @codigo int output,
@nombre varchar(50),
@BajaPorVidaUtil bit
)
as
insert into  LA_BANDA_DE_GARRI.Ciudad(Nombre,Habilitada)
values(@nombre,@BajaPorVidaUtil)
go

--PROCEDIMIENTO Modificar nombre rol --
create proc LA_BANDA_DE_GARRI.spinsertar_modificar_nombre_rol
(
	 @nombreAnterior varchar(50),
	 @nombreNuevo varchar(50)
)
as
update LA_BANDA_DE_GARRI.Rol Set Rol =  @nombreNuevo
where  @nombreAnterior = Rol
go

--PROCEDIMIENTO Eliminar Funcionalidades para un rol --
create proc LA_BANDA_DE_GARRI.speliminar_funcionalidades_para_rol
(@id_rol int
)
as
if exists(select Id_Rol from LA_BANDA_DE_GARRI.Rol_Funcionalidad where Id_Rol = @id_rol)
begin

delete from LA_BANDA_DE_GARRI.Rol_Funcionalidad
where Id_Rol = @id_rol

declare @id_aux int
select @id_aux = Id from LA_BANDA_DE_GARRI.Rol where @id_rol = Id

return(@id_aux)

end
go

-- Agregado Nico 05/11/2015 --
--PROCEDIMIENTO Para mandar un rol a C# --

create proc LA_BANDA_DE_GARRI.sptraer_Rol
(
@Rol_Nombre varchar(100)
)
as

select * from LA_BANDA_DE_GARRI.Rol where @Rol_Nombre = Rol
go

--Agregado Nico 06/11/2015--
--Procecimiento para mandar las funcionalidades de un rol a C#--

create proc LA_BANDA_DE_GARRI.sptraerRol_Funcionalidad
(
@rol_id int
)
as
select * from LA_BANDA_DE_GARRI.Rol_Funcionalidad where Id_Rol = @rol_id
go

--PROCEDIMIENTO MOSTRAR TABLA Ciudad--
create proc LA_BANDA_DE_GARRI.spmostrar_ciudades
as
select * from LA_BANDA_DE_GARRI.Ciudad
go


--Procedimiento insertar millas--
create proc LA_BANDA_DE_GARRI.spinsertar_millas
(
	@id int output,
	@id_cliente int,
	@cantMillas int,
	@fechaExp datetime 
)
as
insert into  LA_BANDA_DE_GARRI.Millas(Id_cliente,Cantidad,Validez_Hasta)
values(@id_cliente,@cantMillas,@fechaExp)
go

--Procedimiento spmostrar_millas --
CREATE PROC  LA_BANDA_DE_GARRI.spmostrar_millas
as
select * from LA_BANDA_DE_GARRI.Millas
order by Id_cliente
GO

--Procedimiento spbuscarMillas_cliente --
create proc LA_BANDA_DE_GARRI.spbuscarMillas_cliente
(
@dniCliente int
)
as
BEGIN

declare @id_cliente int
select @id_cliente = Id from LA_BANDA_DE_GARRI.Cliente where dni = @dniCliente

select * from LA_BANDA_DE_GARRI.Millas where Id_cliente = @id_cliente
END
go

--Procedimiento spbaja_millas--
create proc LA_BANDA_DE_GARRI.spbaja_millas
(
@dni_cliente int
)
as
BEGIN

declare @id_cliente int
select @id_cliente = Id from LA_BANDA_DE_GARRI.Cliente where dni = @dni_cliente

delete from LA_BANDA_DE_GARRI.Millas where Id_cliente = @id_cliente
END
go

--PROCEDURE sprestar_millas", dni_cliente, cantidad);--
create proc LA_BANDA_DE_GARRI.sprestar_millas
(
@dni_cliente int,
@cantidad int,
@producto_elegido int,
@fechaActual datetime
)
as

insert into  LA_BANDA_DE_GARRI.Canje_Millas(DNI,Producto_elegido,Cantidad,Fecha)
values(@dni_cliente,@producto_elegido,@cantidad,@fechaActual)

go

--PROCEDURE spcalcular_millas", dni_cliente--
create proc LA_BANDA_DE_GARRI.spcalcular_millas
(
@dni_cliente int
)
as
begin

declare @id_cliente int
select @id_cliente = Id from LA_BANDA_DE_GARRI.Cliente where dni = @dni_cliente

declare @sumaDeMillas int

select @sumaDeMillas = (select SUM(Cantidad) FROM LA_BANDA_DE_GARRI.Millas
where  @id_cliente = Id_cliente and (select DATEDIFF(day,Validez_Hasta,GETDATE())) <= 365)

end
go

-- PROCEDIMIENTO executeProcedure("spinsertar_premio", 1 ,premio.Nombre,premio.Cantidad,premio.Cantidad_millas);
CREATE PROC LA_BANDA_DE_GARRI.spinsertar_premio
(
@idPremio int output,
@nombrePremio varchar(100),
@cantidadPremio int,
@cantidadMillas int
)
as
insert into  LA_BANDA_DE_GARRI.Producto(Descripcion,Stock,Cantidad_Millas)
values(@nombrePremio,@cantidadPremio,@cantidadMillas)

go

--PROCEDIMIENTO spmostrar_premios --
create proc LA_BANDA_DE_GARRI.spmostrar_premios
as
select * from LA_BANDA_DE_GARRI.Producto
order by Id
go

--PROCEDIMIENTO spmostrar_premios", nombre--
create proc LA_BANDA_DE_GARRI.spmostrar_premios_nombre
(
@nombre varchar(100)
)
as
select * from LA_BANDA_DE_GARRI.Producto
where @nombre = Descripcion
order by Id
go

--PROCEDIMIENTO spbaja_premio", id_Premio)--
CREATE PROC LA_BANDA_DE_GARRI.spbaja_premio
(
@id_premio int
)
as
delete from LA_BANDA_DE_GARRI.Producto where Id = @id_premio
go

--PROCEDIMIENTO sprestar_premio id_Premio, cantidad)--
CREATE PROC LA_BANDA_DE_GARRI. sprestar_premio
(
@ID_PREMIO int,
@cantidad int
)
as
begin

declare @cantidadActualizada int
set @cantidadActualizada = (select Stock from LA_BANDA_DE_GARRI.Producto where @ID_PREMIO = Id) - 1

update LA_BANDA_DE_GARRI.Producto
	set Stock = @cantidadActualizada - 1
	where Id = @ID_PREMIO
END
go

--PROCEDIMIENTO spinsertar_compra--
CREATE PROC LA_BANDA_DE_GARRI.spinsertar_compra
(
@ID_compra int output,
@idviajeSeleccionado int,
@nombre nvarchar(255),
@apellido nvarchar(255),
@dni numeric(18,0),
@direccion nvarchar(255),
@telefono numeric(18,0),
@email nvarchar(255),
@fechaNac date,
@cantidadPasaje int,
@cantidadKG int,
@fechaCompra datetime,
@Importe decimal(18,0),
@Tipo_Pago char(1),
@idButaca int
)
as
begin

declare @idCliente int
declare @idAeronave int

if not exists(select * from LA_BANDA_DE_GARRI.Cliente where Nombre = @nombre and Apellido = @apellido and dni = @dni and direccion = @direccion and telefono = @telefono and mail = @email and fecha_nacimiento = @fechaNac)
	begin

		insert into  LA_BANDA_DE_GARRI.Cliente(Nombre,Apellido,dni,direccion,telefono,mail,fecha_nacimiento)
		values(@nombre,@apellido,@dni,@direccion,@telefono,@email,@fechaNac)

	end
		
	SET @idCliente = (select Cliente.Id from LA_BANDA_DE_GARRI.Cliente where Nombre = @nombre and Apellido = @apellido and dni = @dni and direccion = @direccion and telefono = @telefono and mail = @email and fecha_nacimiento = @fechaNac)
	SET @idAeronave = (select Viaje.Id_Aeronave from LA_BANDA_DE_GARRI.Viaje where @idviajeSeleccionado = Id)

	insert into  LA_BANDA_DE_GARRI.Pago(Id_viaje,Id_Cliente,Importe,Fecha_compra,Tipo_Pago)
	values(@idviajeSeleccionado,@idCliente,@Importe,@fechaCompra,@Tipo_Pago)
	
	declare @idPago int
	set @idPago = (SELECT MAX(PNR) FROM LA_BANDA_DE_GARRI.Pago)

	insert into  LA_BANDA_DE_GARRI.Pasaje_Encomienda(Id_Cliente,Id_Viaje,Id_Butaca,Id_Pago,KG)
	values(@idCliente,@idviajeSeleccionado,@idButaca,@idPago,@cantidadKG)

	update LA_BANDA_DE_GARRI.Viaje_Butaca
	set libre = 0
	where id_Butaca = @idButaca and id_Viaje=@idviajeSeleccionado

end
go

-- PROCEDIMIENTO spmostrar_compra--
--create proc spmostrar_compra
--as
--select * from LA_BANDA_DE_GARRI.compra
--where @nombre = Descripcion
--order by Id
--go

create function LA_BANDA_DE_GARRI.fn_en_semestre (@semestre int, @fecha DATETIME) returns BIT
as
	begin
		if Month(@fecha) < 7 and @semestre = 1
			begin
				return 1
			end

		if Month(@fecha) > 6 and @semestre = 2
			begin
				return 1
			end

		return 0
	end
GO

--top 5 destinos con mas pasajes comprados
create procedure LA_BANDA_DE_GARRI.sp_estadistico_destinos_mas_pasajes_comprados (@anio numeric(4,0), @semestre int)
as
begin
	select top 5 c.id, c.Nombre, count(p.Id)
	from LA_BANDA_DE_GARRI.Ciudad c
	join LA_BANDA_DE_GARRI.Ruta_Aerea r on (r.Ciudad_Destino = c.Id)
	join LA_BANDA_DE_GARRI.Viaje v on (r.Id = v.Codigo_Ruta_Aerea)
	join LA_BANDA_DE_GARRI.Pasaje_Encomienda p on (v.Id = p.Id_Viaje)
	join LA_BANDA_DE_GARRI.Pago pa on(pa.Id_viaje = p.Id_Viaje)
	where p.KG != 0
	and year(pa.Fecha_compra) = @anio 
	and LA_BANDA_DE_GARRI.fn_en_semestre(@semestre, pa.Fecha_compra) = 1
	group by c.id, c.Nombre
	order by 3 desc
end

go

-- top 5 destinos con mas pasajes cancelados
create procedure LA_BANDA_DE_GARRI.sp_estadistico_destinos_mas_pasajes_cancelados (@anio numeric(4,0), @semestre int)
as
begin
	select top 5 c.id, c.Nombre, count(d.Id_Pasaje_Encomienda)
	from LA_BANDA_DE_GARRI.Ciudad c
	join LA_BANDA_DE_GARRI.Ruta_Aerea r on (r.Ciudad_Destino = c.Id)
	join LA_BANDA_DE_GARRI.Viaje v on (r.Id = v.Codigo_Ruta_Aerea)
	join LA_BANDA_DE_GARRI.Pasaje_Encomienda p on (v.Id = p.Id_Viaje)
	join LA_BANDA_DE_GARRI.Devolucion d on (d.Id_Pasaje_Encomienda = p.Id)
	where p.KG != 0
	and year(d.Fecha_Devolucion) = @anio
	and LA_BANDA_DE_GARRI.fn_en_semestre(@semestre, d.Fecha_Devolucion) = 1
	group by c.id, c.Nombre
	order by 3 desc
end

go

-- top 5 aeronaves con mayor cantidad dias fuera de servicio
-- habria que ver que datos de aeronave hay que mostrar y hacer el join con la tabla Aeronave y traerlos
create procedure LA_BANDA_DE_GARRI.sp_estadistico_aeronave_fuera_servicio (@anio numeric(4,0), @semestre int)
as
begin
	select top 5 a.id_Aeronave, sum(DATEDIFF(day,a.Fecha_Fuera_Servicio,a.Fecha_Reinicio))
	from LA_BANDA_DE_GARRI.Aeronave_Baja_Temporaria a
	where year(a.Fecha_Fuera_Servicio) = @anio
	and LA_BANDA_DE_GARRI.fn_en_semestre(@semestre, a.Fecha_Fuera_Servicio) = 1
	group by a.id_Aeronave
	order by 2 desc
end

go

-- top 5 clientes con mas puntos acumulados
create procedure LA_BANDA_DE_GARRI.sp_estadistico_clientes_mas_puntos_acumulados (@anio numeric(4,0), @semestre int)
as
begin
	select top 5 c.Id, c.Nombre, c.Apellido, cantidad_millas=sum(m.Cantidad) 
	from LA_BANDA_DE_GARRI.Millas m
	join LA_BANDA_DE_GARRI.Cliente c on(m.Id_cliente = c.Id)
	where year(m.Validez_Hasta) = @anio
	and LA_BANDA_DE_GARRI.fn_en_semestre(@semestre, m.Validez_Hasta) = 1
	group by c.id, c.Nombre, c.Apellido
	order by 4 desc 
end

go

--top 5 aeronave mas vacia
create procedure LA_BANDA_DE_GARRI.sp_estadistico_aeronave_mas_vacia (@anio numeric(4,0), @semestre int)
as
begin
	select v.Id_Aeronave, COUNT(v.Id_Aeronave)
	from LA_BANDA_DE_GARRI.Viaje v
	join LA_BANDA_DE_GARRI.Butaca b on b.Aeronave_id = v.Id_Aeronave
	join LA_BANDA_DE_GARRI.Pasaje_Encomienda p on (p.Id_Butaca = b.Id
													and p.Id_Viaje = v.Id)
	where p.KG > 0 
	and year(v.Fecha_salida) = @anio
	and LA_BANDA_DE_GARRI.fn_en_semestre(@semestre, v.Fecha_salida) = 1
	group by v.Id_Aeronave
	order by 2 asc
end

go

--Fecha 14/11/2015 Nico --
-- Procedimiento Editar Ciudad --

create proc LA_BANDA_DE_GARRI.speditar_ciudad
(
@idCiudad int,
@Nombre varchar(255),
@habilitada bit
)
as
update LA_BANDA_DE_GARRI.Ciudad
	set Nombre = @Nombre,
	Habilitada = @habilitada
	where Id = @idCiudad
go

create proc LA_BANDA_DE_GARRI.spbaja_ciudad
(@CodigoCiudad int,
@habilitado bit)
as
update LA_BANDA_DE_GARRI.Ciudad Set Habilitada = @habilitado
where Id = @CodigoCiudad
go

create proc LA_BANDA_DE_GARRI.spbuscar_ciudad
@nombre varchar(100)
as
select * from LA_BANDA_DE_GARRI.Ciudad
where Nombre like '%' + @nombre  + '%'
go

create proc LA_BANDA_DE_GARRI.spMostrar_Ciudad_sin_baja_util
as
select * from LA_BANDA_DE_GARRI.Ciudad
where Habilitada = 1
go

--create proc LA_BANDA_DE_GARRI.spinsertar_Ruta

--PROCEDIMIENTO spinsertar_Ruta--
CREATE PROC   LA_BANDA_DE_GARRI.spinsertar_Ruta
(@id int output,
@CodigoRuta int ,
@TipoServicio int,
@CiudadOrigen varchar(100),
@CiudadDestino varchar(100),
@PrecioKG int,
@PrecioBase int,
@habilitado varchar(100)
)
as
begin

declare @idCiudadOrigen int
declare @idCiudadDestino int

set @idCiudadOrigen = (select Id from LA_BANDA_DE_GARRI.Ciudad where @CiudadOrigen = Nombre)
set @idCiudadDestino = (select Id from LA_BANDA_DE_GARRI.Ciudad where @CiudadDestino = Nombre)

insert into  LA_BANDA_DE_GARRI.Ruta_Aerea(Codigo,Id_Tipo_Servicio,Ciudad_Origen,Ciudad_Destino,Precio_base_pasaje,Precio_base_kg,Habilitada)
values(@CodigoRuta,@TipoServicio, @idCiudadOrigen,@idCiudadDestino,@PrecioBase,@PrecioKG,@habilitado)

end
go


--PROCEDIMIENTO sptraerCiudad --> LO USO PARA COMBOBOX IMPORTANTE--
create proc LA_BANDA_DE_GARRI.sptraerCiudad
(
@idCiudad int
)
as
select * from LA_BANDA_DE_GARRI.Ciudad where Id = @idCiudad
go

CREATE PROC  LA_BANDA_DE_GARRI.speditar_Ruta
(@id int ,
@CodigoRuta numeric(18,0),
@TipoServicio int,
@CiudadOrigen varchar(100),
@CiudadDestino varchar(100),
@PrecioKG numeric(18,2),
@PrecioBase numeric(18,2),
@habilitado binary
)
as
begin

declare @idCiudadOrigen int
declare @idCiudadDestino int

set @idCiudadOrigen = (select Id from LA_BANDA_DE_GARRI.Ciudad where @CiudadOrigen = Nombre)
set @idCiudadDestino = (select Id from LA_BANDA_DE_GARRI.Ciudad where @CiudadDestino = Nombre)

update LA_BANDA_DE_GARRI.Ruta_Aerea
		set Codigo = @CodigoRuta,
		Id_Tipo_Servicio = @TipoServicio,
		Ciudad_Origen = @idCiudadOrigen,
		Ciudad_Destino = @idCiudadDestino,
		Precio_base_kg = @PrecioKG,
		Precio_base_pasaje = @PrecioBase,
		Habilitada = @habilitado
		where Id = @id
end
go

create proc LA_BANDA_DE_GARRI.spmostrar_RolHabilitados
as
select * from LA_BANDA_DE_GARRI.Rol
where Habilitado = 1
order by Rol.Id
GO


---agregado por lucas 15/11- --

CREATE PROC LA_BANDA_DE_GARRI.spinsertar_cliente
(
@codigo int output,
@nombre nvarchar(255),
@apellido nvarchar(255),
@dni numeric(18,0),
@direccion nvarchar(255),
@telefono numeric(18,0),
@email nvarchar(255),
@fechanac date
)
as 
insert into  LA_BANDA_DE_GARRI.Cliente(Nombre,Apellido,dni,direccion,telefono,mail,fecha_nacimiento)
values (@nombre,@apellido,@dni,@direccion,@telefono,@email,@fechanac)
go

CREATE proc LA_BANDA_DE_GARRI.spmostrar_clientes_pordni 
(@dni numeric(18,0))
as
select * from LA_BANDA_DE_GARRI.Cliente
where @dni = dni
order by Id
go

CREATE proc LA_BANDA_DE_GARRI.spmostrar_clientes 
as
select * from LA_BANDA_DE_GARRI.Cliente
order by Id
go



CREATE proc LA_BANDA_DE_GARRI.spinsertar_pago
(
@codigo int output,
@pnr int,
@id_viaje int,
@id_cliente int,
@importe numeric(18,2),
@fechacompra datetime,
@tipo_pago char)
as insert into  LA_BANDA_DE_GARRI.Pago(PNR,Id_viaje,Id_Cliente,Importe,Fecha_compra,Tipo_Pago)
values (@pnr,@id_viaje,@id_cliente,@importe,@fechacompra,@tipo_pago)
go


CREATE proc LA_BANDA_DE_GARRI.spMostrar_viaje_esp(
@id int
)
as
select * from LA_BANDA_DE_GARRI.Ruta_Aerea
where Id = id 
order by Id
go

CREATE proc LA_BANDA_DE_GARRI.sp_Kg_disponibles(
@id_viaje int
)
as
begin
declare @idAeronave int
set @idAeronave = (select viaje.Id_Aeronave from LA_BANDA_DE_GARRI.Viaje where Id = @id_viaje)
declare @retorno int
set @retorno = (select Aeronave.Kg_Disponibles from LA_BANDA_DE_GARRI.Aeronave where Id = @idAeronave)
return(@retorno)
end
go



create proc LA_BANDA_DE_GARRI.sp_checkViaje(
@matricula varchar(255),
@origen varchar(255),
@destino varchar(255)
)
as
begin
declare @idorigen int
declare @iddestino int
declare @idaeronave int
select @idaeronave = LA_BANDA_DE_GARRI.Aeronave.Id from LA_BANDA_DE_GARRI.Aeronave 
where Matricula = @matricula
select @idorigen = LA_BANDA_DE_GARRI.Ciudad.Id from LA_BANDA_DE_GARRI.Ciudad
where Nombre = @origen
select @iddestino = LA_BANDA_DE_GARRI.Ciudad.Id from LA_BANDA_DE_GARRI.Ciudad
where Nombre = @destino

declare @idruta int
select @idruta = LA_BANDA_DE_GARRI.Ruta_Aerea.Id from LA_BANDA_DE_GARRI.Ruta_Aerea
where Ciudad_Origen = @idorigen and Ciudad_Destino = @iddestino and Habilitada = 'True'

declare @resul int
select @resul = LA_BANDA_DE_GARRI.Viaje.Id from LA_BANDA_DE_GARRI.Viaje
where Id_Aeronave = @idaeronave and Codigo_Ruta_Aerea = @idruta

if(@resul is null)
begin
	return(0)
	end
else
begin
	return(1)
	end
end
go

-- Agregado Nico 24/11/2015--

create proc LA_BANDA_DE_GARRI.spcargar_butacasEnTablaViaje_Butaca
(
@id_viaje int,
@id_aeronave int
)
as
begin

insert into LA_BANDA_DE_GARRI.Viaje_Butaca(id_Viaje,id_Butaca,libre)
select @id_viaje,b.Id,1 from LA_BANDA_DE_GARRI.Butaca b where b.Aeronave_id = @id_aeronave

end 
go

--Se agrega la cantidad de tipos de butaca en cada aeronave
create procedure LA_BANDA_DE_GARRI.sp_actualizar_cantidad_tipo_butacas AS
BEGIN
	DECLARE AeronaveCursor CURSOR FOR
	
	select Id from LA_BANDA_DE_GARRI.Aeronave 
	
	DECLARE @aeronave_id INT, @cantidad_ventana INT, @cantidad_pasillo INT;
		
		OPEN AeronaveCursor;
			
			FETCH NEXT FROM AeronaveCursor INTO @aeronave_id 
			WHILE @@FETCH_STATUS = 0
			
			BEGIN
				
				select 	@cantidad_pasillo = count(b.Aeronave_id)
				from LA_BANDA_DE_GARRI.Aeronave a
				join LA_BANDA_DE_GARRI.Butaca b on (a.Id = b.Aeronave_id)
				where a.Id = @aeronave_id 
				group by a.Id, b.Tipo
				having b.Tipo = 1

				select @cantidad_ventana = count(b.Aeronave_id)
				from LA_BANDA_DE_GARRI.Aeronave a
				join LA_BANDA_DE_GARRI.Butaca b on (a.Id = b.Aeronave_id)

				where a.Id = @aeronave_id 
				group by a.Id, b.Tipo
				having b.Tipo = 2

				update LA_BANDA_DE_GARRI.Aeronave
				SET cantidad_butacas_ventana = @cantidad_ventana,
					cantidad_ventanas_pasillo = @cantidad_pasillo
				WHERE id = @aeronave_id;
				
				FETCH NEXT FROM AeronaveCursor INTO @aeronave_id
			END;
		
		CLOSE AeronaveCursor;
	DEALLOCATE AeronaveCursor;
END;
GO

	exec LA_BANDA_DE_GARRI.sp_actualizar_cantidad_tipo_butacas	
GO

create proc LA_BANDA_DE_GARRI.spMostrar_butacas_pasaje_compra(
@numeroPasaje int,
@PNR int
)
as
begin

	declare @idViaje int
	select @idViaje = Id_viaje from LA_BANDA_DE_GARRI.Pago where PNR = @PNR

	select * from LA_BANDA_DE_GARRI.Viaje_Butaca WHERE id_Viaje = @idViaje and libre = '0'

end
go
