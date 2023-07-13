CREATE TABLE [dbo].[user_tbl]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nom] NVARCHAR(50) NULL, 
    [prenom] NVARCHAR(50) NULL, 
    [password] NVARCHAR(50) NULL, 
    [date_naissance] DATE NULL, 
    [statut] NVARCHAR(50) NULL, 
    [grade] NVARCHAR(50) NULL, 
	   [role] NVARCHAR(50) NULL,
    [sexe] NVARCHAR(50) NULL
 

)
