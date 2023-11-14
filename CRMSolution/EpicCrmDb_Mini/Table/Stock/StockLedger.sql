﻿CREATE TABLE [dbo].[StockLedger]
(
	[Id] BIGINT NOT NULL PRIMARY KEY Identity,
	[TransactionDate] DATE NOT NULL,
	[ItemMasterId] BIGINT NOT NULL REFERENCES dbo.ItemMaster,
	[ReferenceNo] NVARCHAR(20) NOT NULL,
	[LineNumber] INT NOT NULL,
	[IssueQuantity] INT NOT NULL DEFAULT 0,
	[ReceiveQuantity] INT NOT NULL DEFAULT 0,

	[ZoneCode] NVARCHAR(50) NOT NULL,
	[AreaCode] NVARCHAR(50) NOT NULL,
	[TerritoryCode] NVARCHAR(50) NOT NULL,
	[HQCode] NVARCHAR(50) NOT NULL,
	[StaffCode] NVARCHAR(10) NOT NULL,

	[CyclicCount] BIGINT NOT NULL DEFAULT 1,

	[CreatedBy] NVARCHAR(50) NOT NULL DEFAULT '',
	[UpdatedBy] NVARCHAR(50) NOT NULL DEFAULT '',
	[DateCreated] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
	[DateUpdated] DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
)