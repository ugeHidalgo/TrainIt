CREATE TABLE [dbo].[Materials] (
    [MatID]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [MatName]     VARCHAR (50)    NOT NULL,
    [MatModel]    VARCHAR (50)    NULL,
    [MatBrand]    VARCHAR (50)    NULL,
    [MatSize]     VARCHAR (10)    CONSTRAINT [DF_Materials_MatSize] DEFAULT ('0') NULL,
    [MatWeight]   DECIMAL (10, 2) CONSTRAINT [DF_Materials_MatWeight] DEFAULT ((0.00)) NULL,
    [MatBuyDate]  DATE            NULL,
    [MatCost]     MONEY           CONSTRAINT [DF_Materials_MatCost] DEFAULT ('0') NULL,
    [MatInitTime] FLOAT (53)      NULL,
    [MatInitDist] DECIMAL (20, 3) CONSTRAINT [DF_Materials_initDist] DEFAULT ((0.000)) NULL,
    [MatRecTime]  VARCHAR (12)    CONSTRAINT [DF_Materials_MatRecTime] DEFAULT ('00:00:00') NULL,
    [MatRecDist]  DECIMAL (20, 3) CONSTRAINT [DF_Materials_MatRecDist] DEFAULT ((0.000)) NULL,
    [MatBuyMemo]  VARCHAR (MAX)   NULL,
    [userID]      BIGINT          NOT NULL,
    [MatImage]    IMAGE           NULL,
    CONSTRAINT [PK_Materials] PRIMARY KEY CLUSTERED ([MatID] ASC)
);

