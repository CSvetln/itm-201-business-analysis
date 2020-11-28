CREATE TABLE [dbo].[HoursOfJob] (
    [IdHourOfJob] INT  NOT NULL,
    [IdPerson]    INT  NOT NULL,
    [IdProject]   INT  NOT NULL,
    [IdDate]      INT  NOT NULL,
    [Value]       REAL NOT NULL,
    CONSTRAINT [PK_HoursOfJob] PRIMARY KEY CLUSTERED ([IdHourOfJob] ASC),
    CONSTRAINT [FK_HoursOfJob_Dates] FOREIGN KEY ([IdDate]) REFERENCES [dbo].[Dates] ([IdDate]),
    CONSTRAINT [FK_HoursOfJob_Persons] FOREIGN KEY ([IdPerson]) REFERENCES [dbo].[Persons] ([IdPerson]),
    CONSTRAINT [FK_HoursOfJob_Projects] FOREIGN KEY ([IdProject]) REFERENCES [dbo].[Projects] ([IdProject])
);

