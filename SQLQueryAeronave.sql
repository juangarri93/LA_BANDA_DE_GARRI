-----------------------------------------------------------------------------------
---------------------------------------------------------------------------------
---------------- ELIMINAR Y DROPEAR TABLAS Y PROCEDIMIENTOS ----------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
----------------------------------------------------------------------------------

--ELIMINAR TABLA VIAJE--
drop table Viaje
go

--ELIMINAR TABLA RUTA_AEREA--
drop table Ruta_Aerea
go

--ELIMINAR TABLA rol_funcionalidad--
drop table rol_funcionalidad
go

--------------------------------------------------------------------------------

--ELIMINAR TABLA ROL--
drop table Rol;
go


-------------------------------------------------------------------------------------

--ELIMINAR TABLA FUNCIONALIDAD--
drop table Funcionalidad;
go

-----------------------------------------------------------------------------------

--ELIMINAR TABLA AERONAVE--
drop table Aeronave
go

------------------------------------------------------------------------------------

--ELIMINAR TABLA CIUDAD--
drop table Ciudad
go

----------------------------------------------------------------------------------------

--ELIMINAR TABLA Persona--
drop table Persona
go

----------------------------------------------------------------------------------------
drop proc spmostrar_Ruta
GO

drop proc speliminar_usuario
go

drop proc spinsertar_usuario
go

drop proc speditar_usuario
go

drop proc spmostrar_usuario
go

drop proc spbaja_usuario
go
 
drop proc spinsertar_Ruta
go

drop proc speliminar_ciudad
go

drop proc spinsertar_ciudad
go

drop proc spbuscarModelo_aeronave
go

drop proc speditar_ciudad
go

drop proc spmostrar_ciudad
go

drop proc spbaja_ciudad
go 

drop proc spMostrar_Funcionalidades
go

--ELIMINAR insertar rol-funcionalidad en tabla rol_funcionalidad--
drop proc spinsertar_rol_funcionalidad
go


--ELIMINAR PROCEDIMIENTO spinsertar_rol--
DROP PROC spinsertar_rol;
go

--ELIMINAR PROCEDIMIENTO INSERTAR--
drop proc spinsertar_aeronave;
go

--ELIMINAR PROCEDIMIENTO MOSTRAR--
drop proc spmostrar_aeronave;
go

--ELIMINAR PROCEDIMIENTO BUSCAR NUMERO--
drop proc spbuscarNombre_aeronave;
go

--ELIMINAR PROCEDIMIENTO BUSCAR FABRICANTE--
drop proc spbuscarFabricante_aeronave;
go

--ELIMINAR PROCEDIMIENTO speditar_aeronave --
DROP PROC speditar_aeronave
go

--ELIMINAR PROCEDIMIENTO speliminar_aeronave--
DROP PROC speliminar_aeronave
go

--ELIMINAR PROCEDIMIENTO spdardebaja_aerolinea--
DROP PROC spdardebaja_aerolinea
go

--ELIMINAR PROCEDIMIENTO spMostrar_Ciudad_sin_baja_util--
DROP PROC spMostrar_Ciudad_sin_baja_util
go

drop proc spbuscar_ciudad
go

drop proc spbuscar_usuario
go

----------------------------------------------
----------------------------------------------
---------------- TABLAS ----------------------
----------------------------------------------
----------------------------------------------
--CREAR TABLA AERONAVE--
CREATE TABLE dbo.Aeronave
   (CodigoAeronave int PRIMARY KEY NOT NULL identity ,
    FechaAlta date NOT NULL,
    NumeroAeronave int NOT NULL,
    Modelo varchar(50) NOT NULL,
	Matricula varchar(50) NOT NULL,
	Fabricante varchar(50) NOT NULL,
	TipoDeServicio varchar(50) NOT NULL,
	BajaPorFueraDeServicio varchar(50) NOT NULL,
	BajaPorVidaUtil varchar(50) NOT NULL,
	FechaDeFueraDeServicio date  NOT NULL,
	FechaDeReinicioDeServicio date  NOT NULL,
	FechaDeBajaDefinitiva date  NOT NULL,
	CantidadButacas int NOT NULL,
	KgDisponible int NOT NULL,
	)
