namespace Holism.Orders.Models
{
    public class OrderItem : Holism.Models.IEntity
    {
        public OrderItem()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public long OrderId { get; set; }

        public int Number { get; set; }

        public long ProductToken { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
