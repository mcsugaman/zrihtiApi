using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodPlanType
    {
        public CodPlanType()
        {
            PlanPackage = new HashSet<PlanPackage>();
        }

        public int IdPlanTypeCod { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PlanPackage> PlanPackage { get; set; }
    }
}
