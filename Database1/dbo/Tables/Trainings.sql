CREATE TABLE [dbo].[Trainings] (
    [TrainID]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [UserID]    BIGINT       NOT NULL,
    [TrainDate] DATE         NOT NULL,
    [TrainName] VARCHAR (50) CONSTRAINT [DF_Trainings_TrainName] DEFAULT ('No name') NOT NULL,
    CONSTRAINT [PK_Trainings] PRIMARY KEY CLUSTERED ([TrainID] ASC)
);

