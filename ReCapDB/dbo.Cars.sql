CREATE TABLE [dbo].[Cars] (
    [CarId]       INT         IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT         NOT NULL,
    [ColorId]     INT         NOT NULL,
    [CarName]     NVARCHAR(50)  NOT NULL,
    [ModelYear]   INT         NOT NULL,
    [DailyPrice]  INT         NULL,
    [Description] NTEXT NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC)
);

