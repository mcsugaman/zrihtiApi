using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodPhone
    {
        public CodPhone()
        {
            MobilePackagePrice = new HashSet<MobilePackagePrice>();
        }

        public int IdPhoneCod { get; set; }
        public int IdOscod { get; set; }
        public string Name { get; set; }
        public int? Storage { get; set; }
        public string ImageUrlPhone { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string Camera { get; set; }
        public string Dimensions { get; set; }
        public string Weight { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Battery { get; set; }
        public string ColorDepth { get; set; }
        public string Resolution { get; set; }

        public virtual ICollection<MobilePackagePrice> MobilePackagePrice { get; set; }
        public virtual CodOs IdOscodNavigation { get; set; }
    }
}
