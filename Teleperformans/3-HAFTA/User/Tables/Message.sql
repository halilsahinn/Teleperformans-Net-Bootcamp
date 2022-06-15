CREATE TABLE [User].[Message] (
    [MessageId]     INT            IDENTITY (1, 1) NOT NULL,
    [MessageTitle]  NCHAR (100)    NULL,
    [MessageBody]   NVARCHAR (MAX) NULL,
    [SenderId]      INT            NULL,
    [ReceiverId]    INT            NULL,
    [SentDate]      DATETIME2 (7)  NULL,
    [MessageTypeId] INT            NULL,
    CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED ([MessageId] ASC),
    CONSTRAINT [FK_Message_MessageType] FOREIGN KEY ([MessageTypeId]) REFERENCES [User].[MessageType] ([MessageTypeId]),
    CONSTRAINT [FK_Message_User] FOREIGN KEY ([SenderId]) REFERENCES [dbo].[User] ([UserId]),
    CONSTRAINT [FK_Message_User1] FOREIGN KEY ([ReceiverId]) REFERENCES [dbo].[User] ([UserId])
);

