using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class MobileProvider
    {
        public MobileProvider()
        {
            MobilePackagePrice = new HashSet<MobilePackagePrice>();
        }

        public int IdMobileProvider { get; set; }
        public int IdProvider { get; set; }

        public virtual ICollection<MobilePackagePrice> MobilePackagePrice { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
    }
}
