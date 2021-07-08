// using Holism.Framework.Extensions;
// using Holism.UsageEligibility.Business;

// namespace Holism.Orders.Business
// {
//     public class UsageEligibilityProvider : IEligibilityProvider
//     {
//         public const string EligibilityKey = "ServiceOrder";

//         public Eligibility Check(long userId)
//         {
//             var eligibility = new Eligibility();
//             eligibility.Key = EligibilityKey;
//             var lastActiveOrder = new ServiceOrderBusiness().GetLastActiveOrder(userId);
//             if (lastActiveOrder.IsNull())
//             {
//                 eligibility.IsEligible = false;
//                 eligibility.Reason = "بسته فعالی برای کاربر یافت نشد";
//             }
//             else
//             {
//                 eligibility.IsEligible = true;
//                 eligibility.Reason = $"بسته {lastActiveOrder.PackageTitle}";
//                 eligibility.Until = lastActiveOrder.EndDate.Value;
//             }
//             return eligibility;
//         }
//     }
// }
