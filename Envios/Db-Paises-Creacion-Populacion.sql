USE [master]
GO

IF EXISTS (SELECT * FROM sys.databases d WHERE d.[name]='Paises')
BEGIN
	ALTER DATABASE [Paises] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
END
GO

USE [master]
GO

IF EXISTS (SELECT * FROM sys.databases d WHERE d.[name]='Paises')
BEGIN
	DROP DATABASE [Paises]
END
GO

CREATE DATABASE Paises
GO

USE Paises
GO

CREATE SCHEMA db
GO

--Creacion de Tablas--
CREATE TABLE [db].[Paises] (
    PaisID int IDENTITY(1,1) NOT NULL,
    PaisName nvarchar(50) NOT NULL
);

CREATE TABLE [db].[Provincias] (
    ProvinciaID int IDENTITY(1,1) NOT NULL,
    ProvinciaName nvarchar(50) NOT NULL,
	PaisID int NOT NULL
);

CREATE TABLE [db].[Localidades] (
    localidadID int IDENTITY(1,1) NOT NULL,
    LocalidadName nvarchar(50) NOT NULL,
	ProvinciaID int NOT NULL
);

--Asignacion de Primary y Foreign Keys--

ALTER TABLE [db].[Paises]
	ADD PRIMARY KEY (PaisID);
	
ALTER TABLE [db].[Provincias]
	ADD PRIMARY KEY (ProvinciaID);

ALTER TABLE [db].[Localidades]
	ADD PRIMARY KEY (localidadID);
	
ALTER TABLE [db].[Provincias]
	ADD FOREIGN KEY (PaisID) 
	REFERENCES [db].[Paises](PaisID);
	
ALTER TABLE [db].[Localidades]
	ADD FOREIGN KEY (ProvinciaID) 
	REFERENCES [db].[Provincias](ProvinciaID);
	
--Insercion de Datos // PAISES --

INSERT INTO [db].[Paises] (PaisName)
	VALUES('ARGENTINA');
	
INSERT INTO [db].[Paises] (PaisName)
	VALUES('CHILE');

INSERT INTO [db].[Paises] (PaisName)
	VALUES('PERU');
	
--Insercion de Datos // PROVINCIAS --
	
INSERT INTO [db].[Provincias] (ProvinciaName, PaisID)
	VALUES('BUENOS AIRES', 1);

INSERT INTO [db].[Provincias] (ProvinciaName, PaisID)
	VALUES('ROSARIO', 1);

INSERT INTO [db].[Provincias] (ProvinciaName, PaisID)
	VALUES('ANTOFAGASTA', 2);

INSERT INTO [db].[Provincias] (ProvinciaName, PaisID)
	VALUES('SANTIAGO', 2);

INSERT INTO [db].[Provincias] (ProvinciaName, PaisID)
	VALUES('AMAZONAS', 3);

INSERT INTO [db].[Provincias] (ProvinciaName, PaisID)
	VALUES('AREQUIPA', 3);

--Insercion de Datos // LOCALIDADES --

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('SAN MIGUEL', 1);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('MORON', 1);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('HAEDO', 1);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('ALVEAR', 2);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('ARROYO SECO', 2);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('FUNES', 2);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('ANTOFAGASTA', 3);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('MEJILLONES', 3);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('SIERRA GORDA', 3);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('SANTIAGO', 4);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('SAN MIGUEL', 4);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('RECOLETA', 4);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('BAGUA', 5);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('BONGARA', 5);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('LUYA', 5);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('AREQUIPA', 6);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('CASTILLA', 6);

INSERT INTO [db].[Localidades] (LocalidadName, ProvinciaID)
	VALUES('LA UNION', 6);