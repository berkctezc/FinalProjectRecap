--Database Creation
create database CarProjectDB;
use CarProjectDB;

--Car Table
CREATE TABLE [dbo].[Cars] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [ModelYear]   VARCHAR (4)   NOT NULL,
    [DailyPrice]  INT           NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([Id] ASC)
);

--Brand Table
CREATE TABLE [dbo].[Brands] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED ([Id] ASC)
);

--Color table
CREATE TABLE [dbo].[Colors] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED ([Name] ASC)
);

--User Table
CREATE TABLE [dbo].[Users] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [Email]     VARCHAR (50) NOT NULL,
    [PasswordHash]  VARBINARY(500) NOT NULL,
    [PasswordSalt] VARBINARY(500) NOT NULL, 
    [Status] BIT NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

--Customer Table
CREATE TABLE [dbo].[Customers] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [UserId]      INT          NOT NULL,
    [CompanyName] VARCHAR (30) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

--Rental Table
CREATE TABLE [dbo].[Rentals] (
    [Id]         INT  IDENTITY (1, 1) NOT NULL,
    [CarId]      INT  NOT NULL,
    [CustomerId] INT  NOT NULL,
    [RentDate]   DATE NOT NULL,
    [ReturnDate] DATE NULL,
    CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED ([Id] ASC)
);

--CarImages Table
CREATE TABLE [dbo].[CarImages] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [CarId]     INT           NOT NULL,
    [ImagePath] VARCHAR (255) NOT NULL,
    [Date]      DATE          NOT NULL,
    CONSTRAINT [PK_CarImages] PRIMARY KEY CLUSTERED ([Id] ASC)
);

--Claims
CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NOT NULL,
    [OperationClaimId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-------------------
--Truncate Tables--
-------------------
use CarProjectDB;

truncate table brands;
truncate table colors;
truncate table cars;
truncate table users;
truncate table customers;
truncate table carimages;
truncate table rentals;