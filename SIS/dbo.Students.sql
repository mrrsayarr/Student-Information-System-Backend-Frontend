CREATE TABLE [dbo].[Students] (
    [Id]                   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]            NVARCHAR (MAX) NULL,
    [LastName]             NVARCHAR (MAX) NULL,
    [Department]           NVARCHAR (MAX) NULL,
    [Email]                NVARCHAR (MAX) NULL,
    [Address]              NVARCHAR (MAX) NULL,
    [StudentNo]            NVARCHAR (MAX)            NULL,
    [PhoneNumber]          NVARCHAR (MAX)  NULL,
    [BirthDate]            DATETIME2 (7)  NOT NULL,
    [RegistrationDate]     DATETIME2 (7)  NOT NULL,
    [Gender]               NVARCHAR (MAX) NULL,
    [IdentificationNumber] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED ([Id] ASC)
);

