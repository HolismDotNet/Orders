using System;

namespace Holism.Orders.Models
{
    public class Cart : Holism.Models.IEntity
    {
        public Cart()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
