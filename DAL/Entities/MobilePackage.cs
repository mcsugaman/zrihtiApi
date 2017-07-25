using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class MobilePackage
    {
        public MobilePackage()
        {
            Badge = new HashSet<Badge>();
            MobilePackagePrice = new HashSet<MobilePackagePrice>();
        }

        public int IdMobilePackage { get; set; }
        public int IdContarctTypeCod { get; set; }
        public string Name { get; set; }
        public int? Minutes { get; set; }
        public int? Sms { get; set; }
        public int? Data { get; set; }
        public decimal? PriceMonthly { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Badge> Badge { get; set; }
        public virtual ICollection<MobilePackagePrice> MobilePackagePrice { get; set; }
        public virtual CodContractType IdContarctTypeCodNavigation { get; set; }
    }
}