go

--CREAR TABLA Persona--
CREATE TABLE dbo.Persona
   (CodigoPersona int PRIMARY KEY NOT NULL identity ,
    Nombre varchar(50) NOT NULL,
	Apellido varchar(50) NOT NULL, 
	Dni int NOT NULL,
	Direccion varchar(50) NOT NULL,
	Telefono int NOT NULL,
	Email varchar(50) NOT NULL,
	FechaNac date NOT NULL,
	Estado varchar(50) NOT NULL
	)
go

-------------------------------------------------

--CREAR TABLA Ciudad--
CREATE TABLE dbo.Ciudad
   (CodigoCiudad int PRIMARY KEY NOT NULL identity ,
    Nombre varchar(50) NOT NULL,

	BajaPorVidaUtil varchar(50) NOT NULL,
	)
go

--CREAR TABLA Ruta_Aerea--
create table Ruta_Aerea
(id_Ruta int primary key not null identity,
 tipo_servicio varchar(100),
 precio_base_pasaje int,
 precio_base_kg int,
 habilitado varchar(100),
 idCiudadOrigen int foreign key references Ciudad(CodigoCiudad),
 idCiudadDestino int foreign key references Ciudad(CodigoCiudad)
)
go


--CREAR TABLA VIAJE--
CREATE TABLE Viaje
(
	id_Viaje int PRIMARY KEY NOT NULL identity,
	fecha_salida datetime,
	fecha_llegada datetime,
		fecha_llegada_est datetime,
	Codigo_Aeronave int foreign key references Aeronave(CodigoAeronave),
	ruta_Aerea int foreign key references Ruta_Aerea(id_Ruta),
	habilitado varchar(50)
)
go

--------------------------------------------------

--PROCEDIMIENTO CREAR TABLA Funcionalidad--
create table Funcionalidad
(id_funcionalidad int PRIMARY KEY not null identity,
nombre varchar(100)
)
go

---------------------------------------------------

--PROCEDIMIENTO CREAR TABLA ROL --
CREATE TABLE Rol
(id_rol int PRIMARY KEY not null identity,
nombre varchar(100),
habilitado binary
)
go

--------------------------------------------------

--CREAR TABLA rol_funcionalidad--
CREATE TABLE dbo.rol_funcionalidad
(id_rol int foreign key references Rol(id_rol),	
id_funcionalidad int foreign key references Funcionalidad(id_funcionalidad)
)
go

-------------------------------------------------------
-------------------------------------------------------
---------------- PROCEDIMIENTOS  ----------------------
-------------------------------------------------------
-------------------------------------------------------

--PROCEDIMIENTO INSERTAR AERONAVE EN TABLA AERONAVE--
create proc spinsertar_aeronave
(@codigo int output, 
@fechaAlta  date,
@numeroAeronave int, 
@modelo varchar(50),
@matricula varchar(50), 
@fabricante varchar(50),
@tipoDeServicio varchar(50), 
@bajaPorFueraDeServicio varchar(50),
@FechaDeFueraDeServicio date ,
@FechaDeReinicioDeServicio date ,
@CantidadButacas int, 
@kgDisponible int)
as
insert into Aeronave(FechaAlta,NumeroAeronave,Modelo,Matricula,Fabricante,TipoDeServicio,BajaPorFueraDeServicio,BajaPorVidaUtil,FechaDeFueraDeServicio,FechaDeReinicioDeServicio,FechaDeBajaDefinitiva,CantidadButacas,KgDisponible)
values(@fechaAlta,@numeroAeronave,@modelo,@matricula, @fabricante,@tipoDeServicio, @bajaPorFueraDeServicio,'Habilitado',@FechaDeFueraDeServicio,@FechaDeReinicioDeServicio,'2050-01-01' ,@CantidadButacas, @kgDisponible)
go

