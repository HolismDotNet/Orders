using Holism.Identities.Business;
using Holism.Business;
using Holism.Configuration.Business;
using Holism.EntityFramework;
using Holism.Framework;
using Holism.Framework.Extensions;
using Holism.Orders.DataAccess;
using Holism.Orders.Models;
using Holism.Orders.Models.Views;
using Holism.Services.Business;
using Holism.Validation;
using System;
using System.Dynamic;
using System.Linq;

namespace Holism.Orders.Business
{
    public class ServiceOrderBusiness : Business<ServiceOrderView, ServiceOrder>
    {
        protected override Repository<ServiceOrder> WriteRepository => Repository.ServiceOrder;

        protected override ReadRepository<ServiceOrderView> ReadRepository => Repository.ServiceOrderView;

        public ServiceOrderView PlaceOrder(long userId, Guid packageGuid, bool? hasVat = null)
        {
            Guid userGuid = new UserBusiness().GetOrSetAndGetGuid(userId);
            packageGuid.Ensure().IsNotNull().And().AsString().IsNotEmptyGuid();
            new PackageBusiness().EnsurePackageExistence(packageGuid);
            var package = new PackageBusiness().Get(packageGuid);
            var order = new ServiceOrder();
            order.Guid = Guid.NewGuid();
            order.UserGuid = userGuid;
            order.PackageGuid = packageGuid;
            order.Date = DateTime.Now;
            hasVat = hasVat ?? new ConfigurationItemBusiness().Get(typeof(ServiceOrderBusiness).Assembly.GetName().Name, "HasVat").ToBoolean();
            if (hasVat.HasValue)
            {
                var vatAmount = (int)(package.NewPriceInTomans * 9 / 100);
                order.VatAmountInTomans = vatAmount;
            }
            else
            {
                order.VatAmountInTomans = 0;
            }
            Create(order);
            var savedOrder = Get(order.Id);
            return savedOrder;
        }

        public ServiceOrderView GetLastActiveOrder(long userId)
        {
            var userGuid = new UserBusiness().GetGuid(userId);
            if (!userGuid.HasValue)
            {
                return null;
            }
            var lastActiveOrder = ReadRepository.All
                .Where(i => i.UserGuid == userGuid.Value)
                .Where(i => i.EndDate != null)
                .Where(i => i.EndDate >= DateTime.Now)
                .OrderByDescending(i => i.EndDate)
                .FirstOrDefault();
            return lastActiveOrder;
        }

        public object GetState(long userId)
        {
            dynamic result = new ExpandoObject();
            var lastActiveOrder = new ServiceOrderBusiness().GetLastActiveOrder(userId);
            if (lastActiveOrder == null)
            {
                result.HasActiveOrder = false;
            }
            else
            {
                result.HasActiveOrder = true;
                result.RemainingTimeInDays = new ServiceOrderBusiness().CalculateRemainingTime(lastActiveOrder.EndDate.Value);
            }
            result.LastActiveOrder = lastActiveOrder;
            result.Packages = new PackageBusiness().GetAll();
            return result;
        }

        private int CalculateRemainingTime(DateTime endDate)
        {
            return Convert.ToInt32(endDate.Subtract(DateTime.Now).TotalDays);
        }

        public void HandlePayment(Guid orderGuid)
        {
            var order = WriteRepository.Get(orderGuid);
            order.IsPaid = true;
            Update(order);
            var package = new PackageBusiness().Get(order.PackageGuid);
            new PackageBusiness().EnsurePackageIsValid(package);
            if (package.DurationInDays.HasValue)
            {
                order.EndDate = DateTime.Now.AddDays(package.DurationInDays.Value);
            }
            else if (package.DurationInMonths.HasValue)
            {
                order.EndDate = DateTime.Now.AddMonths(package.DurationInMonths.Value);
            }
            else
            {
                throw new BusinessException($"Package {package.Title} has no duration");
            }
            Update(order);
        }
    }
}
