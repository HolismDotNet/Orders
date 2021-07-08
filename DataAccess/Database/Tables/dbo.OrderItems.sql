CREATE TABLE [dbo].[OrderItems]
(
[Id] [bigint] NOT NULL IDENTITY(1, 1),
[OrderId] [bigint] NOT NULL,
[Number] [int] NOT NULL,
[ProductToken] [bigint] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderItems] ADD CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
