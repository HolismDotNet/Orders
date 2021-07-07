CREATE TABLE [dbo].[Carts]
(
[Id] [bigint] NOT NULL IDENTITY(1, 1),
[Guid] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Carts] ADD CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
