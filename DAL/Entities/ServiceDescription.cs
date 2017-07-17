using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ServiceDescription
    {
        public ServiceDescription()
        {
            ServiceDescriptionImg = new HashSet<ServiceDescriptionImg>();
            ServiceDescriptionTr = new HashSet<ServiceDescriptionTr>();
        }

        public int IdServiceDescription { get; set; }
        public int IdProvider { get; set; }
        public int IdServiceCod { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<ServiceDescriptionImg> ServiceDescriptionImg { get; set; }
        public virtual ICollection<ServiceDescriptionTr> ServiceDescriptionTr { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
        public virtual CodService IdServiceCodNavigation { get; set; }
    }
}
