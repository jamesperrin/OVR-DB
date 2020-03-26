using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class Address
    {
        public Address()
        {
            Organization = new HashSet<Organization>();
            Supplier = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Organization> Organization { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
