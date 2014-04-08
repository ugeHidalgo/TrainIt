CREATE TABLE [dbo].[TempMaterial] (
    [matID]     BIGINT       NOT NULL,
    [MatName]   VARCHAR (50) NULL,
    [MatModel]  VARCHAR (50) NULL,
    [MatBrand]  VARCHAR (50) NULL,
    [MatImage]  IMAGE        NULL,
    [SessionID] BIGINT       NOT NULL
);

