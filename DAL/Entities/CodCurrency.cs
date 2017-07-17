using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodCurrency
    {
        public CodCurrency()
        {
            Package = new HashSet<Package>();
            PlanPackage = new HashSet<PlanPackage>();
        }

        public int IdCurrencyCod { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<PlanPackage> PlanPackage { get; set; }
    }
}
