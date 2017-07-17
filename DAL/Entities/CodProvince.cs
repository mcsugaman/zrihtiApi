using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodProvince
    {
        public CodProvince()
        {
            CodPlace = new HashSet<CodPlace>();
        }

        public int IdProvinceCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CodPlace> CodPlace { get; set; }
    }
}
