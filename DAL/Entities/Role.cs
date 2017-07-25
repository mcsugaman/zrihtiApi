using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Role
    {
        public Role()
        {
            PortalUser = new HashSet<PortalUser>();
        }

        public int IdRole { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PortalUser> PortalUser { get; set; }
    }
}
