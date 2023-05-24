CREATE TABLE [dbo].[TedaviTbl] (
    [TedaviId]  INT          IDENTITY (1000, 1) NOT NULL,
    [TAd]       VARCHAR (50) NOT NULL,
    [TUcret]    INT          NOT NULL,
    [TAçıklama] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([TedaviId] ASC)
);

