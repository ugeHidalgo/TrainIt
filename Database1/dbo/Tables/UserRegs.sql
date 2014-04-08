CREATE TABLE [dbo].[UserRegs] (
    [UserRegID] BIGINT     IDENTITY (1, 1) NOT NULL,
    [UserID]    BIGINT     NOT NULL,
    [RegDate]   DATE       NOT NULL,
    [Weight]    FLOAT (53) NULL,
    [RHR]       SMALLINT   NULL,
    [FatIndex]  FLOAT (53) NULL,
    [Height]    FLOAT (53) NULL,
    CONSTRAINT [PK_UserRegs] PRIMARY KEY CLUSTERED ([UserRegID] ASC),
    CONSTRAINT [FK_UserRegs_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID]) ON DELETE CASCADE
);

