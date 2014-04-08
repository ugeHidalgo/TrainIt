CREATE TABLE [dbo].[Sessions] (
    [SessionID]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [TrainID]     BIGINT        NOT NULL,
    [UserID]      BIGINT        NOT NULL,
    [SportTypeID] BIGINT        NOT NULL,
    [Competition] BIT           CONSTRAINT [DF_Sessions_Competition] DEFAULT ((0)) NOT NULL,
    [Distance]    FLOAT (53)    CONSTRAINT [DF_Sessions_Distance] DEFAULT ((0)) NULL,
    [Time]        DATETIME      CONSTRAINT [DF_Sessions_Time] DEFAULT ('00:00:00') NULL,
    [MedHR]       SMALLINT      CONSTRAINT [DF_Sessions_MedHR] DEFAULT ('0') NOT NULL,
    [MaxHR]       SMALLINT      CONSTRAINT [DF_Sessions_MaxHR] DEFAULT ('0') NOT NULL,
    [Value]       SMALLINT      CONSTRAINT [DF_Sessions_Value] DEFAULT ('0') NOT NULL,
    [Memo]        VARCHAR (MAX) NULL,
    [Date]        DATE          NOT NULL,
    CONSTRAINT [PK_Sessions] PRIMARY KEY CLUSTERED ([SessionID] ASC),
    CONSTRAINT [FK_Sessions_Trainings] FOREIGN KEY ([TrainID]) REFERENCES [dbo].[Trainings] ([TrainID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Sessions_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID]) ON DELETE CASCADE
);

