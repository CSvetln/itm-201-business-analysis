CREATE TABLE [dbo].[Persons] (
    [IdPerson] INT            NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED ([IdPerson] ASC)
);

