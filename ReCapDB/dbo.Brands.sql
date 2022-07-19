CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT        IDENTITY (1, 1) NOT NULL,
    [BrandName] NVARCHAR(25) NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