------------------------------------------------------------

--PROCEDIMIENTO BUSCAR NUMERO--
create proc spbuscarNombre_aeronave
@textoBuscar varchar(50)
as
select * from Aeronave
where NumeroAeronave like @textoBuscar + '%'
go

--------------------------------------------------------------

--PROCEDIMIENTO BUSCAR FABRICANTE--
create proc spbuscarFabricante_aeronave
@textoBuscar varchar(50)
as
select * from Aeronave
where Fabricante like @textoBuscar + '%'
go

---------------------------------------------------------------

--PROCEDIMIENTO BUSCAR MODELO--
create proc spbuscarModelo_aeronave
@textoBuscar varchar(50)
as
select * from Aeronave
where Modelo like @textoBuscar + '%'
go

-----------------------------------------------------------------

--PROCEDIMIENTO EDITAR AERONAVE--
create proc speditar_aeronave
(@codigo int, 
@fechaAlta  date,
@numeroAeronave int, 
@modelo varchar(50),
@matricula varchar(50), 
@fabricante varchar(50),
@tipoDeServicio varchar(50), 
@bajaPorFueraDeServicio varchar(50),
@BajaPorVidaUtil varchar(50),
@FechaDeFueraDeServicio date,
@FechaDeReinicioDeServicio date ,
@FechaBajaDefinitiva date,
@CantidadButacas int, 
@kgDisponible int)
as
update Aeronave set FechaAlta = @fechaAlta,
NumeroAeronave = @numeroAeronave,
Modelo = @modelo,
Matricula = @matricula,
Fabricante = @fabricante,
TipoDeServicio = @tipoDeServicio,
BajaPorFueraDeServicio = @bajaPorFueraDeServicio,
BajaPorVidaUtil = @BajaPorVidaUtil,
FechaDeFueraDeServicio = @FechaDeFueraDeServicio,
FechaDeReinicioDeServicio = @FechaDeReinicioDeServicio,
FechaDeBajaDefinitiva = @FechaBajaDefinitiva,
CantidadButacas = @CantidadButacas,
KgDisponible = @kgDisponible
where CodigoAeronave = @codigo
go

----------------------------------------------------------

--PROCEDIMIENTO MOSTRAR TABLA AERONAVE--
create proc spmostrar_aeronave
as
select * from Aeronave
where BajaPorVidaUtil = 'Habilitado'
order by CodigoAeronave
go

------------------------------------------------------------

--PROCEDIMIENTO ELIMINAR AERONAVE--
create proc speliminar_aeronave
@codigoAeronave int 
as
delete from Aeronave
where CodigoAeronave = @codigoAeronave
go

------------------------------------------------------------

--PROCEDIMIENTO spdardebaja_aerolinea --
create proc spdardebaja_aerolinea
@CodigoAeronave int
as
update Aeronave Set BajaPorVidaUtil = 'Deshabilitado',FechaDeBajaDefinitiva = getdate()
where @CodigoAeronave = CodigoAeronave
go

-------------------------------------------------------------

--PROCEDIMIENTO INSERTAR ciudad EN TABLA Ciudad--
create proc spinsertar_ciudad
 (  @codigo int output,
@nombre varchar(50),

@BajaPorVidaUtil varchar(50)
)
as
insert into Ciudad(Nombre,BajaPorVidaUtil)
values(@nombre, @BajaPorVidaUtil)
go

----------------------------------------------------------------

--PROCEDIMIENTO EDITAR Ciudad--
create proc speditar_ciudad
( @codigo int output,
@nombre varchar(50),
)
as
update Ciudad set Nombre = @nombre

where CodigoCiudad = @codigo
go

-----------------------------------------------------------------------


