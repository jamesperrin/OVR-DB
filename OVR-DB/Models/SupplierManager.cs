using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class SupplierManager
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SupplierId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual User User { get; set; }
    }
}
