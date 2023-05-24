CREATE TABLE [dbo].[andevuTbl] (
    [RandevuId] INT          IDENTITY (500, 1) NOT NULL,
    [Hasta]     VARCHAR (50) NOT NULL,
    [Tedavi]    VARCHAR (50) NOT NULL,
    [RTarih]    DATE         NOT NULL,
    [RSaat]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([RandevuId] ASC)
);

