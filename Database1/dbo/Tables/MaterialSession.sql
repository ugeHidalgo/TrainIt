CREATE TABLE [dbo].[MaterialSession] (
    [MatID]     BIGINT NOT NULL,
    [SessionID] BIGINT NOT NULL,
    CONSTRAINT [FK_MaterialSession_Materials] FOREIGN KEY ([MatID]) REFERENCES [dbo].[Materials] ([MatID]),
    CONSTRAINT [FK_MaterialSession_Sessions] FOREIGN KEY ([SessionID]) REFERENCES [dbo].[Sessions] ([SessionID]) ON DELETE CASCADE
);

