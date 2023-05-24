CREATE TABLE [dbo].[RecTbl] (
    [RecId]     INT          IDENTITY (1000, 1) NOT NULL,
    [HasAd]     VARCHAR (50) NOT NULL,
    [TedaviAd]  VARCHAR (50) NOT NULL,
    [TedUcret]  INT          NOT NULL,
    [İlac]      VARCHAR (50) NOT NULL,
    [RecMiktar] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([RecId] ASC)
);

