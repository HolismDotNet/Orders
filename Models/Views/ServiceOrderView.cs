using System;

namespace Holism.Orders.Models
{
    public class ServiceOrderView : Holism.Models.IEntity
    {
        public ServiceOrderView()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public Guid UserGuid { get; set; }

        public DateTime Date { get; set; }

        public string PersianDate { get; set; }

        public Guid PackageGuid { get; set; }

        public int? VatAmountInTomans { get; set; }

        public Guid? PaymentGuid { get; set; }

        public DateTime? EndDate { get; set; }

        public string PersianEndDate { get; set; }

        public bool IsPaid { get; set; }

        public string PackageTitle { get; set; }

        public int? DurationInDays { get; set; }

        public int? DurationInMonths { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
