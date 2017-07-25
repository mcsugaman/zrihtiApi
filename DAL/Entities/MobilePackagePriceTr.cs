using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class MobilePackagePriceTr
    {
        public int IdMobilePackagePriceTr { get; set; }
        public int IdPhonePrice { get; set; }
        public int IdLanguageCod { get; set; }
        public string Note { get; set; }

        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
        public virtual MobilePackagePrice IdPhonePriceNavigation { get; set; }
    }
}
