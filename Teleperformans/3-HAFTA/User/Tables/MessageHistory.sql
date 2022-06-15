CREATE TABLE [User].[MessageHistory] (
    [MessageHistoryId] INT            IDENTITY (1, 1) NOT NULL,
    [MessageId]        INT            NULL,
    [MessageTypeId]    INT            NULL,
    [MessageBody]      NVARCHAR (MAX) NULL,
    [UpdatedDate]      DATETIME2 (7)  NULL,
    CONSTRAINT [PK_MessageHistory] PRIMARY KEY CLUSTERED ([MessageHistoryId] ASC),
    CONSTRAINT [FK_MessageHistory_Message] FOREIGN KEY ([MessageId]) REFERENCES [User].[Message] ([MessageId]),
    CONSTRAINT [FK_MessageHistory_MessageType] FOREIGN KEY ([MessageTypeId]) REFERENCES [User].[MessageType] ([MessageTypeId])
);

