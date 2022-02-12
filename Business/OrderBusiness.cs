namespace Orders;

public class OrderBusiness : Business<Order, Order>
{
    protected override Read<Order> Read => Repository.Order;

    protected override Write<Order> Write => Repository.Order;
}