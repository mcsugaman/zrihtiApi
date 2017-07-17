using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PriceSetterTr
    {
        public int IdPriceSetterTr { get; set; }
        public int IdPriceSetter { get; set; }
        public int IdLanguageCod { get; set; }
        public string Note { get; set; }

        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
        public virtual PriceSetter IdPriceSetterNavigation { get; set; }
    }
}
