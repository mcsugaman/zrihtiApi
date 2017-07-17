using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PromotionPlan
    {
        public int IdPromotionPlan { get; set; }
        public int IdPlanPackage { get; set; }
        public int IdDbtableCod { get; set; }
        public int IdProvider { get; set; }
        public int FkEntityId { get; set; }
        public int? NoOfPlans { get; set; }
        public int? SpentCount { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual CodDbtable IdDbtableCodNavigation { get; set; }
        public virtual PlanPackage IdPlanPackageNavigation { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
    }
}
