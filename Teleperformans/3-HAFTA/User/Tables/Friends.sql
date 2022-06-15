CREATE TABLE [User].[Friends] (
    [UserFriendId] INT           IDENTITY (1, 1) NOT NULL,
    [SourceId]     INT           NULL,
    [TargetId]     INT           NULL,
    [CreatedDate]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_Friends] PRIMARY KEY CLUSTERED ([UserFriendId] ASC)
);

