using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class HospitalVentilators
    {
        public HospitalVentilators()
        {
            HospitalVentilatorsHistory = new HashSet<HospitalVentilatorsHistory>();
        }

        public int Id { get; set; }
        public int HospitalId { get; set; }
        public int? Total { get; set; }
        public int? Available { get; set; }
        public int? Demand { get; set; }

        public virtual Hospital Hospital { get; set; }
        public virtual ICollection<HospitalVentilatorsHistory> HospitalVentilatorsHistory { get; set; }
    }
}
