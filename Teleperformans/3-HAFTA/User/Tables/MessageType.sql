CREATE TABLE [User].[MessageType] (
    [MessageTypeId]   INT        IDENTITY (1, 1) NOT NULL,
    [MessageTypeName] NCHAR (10) NULL,
    CONSTRAINT [PK_MessageType] PRIMARY KEY CLUSTERED ([MessageTypeId] ASC)
);

