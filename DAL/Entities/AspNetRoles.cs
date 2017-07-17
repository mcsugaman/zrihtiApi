using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetRoleClaims1 = new HashSet<AspNetRoleClaims1>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        public string Id { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public virtual ICollection<AspNetRoleClaims1> AspNetRoleClaims1 { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
