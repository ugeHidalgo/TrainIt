CREATE TABLE [dbo].[TempSessionData] (
    [UserID]           BIGINT     NULL,
    [SportTypeID]      BIGINT     NULL,
    [ChildSportTypeID] BIGINT     NULL,
    [SessionsCant]     INT        NULL,
    [TotDist]          FLOAT (53) NULL,
    [AvgDist]          FLOAT (53) NULL,
    [MaxDist]          FLOAT (53) NULL,
    [TotTimeCalc]      FLOAT (53) NULL,
    [AvgTimeCalc]      FLOAT (53) NULL,
    [MaxTimeCalc]      FLOAT (53) NULL,
    [AvgMedHR]         FLOAT (53) NULL,
    [MaxMedHR]         FLOAT (53) NULL,
    [AvgMaxHR]         FLOAT (53) NULL,
    [MaxMAxHR]         INT        NULL,
    [AvgValue]         FLOAT (53) NULL,
    [MaxValue]         INT        NULL,
    [Days]             INT        NULL
);

