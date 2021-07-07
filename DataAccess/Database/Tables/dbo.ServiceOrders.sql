CREATE TABLE [dbo].[ServiceOrders]
(
[Id] [bigint] NOT NULL IDENTITY(1, 1),
[Guid] [uniqueidentifier] NOT NULL,
[UserGuid] [uniqueidentifier] NOT NULL,
[Date] [datetime] NOT NULL,
[PersianDate] AS ([dbo].[ToPersianDateTime]([Date])),
[PackageGuid] [uniqueidentifier] NOT NULL,
[VatAmountInTomans] [int] NULL,
[PaymentGuid] [uniqueidentifier] NULL,
[EndDate] [datetime] NULL,
[PersianEndDate] AS ([dbo].[ToPersianDateTime]([EndDate])),
[IsPaid] [bit] NOT NULL CONSTRAINT [DF_ServiceOrders_IsPaid] DEFAULT ((0))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ServiceOrders] ADD CONSTRAINT [PK_ServiceOrders] PRIMARY KEY CLUSTERED  ([Id]) ON [PRIMARY]
GO
