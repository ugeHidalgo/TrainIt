CREATE TABLE [dbo].[BioRegTypes] (
    [BioRegTypeID] BIGINT        IDENTITY (1, 1) NOT NULL,
    [BioRegName]   VARCHAR (50)  NOT NULL,
    [Memo]         VARCHAR (MAX) NULL,
    [UserID]       BIGINT        NOT NULL,
    CONSTRAINT [PK_BioRegTypes] PRIMARY KEY CLUSTERED ([BioRegTypeID] ASC),
    CONSTRAINT [FK_BioRegTypes_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

