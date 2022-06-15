CREATE TABLE [User].[Main] (
    [UserId]      INT           NOT NULL,
    [Name]        NCHAR (100)   NULL,
    [SurName]     NCHAR (100)   NULL,
    [Email]       NCHAR (100)   NULL,
    [Password]    NCHAR (100)   NULL,
    [UserName]    NCHAR (100)   NULL,
    [IsActive]    BIT           NULL,
    [CreatedDate] DATETIME2 (7) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

