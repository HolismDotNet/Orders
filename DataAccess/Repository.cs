namespace Orders;

public class Repository
{
    public static Write<Orders.Order> Order
    {
        get
        {
            return new Write<Orders.Order>(new OrdersContext());
        }
    }
}
