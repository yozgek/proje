CREATE TABLE [dbo].[HastaTbl] (
    [HId]           INT          IDENTITY (100, 1) NOT NULL,
    [HastaAd]       VARCHAR (50) NOT NULL,
    [HastaTel]      VARCHAR (50) NOT NULL,
    [HastaDogumT]   VARCHAR (50) NOT NULL,
    [HastaCinsiyet] VARCHAR (10) NOT NULL,
    [HastaAlerji]   VARCHAR (50) NOT NULL,
    [HastaAdres]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([HId] ASC)
);

