using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodContractType
    {
        public CodContractType()
        {
            MobilePackage = new HashSet<MobilePackage>();
            MobilePackagePrice = new HashSet<MobilePackagePrice>();
        }

        public int IdContarctTypeCod { get; set; }
        public string Name { get; set; }
        public int? NoMonths { get; set; }

        public virtual ICollection<MobilePackage> MobilePackage { get; set; }
        public virtual ICollection<MobilePackagePrice> MobilePackagePrice { get; set; }
    }
}