--PROCEDIMIENTO MOSTRAR TABLA Ciudad--
create proc spmostrar_ciudad
as
select * from Ciudad
order by CodigoCiudad
go

--------------------------------------------------------------------------

--PROCEDIMIENTO ELIMINAR CIUDAD--
create proc speliminar_ciudad
@codigoCiudad int 
as
delete from Ciudad
where CodigoCiudad = @codigoCiudad
go

--------------------------------------------------------------------------

--PROCEDIMIENTO BUSCAR CIUDAD--
create proc spbuscar_ciudad
@textoBuscar varchar(50)
as
select * from Ciudad
where nombre like @textoBuscar + '%'
go
--------------------------------------------------------------------------

--PROCEDIMIENTO spdardebaja_ciudad --
create proc spbaja_ciudad
@CodigoCiudad int
as
update Ciudad Set BajaPorVidaUtil = 'Deshabilitado'
where @CodigoCiudad = CodigoCiudad
go
----------------------------------------------------------------------------

--PROCEDIMIENTO MOSTRAR TABLA FUNCIONALIDAD --> spMostrar_Funcionalidades --
CREATE PROC spMostrar_Funcionalidades
as
select * from Funcionalidad
order by id_funcionalidad
go

----------------------------------------------------------------------------------

--PROCEDIMIENTO INSERTAR ROL --> spinsertar_rol --
CREATE PROC spinsertar_rol
 (@id_rol int output,
@nombre varchar(100),
@habilitado binary
)
as

begin

insert into Rol(nombre,habilitado)
values(@nombre,@habilitado)

declare @id_aux int
select @id_aux = id_rol from Rol where @nombre = nombre 

return(@id_aux)

end
go

----------------------------------------------------------------------------------------

--Crear insertar rol-funcionalidad en tabla rol_funcionalidad--
CREATE PROC spinsertar_rol_funcionalidad
(@id_rol int,
@id_funcionalidad int
)

as

insert into rol_funcionalidad(id_rol,id_funcionalidad)
values(@id_rol,@id_funcionalidad)

go

-------------------------------------------------------------------------------------------
--PROCEDIMIENTO spinsertar_Ruta--
CREATE PROC spinsertar_Ruta
(@CodigoRuta int output,
@TipoServicio varchar(100),
@CiudadOrigen int,
@CiudadDestino int,
@PrecioKG int,
@PrecioBase int,
@habilitado varchar(100)
)
as
insert into Ruta_Aerea(tipo_servicio,precio_base_kg,precio_base_pasaje,idCiudadOrigen,idCiudadDestino,habilitado)
values(@TipoServicio,@PrecioKG,@PrecioBase,@CiudadOrigen,@CiudadDestino,@habilitado)

go

-------------------------------------------------------------------------------------------

--PROCEDIMIENTO spMostrar_Ciudad_sin_baja_util --
CREATE PROC spMostrar_Ciudad_sin_baja_util
as
select * from Ciudad
where BajaPorVidaUtil = 'Habilitado'
order by CodigoCiudad
go

---------------------------------------------------------------------------------------------

-- PROCEDIMIENTO spinsertar_usuario --

CREATE PROC spinsertar_usuario
(
	@CodigoPersona int output,
    @Nombre varchar(50),
	@Apellido varchar(50), 
	@Dni int,
	@Direccion varchar(50),
	@Telefono int,
	@Email varchar(50),
	@FechaNac date,
	@estado varchar(50)
	)
as
insert into Persona(Nombre,Apellido,Dni,Direccion,Telefono,Email,Fechanac,Estado)
values(@Nombre,@Apellido,@Dni,@Direccion,@Telefono,@Email,@FechaNac,@estado)
go
------------------------------------------------------------------------------------------

-- PROCEDIMIENTO spmostrar_usuario --

