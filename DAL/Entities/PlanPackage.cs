using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PlanPackage
    {
        public PlanPackage()
        {
            PlanPackageTr = new HashSet<PlanPackageTr>();
            PromotionPlan = new HashSet<PromotionPlan>();
        }

        public int IdPlanPackage { get; set; }
        public int IdCurrencyCod { get; set; }
        public int IdPlanTypeCod { get; set; }
        public int Supply { get; set; }
        public decimal PriceMonthly { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<PlanPackageTr> PlanPackageTr { get; set; }
        public virtual ICollection<PromotionPlan> PromotionPlan { get; set; }
        public virtual CodCurrency IdCurrencyCodNavigation { get; set; }
        public virtual CodPlanType IdPlanTypeCodNavigation { get; set; }
    }
}
