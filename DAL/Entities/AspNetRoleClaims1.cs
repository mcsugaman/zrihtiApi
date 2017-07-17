using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class AspNetRoleClaims1
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetRoles Role { get; set; }
    }
}
