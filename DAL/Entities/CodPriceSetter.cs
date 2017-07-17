using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodPriceSetter
    {
        public CodPriceSetter()
        {
            PriceSetter = new HashSet<PriceSetter>();
        }

        public int IdPriceSetterCod { get; set; }
        public int IdPriceSetterTypeCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PriceSetter> PriceSetter { get; set; }
        public virtual CodPriceSetterType IdPriceSetterTypeCodNavigation { get; set; }
    }
}
