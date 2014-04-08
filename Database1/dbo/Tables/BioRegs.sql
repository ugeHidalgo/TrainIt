CREATE TABLE [dbo].[BioRegs] (
    [BioRegID]     BIGINT         IDENTITY (1, 1) NOT NULL,
    [BioRegTypeID] BIGINT         NOT NULL,
    [BioRegDate]   DATETIME       NOT NULL,
    [Value]        FLOAT (53)     CONSTRAINT [DF_BioRegs_Value] DEFAULT ('0') NOT NULL,
    [Memo]         NVARCHAR (MAX) NULL,
    [UserID]       BIGINT         NOT NULL,
    CONSTRAINT [PK_BioRegs] PRIMARY KEY CLUSTERED ([BioRegID] ASC),
    CONSTRAINT [FK_BioRegs_BioRegTypes] FOREIGN KEY ([BioRegTypeID]) REFERENCES [dbo].[BioRegTypes] ([BioRegTypeID])
);

