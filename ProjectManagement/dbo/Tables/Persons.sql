CREATE TABLE [dbo].[Persons] (
    [IdPerson] INT            NOT NULL,
    [NamePerson]     NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED ([IdPerson] ASC)
);

