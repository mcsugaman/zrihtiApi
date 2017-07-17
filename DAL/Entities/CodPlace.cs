using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodPlace
    {
        public CodPlace()
        {
            Office = new HashSet<Office>();
        }

        public int IdPlaceCod { get; set; }
        public int IdProvinceCod { get; set; }
        public int PostNumber { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Office> Office { get; set; }
        public virtual CodProvince IdProvinceCodNavigation { get; set; }
    }
}
