using System;

namespace Holism.Orders.Models
{
    public class Order : Holism.Models.IEntity
    {
        public Order()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public long UserToken { get; set; }

        public DateTime Date { get; set; }

        public string PersianDate { get; private set; }

        public dynamic RelatedItems { get; set; }
    }
}
