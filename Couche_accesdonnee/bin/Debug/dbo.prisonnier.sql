CREATE TABLE [dbo].[prisonnier] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [nom]             NVARCHAR (50) NULL,
    [prenom]          NVARCHAR (50) NULL,
    [date_naissance]  NVARCHAR (50) NULL,
    [date_entrer]     NVARCHAR (50) NULL,
    [date_liberation] NVARCHAR (50) NULL,
    [etat_sante]      NVARCHAR (50) NULL,
    [photo]           NVARCHAR(50)         NULL,
    [prison]          NVARCHAR (50) NULL,
    [sexe]            NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

