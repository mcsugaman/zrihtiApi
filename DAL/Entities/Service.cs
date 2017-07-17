using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Service
    {
        public Service()
        {
            ServiceTr = new HashSet<ServiceTr>();
        }

        public int IdService { get; set; }
        public int IdServiceCod { get; set; }
        public int IdPackage { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<ServiceTr> ServiceTr { get; set; }
        public virtual Package IdPackageNavigation { get; set; }
        public virtual CodService IdServiceCodNavigation { get; set; }
    }
}
