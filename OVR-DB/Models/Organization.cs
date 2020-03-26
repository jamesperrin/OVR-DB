using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class Organization
    {
        public Organization()
        {
            Hospital = new HashSet<Hospital>();
        }

        public int Id { get; set; }
        public int? AddressId { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Address Address { get; set; }
        public virtual ICollection<Hospital> Hospital { get; set; }
    }
}
