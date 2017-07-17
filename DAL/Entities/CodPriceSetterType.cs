using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodPriceSetterType
    {
        public CodPriceSetterType()
        {
            CodPriceSetter = new HashSet<CodPriceSetter>();
        }

        public int IdPriceSetterTypeCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CodPriceSetter> CodPriceSetter { get; set; }
    }
}
