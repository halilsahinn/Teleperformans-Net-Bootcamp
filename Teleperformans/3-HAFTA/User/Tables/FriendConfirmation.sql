CREATE TABLE [User].[FriendConfirmation] (
    [FriendConfirmationId] INT           IDENTITY (1, 1) NOT NULL,
    [SourceId]             INT           NULL,
    [TargetId]             INT           NULL,
    [IsAccepted]           BIT           NULL,
    [SentDate]             DATETIME2 (7) NULL,
    CONSTRAINT [PK_FriendConfirmation] PRIMARY KEY CLUSTERED ([FriendConfirmationId] ASC),
    CONSTRAINT [FK_FriendConfirmation_Friends] FOREIGN KEY ([SourceId]) REFERENCES [User].[Friends] ([UserFriendId]),
    CONSTRAINT [FK_FriendConfirmation_Friends1] FOREIGN KEY ([TargetId]) REFERENCES [User].[Friends] ([UserFriendId])
);

