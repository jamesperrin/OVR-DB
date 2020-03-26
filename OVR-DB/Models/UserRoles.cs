using System;
using System.Collections.Generic;

namespace OVR_DB.Models
{
    public partial class UserRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Roles Role { get; set; }
        public virtual User User { get; set; }
    }
}
