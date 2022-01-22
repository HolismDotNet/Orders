namespace Orders;

public class OrderBusiness : Business<Order, Order>
{
    protected override ReadRepository<Order> ReadRepository => Repository.Order;

    protected override Repository<Order> WriteRepository => Repository.Order;
}