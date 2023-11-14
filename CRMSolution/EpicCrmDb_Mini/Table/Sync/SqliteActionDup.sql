﻿CREATE TABLE [dbo].[SqliteActionDup]
(
	[Id] BIGINT NOT NULL PRIMARY KEY Identity,
	[SqliteTableId] BIGINT NOT NULL,  -- unique index
	[BatchId] BIGINT NOT NULL,
	[PhoneDbId] NVARCHAR(50) NOT NULL DEFAULT '',
    [EmployeeId] BIGINT NOT NULL,
    [At] DATETIME2 NOT NULL,
    [Name] NVARCHAR(20) NOT NULL,
	[ActivityTrackingType] INT NOT NULL DEFAULT 0,
    [Latitude] DECIMAL(19,9) NOT NULL,
    [Longitude] DECIMAL(19,9) NOT NULL,
    [MNC] BIGINT NOT NULL,
    [MCC] BIGINT NOT NULL,
    [LAC] BIGINT NOT NULL,
	[CellId] BIGINT NOT NULL,

	[AtBusiness] BIT NOT NULL DEFAULT 0,
	[ClientCode] NVARCHAR(50) NOT NULL DEFAULT '',
	[ClientName] NVARCHAR(50) NOT NULL,
	[ClientPhone] NVARCHAR(20) NOT NULL,
	[ClientType] NVARCHAR(50) NOT NULL,
	[ActivityType] NVARCHAR(50) NOT NULL, 
	[ActivityAmount] DECIMAL(19,2) NOT NULL DEFAULT 0.0,
	[Comments] NVARCHAR(2048) NOT NULL,

	[ContactCount] INT NOT NULL DEFAULT 0,

	[ImageCount] INT NOT NULL DEFAULT 0,

	[DateCreated] [DATETIME2] NOT NULL DEFAULT SYSUTCDATETIME()
)