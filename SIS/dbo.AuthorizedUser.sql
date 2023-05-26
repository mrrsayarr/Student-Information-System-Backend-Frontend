CREATE TABLE [dbo].[AuthorizedUser] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Username]  NVARCHAR (50) NULL,
    [Password]  NVARCHAR (50) NULL,
    [Email]     NVARCHAR (50) NULL,
    [Authority] NVARCHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UQ_Username] UNIQUE NONCLUSTERED ([Username] ASC)
);

