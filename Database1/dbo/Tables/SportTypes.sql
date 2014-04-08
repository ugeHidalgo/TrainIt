CREATE TABLE [dbo].[SportTypes] (
    [SportTypeID]       BIGINT        IDENTITY (1, 1) NOT NULL,
    [SportTypeName]     VARCHAR (50)  NOT NULL,
    [ParentSportTypeID] BIGINT        CONSTRAINT [DF_SportTypes_ParentSportTypeID] DEFAULT ((0)) NOT NULL,
    [Memo]              VARCHAR (MAX) NULL,
    [UserID]            BIGINT        NOT NULL,
    [DistForPace]       FLOAT (53)    CONSTRAINT [DF_SportTypes_DistForPace] DEFAULT ((1.0)) NOT NULL,
    CONSTRAINT [PK_SportTypes] PRIMARY KEY CLUSTERED ([SportTypeID] ASC),
    CONSTRAINT [FK_SportTypes_Users1] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID]) ON DELETE CASCADE
);

