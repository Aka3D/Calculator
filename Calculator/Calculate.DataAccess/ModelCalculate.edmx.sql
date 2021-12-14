
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/14/2021 21:38:52
-- Generated from EDMX file: C:\Users\vmadmin\Documents\GitHub\Calculator\Calculator\Calculate.DataAccess\ModelCalculate.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Rechner_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Calculate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Calculate];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Calculate'
CREATE TABLE [dbo].[Calculate] (
    [BerechnungId] int IDENTITY(1,1) NOT NULL,
    [Zahl1] float  NOT NULL,
    [Zahl2] float  NOT NULL,
    [Operation] varchar(255)  NOT NULL,
    [fk_UserId] int  NOT NULL,
    [Resultat] varchar(255)  NOT NULL,
    [Rechnung] varchar(255)  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [UserId] int  NOT NULL,
    [Vorname] varchar(255)  NOT NULL,
    [Nachname] varchar(255)  NOT NULL,
    [Pwd] varchar(255)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [BerechnungId] in table 'Calculate'
ALTER TABLE [dbo].[Calculate]
ADD CONSTRAINT [PK_Calculate]
    PRIMARY KEY CLUSTERED ([BerechnungId] ASC);
GO

-- Creating primary key on [UserId] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------