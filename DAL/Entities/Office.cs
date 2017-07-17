using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Office
    {
        public Office()
        {
            WorkingTime = new HashSet<WorkingTime>();
        }

        public int IdOffice { get; set; }
        public int IdPlaceCod { get; set; }
        public int IdProvider { get; set; }
        public bool IsMain { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Telephone { get; set; }
        public string TelephoneMobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<WorkingTime> WorkingTime { get; set; }
        public virtual CodPlace IdPlaceCodNavigation { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
    }
}
