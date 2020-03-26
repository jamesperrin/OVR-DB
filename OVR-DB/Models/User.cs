using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class User
    {
        public User()
        {
            Hospital = new HashSet<Hospital>();
            HospitalManager = new HashSet<HospitalManager>();
            SupplierManager = new HashSet<SupplierManager>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Hospital> Hospital { get; set; }
        public virtual ICollection<HospitalManager> HospitalManager { get; set; }
        public virtual ICollection<SupplierManager> SupplierManager { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
