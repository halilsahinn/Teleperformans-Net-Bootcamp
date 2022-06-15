CREATE TABLE [User].[GroupMessages] (
    [GroupMessagesId] INT            IDENTITY (1, 1) NOT NULL,
    [MessageTypeId]   INT            NULL,
    [MessageBody]     NVARCHAR (MAX) NULL,
    [SentDate]        DATETIME2 (7)  NULL,
    [SenderId]        INT            NULL,
    [RecieverId]      INT            NULL,
    CONSTRAINT [PK_GroupMessages] PRIMARY KEY CLUSTERED ([GroupMessagesId] ASC),
    CONSTRAINT [FK_GroupMessages_MessageType] FOREIGN KEY ([MessageTypeId]) REFERENCES [User].[MessageType] ([MessageTypeId])
);

