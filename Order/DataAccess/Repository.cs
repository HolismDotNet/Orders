using Holism.Orders.Models;
using Holism.DataAccess;

namespace Holism.Orders.DataAccess
{
    public class Repository
    {
        public static Repository<Order> Order
        {
            get
            {
                return new Holism.DataAccess.Repository<Order>(new OrderContext());
            }
        }

        public static Repository<OrderItem> OrderItem
        {
            get
            {
                return new Holism.DataAccess.Repository<OrderItem>(new OrderContext());
            }
        }
        public static Repository<ServiceOrder> ServiceOrder
        {
            get
            {
                return new Holism.DataAccess.Repository<ServiceOrder>(new OrderContext());
            }
        }
        public static Repository<ServiceOrderView> ServiceOrderView
        {
            get
            {
                return new Holism.DataAccess.Repository<ServiceOrderView>(new OrderContext());
            }
        }
    }        
}
