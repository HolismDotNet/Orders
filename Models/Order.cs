namespace Orders;

public class Order : IEntity
{
    public Order()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public DateTime UtcDate { get; set; }

    public dynamic RelatedItems { get; set; }
}
