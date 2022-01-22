namespace Orders;

public class OrdersContext : DatabaseContext
{
    public override string ConnectionStringName => "Orders";

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
