CREATE TABLE [dbo].[Projects] (
    [IdProject] INT            NOT NULL,
    [Name]      NVARCHAR (MAX) NOT NULL,
    [Fund]      REAL           NULL,
    CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED ([IdProject] ASC)
);

