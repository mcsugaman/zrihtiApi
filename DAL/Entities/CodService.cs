using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class CodService
    {
        public CodService()
        {
            Service = new HashSet<Service>();
            ServiceDescription = new HashSet<ServiceDescription>();
        }

        public int IdServiceCod { get; set; }
        public int IdCategoryCod { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Service> Service { get; set; }
        public virtual ICollection<ServiceDescription> ServiceDescription { get; set; }
        public virtual CodCategory1 IdCategoryCodNavigation { get; set; }
    }
}
