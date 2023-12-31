﻿CREATE TABLE [dbo].[BankMaster]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY,
    [BankName] NVARCHAR(200) NULL,
    [BranchName] NVARCHAR(200) NULL,
    [IfscCode] NVARCHAR(15) NULL,
	[StartDate] DATETIME2 NULL,
    [EndDate] DATETIME2 NULL,
    [Status] BIT NOT NULL DEFAULT 1,
    [CreatedOn] DATETIME2 NOT NULL DEFAULT GETUTCDATE(),
    [ModifiedOn] DATETIME2 NOT NULL DEFAULT GETUTCDATE(),
)
