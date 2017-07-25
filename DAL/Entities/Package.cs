using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Package
    {
        public Package()
        {
            PackageTr = new HashSet<PackageTr>();
            PriceSetter = new HashSet<PriceSetter>();
            Service = new HashSet<Service>();
        }

        public int IdPackage { get; set; }
        public int IdPriceTypeCod { get; set; }
        public int IdCurrencyCod { get; set; }
        public int? IdProvider { get; set; }
        public DateTime? DateDeleted { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<PackageTr> PackageTr { get; set; }
        public virtual ICollection<PriceSetter> PriceSetter { get; set; }
        public virtual ICollection<Service> Service { get; set; }
        public virtual CodCurrency IdCurrencyCodNavigation { get; set; }
        public virtual CodPriceType IdPriceTypeCodNavigation { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
    }
}