CREATE PROC spmostrar_usuario
as
select * from Persona
order by CodigoPersona
go
------------------------------------------------------------------------------------------
--PROCEDIMIENTO BUSCAR USUARIO--
create proc spbuscar_usuario
@textoBuscar varchar(50)
as
select * from Persona
where Dni like @textoBuscar + '%'
go
--------------------------------------------------------------------------
--PROCEDIMIENTO EDITAR USUARIO ---

create proc speditar_usuario
( 	@codigoPersona int output,
    @nombre varchar(50),
	@apellido varchar(50), 
	@dni int,
	@direccion varchar(50),
	@telefono int,
	@email varchar(50),
	@fechaNac date
	)
as
update Persona set Nombre = @nombre,
	Apellido = @apellido,
	Dni = @dni,
	Direccion = @direccion,
	Telefono =  @telefono,
	Email = @email,
	FechaNac = @fechaNac
where CodigoPersona = @codigoPersona
go
--------------------------------------------------------------------------
--PROCEDIMIENDO ELIMINAR USUARIO---

CREATE proc speliminar_usuario
@dni int 
as
delete from Persona
where Dni = @dni
go

--------------------------------------------------------------------------
-- PROCEDIMIENTO BAJA USUARIO --

create proc spbaja_usuario
@dni int
as
update Persona Set Estado = 'Deshabilitado'
where @dni = dni
go
---------------------------------------------------------------------------

--PROCEDIMIENTO MOSTRAR RUTA -- 
create proc spmostrar_Ruta
as 
select * from Ruta_Aerea
order by id_Ruta
go


---------------------------------------------------
---para generar viaje
--spMostrar_Aeronaves_sin_baja_util------
CREATE PROC spMostrar_Aeronaves_sin_baja_util
as
select * from Aeronave
where BajaPorVidaUtil = 'Habilitado'
order by CodigoAeronave
go

--spMostrar_RutaAerea_sin_baja_util------
CREATE PROC spMostrar_RutaAerea_sin_baja_util
as
select * from Ruta_Aerea
where habilitado = 'Habilitado'
order by id_Ruta
go

--spMostrar_RutaAerea_esp------
CREATE PROC spMostrar_RutaAerea_esp(
@id int
)
as
select * from Ruta_Aerea
where habilitado = 'Habilitado' and id_Ruta = @id
order by id_Ruta
go
---spmostrar_Viajes----
create proc spmostrar_Viajes
as 
select * from Viaje
order by id_Viaje
go
----spinsertar_Viaje---

/*se debe validar que la fecha sea mayor a la fecha actual--
se tendrá que controlar que el servicio de la ruta concuerde 
con el tipo de servicio que brinda la aeronave seleccionada.--
al momento de seleccionar una aeronave esta deba estar disponible
y no estar asignada previamente a otro viaje en la fecha que se está 
ingresando*/

CREATE PROC spinsertar_Viaje
(@CodigoViaje int output,
@FechaSalida datetime,
@FechaLlegada datetime,
@FechaLlegadaEstimada datetime,
@Aeronave int,
@Ruta int,
@habilitado varchar(100)
)
as
insert into Viaje(id_Viaje,fecha_salida,fecha_llegada, fecha_llegada_est, Codigo_Aeronave, ruta_Aerea, habilitado)
values(@CodigoViaje,@FechaSalida,@FechaLlegada,@FechaLlegadaEstimada,@Aeronave,@Ruta,@habilitado)
go


------spbuscar_fechaOrigenDestino ---
/* no me esta andando bien*/
create proc spbuscar_fechaOrigenDestino(
@FechaSalida datetime,
@CiudadOrigen int,
@CiudadDestino int
)
as 
select * from Viaje 
where fecha_salida = @FechaSalida and ruta_Aerea = (select id_Ruta from Ruta_Aerea where idCiudadOrigen = @CiudadOrigen and idCiudadDestino = @CiudadDestino and habilitado = 'Habilitado' )
order by id_Viaje
go