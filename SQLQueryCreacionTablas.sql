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