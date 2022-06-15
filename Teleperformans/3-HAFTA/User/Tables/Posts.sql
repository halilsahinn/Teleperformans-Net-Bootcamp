CREATE TABLE [User].[Posts] (
    [PostId]      INT            IDENTITY (1, 1) NOT NULL,
    [Caption]     NCHAR (100)    NULL,
    [Body]        NVARCHAR (MAX) NULL,
    [UserId]      INT            NULL,
    [IsDeleted]   BIT            NULL,
    [CreatedDate] DATETIME2 (7)  NULL,
    CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [FK_Posts_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);

