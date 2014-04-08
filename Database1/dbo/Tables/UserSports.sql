CREATE TABLE [dbo].[UserSports] (
    [UserID]      BIGINT NULL,
    [SportTypeID] BIGINT NULL,
    CONSTRAINT [FK_UserSports_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID]) ON DELETE CASCADE
);

