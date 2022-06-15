CREATE TABLE [User].[PostLikes] (
    [LikeId] INT IDENTITY (1, 1) NOT NULL,
    [PostId] INT NULL,
    [UserId] INT NULL,
    CONSTRAINT [PK_PostLikes] PRIMARY KEY CLUSTERED ([LikeId] ASC),
    CONSTRAINT [FK_PostLikes_Posts] FOREIGN KEY ([PostId]) REFERENCES [User].[Posts] ([PostId]),
    CONSTRAINT [FK_PostLikes_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId])
);

