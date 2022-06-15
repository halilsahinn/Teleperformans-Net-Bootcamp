CREATE TABLE [User].[Comments] (
    [CommentId]      INT            IDENTITY (1, 1) NOT NULL,
    [UserId]         INT            NOT NULL,
    [CommentBody]    NVARCHAR (500) NOT NULL,
    [CreatedDate]    DATETIME2 (7)  NOT NULL,
    [PostId]         INT            NOT NULL,
    [CommentCaption] NVARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([CommentId] ASC),
    CONSTRAINT [FK_Comments_Posts] FOREIGN KEY ([PostId]) REFERENCES [User].[Posts] ([PostId]),
    CONSTRAINT [FK_Comments_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);

