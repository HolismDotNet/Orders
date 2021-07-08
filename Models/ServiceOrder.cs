using System;

namespace Holism.Orders.Models
{
    public class ServiceOrder : Holism.Models.IEntity
    {
        public ServiceOrder()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public Guid UserGuid { get; set; }

        public DateTime Date { get; set; }

        public string PersianDate { get; private set; }

        public Guid PackageGuid { get; set; }

        public int? VatAmountInTomans { get; set; }

        public Guid? PaymentGuid { get; set; }

        public DateTime? EndDate { get; set; }

        public string PersianEndDate { get; private set; }

        public bool IsPaid { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
