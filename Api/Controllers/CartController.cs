
using Holism.Api.Controllers;
using Holism.Business;
using Holism.Orders.Business;
using Holism.Orders.Models;

namespace Holism.Orders.Api.Controllers
{
    public class CartController : ReadController<Cart>
    {
        public override ReadBusiness<Cart> ReadBusiness => new CartBusiness();
    }
}
