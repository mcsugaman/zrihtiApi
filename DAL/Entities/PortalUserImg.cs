using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PortalUserImg
    {
        public int IdPortalUserImg { get; set; }
        public int IdPortalUser { get; set; }
        public bool? IsAvatar { get; set; }
        public int? OrderNo { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

        public virtual PortalUser IdPortalUserNavigation { get; set; }
    }
}
