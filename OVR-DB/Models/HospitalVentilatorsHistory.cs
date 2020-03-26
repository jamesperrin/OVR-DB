using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class HospitalVentilatorsHistory
    {
        public int Id { get; set; }
        public int HospitalVentilatorsId { get; set; }
        public int Total { get; set; }
        public int Available { get; set; }
        public int Demand { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual HospitalVentilators HospitalVentilators { get; set; }
    }
}
