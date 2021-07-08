using Holism.Business;
using Holism.DataAccess;
using Holism.Orders.DataAccess;
using Holism.Orders.Models;

namespace Holism.Orders.Business
{
    public class CartBusiness : Business<Cart, Cart>
    {
        protected override Repository<Cart> WriteRepository => Repository.Cart;

        protected override ReadRepository<Cart> ReadRepository => Repository.Cart;
    }
}
