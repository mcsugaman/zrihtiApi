using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodPriceType
    {
        public CodPriceType()
        {
            Package = new HashSet<Package>();
        }

        public int IdPriceTypeCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Package> Package { get; set; }
    }
}
