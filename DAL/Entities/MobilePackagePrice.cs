using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class MobilePackagePrice
    {
        public MobilePackagePrice()
        {
            Badge = new HashSet<Badge>();
            MobilePackagePriceTr = new HashSet<MobilePackagePriceTr>();
        }

        public int IdPhonePrice { get; set; }
        public int IdPhoneCod { get; set; }
        public int IdMobileProvider { get; set; }
        public int IdContarctTypeCod { get; set; }
        public int IdMobilePackage { get; set; }
        public decimal? Upfront { get; set; }
        public decimal? PriceMonthly { get; set; }
        public decimal? PriceWithContract { get; set; }
        public decimal? TotalCost { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Badge> Badge { get; set; }
        public virtual ICollection<MobilePackagePriceTr> MobilePackagePriceTr { get; set; }
        public virtual CodContractType IdContarctTypeCodNavigation { get; set; }
        public virtual MobilePackage IdMobilePackageNavigation { get; set; }
        public virtual MobileProvider IdMobileProviderNavigation { get; set; }
        public virtual CodPhone IdPhoneCodNavigation { get; set; }
    }
}
