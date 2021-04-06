CREATE TABLE [dbo].[Cars] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT            NULL,
    [ColorId]     INT            NULL,
    [ModelYear]   NVARCHAR (40)  NULL,
    [DailyPrice]  MONEY          DEFAULT ((0)) NULL,
    [Description] NVARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

