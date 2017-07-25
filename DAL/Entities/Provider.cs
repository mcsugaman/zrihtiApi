using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Provider
    {
        public Provider()
        {
            Banner1 = new HashSet<Banner1>();
            MobileProvider = new HashSet<MobileProvider>();
            Office = new HashSet<Office>();
            Package = new HashSet<Package>();
            PortalUser = new HashSet<PortalUser>();
            PromotionPlan = new HashSet<PromotionPlan>();
            ProviderImg = new HashSet<ProviderImg>();
            ProviderTr = new HashSet<ProviderTr>();
            ServiceDescription = new HashSet<ServiceDescription>();
            SocialNetwork = new HashSet<SocialNetwork>();
        }

        public int IdProvider { get; set; }
        public string Name { get; set; }
        public decimal? Rating { get; set; }
        public int? NoOfVotes { get; set; }
        public string Vatnumber { get; set; }
        public string TransactionAccountNumber { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Banner1> Banner1 { get; set; }
        public virtual ICollection<MobileProvider> MobileProvider { get; set; }
        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<PortalUser> PortalUser { get; set; }
        public virtual ICollection<PromotionPlan> PromotionPlan { get; set; }
        public virtual ICollection<ProviderImg> ProviderImg { get; set; }
        public virtual ICollection<ProviderTr> ProviderTr { get; set; }
        public virtual ICollection<ServiceDescription> ServiceDescription { get; set; }
        public virtual ICollection<SocialNetwork> SocialNetwork { get; set; }
    }
}
