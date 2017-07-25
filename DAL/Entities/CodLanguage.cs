using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodLanguage
    {
        public CodLanguage()
        {
            CodelistTr = new HashSet<CodelistTr>();
            MobilePackagePriceTr = new HashSet<MobilePackagePriceTr>();
            PackageTr = new HashSet<PackageTr>();
            PlanPackageTr = new HashSet<PlanPackageTr>();
            PriceSetterTr = new HashSet<PriceSetterTr>();
            ProviderTr = new HashSet<ProviderTr>();
            ServiceDescriptionTr = new HashSet<ServiceDescriptionTr>();
            ServiceTr = new HashSet<ServiceTr>();
        }

        public int IdLanguageCod { get; set; }
        public string Name { get; set; }
        public bool? IsDefault { get; set; }

        public virtual ICollection<CodelistTr> CodelistTr { get; set; }
        public virtual ICollection<MobilePackagePriceTr> MobilePackagePriceTr { get; set; }
        public virtual ICollection<PackageTr> PackageTr { get; set; }
        public virtual ICollection<PlanPackageTr> PlanPackageTr { get; set; }
        public virtual ICollection<PriceSetterTr> PriceSetterTr { get; set; }
        public virtual ICollection<ProviderTr> ProviderTr { get; set; }
        public virtual ICollection<ServiceDescriptionTr> ServiceDescriptionTr { get; set; }
        public virtual ICollection<ServiceTr> ServiceTr { get; set; }
    }
}
