using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class Hospital
    {
        public Hospital()
        {
            HospitalManager = new HashSet<HospitalManager>();
            HospitalVentilators = new HashSet<HospitalVentilators>();
        }

        public int Id { get; set; }
        public int? OrganizationId { get; set; }
        public int Npi { get; set; }
        public bool IsVerified { get; set; }
        public int? UserId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<HospitalManager> HospitalManager { get; set; }
        public virtual ICollection<HospitalVentilators> HospitalVentilators { get; set; }
    }
}
