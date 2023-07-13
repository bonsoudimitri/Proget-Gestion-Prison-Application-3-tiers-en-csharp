CREATE TABLE [dbo].[cellule] (
    [Id] INT NOT NULL IDENTITY,
    [nom]       NVARCHAR (50) NULL,
    [capacite]  INT           NULL,
    [nombre_prisonnier] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

