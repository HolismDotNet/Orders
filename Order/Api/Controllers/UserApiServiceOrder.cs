// using Holism.Identities.Business;
// using Holism.Identities.Security;
// using Holism.Api.Controllers;
// using Holism.Business;
// using Holism.Framework;
// using Holism.Orders..Business;
// using Holism.Orders..DataAccess.Models;
// using Holism.Orders..DataAccess.Models.Views;
// using Microsoft.AspNetCore.Mvc;
// using System;

// namespace Holism.Orders..UserApi.Controllers
// {
//     public class ServiceOrderController : ViewController<ServiceOrderView>
//     {
//         public override ViewBusiness<ServiceOrderView> ViewBusiness => new ServiceOrderBusiness();

//         public long UserId
//         {
//             get
//             {
//                 return (long)new SecureController().ParsedUserData(HttpContext).UserId;
//             }
//         }

//         public override Action<ListOptions> ListOptionsAugmenter => listOptions =>
//         {
//             Guid? userGuid = new UserBusiness().GetGuid(UserId);
//             listOptions.AddFilter<ServiceOrder>(i => i.UserGuid, userGuid.ToString());
//         };

//         [HttpPost]
//         public IActionResult PlaceOrder(Guid packageGuid)
//         {
//             var url = new ServiceOrderBusiness().PlaceOrder(UserId, packageGuid);
//             return OkJson(null, new
//             {
//                 PaymentUrl = url
//             });
//         }
//     }
// }
