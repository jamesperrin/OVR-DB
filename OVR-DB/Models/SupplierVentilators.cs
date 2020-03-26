using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class SupplierVentilators
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int? Availability { get; set; }
        public int? Demand { get; set; }
        public int? Forecast { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
