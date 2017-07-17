using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PriceSetter
    {
        public PriceSetter()
        {
            PriceSetterTr = new HashSet<PriceSetterTr>();
        }

        public int IdPriceSetter { get; set; }
        public int IdPackage { get; set; }
        public int IdPriceSetterCod { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<PriceSetterTr> PriceSetterTr { get; set; }
        public virtual Package IdPackageNavigation { get; set; }
        public virtual CodPriceSetter IdPriceSetterCodNavigation { get; set; }
    }
}
