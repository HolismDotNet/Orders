SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO



CREATE view [dbo].[ServiceOrderViews]
as
select 
	ServiceOrders.Id,
	ServiceOrders.[Guid],
	ServiceOrders.UserGuid,
	ServiceOrders.[Date],
	ServiceOrders.PersianDate,
	ServiceOrders.PackageGuid,
	ServiceOrders.VatAmountInTomans,
	ServiceOrders.PaymentGuid,
	ServiceOrders.EndDate,
	ServiceOrders.PersianEndDate,
	ServiceOrders.IsPaid,
	dbo.PackageViews.Title as PackageTitle,
	dbo.PackageViews.DurationInDays,
	dbo.PackageViews.DurationInMonths
from ServiceOrders
inner join dbo.PackageViews
on ServiceOrders.PackageGuid = dbo.PackageViews.[Guid]
GO
