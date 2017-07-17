using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PlanPackageTr
    {
        public int IdPlanPackageTr { get; set; }
        public int IdPlanPackage { get; set; }
        public int IdLanguageCod { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual CodLanguage IdLanguageCodNavigation { get; set; }
        public virtual PlanPackage IdPlanPackageNavigation { get; set; }
    }
}
