using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            SupplierManager = new HashSet<SupplierManager>();
            SupplierVentilators = new HashSet<SupplierVentilators>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AddressId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<SupplierManager> SupplierManager { get; set; }
        public virtual ICollection<SupplierVentilators> SupplierVentilators { get; set; }
    }
}
