namespace Orders;

public class Repository
{
    public static Repository<Orders.Order> Order
    {
        get
        {
            return new Repository<Orders.Order>(new OrdersContext());
        }
    }
}
