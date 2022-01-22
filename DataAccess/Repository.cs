namespace Holism.Orders.DataAccess;

public class Repository
{
    public static Repository<Order> Order
    {
        get
        {
            return new Repository<Order>(new OrdersContext());
        }
    }
}
