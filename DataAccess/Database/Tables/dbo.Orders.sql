CREATE TABLE [dbo].[Orders]
(
[Id] [bigint] NOT NULL IDENTITY(1, 1),
[UserToken] [bigint] NOT NULL,
[Date] [datetime] NOT NULL,
[PersianDate] AS ([dbo].[ToPersianDateTime]([Date]))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders] ADD CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
