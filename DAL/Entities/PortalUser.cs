using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PortalUser
    {
        public PortalUser()
        {
            Feedback = new HashSet<Feedback>();
            PortalUserImg = new HashSet<PortalUserImg>();
        }

        public int IdPortalUser { get; set; }
        public int? IdProvider { get; set; }
        public bool? IsProvider { get; set; }
        public bool? IsResource { get; set; }
        public string LoginId { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual ICollection<PortalUserImg> PortalUserImg { get; set; }
        public virtual Provider IdProviderNavigation { get; set; }
    }
}
