CREATE TABLE [dbo].[Bugs] (
    [IdStage]     INT NOT NULL,
    [IdProject]   INT NOT NULL,
    [CountOfBugs] INT NOT NULL,
    CONSTRAINT [PK_Bugs] PRIMARY KEY CLUSTERED ([IdStage] ASC, [IdProject] ASC),
    CONSTRAINT [FK_Bugs_Projects] FOREIGN KEY ([IdProject]) REFERENCES [dbo].[Projects] ([IdProject]),
    CONSTRAINT [FK_Bugs_Stages] FOREIGN KEY ([IdStage]) REFERENCES [dbo].[Stages] ([IdStage])
);

