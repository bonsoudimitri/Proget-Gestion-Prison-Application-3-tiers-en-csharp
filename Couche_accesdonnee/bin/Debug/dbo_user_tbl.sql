CREATE TABLE [dbo].[user] (
    [Id]      INT NOT NULL  IDENTITY,
    [nom]            NVARCHAR (50) NULL,
    [prenom]         NVARCHAR (50) NULL,
    [password]       NVARCHAR (50) NULL,
    [date_naissance] DATE          NULL,
    [statut]         NVARCHAR (50) NULL,
    [grade]          NVARCHAR (50) NULL,
    [role]           NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

