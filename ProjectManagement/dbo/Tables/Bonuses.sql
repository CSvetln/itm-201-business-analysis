CREATE TABLE [dbo].[Bonuses] (
    [IdPerson]  INT  NOT NULL,
    [IdDate]    INT  NOT NULL,
    [IdMark]    INT  NOT NULL,
    [IdBonuses] INT  NOT NULL,
    [Value]     REAL NOT NULL,
    CONSTRAINT [PK_PersonsMark] PRIMARY KEY CLUSTERED ([IdBonuses] ASC),
    CONSTRAINT [FK_PersonsMark_Dates] FOREIGN KEY ([IdDate]) REFERENCES [dbo].[Dates] ([IdDate]),
    CONSTRAINT [FK_PersonsMark_Marks] FOREIGN KEY ([IdMark]) REFERENCES [dbo].[Marks] ([IdMark]),
    CONSTRAINT [FK_PersonsMark_Persons] FOREIGN KEY ([IdPerson]) REFERENCES [dbo].[Persons] ([IdPerson])
);

